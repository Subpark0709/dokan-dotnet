using System;
using System.IO;
using System.Runtime.Versioning;
using DokanNet;

namespace DokanNetMirror;

#if NET5_0_OR_GREATER
[SupportedOSPlatform("windows")]
#endif
internal class Notify : IDisposable
{
    private readonly string _sourcePath;
    private readonly string _targetPath;
    private readonly DokanInstance _dokanInstance;
    private readonly FileSystemWatcher _commonFsWatcher;
    private readonly FileSystemWatcher _fileFsWatcher;
    private readonly FileSystemWatcher _dirFsWatcher;
    private bool _disposed;

    public Notify(string mirrorPath, string mountPath, DokanInstance dokanInstance)
    {
        _sourcePath = mirrorPath;
        _targetPath = mountPath;
        _dokanInstance = dokanInstance;

        _commonFsWatcher = new FileSystemWatcher(mirrorPath)
        {
            IncludeSubdirectories = true,
            NotifyFilter = NotifyFilters.Attributes |
                NotifyFilters.CreationTime |
                NotifyFilters.DirectoryName |
                NotifyFilters.FileName |
                NotifyFilters.LastAccess |
                NotifyFilters.LastWrite |
                NotifyFilters.Security |
                NotifyFilters.Size
        };

        _commonFsWatcher.Changed += OnCommonFileSystemWatcherChanged;
        _commonFsWatcher.Created += OnCommonFileSystemWatcherCreated;
        _commonFsWatcher.Renamed += OnCommonFileSystemWatcherRenamed;

        _commonFsWatcher.EnableRaisingEvents = true;

        _fileFsWatcher = new FileSystemWatcher(mirrorPath)
        {
            IncludeSubdirectories = true,
            NotifyFilter = NotifyFilters.FileName
        };

        _fileFsWatcher.Deleted += OnCommonFileSystemWatcherFileDeleted;

        _fileFsWatcher.EnableRaisingEvents = true;

        _dirFsWatcher = new FileSystemWatcher(mirrorPath)
        {
            IncludeSubdirectories = true,
            NotifyFilter = NotifyFilters.DirectoryName
        };

        _dirFsWatcher.Deleted += OnCommonFileSystemWatcherDirectoryDeleted;

        _dirFsWatcher.EnableRaisingEvents = true;
    }

    private string AlterPathToMountPath(string path)
    {
        var relativeMirrorPath = path.Substring(_sourcePath.Length).TrimStart('\\');

        return Path.Combine(_targetPath, relativeMirrorPath);
    }

    private void OnCommonFileSystemWatcherFileDeleted(object sender, FileSystemEventArgs e)
    {
        if (_dokanInstance.IsDisposed)
        {
            return;
        }

        var fullPath = AlterPathToMountPath(e.FullPath);

        _dokanInstance.NotifyDelete(fullPath, false);
    }

    private void OnCommonFileSystemWatcherDirectoryDeleted(object sender, FileSystemEventArgs e)
    {
        if (_dokanInstance.IsDisposed)
        {
            return;
        }

        var fullPath = AlterPathToMountPath(e.FullPath);

        _dokanInstance.NotifyDelete(fullPath, true);
    }

    private void OnCommonFileSystemWatcherChanged(object sender, FileSystemEventArgs e)
    {
        if (_dokanInstance.IsDisposed)
        {
            return;
        }

        var fullPath = AlterPathToMountPath(e.FullPath);

        _dokanInstance.NotifyUpdate(fullPath);
    }

    /// <summary>
    /// 원본 파일 시스템에서 항목이 생성되었을 때 호출됩니다.
    /// Dokan 파일 시스템에 해당 생성 알림을 전달합니다.
    /// </summary>
    /// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
    /// <param name="e">이벤트에 대한 데이터를 포함하는 FileSystemEventArgs입니다.</param>
    private void OnCommonFileSystemWatcherCreated(object sender, FileSystemEventArgs e)
    {
        if (_dokanInstance.IsDisposed)
        {
            return;
        }

        // AlterPathToMountPath는 Dokan 파일 시스템 내의 경로로 변환합니다.
        var dokanPath = AlterPathToMountPath(e.FullPath);

        // 디렉터리인지 여부는 원본 파일 시스템 경로(e.FullPath)를 기준으로 판단해야 합니다.
        // Directory.Exists는 해당 경로가 디렉터리인지 확인합니다.
        var isDirectory = Directory.Exists(e.FullPath); // 수정된 라인: e.FullPath 사용

        // Dokan 파일 시스템에 생성 알림을 보냅니다.
        _dokanInstance.NotifyCreate(dokanPath, isDirectory);
    }

    private void OnCommonFileSystemWatcherRenamed(object sender, RenamedEventArgs e)
    {
        if (_dokanInstance.IsDisposed)
        {
            return;
        }

        var oldFullPath = AlterPathToMountPath(e.OldFullPath);
        var oldDirectoryName = Path.GetDirectoryName(e.OldFullPath);

        var fullPath = AlterPathToMountPath(e.FullPath);
        var directoryName = Path.GetDirectoryName(e.FullPath);

        // 이 부분은 이미 e.FullPath (원본의 새 경로)를 사용하고 있었으므로 변경 없음
        var isDirectory = Directory.Exists(e.FullPath);
        var isInSameDirectory = string.Equals(oldDirectoryName, directoryName);

        _dokanInstance.NotifyRename(oldFullPath, fullPath, isDirectory, isInSameDirectory);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // dispose managed state (managed objects)
                _commonFsWatcher.Changed -= OnCommonFileSystemWatcherChanged;
                _commonFsWatcher.Created -= OnCommonFileSystemWatcherCreated;
                _commonFsWatcher.Renamed -= OnCommonFileSystemWatcherRenamed;

                _commonFsWatcher.Dispose();
                _fileFsWatcher.Dispose();
                _dirFsWatcher.Dispose();

            }

            // free unmanaged resources (unmanaged objects) and override finalizer
            // set large fields to null
            _disposed = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

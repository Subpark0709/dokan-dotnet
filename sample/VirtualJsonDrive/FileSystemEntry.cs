using System;
using System.Collections.Generic;
using System.IO;

namespace VirtualJsonDrive
{
    /// <summary>
    /// 파일 시스템의 노드(파일 또는 디렉터리)를 나타내는 기본 클래스입니다.
    /// </summary>
    public abstract class FileSystemNode
    {
        /// <summary>
        /// 파일 또는 디렉터리의 이름입니다.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 파일 또는 디렉터리의 특성입니다.
        /// </summary>
        public FileAttributes Attributes { get; set; }

        /// <summary>
        /// 생성 시간입니다.
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 마지막 접근 시간입니다.
        /// </summary>
        public DateTime LastAccessTime { get; set; }

        /// <summary>
        /// 마지막 쓰기 시간입니다.
        /// </summary>
        public DateTime LastWriteTime { get; set; }

        /// <summary>
        /// 부모 디렉터리입니다. 루트 노드의 경우 null입니다.
        /// </summary>
        public DirectoryNode? Parent { get; set; }

        protected FileSystemNode(string name, FileAttributes attributes, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, DirectoryNode? parent)
        {
            Name = name;
            Attributes = attributes;
            CreationTime = creationTime;
            LastAccessTime = lastAccessTime;
            LastWriteTime = lastWriteTime;
            Parent = parent;
        }
    }

    /// <summary>
    /// 파일을 나타내는 클래스입니다.
    /// </summary>
    public class FileNode : FileSystemNode
    {
        /// <summary>
        /// 파일의 내용입니다.
        /// </summary>
        public byte[] Content { get; set; }

        public FileNode(string name, FileAttributes attributes, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, DirectoryNode? parent, byte[] content)
            : base(name, attributes, creationTime, lastAccessTime, lastWriteTime, parent)
        {
            Content = content;
        }
    }

    /// <summary>
    /// 디렉터리를 나타내는 클래스입니다.
    /// </summary>
    public class DirectoryNode : FileSystemNode
    {
        /// <summary>
        /// 자식 노드들의 컬렉션입니다. 파일/디렉터리 이름을 키로 사용합니다.
        /// </summary>
        public Dictionary<string, FileSystemNode> Children { get; set; }

        public DirectoryNode(string name, FileAttributes attributes, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, DirectoryNode? parent)
            : base(name, attributes, creationTime, lastAccessTime, lastWriteTime, parent)
        {
            Children = new Dictionary<string, FileSystemNode>(StringComparer.OrdinalIgnoreCase);
        }
    }
}

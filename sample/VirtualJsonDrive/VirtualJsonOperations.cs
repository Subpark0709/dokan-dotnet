using DokanNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
// Newtonsoft.Json 관련 using 지시문은 FileSystemLoader.cs로 이동했으므로 여기서는 필요 없을 수 있음
// 단, 다른 이유로 필요하다면 유지해야 함. 현재로서는 제거해도 될 것으로 보임.
// using Newtonsoft.Json;
// using Newtonsoft.Json.Converters;

namespace VirtualJsonDrive
{
    /// <summary>
    /// JSON 기반 가상 드라이브에 대한 Dokan 작업을 구현합니다.
    /// </summary>
    public class VirtualJsonOperations : IDokanOperations
    {
        /// <summary>
        /// 파일 시스템의 루트 노드입니다.
        /// </summary>
        private readonly DirectoryNode rootNode; // 이제 readonly로 설정 가능

        /// <summary>
        /// VirtualJsonOperations 클래스의 새 인스턴스를 초기화합니다.
        /// FileSystemLoader를 사용하여 테스트용 기본 JSON 파일 시스템을 로드합니다.
        /// </summary>
        public VirtualJsonOperations()
        {
            // 테스트용 기본 JSON 데이터
            // 이 JSON 문자열은 실제 애플리케이션에서는 외부 파일이나 설정에서 로드할 수 있습니다.
            string defaultJsonContent = @"
            {
              ""Name"": ""Root"",
              ""Type"": ""Directory"",
              ""Attributes"": ""Directory"",
              ""CreationTime"": ""2023-01-01T10:00:00"",
              ""LastAccessTime"": ""2023-01-02T11:00:00"",
              ""LastWriteTime"": ""2023-01-03T12:00:00"",
              ""Children"": [
                {
                  ""Name"": ""MyDocuments"",
                  ""Type"": ""Directory"",
                  ""Attributes"": ""Directory"",
                  ""CreationTime"": ""2023-01-01T10:01:00"",
                  ""LastAccessTime"": ""2023-01-02T11:01:00"",
                  ""LastWriteTime"": ""2023-01-03T12:01:00"",
                  ""Children"": [
                    {
                      ""Name"": ""Example.txt"",
                      ""Type"": ""File"",
                      ""Attributes"": ""Archive"",
                      ""CreationTime"": ""2023-01-01T10:02:00"",
                      ""LastAccessTime"": ""2023-01-02T11:02:00"",
                      ""LastWriteTime"": ""2023-01-03T12:02:00"",
                      ""Content"": ""VGhpcyBpcyBhIHRlc3QgZmlsZS4=""
                    },
                    {
                      ""Name"": ""AnotherExample.txt"",
                      ""Type"": ""File"",
                      ""Attributes"": ""ReadOnly"",
                      ""CreationTime"": ""2023-01-04T10:00:00"",
                      ""LastAccessTime"": ""2023-01-04T11:00:00"",
                      ""LastWriteTime"": ""2023-01-04T12:00:00"",
                      ""Content"": ""QW5vdGhlciB0ZXN0IGZpbGUu""
                    }
                  ]
                },
                {
                  ""Name"": ""EmptyFolder"",
                  ""Type"": ""Directory"",
                  ""Attributes"": ""Directory"",
                  ""CreationTime"": ""2023-01-05T15:00:00"",
                  ""LastAccessTime"": ""2023-01-05T15:00:00"",
                  ""LastWriteTime"": ""2023-01-05T15:00:00"",
                  ""Children"": []
                }
              ]
            }";
            // FileSystemLoader를 사용하여 rootNode를 초기화합니다.
            this.rootNode = FileSystemLoader.LoadFileSystemFromJson(defaultJsonContent);
        }

        // LoadFileSystemFromJson, ConvertJsonEntryToDirectoryNode, ConvertJsonEntryToNode 메서드들은
        // FileSystemLoader.cs로 이동되었으므로 여기서 제거합니다.

        /// <summary>
        /// 지정된 경로에 해당하는 FileSystemNode를 찾습니다.
        /// </summary>
        /// <param name="path">찾을 파일 또는 디렉터리의 전체 경로입니다. 경로는 '\'로 시작해야 합니다.</param>
        /// <returns>경로에 해당하는 FileSystemNode를 찾으면 해당 노드를 반환하고, 그렇지 않으면 null을 반환합니다.</returns>
        private FileSystemNode? FindNodeByPath(string path)
        {
            if (string.IsNullOrEmpty(path) || path == "\\")
            {
                return rootNode;
            }

            // 경로가 '\'로 시작한다고 가정하고, 첫 번째 '\'를 제거하여 부분 이름들로 분리
            string normalizedPath = path.TrimStart('\\');
            if (string.IsNullOrEmpty(normalizedPath)) // 오직 "\"만 있었던 경우
            {
                return rootNode;
            }

            string[] parts = normalizedPath.Split('\\');
            FileSystemNode? currentNode = rootNode;

            foreach (string part in parts)
            {
                if (string.IsNullOrEmpty(part)) continue; // 경로에 이중 슬래시가 있는 경우 (예: \\Dir1\\File.txt) 무시

                if (currentNode is DirectoryNode directoryNode)
                {
                    if (directoryNode.Children.TryGetValue(part, out FileSystemNode? nextNode))
                    {
                        currentNode = nextNode;
                    }
                    else
                    {
                        return null; // 경로의 일부를 찾을 수 없음
                    }
                }
                else
                {
                    return null; // 경로 중간에 파일이 있는 경우 (마지막 부분이 아닌데 디렉터리가 아님)
                }
            }
            return currentNode;
        }


        /// <summary>
        /// 지정된 경로의 부모 DirectoryNode를 찾습니다.
        /// </summary>
        /// <param name="path">파일 또는 디렉터리의 전체 경로입니다.</param>
        /// <param name="itemName">경로의 마지막 항목 이름 (출력)입니다.</param>
        /// <returns>부모 DirectoryNode를 반환합니다. 경로가 루트이거나 부모를 찾을 수 없는 경우 null을 반환합니다.</returns>
        private DirectoryNode? GetParentNode(string path, out string itemName)
        {
            path = path.TrimStart('\\');
            itemName = string.Empty;

            if (string.IsNullOrEmpty(path)) // 루트를 직접 대상으로 하는 경우 (예: 루트에 파일 생성 시도)
            {
                return null; // 루트에는 이름이 없으므로 itemName은 비어있음
            }

            string[] parts = path.Split('\\');
            itemName = parts[parts.Length - 1];

            if (parts.Length == 1) // 루트 디렉터리 바로 아래 항목
            {
                return rootNode;
            }

            DirectoryNode currentNode = rootNode;
            // 마지막 항목(itemName)을 제외하고 경로 탐색
            for (int i = 0; i < parts.Length - 1; i++)
            {
                string part = parts[i];
                if (currentNode.Children.TryGetValue(part, out FileSystemNode? nextNode) && nextNode is DirectoryNode directoryNode)
                {
                    currentNode = directoryNode;
                }
                else
                {
                    return null; // 부모 경로를 찾을 수 없음
                }
            }
            return currentNode;
        }


        /// <summary>
        /// 파일이나 디렉터리를 만들거나 엽니다.
        /// </summary>
        /// <param name="fileName">파일 또는 디렉터리 경로입니다.</param>
        /// <param name="access">요청된 액세스 권한입니다. (현재는 단순화/무시)</param>
        /// <param name="share">공유 모드입니다. (현재는 단순화/무시)</param>
        /// <param name="mode">파일 열기 모드입니다.</param>
        /// <param name="options">파일 옵션입니다. (현재는 단순화/무시)</param>
        /// <param name="attributes">새로 생성될 파일/디렉터리의 특성입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus CreateFile(string fileName, DokanNet.FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, IDokanFileInfo info)
        {
            // 현재는 접근 권한(access), 공유 모드(share), 파일 옵션(options)은 검사하지 않고 단순화합니다.
            // 향후 필요에 따라 이 매개변수들을 사용하여 더 정교한 제어를 구현할 수 있습니다.

            DirectoryNode? parentNode;
            string itemName;

            try
            {
                parentNode = GetParentNode(fileName, out itemName);
            }
            catch (ArgumentException e) // GetParentNode 또는 FindNodeByPath 내부에서 발생할 수 있는 예외
            {
                // 예외 메시지를 로깅하거나 특정 오류 코드로 변환할 수 있습니다.
                // 예를 들어, "경로 ... 부분이 디렉터리가 아닙니다." -> NotADirectory
                // "경로 ... 부분을 찾을 수 없습니다." -> ObjectPathNotFound
                // 지금은 일반적인 오류 코드를 반환합니다.
                // Console.WriteLine($"Path validation error in CreateFile: {e.Message}"); // 디버깅용
                return DokanResult.ObjectPathInvalid;
            }

            // fileName이 루트 디렉터리 자체를 가리키는지 확인
            // 1. fileName이 "\" 인 경우
            // 2. GetParentNode에서 parentNode가 null이고 itemName이 비어있는 경우 (루트 경로를 나타냄)
            // 3. GetParentNode에서 parentNode가 rootNode이고 itemName이 rootNode.Name과 일치하는 경우 (예: "\Root" 요청)
            bool isRequestingRoot = fileName.Equals("\\", StringComparison.Ordinal) ||
                                  (parentNode == null && string.IsNullOrEmpty(itemName)) ||
                                  (parentNode == rootNode && !string.IsNullOrEmpty(itemName) && itemName.Equals(rootNode.Name, StringComparison.OrdinalIgnoreCase) && fileName.TrimEnd('\\').Equals(rootNode.Name, StringComparison.OrdinalIgnoreCase));

            if (isRequestingRoot)
            {
                 // 루트 디렉터리 자체를 열거나 상태를 확인하려는 경우
                if (info.IsDirectory)
                {
                    if (mode == FileMode.Open || mode == FileMode.OpenOrCreate)
                    {
                        info.Context = rootNode;
                        return DokanResult.Success;
                    }
                    else if (mode == FileMode.CreateNew) // 루트를 새로 만들 수는 없음
                    {
                        return DokanResult.ObjectNameCollision; // 이미 존재함
                    }
                }
                else // 루트를 파일로 열려고 하는 경우
                {
                    return DokanResult.NotADirectory; // 루트는 파일이 아님
                }
            }


            if (parentNode == null) // 부모 경로를 찾을 수 없음 (루트 바로 아래가 아닌데 부모가 없는 경우)
            {
                return DokanResult.ObjectPathNotFound;
            }

            // 요청된 이름(itemName)으로 기존 노드가 있는지 확인
            FileSystemNode? existingNode = parentNode.Children.TryGetValue(itemName, out var node) ? node : null;

            if (info.IsDirectory)
            {
                // === 디렉터리 생성/열기 ===
                switch (mode)
                {
                    case FileMode.CreateNew:
                        if (existingNode != null)
                        {
                            return DokanResult.ObjectNameCollision; // 이름 충돌
                        }
                        // 새 디렉터리 생성
                        var newDirectory = new DirectoryNode(itemName, attributes | FileAttributes.Directory, DateTime.Now, DateTime.Now, DateTime.Now, parentNode);
                        parentNode.Children.Add(itemName, newDirectory);
                        info.Context = newDirectory;
                        return DokanResult.Success;

                    case FileMode.Open:
                        if (existingNode == null)
                        {
                            return DokanResult.ObjectNameNotFound; // 디렉터리 없음
                        }
                        if (!(existingNode is DirectoryNode))
                        {
                            return DokanResult.NotADirectory; // 파일인데 디렉터리로 열려고 함
                        }
                        info.Context = existingNode; // 기존 디렉터리 컨텍스트 설정
                        return DokanResult.Success;

                    case FileMode.OpenOrCreate:
                        if (existingNode != null)
                        {
                            if (!(existingNode is DirectoryNode))
                            {
                                return DokanResult.NotADirectory;
                            }
                            info.Context = existingNode;
                            return DokanResult.AlreadyExists; // Dokan은 OpenOrCreate 시 이미 존재하면 이 값을 기대할 수 있음
                        }
                        else
                        {
                            var newDir = new DirectoryNode(itemName, attributes | FileAttributes.Directory, DateTime.Now, DateTime.Now, DateTime.Now, parentNode);
                            parentNode.Children.Add(itemName, newDir);
                            info.Context = newDir;
                            return DokanResult.Success;
                        }

                    default:
                        // 지원하지 않는 FileMode (Create, Truncate, Append는 디렉터리에 의미 없음)
                        return DokanResult.AccessDenied; // 또는 InvalidParameter
                }
            }
            else
            {
                // === 파일 생성/열기 ===
                switch (mode)
                {
                    case FileMode.CreateNew:
                        if (existingNode != null)
                        {
                            return DokanResult.ObjectNameCollision; // 이름 충돌
                        }
                        // 새 파일 생성
                        var newFile = new FileNode(itemName, attributes, DateTime.Now, DateTime.Now, DateTime.Now, parentNode, Array.Empty<byte>());
                        parentNode.Children.Add(itemName, newFile);
                        info.Context = newFile; // 컨텍스트에 새 FileNode 저장
                        return DokanResult.Success;

                    case FileMode.Open:
                        if (existingNode == null)
                        {
                            return DokanResult.ObjectNameNotFound; // 파일 없음
                        }
                        if (existingNode is DirectoryNode)
                        {
                            return DokanResult.ObjectPathInvalid; // 디렉터리인데 파일로 열려고 함 (또는 AccessDenied)
                        }
                        info.Context = existingNode; // 기존 파일 컨텍스트 설정
                        return DokanResult.Success;

                    case FileMode.OpenOrCreate:
                        if (existingNode != null)
                        {
                            if (existingNode is DirectoryNode)
                            {
                                return DokanResult.ObjectPathInvalid; // 디렉터리인데 파일로 열려고 함
                            }
                            info.Context = existingNode;
                            // Dokan은 OpenOrCreate 시 이미 존재하면 DokanResult.Success를 기대하거나,
                            // NtStatus.ObjectNameCollision 또는 STATUS_OBJECT_NAME_EXISTS (DokanResult.FileExists 와 유사)를 반환 후
                            // 다시 Open으로 호출할 수 있습니다. 여기서는 Success를 반환하고 컨텍스트를 설정합니다.
                            // 또는 DokanResult.AlreadyExists (0x800700B7L을 STATUS_OBJECT_NAME_COLLISION으로 매핑)
                            return NtStatus.ObjectNameCollision; // 또는 DokanResult.AlreadyExists
                        }
                        else
                        {
                            // 새 파일 생성 (CreateNew와 동일 로직)
                            var createdFile = new FileNode(itemName, attributes, DateTime.Now, DateTime.Now, DateTime.Now, parentNode, Array.Empty<byte>());
                            parentNode.Children.Add(itemName, createdFile);
                            info.Context = createdFile;
                            return DokanResult.Success;
                        }

                    case FileMode.Create:
                        if (existingNode != null)
                        {
                            if (existingNode is DirectoryNode)
                            {
                                return DokanResult.ObjectPathInvalid; // 디렉터리는 덮어쓸 수 없음
                            }
                            // 기존 파일 덮어쓰기 (내용 비우기, 시간 업데이트)
                            var existingFileNode = (FileNode)existingNode;
                            existingFileNode.Content = Array.Empty<byte>();
                            existingFileNode.LastWriteTime = DateTime.Now;
                            existingFileNode.LastAccessTime = DateTime.Now;
                            // 특성도 업데이트 할 수 있음 (attributes 매개변수 사용)
                            existingFileNode.Attributes = attributes;
                            info.Context = existingFileNode;
                        }
                        else
                        {
                            // 새 파일 생성
                            var newCreatedFile = new FileNode(itemName, attributes, DateTime.Now, DateTime.Now, DateTime.Now, parentNode, Array.Empty<byte>());
                            parentNode.Children.Add(itemName, newCreatedFile);
                            info.Context = newCreatedFile;
                        }
                        return DokanResult.Success;

                    case FileMode.Truncate:
                        if (existingNode == null)
                        {
                            return DokanResult.ObjectNameNotFound; // 파일 없음
                        }
                        if (existingNode is DirectoryNode)
                        {
                            return DokanResult.ObjectPathInvalid; // 디렉터리는 Truncate 할 수 없음
                        }
                        // 기존 파일 내용 비우기
                        var fileToTruncate = (FileNode)existingNode;
                        fileToTruncate.Content = Array.Empty<byte>();
                        fileToTruncate.LastWriteTime = DateTime.Now;
                        info.Context = fileToTruncate;
                        return DokanResult.Success;

                    case FileMode.Append: // Append는 WriteFile에서 처리, 여기서는 열기만 성공
                        if (existingNode == null) {
                            // Append는 파일이 없으면 새로 만들어야 할 수도 있지만, Dokan은 보통 Create 후 Append를 시도.
                            // 여기서는 단순하게 파일이 없으면 오류 반환. 또는 CreateNew처럼 새로 만들 수도 있음.
                            return DokanResult.ObjectNameNotFound;
                        }
                        if (existingNode is DirectoryNode) {
                             return DokanResult.ObjectPathInvalid;
                        }
                        info.Context = existingNode;
                        return DokanResult.Success;


                    default:
                        return DokanResult.AccessDenied; // 지원하지 않는 FileMode
                }
            }
        }

        /// <summary>
        /// 파일이나 디렉터리가 닫히기 전에 정리 작업을 수행합니다.
        /// </summary>
        /// <param name="fileName">파일 또는 디렉터리 경로입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        public void Cleanup(string fileName, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
        }

        /// <summary>
        /// 파일이나 디렉터리를 닫습니다.
        /// </summary>
        /// <param name="fileName">파일 또는 디렉터리 경로입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        public void CloseFile(string fileName, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
        }

        /// <summary>
        /// 파일에서 데이터를 읽습니다.
        /// </summary>
        /// <param name="fileName">파일 경로입니다.</param>
        /// <param name="buffer">읽은 데이터를 저장할 버퍼입니다.</param>
        /// <param name="bytesRead">실제로 읽은 바이트 수입니다.</param>
        /// <param name="offset">파일 시작으로부터의 오프셋입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus ReadFile(string fileName, byte[] buffer, out int bytesRead, long offset, IDokanFileInfo info)
        {
            bytesRead = 0; // 기본적으로 읽은 바이트 수를 0으로 설정

            // 1. 컨텍스트 확인 및 유효성 검사
            if (info.Context == null)
            {
                // CreateFile에서 컨텍스트가 설정되지 않았거나 유효하지 않은 경우
                return DokanResult.InvalidHandle; // 또는 DokanResult.AccessDenied 또는 DokanResult.Error
            }

            if (!(info.Context is FileNode fileNode))
            {
                // 컨텍스트가 FileNode가 아닌 경우 (예: DirectoryNode일 때)
                // 이 경우는 CreateFile에서 info.IsDirectory가 false일 때 FileNode만 Context에 넣으므로 발생하기 어려움.
                // 하지만 방어적으로 확인합니다.
                return DokanResult.AccessDenied; // 파일이 아닌 다른 것을 읽으려고 시도
            }

            // 파일 내용이 null인 비정상적인 경우 (FileNode 생성자에서 빈 배열로 초기화하므로 거의 발생 안 함)
            if (fileNode.Content == null)
            {
                // 파일 내용이 존재하지 않는 예외적인 상황
                // Console.WriteLine($"ReadFile Error: FileNode.Content is null for {fileName}"); // 디버깅용
                return DokanResult.Error; // 일반적인 오류
            }

            // 2. 오프셋 및 읽기 길이 계산
            long fileLength = fileNode.Content.LongLength;

            if (offset < 0)
            {
                // 잘못된 오프셋 값 (음수 오프셋)
                return DokanResult.InvalidParameter;
            }

            // Dokan 명세에 따르면 offset이 파일 길이와 같거나 클 경우,
            // bytesRead = 0으로 하고 STATUS_SUCCESS를 반환하는 것이 일반적입니다.
            // (파일 끝에서 읽으려고 시도하거나 파일 끝을 넘어선 지점에서 읽으려고 시도)
            if (offset >= fileLength)
            {
                // bytesRead는 이미 0으로 초기화되었음
                return DokanResult.Success; // EOF를 나타내는 특별한 코드가 아닌 Success
            }

            // 실제로 읽을 바이트 수 계산
            // buffer.Length: 읽기 요청자가 제공한 버퍼의 크기
            // fileLength - offset: 파일에서 실제로 읽을 수 있는 남은 바이트 수
            // Math.Min의 결과는 buffer.Length (int)에 의해 제한되므로 int 범위를 초과하지 않습니다.
            int bytesToRead = (int)Math.Min(buffer.Length, fileLength - offset);

            // 만약 bytesToRead가 0이면 (예: buffer.Length가 0이거나, offset이 파일 끝에 매우 가까워 남은 바이트가 0일 때),
            // 이 경우에도 bytesRead = 0, Success를 반환
            if (bytesToRead <= 0)
            {
                 // bytesRead는 이미 0으로 초기화되었음
                return DokanResult.Success;
            }

            // 3. 데이터 복사
            try
            {
                Buffer.BlockCopy(fileNode.Content, (int)offset, buffer, 0, bytesToRead);
                bytesRead = bytesToRead; // 실제로 읽은 바이트 수 설정
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Buffer.BlockCopy에서 offset 또는 bytesToRead가 유효 범위를 벗어난 경우 발생 가능
                // (예: offset + bytesToRead > fileNode.Content.Length)
                // 위의 계산 로직으로 인해 발생하기 어렵지만, 방어적으로 처리
                // Console.WriteLine($"ReadFile Error (BlockCopy): {ex.Message} for {fileName}, Offset: {offset}, BytesToRead: {bytesToRead}, FileLength: {fileLength}");
                return DokanResult.InvalidParameter; // 또는 DokanResult.Error
            }
            catch (Exception ex) // 기타 예외 처리
            {
                // Console.WriteLine($"ReadFile Error: {ex.Message} for {fileName}");
                return DokanResult.Error;
            }

            // 4. 반환 값
            return DokanResult.Success; // 성공적으로 데이터를 읽었음
        }

        /// <summary>
        /// 파일에 데이터를 씁니다.
        /// </summary>
        /// <param name="fileName">파일 경로입니다.</param>
        /// <param name="buffer">쓸 데이터가 포함된 버퍼입니다.</param>
        /// <param name="bytesWritten">실제로 쓴 바이트 수입니다.</param>
        /// <param name="offset">파일 시작으로부터의 오프셋입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus WriteFile(string fileName, byte[] buffer, out int bytesWritten, long offset, IDokanFileInfo info)
        {
            bytesWritten = 0; // 기본적으로 쓰인 바이트 수를 0으로 설정

            // 1. 컨텍스트 확인 및 유효성 검사
            if (info.Context == null)
            {
                return DokanResult.InvalidHandle;
            }

            if (!(info.Context is FileNode fileNode))
            {
                // 컨텍스트가 FileNode가 아닌 경우 (예: DirectoryNode일 때)
                return DokanResult.AccessDenied; // 디렉터리에는 직접 쓸 수 없음
            }

            // (선택 사항) 파일이 읽기 전용인지 확인
            // if (fileNode.Attributes.HasFlag(FileAttributes.ReadOnly))
            // {
            //     return DokanResult.AccessDenied;
            // }

            // 2. 오프셋 처리 및 파일 크기 조정
            long currentFileLength = fileNode.Content.LongLength;
            long targetOffset = offset;

            // info.WriteToEndOfFile 플래그 또는 특정 offset 값으로 append 모드 확인
            if (info.WriteToEndOfFile || offset == -1) // -1은 DokanNet에서 파일 끝에 쓰기를 나타낼 수 있음
            {
                targetOffset = currentFileLength;
            }
            else if (offset < -1) // 유효하지 않은 음수 오프셋 (단, -1은 예외)
            {
                return DokanResult.InvalidParameter;
            }

            long requiredLength = targetOffset + buffer.Length;

            // 파일 크기를 늘려야 하는 경우
            if (requiredLength > currentFileLength)
            {
                try
                {
                    // Array.Resize는 새 크기가 현재 크기보다 작으면 데이터를 자르고,
                    // 크면 추가 공간을 0 (또는 기본값)으로 초기화합니다.
                    Array.Resize(ref fileNode.Content, (int)requiredLength); // Content는 byte[] 이므로 int로 캐스팅
                }
                catch (OutOfMemoryException)
                {
                    return DokanResult.DiskFull; // 메모리 부족을 디스크 공간 부족으로 매핑
                }
                // 파일 크기가 변경되었으므로, currentFileLength를 업데이트 할 수 있지만,
                // Buffer.BlockCopy는 requiredLength 또는 targetOffset을 기반으로 작동하므로 필수는 아님.
            }

            // 3. 데이터 쓰기
            if (buffer.Length == 0) // 쓸 데이터가 없는 경우
            {
                bytesWritten = 0;
                // 파일 정보 업데이트는 필요할 수 있음 (예: 파일 크기 조정만 한 경우)
                fileNode.LastWriteTime = DateTime.Now;
                fileNode.LastAccessTime = DateTime.Now; // 접근 시간도 업데이트
                return DokanResult.Success;
            }

            try
            {
                Buffer.BlockCopy(buffer, 0, fileNode.Content, (int)targetOffset, buffer.Length);
                bytesWritten = buffer.Length; // 실제로 쓰인 바이트 수 설정
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // targetOffset 또는 buffer.Length가 유효 범위를 벗어난 경우 발생 가능
                // (예: targetOffset + buffer.Length > fileNode.Content.Length, 또는 음수 offset/length)
                // 위의 크기 조정 로직으로 인해 발생하기 어렵지만, 방어적으로 처리
                // Console.WriteLine($"WriteFile Error (BlockCopy): {ex.Message} for {fileName}, Offset: {targetOffset}, BufferLength: {buffer.Length}, FileContentLength: {fileNode.Content.Length}");
                return DokanResult.InvalidParameter;
            }
            catch (Exception ex) // 기타 예외 처리 (예: OutOfMemoryException은 위에서 처리)
            {
                // Console.WriteLine($"WriteFile Error: {ex.Message} for {fileName}");
                return DokanResult.Error;
            }

            // 4. 파일 정보 업데이트
            fileNode.LastWriteTime = DateTime.Now;
            fileNode.LastAccessTime = DateTime.Now; // 일반적으로 쓰기 작업은 접근 시간도 업데이트

            // 5. 반환 값
            return DokanResult.Success; // 성공적으로 데이터를 썼음
        }

        /// <summary>
        /// 파일 버퍼를 플러시합니다.
        /// </summary>
        /// <param name="fileName">파일 경로입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus FlushFileBuffers(string fileName, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.NotImplemented;
        }

        /// <summary>
        /// 파일 또는 디렉터리 정보를 가져옵니다.
        /// </summary>
        /// <param name="fileName">파일 또는 디렉터리 경로입니다.</param>
        /// <param name="fileInfo">파일 정보를 저장할 구조체입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus GetFileInformation(string fileName, out FileInformation fileInfo, IDokanFileInfo info)
        {
            fileInfo = new FileInformation(); // 항상 초기화

            FileSystemNode? node = FindNodeByPath(fileName);

            if (node == null)
            {
                // info.Context를 확인하여 파일이 방금 삭제되었는지 등을 확인할 수도 있지만,
                // 여기서는 단순히 경로에 노드가 없으면 ObjectNameNotFound를 반환합니다.
                // CreateFile에서 Context에 노드를 저장했으므로, 열려 있는 파일/디렉터리라면 info.Context에서 가져올 수도 있습니다.
                // 하지만 GetFileInformation은 경로 기반으로 동작하는 것이 더 일반적입니다.
                if (info.Context is FileSystemNode contextNode && contextNode.Name.Equals(Path.GetFileName(fileName), StringComparison.OrdinalIgnoreCase))
                {
                    // 만약 컨텍스트가 있고, 요청된 파일 이름과 컨텍스트의 이름이 같다면 컨텍스트 사용 가능
                    // 이는 파일이 이동되거나 이름이 변경된 직후 Dokan이 이전 이름으로 정보를 요청하는 경우에 유용할 수 있음
                    // 지금은 FindNodeByPath 결과만 사용
                }
                return DokanResult.ObjectNameNotFound;
            }

            fileInfo.FileName = node.Name;
            fileInfo.Attributes = node.Attributes;
            fileInfo.CreationTime = node.CreationTime;
            fileInfo.LastAccessTime = node.LastAccessTime;
            fileInfo.LastWriteTime = node.LastWriteTime;

            if (node is FileNode fileNode)
            {
                fileInfo.Length = fileNode.Content?.LongLength ?? 0;
            }
            else // DirectoryNode 또는 다른 타입 (이 경우 DirectoryNode만 가능)
            {
                fileInfo.Length = 0; // 디렉터리의 길이는 0
            }

            return DokanResult.Success;
        }

        /// <summary>
        /// 디렉터리 내의 파일 및 하위 디렉터리를 찾습니다.
        /// 이 메서드는 FindFilesWithPattern으로 위임됩니다.
        /// </summary>
        /// <param name="fileName">디렉터리 경로입니다.</param>
        /// <param name="files">찾은 파일 및 디렉터리 정보를 저장할 목록입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus FindFiles(string fileName, out IList<FileInformation> files, IDokanFileInfo info)
        {
            // "*" 패턴으로 FindFilesWithPattern 호출
            return FindFilesWithPattern(fileName, "*", out files, info);
        }

        /// <summary>
        /// 지정된 패턴과 일치하는 파일 및 하위 디렉터리를 찾습니다.
        /// </summary>
        /// <param name="fileName">디렉터리 경로입니다.</param>
        /// <param name="searchPattern">검색 패턴입니다. (예: "*.txt")</param>
        /// <param name="files">찾은 파일 및 디렉터리 정보를 저장할 목록입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus FindFilesWithPattern(string fileName, string searchPattern, out IList<FileInformation> files, IDokanFileInfo info)
        {
            files = new List<FileInformation>(); // 항상 초기화

            FileSystemNode? node = FindNodeByPath(fileName);

            if (node == null)
            {
                return DokanResult.ObjectPathNotFound; // 지정된 경로의 디렉터리가 없음
            }

            if (!(node is DirectoryNode directoryNode))
            {
                return DokanResult.NotADirectory; // 지정된 경로가 파일임
            }

            // 디렉터리 컨텍스트가 있는 경우, 해당 컨텍스트 사용 가능
            // DirectoryNode directoryNodeFromContext = info.Context as DirectoryNode;
            // if (directoryNodeFromContext != null && directoryNodeFromContext.Name.Equals(node.Name))
            // {
            //    directoryNode = directoryNodeFromContext;
            // }


            lock (directoryNode.Children) // Children 컬렉션 순회 시 동기화 (필요한 경우)
            {
                foreach (var childNode in directoryNode.Children.Values)
                {
                    // DokanIsNameInExpression는 와일드카드(*, ?)를 지원하는 패턴 매칭 함수
                    // ignoreCase: true로 설정하여 대소문자 구분 없이 매칭
                    if (DokanNet.DokanHelper.DokanIsNameInExpression(searchPattern, childNode.Name, true))
                    {
                        var fileInfo = new FileInformation
                        {
                            FileName = childNode.Name,
                            Attributes = childNode.Attributes,
                            CreationTime = childNode.CreationTime,
                            LastAccessTime = childNode.LastAccessTime,
                            LastWriteTime = childNode.LastWriteTime
                        };

                        if (childNode is FileNode fileChildNode)
                        {
                            fileInfo.Length = fileChildNode.Content?.LongLength ?? 0;
                        }
                        else // DirectoryNode
                        {
                            fileInfo.Length = 0;
                        }
                        files.Add(fileInfo);
                    }
                }
            } // lock 해제

            return DokanResult.Success;
        }

        /// <summary>
        /// 파일 또는 디렉터리의 특성을 설정합니다.
        /// </summary>
        /// <param name="fileName">파일 또는 디렉터리 경로입니다.</param>
        /// <param name="attributes">설정할 파일 특성입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus SetFileAttributes(string fileName, FileAttributes attributes, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.NotImplemented;
        }

        /// <summary>
        /// 파일 또는 디렉터리의 시간을 설정합니다.
        /// </summary>
        /// <param name="fileName">파일 또는 디렉터리 경로입니다.</param>
        /// <param name="creationTime">생성 시간입니다.</param>
        /// <param name="lastAccessTime">마지막 액세스 시간입니다.</param>
        /// <param name="lastWriteTime">마지막 쓰기 시간입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus SetFileTime(string fileName, DateTime? creationTime, DateTime? lastAccessTime, DateTime? lastWriteTime, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.NotImplemented;
        }

        /// <summary>
        /// 파일을 삭제합니다.
        /// </summary>
        /// <param name="fileName">삭제할 파일 경로입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus DeleteFile(string fileName, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.NotImplemented;
        }

        /// <summary>
        /// 디렉터리를 삭제합니다.
        /// </summary>
        /// <param name="fileName">삭제할 디렉터리 경로입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus DeleteDirectory(string fileName, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.NotImplemented;
        }

        /// <summary>
        /// 파일 또는 디렉터리를 이동합니다.
        /// </summary>
        /// <param name="oldName">이전 파일 또는 디렉터리 경로입니다.</param>
        /// <param name="newName">새 파일 또는 디렉터리 경로입니다.</param>
        /// <param name="replace">대상 파일이 이미 있는 경우 덮어쓸지 여부입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus MoveFile(string oldName, string newName, bool replace, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.NotImplemented;
        }

        /// <summary>
        /// 파일의 끝을 설정합니다.
        /// </summary>
        /// <param name="fileName">파일 경로입니다.</param>
        /// <param name="length">새 파일 길이입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus SetEndOfFile(string fileName, long length, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.NotImplemented;
        }

        /// <summary>
        /// 파일의 할당 크기를 설정합니다.
        /// </summary>
        /// <param name="fileName">파일 경로입니다.</param>
        /// <param name="length">새 할당 크기입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus SetAllocationSize(string fileName, long length, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.NotImplemented;
        }

        /// <summary>
        /// 파일을 잠급니다.
        /// </summary>
        /// <param name="fileName">파일 경로입니다.</param>
        /// <param name="offset">잠금 시작 오프셋입니다.</param>
        /// <param name="length">잠금 길이입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus LockFile(string fileName, long offset, long length, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.NotImplemented;
        }

        /// <summary>
        /// 파일 잠금을 해제합니다.
        /// </summary>
        /// <param name="fileName">파일 경로입니다.</param>
        /// <param name="offset">잠금 해제 시작 오프셋입니다.</param>
        /// <param name="length">잠금 해제 길이입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus UnlockFile(string fileName, long offset, long length, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.NotImplemented;
        }

        /// <summary>
        /// 디스크의 여유 공간 정보를 가져옵니다.
        /// </summary>
        /// <param name="freeBytesAvailable">사용 가능한 여유 바이트 수입니다.</param>
        /// <param name="totalNumberOfBytes">총 바이트 수입니다.</param>
        /// <param name="totalNumberOfFreeBytes">총 여유 바이트 수입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus GetDiskFreeSpace(out long freeBytesAvailable, out long totalNumberOfBytes, out long totalNumberOfFreeBytes, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            freeBytesAvailable = 0;
            totalNumberOfBytes = 0;
            totalNumberOfFreeBytes = 0;
            return DokanResult.NotImplemented;
        }

        /// <summary>
        /// 볼륨 정보를 가져옵니다.
        /// </summary>
        /// <param name="volumeNameBuffer">볼륨 이름을 저장할 버퍼입니다.</param>
        /// <param name="volumeNameSize">볼륨 이름 버퍼의 크기입니다.</param>
        /// <param name="volumeSerialNumber">볼륨 일련 번호입니다.</param>
        /// <param name="maximumComponentLength">최대 구성 요소 길이입니다.</param>
        /// <param name="fileSystemFlags">파일 시스템 플래그입니다.</param>
        /// <param name="fileSystemNameBuffer">파일 시스템 이름을 저장할 버퍼입니다.</param>
        /// <param name="fileSystemNameSize">파일 시스템 이름 버퍼의 크기입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus GetVolumeInformation(out string volumeName, out FileSystemFeatures features, out string fileSystemName, out uint maximumComponentLength, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            volumeName = "VirtualJsonDrive";
            features = FileSystemFeatures.None;
            fileSystemName = "NTFS";
            maximumComponentLength = 255;
            return DokanResult.NotImplemented;
        }

        /// <summary>
        /// 파일 또는 디렉터리의 보안 정보를 가져옵니다.
        /// </summary>
        /// <param name="fileName">파일 또는 디렉터리 경로입니다.</param>
        /// <param name="security">파일 보안 정보입니다.</param>
        /// <param name="sections">요청된 보안 정보 섹션입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus GetFileSecurity(string fileName, out FileSystemSecurity security, AccessControlSections sections, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            security = new FileSecurity();
            return DokanResult.AccessDenied; // 일반적으로 보안 관련 작업은 더 복잡한 구현이 필요합니다.
        }

        /// <summary>
        /// 파일 또는 디렉터리의 보안 정보를 설정합니다.
        /// </summary>
        /// <param name="fileName">파일 또는 디렉터리 경로입니다.</param>
        /// <param name="security">설정할 파일 보안 정보입니다.</param>
        /// <param name="sections">설정할 보안 정보 섹션입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus SetFileSecurity(string fileName, FileSystemSecurity security, AccessControlSections sections, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.AccessDenied; // 일반적으로 보안 관련 작업은 더 복잡한 구현이 필요합니다.
        }

        /// <summary>
        /// 드라이브가 마운트될 때 호출됩니다.
        /// </summary>
        /// <param name="mountPoint">마운트 지점 경로입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus Mounted(string mountPoint, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.Success;
        }

        /// <summary>
        /// 드라이브가 언마운트될 때 호출됩니다.
        /// </summary>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus Unmounted(IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            return DokanResult.Success;
        }

        /// <summary>
        /// 파일의 대체 스트림을 찾습니다.
        /// </summary>
        /// <param name="fileName">파일 경로입니다.</param>
        /// <param name="streams">찾은 스트림 정보를 저장할 목록입니다.</param>
        /// <param name="info">Dokan 파일 정보입니다.</param>
        /// <returns>작업 상태를 나타내는 NtStatus 값입니다.</returns>
        public NtStatus FindStreams(string fileName, out IList<FileInformation> streams, IDokanFileInfo info)
        {
            // 여기에 로직을 구현합니다.
            streams = new List<FileInformation>();
            return DokanResult.NotImplemented;
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO; // FileAttributes를 위해 필요

namespace VirtualJsonDrive
{
    // JSON 역직렬화를 위한 임시 데이터 구조 (DTO)
    // 이 DTO 들은 FileSystemLoader 내부에서만 사용될 수 있으므로 internal로 유지하거나,
    // 다른 어셈블리에서 접근해야 한다면 public으로 변경할 수 있습니다.
    // 여기서는 FileSystemLoader와 같은 네임스페이스 내에서 사용되므로 internal도 괜찮습니다.
    internal class JsonEntry
    {
        public string Name { get; set; } = "";
        [JsonConverter(typeof(StringEnumConverter))]
        public FileSystemEntryType Type { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FileAttributes Attributes { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public DateTime LastAccessTime { get; set; } = DateTime.Now;
        public DateTime LastWriteTime { get; set; } = DateTime.Now;
        public string? Content { get; set; } // 파일의 경우 Base64 인코딩된 문자열
        public List<JsonEntry>? Children { get; set; }
    }

    internal enum FileSystemEntryType
    {
        File,
        Directory
    }

    /// <summary>
    /// JSON 데이터로부터 파일 시스템 구조를 로드하는 책임을 가집니다.
    /// </summary>
    public static class FileSystemLoader
    {
        /// <summary>
        /// JSON 문자열에서 파일 시스템 구조를 로드하고 DirectoryNode 계층 구조를 빌드합니다.
        /// </summary>
        /// <param name="jsonContent">파일 시스템 구조를 포함하는 JSON 문자열입니다.</param>
        /// <returns>루트 DirectoryNode입니다.</returns>
        /// <exception cref="ArgumentException">제공된 JSON이 유효한 루트 디렉터리를 나타내지 않는 경우 발생합니다.</exception>
        public static DirectoryNode LoadFileSystemFromJson(string jsonContent)
        {
            var jsonOptions = new JsonSerializerSettings
            {
                Converters = { new StringEnumConverter() }
            };

            JsonEntry? rootJsonEntry = JsonConvert.DeserializeObject<JsonEntry>(jsonContent, jsonOptions);

            if (rootJsonEntry == null || rootJsonEntry.Type != FileSystemEntryType.Directory)
            {
                throw new ArgumentException("제공된 JSON은 루트 디렉터리를 나타내야 합니다.");
            }

            return ConvertJsonEntryToDirectoryNode(rootJsonEntry, null);
        }

        /// <summary>
        /// JsonEntry 객체를 DirectoryNode 객체로 변환합니다.
        /// 재귀적으로 자식 노드도 변환하고 Parent 속성을 설정합니다.
        /// </summary>
        /// <param name="jsonEntry">변환할 JsonEntry 객체 (디렉터리 타입이어야 함).</param>
        /// <param name="parent">이 디렉터리 노드의 부모 DirectoryNode입니다. 루트 노드의 경우 null입니다.</param>
        /// <returns>변환된 DirectoryNode입니다.</returns>
        /// <exception cref="ArgumentException">jsonEntry가 디렉터리 타입이 아닌 경우 발생합니다.</exception>
        private static DirectoryNode ConvertJsonEntryToDirectoryNode(JsonEntry jsonEntry, DirectoryNode? parent)
        {
            if (jsonEntry.Type != FileSystemEntryType.Directory)
            {
                // 이 예외는 LoadFileSystemFromJson에서 이미 rootJsonEntry 타입을 확인하므로, 주로 자식 노드 처리 중 발생 가능
                throw new ArgumentException($"JSON 항목 '{jsonEntry.Name}'은 디렉터리여야 하지만, 타입이 '{jsonEntry.Type}'입니다.");
            }

            var directoryNode = new DirectoryNode(
                jsonEntry.Name,
                jsonEntry.Attributes,
                jsonEntry.CreationTime,
                jsonEntry.LastAccessTime,
                jsonEntry.LastWriteTime,
                parent
            );

            if (jsonEntry.Children != null)
            {
                foreach (var childJsonEntry in jsonEntry.Children)
                {
                    var childNode = ConvertJsonEntryToNode(childJsonEntry, directoryNode); // 자식 노드의 부모로 현재 directoryNode를 전달
                    directoryNode.Children.Add(childNode.Name, childNode);
                }
            }
            return directoryNode;
        }

        /// <summary>
        /// JsonEntry 객체를 FileSystemNode 객체 (DirectoryNode 또는 FileNode)로 변환합니다.
        /// 재귀적으로 자식 노드도 변환합니다.
        /// </summary>
        /// <param name="jsonEntry">변환할 JsonEntry 객체입니다.</param>
        /// <param name="parent">이 노드의 부모 DirectoryNode입니다. 루트 노드의 경우 null입니다.</param>
        /// <returns>변환된 FileSystemNode입니다.</returns>
        private static FileSystemNode ConvertJsonEntryToNode(JsonEntry jsonEntry, DirectoryNode? parent)
        {
            if (jsonEntry.Type == FileSystemEntryType.Directory)
            {
                // 자식 디렉터리 노드 변환 시, jsonEntry.Attributes에 FileAttributes.Directory가 설정되어 있는지 확인하는 로직 추가 가능
                // if (!jsonEntry.Attributes.HasFlag(FileAttributes.Directory)) { /* 경고 또는 오류 처리 */ }
                return ConvertJsonEntryToDirectoryNode(jsonEntry, parent);
            }
            else // FileSystemEntryType.File
            {
                byte[] content = jsonEntry.Content != null ? Convert.FromBase64String(jsonEntry.Content) : Array.Empty<byte>();
                return new FileNode(
                    jsonEntry.Name,
                    jsonEntry.Attributes,
                    jsonEntry.CreationTime,
                    jsonEntry.LastAccessTime,
                    jsonEntry.LastWriteTime,
                    parent,
                    content
                );
            }
        }
    }
}

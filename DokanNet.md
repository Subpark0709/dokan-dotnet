# Solution: DokanNet

## Solution File: DokanNet.sln

```
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.13.35931.197
MinimumVisualStudioVersion = 10.0.40219.1
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "sample", "sample", "{6AF2183D-1D93-414C-8FAC-C97E60078F4C}"
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "Solution Items", "Solution Items", "{D685023A-6DCE-4CC5-8468-8A0E672E2ACC}"
	ProjectSection(SolutionItems) = preProject
		.editorconfig = .editorconfig
		.gitignore = .gitignore
		appveyor.yml = appveyor.yml
		CHANGELOG.md = CHANGELOG.md
		dokan_logo.png = dokan_logo.png
		license.mit.txt = license.mit.txt
		README.md = README.md
	EndProjectSection
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "documentations", "documentations", "{CD7C8139-B069-4C41-86EE-8D0F8BD24191}"
	ProjectSection(SolutionItems) = preProject
		DokanNet\documentations\Doxyfile = DokanNet\documentations\Doxyfile
		DokanNet\documentations\mainpage.md = DokanNet\documentations\mainpage.md
	EndProjectSection
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "resources", "resources", "{F4BC71C8-E83F-499B-8E6F-4FB9B2F5972A}"
	ProjectSection(SolutionItems) = preProject
		DokanNet\documentations\resources\customdoxygen.css = DokanNet\documentations\resources\customdoxygen.css
		DokanNet\documentations\resources\doxy-boot.js = DokanNet\documentations\resources\doxy-boot.js
		DokanNet\documentations\resources\footer.html = DokanNet\documentations\resources\footer.html
		DokanNet\documentations\resources\header.html = DokanNet\documentations\resources\header.html
	EndProjectSection
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "DokanNet", "DokanNet\DokanNet.csproj", "{CD78387D-1136-4143-8B71-1DBC2DD440DF}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "RegistryFS", "sample\RegistryFS\RegistryFS.csproj", "{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "DokanNet.Tests", "DokanNet.Tests\DokanNet.Tests.csproj", "{73710F27-0C95-4D47-8A00-CB9F003E2FE7}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "DokanNetMirrorLegacy", "sample\DokanNetMirrorLegacy\DokanNetMirrorLegacy.csproj", "{31E913C0-D407-C428-FBDA-3A257F22EDA6}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "DokanNetMirror", "sample\DokanNetMirror\DokanNetMirror.csproj", "{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Debug|x64 = Debug|x64
		Debug|x86 = Debug|x86
		Release|Any CPU = Release|Any CPU
		Release|x64 = Release|x64
		Release|x86 = Release|x86
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{CD78387D-1136-4143-8B71-1DBC2DD440DF}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{CD78387D-1136-4143-8B71-1DBC2DD440DF}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{CD78387D-1136-4143-8B71-1DBC2DD440DF}.Debug|x64.ActiveCfg = Debug|Any CPU
		{CD78387D-1136-4143-8B71-1DBC2DD440DF}.Debug|x64.Build.0 = Debug|Any CPU
		{CD78387D-1136-4143-8B71-1DBC2DD440DF}.Debug|x86.ActiveCfg = Debug|Any CPU
		{CD78387D-1136-4143-8B71-1DBC2DD440DF}.Debug|x86.Build.0 = Debug|Any CPU
		{CD78387D-1136-4143-8B71-1DBC2DD440DF}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{CD78387D-1136-4143-8B71-1DBC2DD440DF}.Release|Any CPU.Build.0 = Release|Any CPU
		{CD78387D-1136-4143-8B71-1DBC2DD440DF}.Release|x64.ActiveCfg = Release|Any CPU
		{CD78387D-1136-4143-8B71-1DBC2DD440DF}.Release|x64.Build.0 = Release|Any CPU
		{CD78387D-1136-4143-8B71-1DBC2DD440DF}.Release|x86.ActiveCfg = Release|Any CPU
		{CD78387D-1136-4143-8B71-1DBC2DD440DF}.Release|x86.Build.0 = Release|Any CPU
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}.Debug|x64.ActiveCfg = Debug|Any CPU
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}.Debug|x64.Build.0 = Debug|Any CPU
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}.Debug|x86.ActiveCfg = Debug|Any CPU
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}.Debug|x86.Build.0 = Debug|Any CPU
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}.Release|Any CPU.Build.0 = Release|Any CPU
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}.Release|x64.ActiveCfg = Release|Any CPU
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}.Release|x64.Build.0 = Release|Any CPU
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}.Release|x86.ActiveCfg = Release|Any CPU
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3}.Release|x86.Build.0 = Release|Any CPU
		{73710F27-0C95-4D47-8A00-CB9F003E2FE7}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{73710F27-0C95-4D47-8A00-CB9F003E2FE7}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{73710F27-0C95-4D47-8A00-CB9F003E2FE7}.Debug|x64.ActiveCfg = Debug|Any CPU
		{73710F27-0C95-4D47-8A00-CB9F003E2FE7}.Debug|x64.Build.0 = Debug|Any CPU
		{73710F27-0C95-4D47-8A00-CB9F003E2FE7}.Debug|x86.ActiveCfg = Debug|Any CPU
		{73710F27-0C95-4D47-8A00-CB9F003E2FE7}.Debug|x86.Build.0 = Debug|Any CPU
		{73710F27-0C95-4D47-8A00-CB9F003E2FE7}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{73710F27-0C95-4D47-8A00-CB9F003E2FE7}.Release|Any CPU.Build.0 = Release|Any CPU
		{73710F27-0C95-4D47-8A00-CB9F003E2FE7}.Release|x64.ActiveCfg = Release|Any CPU
		{73710F27-0C95-4D47-8A00-CB9F003E2FE7}.Release|x64.Build.0 = Release|Any CPU
		{73710F27-0C95-4D47-8A00-CB9F003E2FE7}.Release|x86.ActiveCfg = Release|Any CPU
		{73710F27-0C95-4D47-8A00-CB9F003E2FE7}.Release|x86.Build.0 = Release|Any CPU
		{31E913C0-D407-C428-FBDA-3A257F22EDA6}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{31E913C0-D407-C428-FBDA-3A257F22EDA6}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{31E913C0-D407-C428-FBDA-3A257F22EDA6}.Debug|x64.ActiveCfg = Debug|Any CPU
		{31E913C0-D407-C428-FBDA-3A257F22EDA6}.Debug|x64.Build.0 = Debug|Any CPU
		{31E913C0-D407-C428-FBDA-3A257F22EDA6}.Debug|x86.ActiveCfg = Debug|Any CPU
		{31E913C0-D407-C428-FBDA-3A257F22EDA6}.Debug|x86.Build.0 = Debug|Any CPU
		{31E913C0-D407-C428-FBDA-3A257F22EDA6}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{31E913C0-D407-C428-FBDA-3A257F22EDA6}.Release|Any CPU.Build.0 = Release|Any CPU
		{31E913C0-D407-C428-FBDA-3A257F22EDA6}.Release|x64.ActiveCfg = Release|Any CPU
		{31E913C0-D407-C428-FBDA-3A257F22EDA6}.Release|x64.Build.0 = Release|Any CPU
		{31E913C0-D407-C428-FBDA-3A257F22EDA6}.Release|x86.ActiveCfg = Release|Any CPU
		{31E913C0-D407-C428-FBDA-3A257F22EDA6}.Release|x86.Build.0 = Release|Any CPU
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}.Debug|x64.ActiveCfg = Debug|Any CPU
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}.Debug|x64.Build.0 = Debug|Any CPU
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}.Debug|x86.ActiveCfg = Debug|Any CPU
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}.Debug|x86.Build.0 = Debug|Any CPU
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}.Release|Any CPU.Build.0 = Release|Any CPU
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}.Release|x64.ActiveCfg = Release|Any CPU
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}.Release|x64.Build.0 = Release|Any CPU
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}.Release|x86.ActiveCfg = Release|Any CPU
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86}.Release|x86.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(NestedProjects) = preSolution
		{F4BC71C8-E83F-499B-8E6F-4FB9B2F5972A} = {CD7C8139-B069-4C41-86EE-8D0F8BD24191}
		{F47199F2-DDE4-4998-8D31-F8E8D8A30DA3} = {6AF2183D-1D93-414C-8FAC-C97E60078F4C}
		{31E913C0-D407-C428-FBDA-3A257F22EDA6} = {6AF2183D-1D93-414C-8FAC-C97E60078F4C}
		{C9D9E6E4-3988-6B0E-D7B9-C1176D2F5E86} = {6AF2183D-1D93-414C-8FAC-C97E60078F4C}
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {6631EDC0-DEBF-411B-ACC6-44A5FA6A19DD}
	EndGlobalSection
EndGlobal

```

## Project: sample

## Project: Solution Items

## Project: documentations

## Project: DokanNet

### Project File: DokanNet.csproj

```<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFrameworks>netstandard2.0;netstandard2.1;net48;net46;net8.0;net9.0</TargetFrameworks>
    <AssemblyName>DokanNet</AssemblyName>
    <RootNamespace>DokanNet</RootNamespace>
    <Description>A user mode file system for windows. 

This is a .NET wrapper over Dokan, and allows you to create your own file systems in Windows.</Description>
    <Copyright>Copyright (C) 2025</Copyright>
    <Version>2.3.0.1</Version>
    <AssemblyVersion>2.3.0.1</AssemblyVersion>
    <FileVersion>2.3.0.1</FileVersion>
    <GeneratePackageOnBuild>True</GeneratePackageOnBuild>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
	<PackageReadmeFile>README.md</PackageReadmeFile>
    <Company>Dokan-dev</Company>
    <Authors>AdrienJ, MaximeC, Hiroki Asakawa</Authors>
    <PackageProjectUrl>https://dokan-dev.github.io/</PackageProjectUrl>
    <PackageLicenseExpression>MIT</PackageLicenseExpression>
    <PackageIcon>dokan_logo.png</PackageIcon>
    <RepositoryUrl>https://github.com/dokan-dev/dokan-dotnet</RepositoryUrl>
    <RepositoryType>git</RepositoryType>
    <PackageTags>dokan file files disk directory storage filesystem io filestore FAT NTFS FUSE</PackageTags>
    <AssemblyOriginatorKeyFile>Dokan.snk</AssemblyOriginatorKeyFile>
    <SignAssembly>false</SignAssembly>
    <CLSCompliant>True</CLSCompliant>
    <LangVersion>Latest</LangVersion>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
  </PropertyGroup>

  <ItemGroup>
    <Compile Remove="documentations\**" />
    <EmbeddedResource Remove="documentations\**" />
    <None Remove="documentations\**" />
  </ItemGroup>

  <ItemGroup>
    <None Include="..\dokan_logo.png" Pack="true" PackagePath="\" />
	<None Include="..\README.md" Pack="true" PackagePath="\" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="LTRData.Extensions.Native" Version="*" />
  </ItemGroup>

  <ItemGroup Condition="'$(TargetFramework.CompareTo(`net461`))' &gt;= 0">
    <PackageReference Include="System.Memory" Version="*" />
    <PackageReference Include="System.Runtime.CompilerServices.Unsafe" Version="*" />
    <PackageReference Include="System.ValueTuple" Version="*" />
    <PackageReference Include="Microsoft.Bcl.AsyncInterfaces" Version="*" />
    <PackageReference Include="System.IO.FileSystem.AccessControl" Version="*" />
  </ItemGroup>

  <ItemGroup Condition="'$(TargetFramework.CompareTo(`net461`))' &lt; 0">
    <PackageReference Include="System.Memory" Version="4.5.*" />
    <PackageReference Include="System.Runtime.CompilerServices.Unsafe" Version="5.*" />
    <PackageReference Include="System.ValueTuple" Version="4.5.*" />
    <PackageReference Include="StringInterpolationBridgeStrong" Version="0.9.1" />
  </ItemGroup>

</Project>

```

### AssemblyInfo.cs

```using System.Runtime.CompilerServices;

// Make internals visible to tests.
[assembly: InternalsVisibleTo("DokanNet.Tests")]

```

### Resources.Designer.cs

```//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DokanNet.Properties {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DokanNet.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t assign a drive letter or mount point.
        /// </summary>
        internal static string ErrorAssignDriveLetter {
            get {
                return ResourceManager.GetString("ErrorAssignDriveLetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad drive letter.
        /// </summary>
        internal static string ErrorBadDriveLetter {
            get {
                return ResourceManager.GetString("ErrorBadDriveLetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dokan error.
        /// </summary>
        internal static string ErrorDokan {
            get {
                return ResourceManager.GetString("ErrorDokan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t install the Dokan driver.
        /// </summary>
        internal static string ErrorDriverInstall {
            get {
                return ResourceManager.GetString("ErrorDriverInstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mount point is invalid.
        /// </summary>
        internal static string ErrorMountPointInvalid {
            get {
                return ResourceManager.GetString("ErrorMountPointInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something&apos;s wrong with the Dokan driver.
        /// </summary>
        internal static string ErrorStart {
            get {
                return ResourceManager.GetString("ErrorStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error.
        /// </summary>
        internal static string ErrorUnknown {
            get {
                return ResourceManager.GetString("ErrorUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version error.
        /// </summary>
        internal static string ErrorVersion {
            get {
                return ResourceManager.GetString("ErrorVersion", resourceCulture);
            }
        }
    }
}

```

### DokanOperationsAdapter.cs

```using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using System.Security.Principal;
using DokanNet.Logging;
using LTRData.Extensions.Native.Memory;

namespace DokanNet.Legacy;

#if NET5_0_OR_GREATER
[SupportedOSPlatform("windows")]
#endif
internal class DokanOperationsAdapter(IDokanOperations operations, ILogger logger) : IDokanOperations2
{
    public int DirectoryListingTimeoutResetIntervalMs => 0;

    public void Cleanup(ReadOnlyNativeMemory<char> fileNamePtr, ref DokanFileInfo info)
        => operations.Cleanup(fileNamePtr.ToString(), new DokanFileInfoAdapter(ref info));

    public void CloseFile(ReadOnlyNativeMemory<char> fileNamePtr, ref DokanFileInfo info)
        => operations.CloseFile(fileNamePtr.ToString(), new DokanFileInfoAdapter(ref info));

    public NtStatus CreateFile(ReadOnlyNativeMemory<char> fileNamePtr, FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, ref DokanFileInfo info)
        => operations.CreateFile(fileNamePtr.ToString(), access, share, mode, options, attributes, new DokanFileInfoAdapter(ref info));

    public NtStatus DeleteDirectory(ReadOnlyNativeMemory<char> fileNamePtr, ref DokanFileInfo info)
        => operations.DeleteDirectory(fileNamePtr.ToString(), new DokanFileInfoAdapter(ref info));

    public NtStatus DeleteFile(ReadOnlyNativeMemory<char> fileNamePtr, ref DokanFileInfo info)
        => operations.DeleteFile(fileNamePtr.ToString(), new DokanFileInfoAdapter(ref info));

    public NtStatus FindFiles(ReadOnlyNativeMemory<char> fileNamePtr, out IEnumerable<FindFileInformation> files, ref DokanFileInfo info)
    {
        var status = operations.FindFiles(fileNamePtr.ToString(), out var list, new DokanFileInfoAdapter(ref info));

        files = list.Select(item => new FindFileInformation
        {
            Attributes = item.Attributes,
            CreationTime = item.CreationTime,
            LastAccessTime = item.LastAccessTime,
            LastWriteTime = item.LastWriteTime,
            Length = item.Length,
            FileName = item.FileName.AsMemory()
        });

        return status;
    }

    public NtStatus FindFilesWithPattern(ReadOnlyNativeMemory<char> fileNamePtr, ReadOnlyNativeMemory<char> searchPatternPtr, out IEnumerable<FindFileInformation> files, ref DokanFileInfo info)
    {
        var status = operations.FindFilesWithPattern(fileNamePtr.ToString(), searchPatternPtr.ToString(), out var list, new DokanFileInfoAdapter(ref info));

        files = list.Select(item => new FindFileInformation
        {
            Attributes = item.Attributes,
            CreationTime = item.CreationTime,
            LastAccessTime = item.LastAccessTime,
            LastWriteTime = item.LastWriteTime,
            Length = item.Length,
            FileName = item.FileName.AsMemory()
        });

        return status;
    }

    public NtStatus FindStreams(ReadOnlyNativeMemory<char> fileNamePtr, out IEnumerable<FindFileInformation> streams, ref DokanFileInfo info)
    {
        var status = operations.FindStreams(fileNamePtr.ToString(), out var list, new DokanFileInfoAdapter(ref info));

        streams = list.Select(item => new FindFileInformation
        {
            Attributes = item.Attributes,
            CreationTime = item.CreationTime,
            LastAccessTime = item.LastAccessTime,
            LastWriteTime = item.LastWriteTime,
            Length = item.Length,
            FileName = item.FileName.AsMemory()
        });

        return status;
    }

    public NtStatus FlushFileBuffers(ReadOnlyNativeMemory<char> fileNamePtr, ref DokanFileInfo info)
        => operations.FlushFileBuffers(fileNamePtr.ToString(), new DokanFileInfoAdapter(ref info));

    public NtStatus GetDiskFreeSpace(out long freeBytesAvailable, out long totalNumberOfBytes, out long totalNumberOfFreeBytes, ref DokanFileInfo info)
        => operations.GetDiskFreeSpace(out freeBytesAvailable, out totalNumberOfBytes, out totalNumberOfFreeBytes, new DokanFileInfoAdapter(ref info));

    public NtStatus GetFileInformation(ReadOnlyNativeMemory<char> fileNamePtr, out ByHandleFileInformation fileInfo, ref DokanFileInfo info)
    {
        var status = operations.GetFileInformation(fileNamePtr.ToString(), out var fileInfoLegacy, new DokanFileInfoAdapter(ref info));

        fileInfo = new()
        {
            Attributes = fileInfoLegacy.Attributes,
            CreationTime = fileInfoLegacy.CreationTime,
            LastAccessTime = fileInfoLegacy.LastAccessTime,
            LastWriteTime = fileInfoLegacy.LastWriteTime,
            Length = fileInfoLegacy.Length
        };

        return status;
    }

    public NtStatus GetFileSecurity(ReadOnlyNativeMemory<char> fileNamePtr, out FileSystemSecurity? security, AccessControlSections sections, ref DokanFileInfo info)
        => operations.GetFileSecurity(fileNamePtr.ToString(), out security, sections, new DokanFileInfoAdapter(ref info));

    public NtStatus GetVolumeInformation(NativeMemory<char> volumeLabel, out FileSystemFeatures features, NativeMemory<char> fileSystemName, out uint maximumComponentLength, ref uint volumeSerialNumber, ref DokanFileInfo info)
    {
        var status = operations.GetVolumeInformation(out var volumeLabelStr, out features, out var fileSystemNameStr, out maximumComponentLength, new DokanFileInfoAdapter(ref info));
        volumeLabel.SetString(volumeLabelStr);
        fileSystemName.SetString(fileSystemNameStr);
        return status;
    }

    public NtStatus LockFile(ReadOnlyNativeMemory<char> fileNamePtr, long offset, long length, ref DokanFileInfo info)
        => operations.LockFile(fileNamePtr.ToString(), offset, length, new DokanFileInfoAdapter(ref info));

    public NtStatus Mounted(ReadOnlyNativeMemory<char> mountPoint, ref DokanFileInfo info)
        => operations.Mounted(mountPoint.ToString(), new DokanFileInfoAdapter(ref info));

    public NtStatus MoveFile(ReadOnlyNativeMemory<char> oldNamePtr, ReadOnlyNativeMemory<char> newNamePtr, bool replace, ref DokanFileInfo info)
        => operations.MoveFile(oldNamePtr.ToString(), newNamePtr.ToString(), replace, new DokanFileInfoAdapter(ref info));

    public NtStatus ReadFile(ReadOnlyNativeMemory<char> fileNamePtr, NativeMemory<byte> buffer, out int bytesRead, long offset, ref DokanFileInfo info)
    {
        if (operations is IDokanOperationsUnsafe unsafeOperations)
        {
            return unsafeOperations.ReadFile(fileNamePtr.ToString(), buffer.Address, (uint)buffer.Length, out bytesRead, offset, new DokanFileInfoAdapter(ref info));
        }

        // Pool the read buffer and return it to the pool when we're done with it.
        var array = BufferPool.Default.RentBuffer(buffer.Length, logger);
        try
        {
            var status = operations.ReadFile(fileNamePtr.ToString(), array, out bytesRead, offset, new DokanFileInfoAdapter(ref info));
            array.AsSpan().CopyTo(buffer.Span);
            return status;
        }
        finally
        {
            BufferPool.Default.ReturnBuffer(array, logger);
        }
    }

    public NtStatus SetAllocationSize(ReadOnlyNativeMemory<char> fileNamePtr, long length, ref DokanFileInfo info)
        => operations.SetAllocationSize(fileNamePtr.ToString(), length, new DokanFileInfoAdapter(ref info));

    public NtStatus SetEndOfFile(ReadOnlyNativeMemory<char> fileNamePtr, long length, ref DokanFileInfo info)
        => operations.SetEndOfFile(fileNamePtr.ToString(), length, new DokanFileInfoAdapter(ref info));

    public NtStatus SetFileAttributes(ReadOnlyNativeMemory<char> fileNamePtr, FileAttributes attributes, ref DokanFileInfo info)
        => operations.SetFileAttributes(fileNamePtr.ToString(), attributes, new DokanFileInfoAdapter(ref info));

    public NtStatus SetFileSecurity(ReadOnlyNativeMemory<char> fileNamePtr, FileSystemSecurity security, AccessControlSections sections, ref DokanFileInfo info)
        => operations.SetFileSecurity(fileNamePtr.ToString(), security, sections, new DokanFileInfoAdapter(ref info));

    public NtStatus SetFileTime(ReadOnlyNativeMemory<char> fileNamePtr, DateTime? creationTime, DateTime? lastAccessTime, DateTime? lastWriteTime, ref DokanFileInfo info)
        => operations.SetFileTime(fileNamePtr.ToString(), creationTime, lastAccessTime, lastWriteTime, new DokanFileInfoAdapter(ref info));

    public NtStatus UnlockFile(ReadOnlyNativeMemory<char> fileNamePtr, long offset, long length, ref DokanFileInfo info)
        => operations.UnlockFile(fileNamePtr.ToString(), offset, length, new DokanFileInfoAdapter(ref info));

    public NtStatus Unmounted(ref DokanFileInfo info)
        => operations.Unmounted(new DokanFileInfoAdapter(ref info));

    public NtStatus WriteFile(ReadOnlyNativeMemory<char> fileNamePtr, ReadOnlyNativeMemory<byte> buffer, out int bytesWritten, long offset, ref DokanFileInfo info)
    {
        if (operations is IDokanOperationsUnsafe unsafeOperations)
        {
            return unsafeOperations.WriteFile(fileNamePtr.ToString(), buffer.Address, (uint)buffer.Length, out bytesWritten, offset, new DokanFileInfoAdapter(ref info));
        }

        // Pool the write buffer and return it to the pool when we're done with it.
        var array = BufferPool.Default.RentBuffer(buffer.Length, logger);
        try
        {
            buffer.Span.CopyTo(array);

            var status = operations.WriteFile(
                fileNamePtr.ToString(),
                array,
                out bytesWritten,
                offset,
                new DokanFileInfoAdapter(ref info));

            return status;
        }
        finally
        {
            BufferPool.Default.ReturnBuffer(array, logger);
        }
    }

    public override string? ToString() => operations.ToString();

    private unsafe class DokanFileInfoAdapter : IDokanFileInfo
    {
        private readonly DokanFileInfo* ptr;

        public DokanFileInfoAdapter(ref DokanFileInfo values)
        {
            ptr = (DokanFileInfo*)Unsafe.AsPointer(ref values);
        }

        public object? Context { get => ptr->Context; set => ptr->Context = value; }

        public bool DeletePending { get => ptr->DeletePending; set => ptr->DeletePending = value; }

        public bool IsDirectory { get => ptr->IsDirectory; set => ptr->IsDirectory = value; }

        public bool NoCache => ptr->NoCache;

        public bool PagingIo => ptr->PagingIo;

        public int ProcessId => ptr->ProcessId;

        public bool SynchronousIo => ptr->SynchronousIo;

        public bool WriteToEndOfFile => ptr->WriteToEndOfFile;

        public WindowsIdentity GetRequestor() => ptr->GetRequestor();

        public bool TryResetTimeout(int milliseconds) => ptr->TryResetTimeout(milliseconds);

        public override string? ToString() => ptr->ToString();
    }
}

```

### ConsoleLogger.cs

```using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Threading.Tasks;

namespace DokanNet.Logging
{
    /// <summary>
    /// Log to the console.
    /// </summary>
    public class ConsoleLogger : ILogger, IDisposable
    {
        private readonly string _loggerName;
        private readonly DateTimeFormatInfo? _dateTimeFormatInfo;
        private readonly BlockingCollection<(string Message, ConsoleColor Color)> _PendingLogs = [];

        private readonly Task? _WriterTask = null;
        private bool _disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleLogger"/> class.
        /// </summary>
        /// <param name="loggerName">Optional name to be added to each log line.</param>
        /// <param name="dateTimeFormatInfo">An object that supplies format information for DateTime.</param>
        public ConsoleLogger(string loggerName = "", DateTimeFormatInfo? dateTimeFormatInfo = null)
        {
            _loggerName = loggerName;
            _dateTimeFormatInfo = dateTimeFormatInfo;
            _WriterTask = Task.Factory.StartNew(() =>
            {
                foreach (var (Message, Color) in _PendingLogs.GetConsumingEnumerable())
                {
                    WriteMessage(Message, Color);
                }
            });
        }

        /// <inheritdoc />        
        public bool DebugEnabled => true;

        /// <inheritdoc />
        public void Debug(string message, params object[] args)
        {
            EnqueueMessage(Console.ForegroundColor, message, args);
        }

        /// <inheritdoc />
        public void Info(string message, params object[] args)
        {
            EnqueueMessage(Console.ForegroundColor, message, args);
        }

        /// <inheritdoc />
        public void Warn(string message, params object[] args)
        {
            EnqueueMessage(ConsoleColor.DarkYellow, message, args);
        }

        /// <inheritdoc />
        public void Error(string message, params object[] args)
        {
            EnqueueMessage(ConsoleColor.Red, message, args);
        }

        /// <inheritdoc />
        public void Fatal(string message, params object[] args)
        {
            EnqueueMessage(ConsoleColor.Red, message, args);
        }

        private void EnqueueMessage(ConsoleColor newColor, string message, params object[] args)
        {
            if (args.Length > 0)
            {
                message = string.Format(message, args);
            }

            _PendingLogs.Add((message, newColor));
        }

        private void WriteMessage(string message, ConsoleColor newColor)
        {
            lock (Console.Out) // we only need this lock because we want to have more than one logger in this version
            {
                var origForegroundColor = Console.ForegroundColor;
                Console.ForegroundColor = newColor;
                Console.WriteLine(message.FormatMessageForLogging(true, loggerName: _loggerName, dateTimeFormatInfo: _dateTimeFormatInfo));
                Console.ForegroundColor = origForegroundColor;
            }
        }

        /// <summary>
        /// Dispose the object from the native resources.
        /// </summary>
        /// <param name="disposing">Whether it was call by <see cref="Dispose()"/></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects)
                    _PendingLogs.CompleteAdding();
                    _WriterTask?.Wait();
                }

                // free unmanaged resources (unmanaged objects) and override finalizer
                // set large fields to null
                _disposed = true;
            }
        }

        /// <summary>
        /// Dispose the object from the native resources.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
```

### DebugViewLogger.cs

```using System.Globalization;

namespace DokanNet.Logging
{
    /// <summary>
    /// Write log using OutputDebugString 
    /// </summary>
    /// <remarks>
    /// To see the output in visual studio 
    /// Project + %Properties, Debug tab, check "Enable unmanaged code debugging".
    /// </remarks> 
    public class DebugViewLogger : ILogger
    {
        private readonly string _loggerName;
        private readonly DateTimeFormatInfo? _dateTimeFormatInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugViewLogger"/> class.
        /// </summary>
        /// <param name="loggerName">Optional name to be added to each log line.</param>
        /// <param name="dateTimeFormatInfo">An object that supplies format information for DateTime.</param>
        public DebugViewLogger(string loggerName = "", DateTimeFormatInfo? dateTimeFormatInfo = null)
        {
            _loggerName = loggerName;
            _dateTimeFormatInfo = dateTimeFormatInfo;
        }

        /// <inheritdoc />
        public bool DebugEnabled => true;

        /// <inheritdoc />
        public void Debug(string message, params object[] args)
        {
            WriteMessageToDebugView("debug", message, args);
        }

        /// <inheritdoc />
        public void Info(string message, params object[] args)
        {
            WriteMessageToDebugView("info", message, args);
        }

        /// <inheritdoc />
        public void Warn(string message, params object[] args)
        {
            WriteMessageToDebugView("warn", message, args);
        }

        /// <inheritdoc />
        public void Error(string message, params object[] args)
        {
            WriteMessageToDebugView("error", message, args);
        }

        /// <inheritdoc />
        public void Fatal(string message, params object[] args)
        {
            WriteMessageToDebugView("fatal", message, args);
        }

        private void WriteMessageToDebugView(string category, string message, params object[] args)
        {
            if (args?.Length > 0)
            {
                message = string.Format(message, args);
            }

            System.Diagnostics.Debug.WriteLine(message.FormatMessageForLogging(category, _loggerName, _dateTimeFormatInfo));
        }
    }
}
```

### ILogger.cs

```namespace DokanNet.Logging
{
    /// <summary>
    /// The %Logger interface.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Gets a value indicating whether the logger wishes to receive debug messages.
        /// </summary>
        bool DebugEnabled { get; }

        /// <summary>
        /// Log a debug message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        /// <param name="args">Arguments to use to format the <paramref name="message"/></param>
        void Debug(string message, params object[] args);

        /// <summary>
        /// Log a info message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        /// <param name="args">Arguments to use to format the <paramref name="message"/></param>
        void Info(string message, params object[] args);

        /// <summary>
        /// Log a warning message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        /// <param name="args">Arguments to use to format the <paramref name="message"/></param>
        void Warn(string message, params object[] args);

        /// <summary>
        /// Log a error message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        /// <param name="args">Arguments to use to format the <paramref name="message"/></param>
        void Error(string message, params object[] args);

        /// <summary>
        /// Log a fatal error message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        /// <param name="args">Arguments to use to format the <paramref name="message"/></param>
        void Fatal(string message, params object[] args);
    }
}

```

### Logger.cs

```using System;

namespace DokanNet.Logging
{
    /// <summary>
    /// Handle log messages with callbacks
    /// </summary>
    public class Logger : ILogger
    {
        private readonly Action<string, object[]> _debug;
        private readonly Action<string, object[]> _info;
        private readonly Action<string, object[]> _warn;
        private readonly Action<string, object[]> _error;
        private readonly Action<string, object[]> _fatal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        /// <param name="debug">An <see cref="Action{T}"/> that are called when a debug log message are arriving.</param>
        /// <param name="info">An <see cref="Action{T}"/> that are called when a information log message are arriving</param>
        /// <param name="warn">An <see cref="Action{T}"/> that are called when a warning log message are arriving</param>
        /// <param name="error">An <see cref="Action{T}"/> that are called when a error log message are arriving</param>
        /// <param name="fatal">An <see cref="Action{T}"/> that are called when a fatal error log message are arriving</param>
        public Logger(
            Action<string, object[]> debug,
            Action<string, object[]> info,
            Action<string, object[]> warn,
            Action<string, object[]> error,
            Action<string, object[]> fatal)
        {
            _debug = debug;
            _info = info;
            _warn = warn;
            _error = error;
            _fatal = fatal;
        }

        /// <inheritdoc />
        public bool DebugEnabled => _debug != null;

        /// <inheritdoc />
        public void Debug(string message, params object[] args)
        {
            _debug(message, args);
        }

        /// <inheritdoc />
        public void Info(string message, params object[] args)
        {
            _info(message, args);
        }

        /// <inheritdoc />
        public void Warn(string message, params object[] args)
        {
            _warn(message, args);
        }

        /// <inheritdoc />
        public void Error(string message, params object[] args)
        {
            _error(message, args);
        }

        /// <inheritdoc />
        public void Fatal(string message, params object[] args)
        {
            _fatal(message, args);
        }
    }
}
```

### LoggerExtensions.cs

```using System;
using System.Globalization;
using System.Text;

namespace DokanNet.Logging
{
    /// <summary>
    /// Extension functions to log messages.
    /// </summary>
    public static class LoggerExtensions
    {
        /// <summary>
        /// Format a log message.
        /// </summary>
        /// <param name="message">Message to format.</param>
        /// <param name="category">Optional category to add to the log message.</param>
        /// <param name="loggerName">Optional log name to at to the log message.</param>
        /// <param name="dateTimeFormatInfo">An object that supplies format information for DateTime.</param>
        /// <returns>A formated log message.</returns>
        public static string FormatMessageForLogging(
            this string message,
            string? category = null,
            string loggerName = "",
            DateTimeFormatInfo? dateTimeFormatInfo = null)
        {
            return message.FormatMessageForLogging(false, category, loggerName, dateTimeFormatInfo);
        }

        /// <summary>
        /// Format a log message.
        /// </summary>
        /// <param name="message">Message to format.</param>
        /// <param name="addDateTime">If date and time shout be added to the log message.</param>
        /// <param name="category">Optional category to add to the log message.</param>
        /// <param name="loggerName">Optional log name to at to the log message.</param>
        /// <param name="dateTimeFormatInfo">An object that supplies format information for DateTime.</param>
        /// <returns>A formated log message.</returns>
        public static string FormatMessageForLogging(
            this string message,
            bool addDateTime = false,
            string? category = null,
            string loggerName = "",
            DateTimeFormatInfo? dateTimeFormatInfo = null)
        {
            var stringBuilder = new StringBuilder();
            if (addDateTime)
            {
                stringBuilder.AppendFormat("{0} - ", DateTime.Now.ToString((IFormatProvider?)dateTimeFormatInfo ?? CultureInfo.InvariantCulture));
            }

            if (!string.IsNullOrEmpty(loggerName))
            {
                stringBuilder.Append(loggerName);
            }

            if (!string.IsNullOrEmpty(category))
            {
                stringBuilder.Append($"{category} ");
            }

            stringBuilder.Append(message);
            return stringBuilder.ToString();
        }
    }
}
```

### NullLogger.cs

```namespace DokanNet.Logging
{
    /// <summary>
    /// Ignore all log messages.
    /// </summary>
    public class NullLogger : ILogger
    {
        /// <inheritdoc />
        public bool DebugEnabled => false;

        /// <inheritdoc />
        public void Debug(string message, params object[] args)
        {
        }

        /// <inheritdoc />
        public void Error(string message, params object[] args)
        {
        }

        /// <inheritdoc />
        public void Fatal(string message, params object[] args)
        {
        }

        /// <inheritdoc />
        public void Info(string message, params object[] args)
        {
        }

        /// <inheritdoc />
        public void Warn(string message, params object[] args)
        {
        }
    }
}
```

### TraceLogger.cs

```using System.Diagnostics;

namespace DokanNet.Logging
{
    /// <summary>
    /// Write all log messages to the <see cref="Trace"/>.
    /// </summary>
    public class TraceLogger : ILogger
    {
        /// <inheritdoc />
        public bool DebugEnabled => true;

        /// <inheritdoc />
        public void Debug(string message, params object[] args)
        {
            Trace.TraceInformation(message, args);
        }

        /// <inheritdoc />
        public void Info(string message, params object[] args)
        {
            Trace.TraceInformation(message, args);
        }

        /// <inheritdoc />
        public void Warn(string message, params object[] args)
        {
            Trace.TraceWarning(message, args);
        }

        /// <inheritdoc />
        public void Error(string message, params object[] args)
        {
            Trace.TraceError(message, args);
        }

        /// <inheritdoc />
        public void Fatal(string message, params object[] args)
        {
            Trace.TraceError(message, args);
        }
    }
}
```

### BY_HANDLE_FILE_INFORMATION.cs

```using System.Runtime.InteropServices;
using FILETIME = System.Runtime.InteropServices.ComTypes.FILETIME;

namespace DokanNet.Native;

/// <summary>
/// Contains information that the <see cref="DokanOperationProxy.GetFileInformationProxy"/> function retrieves.
/// </summary>
/// <remarks>
/// The identifier that is stored in the nFileIndexHigh and nFileIndexLow members is called the file ID.
/// Support for file IDs is file system-specific. File IDs are not guaranteed to be unique over time,
/// because file systems are free to reuse them. In some cases, the file ID for a file can change over time.
/// 
/// In the FAT file system, the file ID is generated from the first cluster of the containing directory
/// and the byte offset within the directory of the entry for the file. Some defragmentation products
/// change this byte offset. (Windows in-box defragmentation does not.) Thus, a FAT file ID can change
/// over time.Renaming a file in the FAT file system can also change the file ID, but only if the new
/// file name is longer than the old one.
/// 
/// In the NTFS file system, a file keeps the same file ID until it is deleted. You can replace one file
/// with another file without changing the file ID by using the ReplaceFile function. However, the file ID
/// of the replacement file, not the replaced file, is retained as the file ID of the resulting file.
/// 
/// Not all file systems can record creation and last access time, and not all file systems record them
/// in the same manner. For example, on a Windows FAT file system, create time has a resolution of
/// 10 milliseconds, write time has a resolution of 2 seconds, and access time has a resolution of
/// 1 day (the access date). On the NTFS file system, access time has a resolution of 1 hour.
/// </remarks>
/// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa363788%28v=vs.85%29.aspx?f=255&amp;MSPPError=-2147217396">BY_HANDLE_FILE_INFORMATION structure (MSDN)</a>
[StructLayout(LayoutKind.Sequential, Pack = 4)]
internal struct BY_HANDLE_FILE_INFORMATION
{
    /// <summary>
    /// The file attributes. For possible values and their descriptions.
    /// </summary>
    public uint dwFileAttributes;

    /// <summary>
    /// A <see cref="FILETIME"/> structure that specifies when a file or directory is created. 
    /// If the underlying file system does not support creation time, this member is zero (0).
    /// </summary>
    public FILETIME ftCreationTime;

    /// <summary>
    ///  A <see cref="FILETIME"/> structure.
    /// For a file, the structure specifies the last time that a file is read from or written to.
    /// For a directory, the structure specifies when the directory is created.
    /// For both files and directories, the specified date is correct, but the time of day is always set to midnight.
    /// If the underlying file system does not support the last access time, this member is zero (0).
    /// </summary>
    public FILETIME ftLastAccessTime;

    /// <summary>
    /// A <see cref="FILETIME"/> structure. 
    /// For a file, the structure specifies the last time that a file is written to. 
    /// For a directory, the structure specifies when the directory is created. 
    /// If the underlying file system does not support the last write time, this member is zero (0).
    /// </summary>
    public FILETIME ftLastWriteTime;

    /// <summary>
    /// The serial number of the volume that contains a file.
    /// </summary>
    public uint dwVolumeSerialNumber;

    /// <summary>
    /// The high-order part of the file size.
    /// </summary>
    public uint nFileSizeHigh;

    /// <summary>
    /// The low-order part of the file size.
    /// </summary>
    public uint nFileSizeLow;

    /// <summary>
    /// The number of links to this file. 
    /// For the FAT file system this member is always 1. 
    /// For the NTFS file system, it can be more than 1.
    /// </summary>
    public int dwNumberOfLinks;

    /// <summary>
    /// The high-order part of a unique identifier that is associated with a file. 
    /// For more information, see <see cref="nFileIndexLow"/>.
    /// </summary>
    public uint nFileIndexHigh;

    /// <summary>
    /// The low-order part of a unique identifier that is associated with a file.
    /// 
    /// The identifier (low and high parts) and the volume serial number uniquely 
    /// identify a file on a single computer. To determine whether two open handles 
    /// represent the same file, combine the identifier and the volume serial number 
    /// for each file and compare them.
    /// 
    /// The ReFS file system, introduced with Windows Server 2012, includes 128-bit 
    /// file identifiers. To retrieve the 128-bit file identifier use the 
    /// GetFileInformationByHandleEx function with FileIdInfo to retrieve 
    /// the FILE_ID_INFO structure. The 64-bit identifier in this structure is not 
    /// guaranteed to be unique on ReFS.
    /// </summary>
    public uint nFileIndexLow;
}

```

### DOKAN_OPERATIONS.cs

```using System.Runtime.InteropServices;
using FILETIME = System.Runtime.InteropServices.ComTypes.FILETIME;

namespace DokanNet.Native;

/// <summary>
/// Dokan API callbacks interface
/// 
/// A struct of callbacks that describe all Dokan API operation
/// that will be called when Windows access to the filesystem.
/// 
/// If an error occurs, return <see cref="NtStatus"/>.
/// 
/// All this callbacks can be set to <c>null</c> or return <see cref="NtStatus.NotImplemented"/>
/// if you dont want to support one of them. Be aware that returning such value to important callbacks
/// such <see cref="ZwCreateFile"/>/<see cref="ReadFile"/>/... would make the filesystem not working or unstable.
/// 
/// Se <see cref="IDokanOperations2"/> for more information about the fields.
/// </summary>
/// <remarks>This is the same struct as <c>_DOKAN_OPERATIONS</c> (dokan.h) in the C version of Dokan.</remarks>
[StructLayout(LayoutKind.Sequential, Pack = 4)]
internal sealed unsafe class DOKAN_OPERATIONS
{
    #region Delegates

    public delegate NtStatus ZwCreateFileDelegate(
        nint rawFileName,
        nint securityContext,
        uint rawDesiredAccess,
        uint rawFileAttributes,
        uint rawShareAccess,
        uint rawCreateDisposition,
        uint rawCreateOptions,
        DokanFileInfo* dokanFileInfo);

    public delegate void CleanupDelegate(
        nint rawFileName,
        DokanFileInfo* rawFileInfo);

    public delegate void CloseFileDelegate(
        nint rawFileName,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus ReadFileDelegate(
        nint rawFileName,
        nint rawBuffer,
        uint rawBufferLength,
        int* rawReadLength,
        long rawOffset,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus WriteFileDelegate(
        nint rawFileName,
        nint rawBuffer,
        uint rawNumberOfBytesToWrite,
        int* rawNumberOfBytesWritten,
        long rawOffset,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus FlushFileBuffersDelegate(
        nint rawFileName,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus GetFileInformationDelegate(
        nint rawFileName,
        BY_HANDLE_FILE_INFORMATION* handleFileInfo,
        DokanFileInfo* fileInfo);

    public delegate NtStatus FindFilesDelegate(
        nint rawFileName,
        nint rawFillFindData,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus FindFilesWithPatternDelegate(
        nint rawFileName,
        nint rawSearchPattern,
        nint rawFillFindData,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus SetFileAttributesDelegate(
        nint rawFileName,
        uint rawAttributes,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus SetFileTimeDelegate(
        nint rawFileName,
        FILETIME* rawCreationTime,
        FILETIME* rawLastAccessTime,
        FILETIME* rawLastWriteTime,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus DeleteFileDelegate(
        nint rawFileName,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus DeleteDirectoryDelegate(
        nint rawFileName,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus MoveFileDelegate(
        nint rawFileName,
        nint rawNewFileName,
        [MarshalAs(UnmanagedType.Bool)] bool rawReplaceIfExisting,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus SetEndOfFileDelegate(
        nint rawFileName,
        long rawByteOffset,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus SetAllocationSizeDelegate(
        nint rawFileName,
        long rawLength,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus LockFileDelegate(
        nint rawFileName,
        long rawByteOffset, long rawLength,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus UnlockFileDelegate(
        nint rawFileName,
        long rawByteOffset, long rawLength,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus GetDiskFreeSpaceDelegate(
        long* rawFreeBytesAvailable, long* rawTotalNumberOfBytes, long* rawTotalNumberOfFreeBytes,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus GetVolumeInformationDelegate(
        nint rawVolumeNameBuffer,
        uint rawVolumeNameSize,
        uint* rawVolumeSerialNumber,
        uint* rawMaximumComponentLength,
        FileSystemFeatures* rawFileSystemFlags,
        nint rawFileSystemNameBuffer,
        uint rawFileSystemNameSize,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus GetFileSecurityDelegate(
        nint rawFileName,
        SECURITY_INFORMATION* rawRequestedInformation,
        nint rawSecurityDescriptor,
        uint rawSecurityDescriptorLength,
        uint* rawSecurityDescriptorLengthNeeded,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus SetFileSecurityDelegate(
        nint rawFileName,
        SECURITY_INFORMATION* rawSecurityInformation,
        nint rawSecurityDescriptor,
        uint rawSecurityDescriptorLength,
        DokanFileInfo* rawFileInfo);

    /// <summary>
    /// Retrieve all FileStreams informations on the file.
    /// This is only called if <see cref="DokanOptions.AltStream"/> is enabled.
    /// </summary>
    /// <remarks>Supported since 0.8.0. 
    /// You must specify the version at <see cref="DOKAN_OPTIONS.Version"/>.</remarks>
    /// <param name="rawFileName">Filename</param>
    /// <param name="rawFillFindData">A <see cref="nint"/> to a <see cref="WIN32_FIND_STREAM_DATA"/>.</param>
    /// <param name="findStreamContext"></param>
    /// <param name="rawFileInfo">A <see cref="DokanFileInfo"/>.</param>
    /// <returns></returns>
    public delegate NtStatus FindStreamsDelegate(
        nint rawFileName,
        nint rawFillFindData,
        nint findStreamContext,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus MountedDelegate(
        nint rawFileName,
        DokanFileInfo* rawFileInfo);

    public delegate NtStatus UnmountedDelegate(
        DokanFileInfo* rawFileInfo);

    #endregion Delegates

    public ZwCreateFileDelegate ZwCreateFile = null!;
    public CleanupDelegate Cleanup = null!;
    public CloseFileDelegate CloseFile = null!;
    public ReadFileDelegate ReadFile = null!;
    public WriteFileDelegate WriteFile = null!;
    public FlushFileBuffersDelegate FlushFileBuffers = null!;
    public GetFileInformationDelegate GetFileInformation = null!;
    public FindFilesDelegate FindFiles = null!;

    public FindFilesWithPatternDelegate FindFilesWithPattern = null!;

    public SetFileAttributesDelegate SetFileAttributes = null!;
    public SetFileTimeDelegate SetFileTime = null!;
    public DeleteFileDelegate DeleteFile = null!;
    public DeleteDirectoryDelegate DeleteDirectory = null!;
    public MoveFileDelegate MoveFile = null!;
    public SetEndOfFileDelegate SetEndOfFile = null!;
    public SetAllocationSizeDelegate SetAllocationSize = null!;

    // Lockfile & Unlockfile are only used if dokan option UserModeLock is enabled
    public LockFileDelegate LockFile = null!;
    public UnlockFileDelegate UnlockFile = null!;

    public GetDiskFreeSpaceDelegate GetDiskFreeSpace = null!;
    public GetVolumeInformationDelegate GetVolumeInformation = null!;
    public MountedDelegate Mounted = null!;
    public UnmountedDelegate Unmounted = null!;

    public GetFileSecurityDelegate GetFileSecurity = null!;
    public SetFileSecurityDelegate SetFileSecurity = null!;

    public FindStreamsDelegate FindStreams = null!;
}

```

### DOKAN_OPTIONS.cs

```using System.Runtime.InteropServices;

namespace DokanNet.Native;

/// <summary>
/// Dokan mount options used to describe dokan device behaviour
/// </summary>
/// <see cref="NativeMethods.DokanMain"/>
/// <remarks>This is the same structure as <c>PDOKAN_OPTIONS</c> (dokan.h) in the C version of Dokan.</remarks>
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
public sealed class DOKAN_OPTIONS
{
    /// <summary>
    /// Version of the dokan features requested (version "123" is equal to Dokan version 1.2.3).
    /// </summary>
    public ushort Version { get; set; }

    /// <summary>
    /// Only use a single thread to process events. This is highly not recommended as can easily create a bottleneck.
    /// </summary>
    [field: MarshalAs(UnmanagedType.U1)]
    public bool SingleThread { get; set; }

    /// <summary>
    /// Features enable for the mount. See <see cref="DokanOptions"/>.
    /// </summary>
    public DokanOptions Options { get; set; }

    /// <summary>
    /// FileSystem can store anything here.
    /// </summary>
    public ulong GlobalContext { get; set; }

    /// <summary>
    /// Mount point.
    /// Can be <c>M:\\</c>(drive letter) or <c>C:\\mount\\dokan</c> (path in NTFS).
    /// </summary>
    [field: MarshalAs(UnmanagedType.LPWStr)]
    public string? MountPoint { get; set; }

    /// <summary>
    /// UNC name used for network volume.
    /// </summary>
    [field: MarshalAs(UnmanagedType.LPWStr)]
    public string? UNCName { get; set; }

    private uint Timeout;
    /// <summary>
    /// Max timeout in milliseconds of each request before Dokan give up.
    /// </summary>
    public System.TimeSpan TimeOut
    {
        get => System.TimeSpan.FromMilliseconds(Timeout);
        set => Timeout = (uint)value.TotalMilliseconds;
    }

    /// <summary>
    /// Allocation Unit Size of the volume. This will behave on the file size.
    /// </summary>
    public int AllocationUnitSize { get; set; }

    /// <summary>
    /// Sector Size of the volume. This will behave on the file size.
    /// </summary>
    public int SectorSize { get; set; }
    /// <summary>
    /// Length of the optional VolumeSecurityDescriptor provided. Set 0 will disable the option.
    /// </summary>
    public int VolumeSecurityDescriptorLength { get; set; }

    /// <summary>
    /// Optional Volume Security descriptor. See <a href="https://docs.microsoft.com/en-us/windows/win32/api/securitybaseapi/nf-securitybaseapi-initializesecuritydescriptor">InitializeSecurityDescriptor</a>
    /// </summary>
    [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16384, ArraySubType = UnmanagedType.U1)]
    public byte[]? VolumeSecurityDescriptor { get; set; }
}

```

### NativeMethods.cs

```using LTRData.Extensions.Native.Memory;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace DokanNet.Native;

#pragma warning disable IDE0079 // Remove unnecessary suppression

internal delegate void NativeWaitOrTimerCallback(nint state, bool timedOut);

/// <summary>
/// Native API to the kernel Dokan driver.
/// </summary>
#if NET5_0_OR_GREATER
[SupportedOSPlatform("windows")]
#endif
internal static partial class NativeMethods
{
    private const string DOKAN_DLL = "dokan2.dll";

#if NET7_0_OR_GREATER
    /// <summary>
    /// Initialize all required Dokan internal resources.
    /// 
    /// This needs to be called only once before trying to use <see cref="DokanMain"/> or <see cref="DokanCreateFileSystem"/> for the first time.
    /// Otherwise both will fail and raise an exception.
    /// </summary>
    [LibraryImport(DOKAN_DLL)]
    public static partial void DokanInit();

    /// <summary>
    /// Release all allocated resources by <see cref="DokanInit"/> when they are no longer needed.
    ///
    /// This should be called when the application no longer expects to create a new FileSystem with
    /// <see cref="DokanMain"/> or <see cref="DokanCreateFileSystem"/> and after all devices are unmount.
    /// </summary>
    [LibraryImport(DOKAN_DLL)]
    public static partial void DokanShutdown();

    /// <summary>
    /// Converts native Win32 error code to NTSTATUS
    /// </summary>
    /// <param name="win32Error"></param>
    /// <returns></returns>
    [LibraryImport(DOKAN_DLL)]
    public static partial NtStatus DokanNtStatusFromWin32(int win32Error);

    /// <summary>
    /// Mount a new Dokan Volume.
    /// 
    /// It is mandatory to have called <see cref="DokanInit"/> previously to use this API.
    /// This function returns directly on device mount or on failure.
    /// <see cref="DokanWaitForFileSystemClosed"/> can be used to wait until the device is unmount.
    /// </summary>
    /// <param name="options">A <see cref="NativeStructWrapper&lt;DOKAN_OPTIONS&gt;"/> that describe the mount.</param>
    /// <param name="operations">Instance of <see cref="NativeStructWrapper&lt;DOKAN_OPERATIONS&gt;"/> that will be called for each request made by the kernel.</param>
    /// <param name="dokanInstance">Dokan mount instance context that can be used for related instance calls like <see cref="DokanIsFileSystemRunning"/>.</param>
    /// <returns><see cref="DokanStatus"/></returns>
    [LibraryImport(DOKAN_DLL)]
    public static partial DokanStatus DokanCreateFileSystem(SafeBuffer options, SafeBuffer operations, out DokanHandle dokanInstance);

    /// <summary>
    /// Register a callback for when the FileSystem is unmounted.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/>.</param>
    /// <param name="handle">Wait handle representing the registered wait. Needs to be freed by calling <see cref="DokanUnregisterWaitForFileSystemClosed"/>.</param>
    /// <param name="callback">Callback function to be called when file system is unmounted or timeout occurs.</param>
    /// <param name="context">Parameter to send to callback function.</param>
    /// <param name="milliSeconds">The time-out interval, in milliseconds. If a nonzero value is specified, the function waits until the object is signaled or the interval elapses. If <paramref name="milliSeconds" /> is zero,
    /// the function does not enter a wait state if the object is not signaled; it always returns immediately. If <paramref name="milliSeconds" /> is INFINITE, the function will return only when the object is signaled.</param>
    /// <returns>See <a href="https://docs.microsoft.com/en-us/windows/win32/api/synchapi/nf-synchapi-waitforsingleobject">WaitForSingleObject</a> for a description of return values.</returns>
    [LibraryImport(DOKAN_DLL)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DokanRegisterWaitForFileSystemClosed(DokanHandle? dokanInstance, out nint handle, NativeWaitOrTimerCallback callback, nint context, uint milliSeconds);

    /// <summary>
    /// Unregister a callback for when the FileSystem is unmounted.
    /// </summary>
    /// <param name="handle">Handle returned in handle parameter in previous call to <see cref="DokanRegisterWaitForFileSystemClosed"/></param>.
    /// <param name="waitForCallbacks">Indicates whether to wait for callbacks to complete before returning. Normally true unless called from same thread as callback function.</param>
    /// <returns></returns>
    [LibraryImport(DOKAN_DLL)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DokanUnregisterWaitForFileSystemClosed(nint handle, [MarshalAs(UnmanagedType.Bool)] bool waitForCallbacks);

    /// <summary>
    /// Check if the FileSystem is still running or not.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/>.</param>
    /// <returns>Whether the FileSystem is still running or not.</returns>
    [LibraryImport(DOKAN_DLL)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DokanIsFileSystemRunning(DokanHandle dokanInstance);

    /// <summary>
    /// Wait until the FileSystem is unmount.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/>.</param>
    /// <param name="milliSeconds">The time-out interval, in milliseconds. If a nonzero value is specified, the function waits until the object is signaled or the interval elapses. If <paramref name="milliSeconds" /> is zero,
    /// the function does not enter a wait state if the object is not signaled; it always returns immediately. If <paramref name="milliSeconds" /> is INFINITE, the function will return only when the object is signaled.</param>
    /// <returns>See <a href="https://docs.microsoft.com/en-us/windows/win32/api/synchapi/nf-synchapi-waitforsingleobject">WaitForSingleObject</a> for a description of return values.</returns>
    [LibraryImport(DOKAN_DLL)]
    public static partial uint DokanWaitForFileSystemClosed(DokanHandle dokanInstance, uint milliSeconds);

    /// <summary>
    /// Unmount and wait until all resources of the \c DokanInstance are released.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/>.</param>
    [LibraryImport(DOKAN_DLL)]
    public static partial void DokanCloseHandle(nint dokanInstance);

    /// <summary>
    /// Unmount a dokan device from a driver letter.
    /// </summary>
    /// <param name="driveLetter">Dokan driver letter to unmount.</param>
    /// <returns><c>True</c> if device was unmount or <c>false</c> in case of failure or device not found.</returns>
    [LibraryImport(DOKAN_DLL, StringMarshalling = StringMarshalling.Utf16)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DokanUnmount(char driveLetter);

    /// <summary>
    /// Get the version of Dokan.
    /// The returned <see cref="uint"/> is the version number without the dots.
    /// </summary>
    /// <returns>The version of Dokan</returns>
    [LibraryImport(DOKAN_DLL)]
    public static partial uint DokanVersion();

    /// <summary>
    /// Get the version of the Dokan driver.
    /// The returned <see cref="uint"/> is the version number without the dots.
    /// </summary>
    /// <returns>The version of Dokan driver.</returns>
    [LibraryImport(DOKAN_DLL)]
    public static partial uint DokanDriverVersion();

    /// <summary>
    /// Unmount a dokan device from a mount point
    /// </summary>
    /// <param name="mountPoint">MountPoint Mount point to unmount ("<c>Z</c>", 
    /// "<c>Z:</c>", "<c>Z:\\</c>", "<c>Z:\MyMountPoint</c>").</param>
    /// <returns><c>True</c> if device was unmount or <c>false</c> in case of failure or device not found.</returns>
    [LibraryImport(DOKAN_DLL, StringMarshalling = StringMarshalling.Utf16)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DokanRemoveMountPoint([MarshalAs(UnmanagedType.LPWStr)] string mountPoint);

    /// <summary>
    /// Convert <see cref="DokanOperationProxy.ZwCreateFileProxy"/> parameters to <see cref="IDokanOperations.CreateFile"/> parameters.
    /// </summary>
    /// <param name="desiredAccess">DesiredAccess from <see cref="DokanOperationProxy.ZwCreateFileProxy"/>.</param>
    /// <param name="fileAttributes">FileAttributes from <see cref="DokanOperationProxy.ZwCreateFileProxy"/>.</param>
    /// <param name="createOptions">CreateOptions from <see cref="DokanOperationProxy.ZwCreateFileProxy"/>.</param>
    /// <param name="createDisposition">CreateDisposition from <see cref="DokanOperationProxy.ZwCreateFileProxy"/>.</param>
    /// <param name="outDesiredAccess">New <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa363858(v=vs.85).aspx">CreateFile (MSDN)</a> dwDesiredAccess.</param>
    /// <param name="outFileAttributesAndFlags">New <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa363858(v=vs.85).aspx">CreateFile (MSDN)</a> dwFlagsAndAttributes.</param>
    /// <param name="outCreationDisposition">New <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa363858(v=vs.85).aspx">CreateFile (MSDN)</a> dwCreationDisposition.</param>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa363858(v=vs.85).aspx">CreateFile function (MSDN)</a>
    [LibraryImport(DOKAN_DLL)]
    public static partial void DokanMapKernelToUserCreateFileFlags(
        uint desiredAccess,
        uint fileAttributes,
        uint createOptions,
        uint createDisposition,
        out uint outDesiredAccess,
        out int outFileAttributesAndFlags,
        out int outCreationDisposition);

    /*
    [DllImport(DOKAN_DLL, CharSet = CharSet.Unicode)]
    public static extern bool DokanIsNameInExpression([MarshalAs(UnmanagedType.LPWStr)] string expression,
                                                      // matching pattern
                                                      [MarshalAs(UnmanagedType.LPWStr)] string name, // file name
                                                      [MarshalAs(UnmanagedType.Bool)] bool ignoreCase);*/

    /// <summary>
    /// Notify Dokan that a file or directory has been created.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/></param>
    /// <param name="filePath">Full path to the file or directory, including mount point.</param>
    /// <param name="isDirectory">Indicates if the path is a directory.</param>
    /// <returns>true if the notification succeeded.</returns>
    [LibraryImport(DOKAN_DLL, StringMarshalling = StringMarshalling.Utf16)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DokanNotifyCreate(DokanHandle dokanInstance,
                                                [MarshalAs(UnmanagedType.LPWStr)] string filePath,
                                                [MarshalAs(UnmanagedType.Bool)] bool isDirectory);

    /// <summary>
    /// Notify Dokan that a file or directory has been deleted.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/></param>
    /// <param name="filePath">Full path to the file or directory, including mount point.</param>
    /// <param name="isDirectory">Indicates if the path is a directory.</param>
    /// <returns>true if notification succeeded.</returns>
    [LibraryImport(DOKAN_DLL, StringMarshalling = StringMarshalling.Utf16)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DokanNotifyDelete(DokanHandle dokanInstance, [MarshalAs(UnmanagedType.LPWStr)] string filePath,
                                                [MarshalAs(UnmanagedType.Bool)] bool isDirectory);

    /// <summary>
    /// Notify Dokan that file or directory attributes have changed.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/></param>
    /// <param name="filePath">Full path to the file or directory, including mount point.</param>
    /// <returns>true if notification succeeded.</returns>
    [LibraryImport(DOKAN_DLL, StringMarshalling = StringMarshalling.Utf16)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DokanNotifyUpdate(DokanHandle dokanInstance, [MarshalAs(UnmanagedType.LPWStr)] string filePath);

    /// <summary>
    /// Notify Dokan that file or directory extended attributes have changed.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/></param>
    /// <param name="filePath">Full path to the file or directory, including mount point.</param>
    /// <returns>true if notification succeeded.</returns>
    [LibraryImport(DOKAN_DLL, StringMarshalling = StringMarshalling.Utf16)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DokanNotifyXAttrUpdate(DokanHandle dokanInstance, [MarshalAs(UnmanagedType.LPWStr)] string filePath);

    /// <summary>
    /// Notify Dokan that a file or directory has been renamed.
    /// </summary>
    /// <remarks>This method supports in-place rename for file/directory within the same parent.</remarks>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/></param>
    /// <param name="OldPath">Old path to the file or directory, including mount point.</param>
    /// <param name="newPath">New path to the file or directory, including mount point.</param>
    /// <param name="isDirectory">Indicates if the path is a directory.</param>
    /// <param name="isInSameDirectory">Indicates if OldPath and NewPath have the same parent.</param>
    /// <returns>true if notification succeeded.</returns>
    [LibraryImport(DOKAN_DLL, StringMarshalling = StringMarshalling.Utf16)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DokanNotifyRename(DokanHandle dokanInstance, [MarshalAs(UnmanagedType.LPWStr)] string OldPath,
                                                [MarshalAs(UnmanagedType.LPWStr)] string newPath,
                                                [MarshalAs(UnmanagedType.Bool)] bool isDirectory,
                                                [MarshalAs(UnmanagedType.Bool)] bool isInSameDirectory);
#else
    /// <summary>
    /// Initialize all required Dokan internal resources.
    /// 
    /// This needs to be called only once before trying to use <see cref="DokanMain"/> or <see cref="DokanCreateFileSystem"/> for the first time.
    /// Otherwise both will fail and raise an exception.
    /// </summary>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    public static extern void DokanInit();

    /// <summary>
    /// Release all allocated resources by <see cref="DokanInit"/> when they are no longer needed.
    ///
    /// This should be called when the application no longer expects to create a new FileSystem with
    /// <see cref="DokanMain"/> or <see cref="DokanCreateFileSystem"/> and after all devices are unmount.
    /// </summary>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    public static extern void DokanShutdown();

    /// <summary>
    /// Converts native Win32 error code to NTSTATUS
    /// </summary>
    /// <param name="win32Error"></param>
    /// <returns></returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    public static extern NtStatus DokanNtStatusFromWin32(int win32Error);

    /// <summary>
    /// Mount a new Dokan Volume.
    /// 
    /// It is mandatory to have called <see cref="DokanInit"/> previously to use this API.
    /// This function returns directly on device mount or on failure.
    /// <see cref="DokanWaitForFileSystemClosed"/> can be used to wait until the device is unmount.
    /// </summary>
    /// <param name="options">A <see cref="NativeStructWrapper&lt;DOKAN_OPTIONS&gt;"/> that describe the mount.</param>
    /// <param name="operations">Instance of <see cref="NativeStructWrapper&lt;DOKAN_OPERATIONS&gt;"/> that will be called for each request made by the kernel.</param>
    /// <param name="dokanInstance">Dokan mount instance context that can be used for related instance calls like <see cref="DokanIsFileSystemRunning"/>.</param>
    /// <returns><see cref="DokanStatus"/></returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    public static extern DokanStatus DokanCreateFileSystem(SafeBuffer options, SafeBuffer operations, out DokanHandle dokanInstance);

    /// <summary>
    /// Check if the FileSystem is still running or not.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/>.</param>
    /// <returns>Whether the FileSystem is still running or not.</returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    public static extern bool DokanIsFileSystemRunning(DokanHandle? dokanInstance);

    /// <summary>
    /// Wait until the FileSystem is unmount.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/>.</param>
    /// <param name="milliSeconds">The time-out interval, in milliseconds. If a nonzero value is specified, the function waits until the object is signaled or the interval elapses. If <paramref name="milliSeconds" /> is zero,
    /// the function does not enter a wait state if the object is not signaled; it always returns immediately. If <paramref name="milliSeconds" /> is INFINITE, the function will return only when the object is signaled.</param>
    /// <returns>See <a href="https://docs.microsoft.com/en-us/windows/win32/api/synchapi/nf-synchapi-waitforsingleobject">WaitForSingleObject</a> for a description of return values.</returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    public static extern uint DokanWaitForFileSystemClosed(DokanHandle? dokanInstance, uint milliSeconds);

    /// <summary>
    /// Register a callback for when the FileSystem is unmounted.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/>.</param>
    /// <param name="handle">Wait handle representing the registered wait. Needs to be freed by calling <see cref="DokanUnregisterWaitForFileSystemClosed"/>.</param>
    /// <param name="callback">Callback function to be called when file system is unmounted or timeout occurs.</param>
    /// <param name="context">Parameter to send to callback function.</param>
    /// <param name="milliSeconds">The time-out interval, in milliseconds. If a nonzero value is specified, the function waits until the object is signaled or the interval elapses. If <paramref name="milliSeconds" /> is zero,
    /// the function does not enter a wait state if the object is not signaled; it always returns immediately. If <paramref name="milliSeconds" /> is INFINITE, the function will return only when the object is signaled.</param>
    /// <returns>See <a href="https://docs.microsoft.com/en-us/windows/win32/api/synchapi/nf-synchapi-waitforsingleobject">WaitForSingleObject</a> for a description of return values.</returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    public static extern bool DokanRegisterWaitForFileSystemClosed(DokanHandle? dokanInstance, out nint handle, NativeWaitOrTimerCallback callback, nint context, uint milliSeconds);

    /// <summary>
    /// Unregister a callback for when the FileSystem is unmounted.
    /// </summary>
    /// <param name="handle">Handle returned in handle parameter in previous call to <see cref="DokanRegisterWaitForFileSystemClosed" /></param>.
    /// <param name="waitForCallbacks">Indicates whether to wait for callbacks to complete before returning. Normally true unless called from same thread as callback function.</param>
    /// <returns></returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    public static extern bool DokanUnregisterWaitForFileSystemClosed(nint handle, bool waitForCallbacks);

    /// <summary>
    /// Unmount and wait until all resources of the \c DokanInstance are released.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/>.</param>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    public static extern void DokanCloseHandle(nint dokanInstance);

    /// <summary>
    /// Unmount a dokan device from a driver letter.
    /// </summary>
    /// <param name="driveLetter">Dokan driver letter to unmount.</param>
    /// <returns><c>True</c> if device was unmount or <c>false</c> in case of failure or device not found.</returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern bool DokanUnmount(char driveLetter);

    /// <summary>
    /// Get the version of Dokan.
    /// The returned <see cref="uint"/> is the version number without the dots.
    /// </summary>
    /// <returns>The version of Dokan</returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    public static extern uint DokanVersion();

    /// <summary>
    /// Get the version of the Dokan driver.
    /// The returned <see cref="uint"/> is the version number without the dots.
    /// </summary>
    /// <returns>The version of Dokan driver.</returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    public static extern uint DokanDriverVersion();

    /// <summary>
    /// Unmount a dokan device from a mount point
    /// </summary>
    /// <param name="mountPoint">MountPoint Mount point to unmount ("<c>Z</c>", 
    /// "<c>Z:</c>", "<c>Z:\\</c>", "<c>Z:\MyMountPoint</c>").</param>
    /// <returns><c>True</c> if device was unmount or <c>false</c> in case of failure or device not found.</returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern bool DokanRemoveMountPoint([MarshalAs(UnmanagedType.LPWStr)] string mountPoint);

    /// <summary>
    /// Convert <see cref="DokanOperationProxy.ZwCreateFileProxy"/> parameters to <see cref="IDokanOperations.CreateFile"/> parameters.
    /// </summary>
    /// <param name="desiredAccess">DesiredAccess from <see cref="DokanOperationProxy.ZwCreateFileProxy"/>.</param>
    /// <param name="fileAttributes">FileAttributes from <see cref="DokanOperationProxy.ZwCreateFileProxy"/>.</param>
    /// <param name="createOptions">CreateOptions from <see cref="DokanOperationProxy.ZwCreateFileProxy"/>.</param>
    /// <param name="createDisposition">CreateDisposition from <see cref="DokanOperationProxy.ZwCreateFileProxy"/>.</param>
    /// <param name="outDesiredAccess">New <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa363858(v=vs.85).aspx">CreateFile (MSDN)</a> dwDesiredAccess.</param>
    /// <param name="outFileAttributesAndFlags">New <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa363858(v=vs.85).aspx">CreateFile (MSDN)</a> dwFlagsAndAttributes.</param>
    /// <param name="outCreationDisposition">New <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa363858(v=vs.85).aspx">CreateFile (MSDN)</a> dwCreationDisposition.</param>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa363858(v=vs.85).aspx">CreateFile function (MSDN)</a>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    public static extern void DokanMapKernelToUserCreateFileFlags(
        uint desiredAccess,
        uint fileAttributes,
        uint createOptions,
        uint createDisposition,
        out uint outDesiredAccess,
        out int outFileAttributesAndFlags,
        out int outCreationDisposition);

    /*
    [DllImport(DOKAN_DLL, CharSet = CharSet.Unicode)]
    public static extern bool DokanIsNameInExpression([MarshalAs(UnmanagedType.LPWStr)] string expression,
                                                      // matching pattern
                                                      [MarshalAs(UnmanagedType.LPWStr)] string name, // file name
                                                      [MarshalAs(UnmanagedType.Bool)] bool ignoreCase);*/

    /// <summary>
    /// Notify Dokan that a file or directory has been created.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/></param>
    /// <param name="filePath">Full path to the file or directory, including mount point.</param>
    /// <param name="isDirectory">Indicates if the path is a directory.</param>
    /// <returns>true if the notification succeeded.</returns>
    [DllImport(DOKAN_DLL, CharSet = CharSet.Unicode)]
    public static extern bool DokanNotifyCreate(DokanHandle dokanInstance,
                                                [MarshalAs(UnmanagedType.LPWStr)] string filePath,
                                                [MarshalAs(UnmanagedType.Bool)] bool isDirectory);

    /// <summary>
    /// Notify Dokan that a file or directory has been deleted.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/></param>
    /// <param name="filePath">Full path to the file or directory, including mount point.</param>
    /// <param name="isDirectory">Indicates if the path is a directory.</param>
    /// <returns>true if notification succeeded.</returns>
    [DllImport(DOKAN_DLL, CharSet = CharSet.Unicode)]
    public static extern bool DokanNotifyDelete(DokanHandle dokanInstance, [MarshalAs(UnmanagedType.LPWStr)] string filePath,
                                                [MarshalAs(UnmanagedType.Bool)] bool isDirectory);

    /// <summary>
    /// Notify Dokan that file or directory attributes have changed.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/></param>
    /// <param name="filePath">Full path to the file or directory, including mount point.</param>
    /// <returns>true if notification succeeded.</returns>
    [DllImport(DOKAN_DLL, CharSet = CharSet.Unicode)]
    public static extern bool DokanNotifyUpdate(DokanHandle dokanInstance, [MarshalAs(UnmanagedType.LPWStr)] string filePath);

    /// <summary>
    /// Notify Dokan that file or directory extended attributes have changed.
    /// </summary>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/></param>
    /// <param name="filePath">Full path to the file or directory, including mount point.</param>
    /// <returns>true if notification succeeded.</returns>
    [DllImport(DOKAN_DLL, CharSet = CharSet.Unicode)]
    public static extern bool DokanNotifyXAttrUpdate(DokanHandle dokanInstance, [MarshalAs(UnmanagedType.LPWStr)] string filePath);

    /// <summary>
    /// Notify Dokan that a file or directory has been renamed.
    /// </summary>
    /// <remarks>This method supports in-place rename for file/directory within the same parent.</remarks>
    /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanCreateFileSystem"/></param>
    /// <param name="OldPath">Old path to the file or directory, including mount point.</param>
    /// <param name="newPath">New path to the file or directory, including mount point.</param>
    /// <param name="isDirectory">Indicates if the path is a directory.</param>
    /// <param name="isInSameDirectory">Indicates if OldPath and NewPath have the same parent.</param>
    /// <returns>true if notification succeeded.</returns>
    [DllImport(DOKAN_DLL, CharSet = CharSet.Unicode)]
    public static extern bool DokanNotifyRename(DokanHandle dokanInstance, [MarshalAs(UnmanagedType.LPWStr)] string OldPath,
                                                [MarshalAs(UnmanagedType.LPWStr)] string newPath,
                                                [MarshalAs(UnmanagedType.Bool)] bool isDirectory,
                                                [MarshalAs(UnmanagedType.Bool)] bool isInSameDirectory);
#endif

    /// <summary>
    /// Extends the time out of the current IO operation in driver.
    /// </summary>
    /// <param name="timeout">Extended time in milliseconds requested.</param>
    /// <param name="rawFileInfo"><see cref="DokanFileInfo"/> of the operation to extend.</param>
    /// <returns>If the operation was successful.</returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    [SuppressMessage("Interoperability", "SYSLIB1054:Use 'LibraryImportAttribute' instead of 'DllImportAttribute' to generate P/Invoke marshalling code at compile time", Justification = "Types not supported")]
    public static extern bool DokanResetTimeout(uint timeout, in DokanFileInfo rawFileInfo);

    /// <summary>
    /// Get the handle to Access Token.
    /// This method needs be called in <see cref="IDokanOperations.CreateFile"/> callback.
    /// The caller must call <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/ms724211(v=vs.85).aspx">CloseHandle (MSDN)</a> for the returned handle.
    /// </summary>
    /// <param name="rawFileInfo">
    /// A <see cref="DokanFileInfo"/> of the operation to extend.
    /// </param>
    /// <returns>
    /// A handle to the account token for the user on whose behalf the code is running.
    /// </returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    [SuppressMessage("Interoperability", "SYSLIB1054:Use 'LibraryImportAttribute' instead of 'DllImportAttribute' to generate P/Invoke marshalling code at compile time", Justification = "Types not supported")]
    public static extern SafeAccessTokenHandle DokanOpenRequestorToken(in DokanFileInfo rawFileInfo);

    /// <summary>
    /// Mount a new Dokan Volume.
    /// This function block until the device is unmount.
    /// If the mount fail, it will directly return an error.
    /// </summary>
    /// <param name="options">A <see cref="DOKAN_OPTIONS"/> that describe the mount.</param>
    /// <param name="operations">Instance of <see cref="DOKAN_OPERATIONS"/> that will be called for each request made by the kernel.</param>
    /// <returns><see cref="DokanStatus"/></returns>
    [DllImport(DOKAN_DLL, ExactSpelling = true)]
    [SuppressMessage("Interoperability", "SYSLIB1054:Use 'LibraryImportAttribute' instead of 'DllImportAttribute' to generate P/Invoke marshalling code at compile time", Justification = "Types not supported")]
    public static extern DokanStatus DokanMain([In] DOKAN_OPTIONS options, [In] DOKAN_OPERATIONS operations);
}

```

### SECURITY_INFORMATION.cs

```using System;

namespace DokanNet.Native
{
    /// <summary>
    /// Identifies the object-related security information being set or queried.
    /// This security information includes:
    /// <list type="bullet">
    ///  <item>The owner of an object.</item>
    ///  <item>The primary group of an object.</item>
    ///  <item>The discretionary access control list(DACL) of an object.</item>
    ///  <item>The system access control list(SACL) of an object.</item>
    /// </list>
    /// </summary>
    /// <remarks>Structure taken from <a href="http://www.pinvoke.net/default.aspx/Enums/SECURITY_INFORMATION.html">pinvoke.net</a> </remarks>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa379573(v=vs.85).aspx">SECURITY_INFORMATION (MSDN)</a>
    [Flags]
    internal enum SECURITY_INFORMATION : uint
    {
        /// <summary>
        /// The owner identifier of the object is being referenced.
        /// </summary>
        OWNER_SECURITY_INFORMATION = 0x00000001,

        /// <summary>
        /// The primary group identifier of the object is being referenced.
        /// </summary>
        GROUP_SECURITY_INFORMATION = 0x00000002,

        /// <summary>
        /// The DACL of the object is being referenced.
        /// </summary>
        DACL_SECURITY_INFORMATION = 0x00000004,

        /// <summary>
        /// The SACL of the object is being referenced.
        /// </summary>
        SACL_SECURITY_INFORMATION = 0x00000008,

        /// <summary>
        /// The SACL inherits ACEs from the parent object.
        /// </summary>
        /// <remarks>Dokan may not be passing Label ?? 0x00000010</remarks>
        UNPROTECTED_SACL_SECURITY_INFORMATION = 0x10000000,

        /// <summary>
        /// The DACL inherits ACEs from the parent object.
        /// </summary>
        UNPROTECTED_DACL_SECURITY_INFORMATION = 0x20000000,

        /// <summary>
        /// The SACL cannot inherit ACEs.
        /// </summary>
        PROTECTED_SACL_SECURITY_INFORMATION = 0x40000000,

        /// <summary>
        /// The DACL cannot inherit access control entries (ACEs).
        /// </summary>
        PROTECTED_DACL_SECURITY_INFORMATION = 0x80000000
    }
}
```

### WIN32_FIND_DATA.cs

```using System;
using System.IO;
using System.Runtime.InteropServices;
using FILETIME = System.Runtime.InteropServices.ComTypes.FILETIME;

namespace DokanNet.Native;

/// <summary>
/// Contains information about the file that is found by the FindFirstFile, FindFirstFileEx, or FindNextFile function.
/// </summary>
/// <remarks>
/// If a file has a long file name, the complete name appears in the cFileName member, and the 8.3 format truncated version
/// of the name appears in the <see cref="cAlternateFileName"/>member. Otherwise,<see cref="cAlternateFileName"/> is empty. If the FindFirstFileEx function
/// was called with a value of FindExInfoBasic in the fInfoLevelId parameter, the <see cref="cAlternateFileName"/> member will always contain
/// a NULL string value. This remains true for all subsequent calls to the FindNextFile function. As an alternative method of
/// retrieving the 8.3 format version of a file name, you can use the GetShortPathName function. For more information about
/// file names, see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365247(v=vs.85).aspx">Naming Files, Paths, and Namespaces (MSDN)</a>.
/// 
/// Not all file systems can record creation and last access times, and not all file systems record them in the same manner.
/// For example, on the FAT file system, create time has a resolution of 10 milliseconds, write time has a resolution of
/// 2 seconds, and access time has a resolution of 1 day. The NTFS file system delays updates to the last access time for
/// a file by up to 1 hour after the last access.For more information, see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/ms724290(v=vs.85).aspx">File Times (MSDN)</a>.
/// </remarks>
/// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365740%28v=vs.85%29.aspx?f=255&amp;MSPPError=-2147217396">WIN32_FIND_DATA structure (MSDN)</a>
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
internal struct WIN32_FIND_DATA
{
    /// <summary>
    /// The file attributes of a file.
    /// 
    /// For possible values and their descriptions, see <see cref="FileAttributes"/>.
    /// The <see cref="FileAttributes.SparseFile"/> attribute on the file is set if any of 
    /// the streams of the file have ever been sparse.
    /// </summary>
    public FileAttributes dwFileAttributes;

    /// <summary>
    /// A <see cref="FILETIME"/> structure that specifies when a file or directory was created.
    /// If the underlying file system does not support creation time, this member is zero.
    /// </summary>
    public FILETIME ftCreationTime;

    /// <summary>
    /// A <see cref="FILETIME"/> structure.
    /// 
    /// For a file, the structure specifies when the file was last read from, written to, or for executable files, run.
    /// 
    /// For a directory, the structure specifies when the directory is created.
    /// If the underlying file system does not support last access time, this member is zero.
    /// 
    /// On the FAT file system, the specified date for both files and directories is correct, 
    /// but the time of day is always set to midnight.
    /// </summary>
    public FILETIME ftLastAccessTime;

    /// <summary>
    /// A <see cref="FILETIME"/> structure.
    /// 
    /// For a file, the structure specifies when the file was last written to, 
    /// truncated, or overwritten, for example, when WriteFile or SetEndOfFile 
    /// are used. The date and time are not updated when file attributes or 
    /// security descriptors are changed.
    /// 
    /// For a directory, the structure specifies when the directory is created.
    /// If the underlying file system does not support last write time, 
    /// this member is zero.
    /// </summary>
    public FILETIME ftLastWriteTime;

    /// <summary>
    /// The high-order DWORD value of the file size, in bytes.
    /// 
    /// This value is zero unless the file size is greater than MAXDWORD.
    /// 
    /// The size of the file is equal to (nFileSizeHigh* (MAXDWORD+1)) + nFileSizeLow.
    /// </summary>
    public uint nFileSizeHigh;

    /// <summary>
    /// The low-order DWORD value of the file size, in bytes.
    /// </summary>
    public uint nFileSizeLow;

    /// <summary>
    /// If the <see cref="dwFileAttributes"/> member includes the <see cref="FileAttributes.ReparsePoint"/> attribute, 
    /// this member specifies the reparse point tag. 
    /// Otherwise, this value is undefined and should not be used.
    /// </summary>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365511(v=vs.85).aspx">Reparse Point Tags (MSDN)</a>
    private readonly uint dwReserved0;

    /// <summary>
    /// Reserved for future use.
    /// </summary>
    private readonly uint dwReserved1;

    /// <summary>
    /// The name of the file.
    /// </summary>
    public unsafe fixed char cFileName[260];

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP
    public unsafe ReadOnlySpan<char> FileName
    {
        set => value.CopyTo(MemoryMarshal.CreateSpan(ref cFileName[0], 260));
    }
#else
    public unsafe ReadOnlySpan<char> FileName
    {
        set
        {
            fixed (char* ptr = cFileName)
            {
                value.CopyTo(new(ptr, 260));
            }
        }
    }
#endif

    /// <summary>
    /// An alternative name for the file.
    /// This name is in the classic 8.3 file name format.
    /// </summary>
    public unsafe fixed char cAlternateFileName[14];

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP
    public unsafe ReadOnlySpan<char> AlternateFileName
    {
        set => value.CopyTo(MemoryMarshal.CreateSpan(ref cAlternateFileName[0], 14));
    }
#else
    public unsafe ReadOnlySpan<char> AlternateFileName
    {
        set
        {
            fixed (char* ptr = cAlternateFileName)
            {
                value.CopyTo(new(ptr, 14));
            }
        }
    }
#endif

    /// <summary>
    /// Obsolete. Do not use.
    /// </summary>
    public uint dwFileType;

    /// <summary>
    /// Obsolete. Do not use.
    /// </summary>
    public uint dwCreatorType;

    /// <summary>
    /// Obsolete. Do not use.
    /// </summary>
    public ushort wFinderFlags;
}

```

### WIN32_FIND_STREAM_DATA.cs

```using System;
using System.Runtime.InteropServices;

namespace DokanNet.Native;

/// <summary>
/// Contains information about the stream found by the <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa364424(v=vs.85).aspx">FindFirstStreamW (MSDN)</a> 
/// or <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa364430(v=vs.85).aspx">FindNextStreamW (MSDN)</a> function.
/// </summary>
/// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365741(v=vs.85).aspx">WIN32_FIND_STREAM_DATA structure (MSDN)</a>
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
internal struct WIN32_FIND_STREAM_DATA
{
    /// <summary>
    /// A <c>long</c> value that specifies the size of the stream, in bytes.
    /// </summary>
    public long StreamSize { get; set; }

    /// <summary>
    /// The name of the stream. The string name format is "<c>:streamname:$streamtype</c>".
    /// </summary>
    public unsafe fixed char cStreamName[260];

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP
    public unsafe ReadOnlySpan<char> StreamName
    {
        set => value.CopyTo(MemoryMarshal.CreateSpan(ref cStreamName[0], 260));
    }
#else
    public unsafe ReadOnlySpan<char> StreamName
    {
        set
        {
            fixed (char* ptr = cStreamName)
            {
                value.CopyTo(new(ptr, 260));
            }
        }
    }
#endif
}

```

### BufferPool.cs

```using System;
using System.Collections.Concurrent;
using System.Threading;
using DokanNet.Logging;

namespace DokanNet
{
    /// <summary>
    /// Simple buffer pool for buffers used by <see cref="IDokanOperations.ReadFile"/> and
    /// <see cref="IDokanOperations.WriteFile"/> to avoid excessive Gen2 garbage collections due to large buffer
    /// allocation on the large object heap (LOH).
    /// 
    /// This pool is a bit different than say System.Buffers.ArrayPool(T) in that <see cref="RentBuffer" /> only returns
    /// exact size buffers. This is because the Read/WriteFile APIs only take a byte[] array as a parameter, not
    /// buffer and length. As such, it would be back compat breaking to return buffers that are bigger than the
    /// data length. To limit the amount of memory consumption, we only buffer sizes that are powers of 2 because
    /// common buffer sizes are typically that. There isn't anything preventing pooling buffers of any size if
    /// we find that there's another common buffer size in use. Only pool buffers 1MB or smaller and only
    /// up to 10 buffers of each size for further memory capping.
    /// </summary>
    internal class BufferPool
    {
        private readonly uint _maxBuffersPerPool; // Max buffers to cache per buffer size.

        // The pools for each buffer size. Index is log2(size).
        private readonly ConcurrentBag<byte[]>[] _pools;

        // Number of bytes served out over the pool's lifetime.
        private long _servedBytes;

        /// <summary>
        /// Constructs a new buffer pool.
        /// </summary>
        /// <param name="maxBufferSize">The max size (bytes) buffer that will be cached. </param>
        /// <param name="maxBuffersPerBufferSize">Maximum number of buffers cached per buffer size.</param>
        public BufferPool(int maxBufferSize = 1024 * 1024, uint maxBuffersPerBufferSize = 10)
        {
            _maxBuffersPerPool = maxBuffersPerBufferSize;
            int log2 = GetPoolIndex(maxBufferSize);
            if (log2 == -1)
            {
                throw new ArgumentOutOfRangeException(nameof(maxBufferSize), maxBufferSize, "Must be a power of 2.");
            }

            // Create empty pools for each size.
            _pools = new ConcurrentBag<byte[]>[log2 + 1];
            for (int i = 0; i < _pools.Length; i++)
            {
                _pools[i] = [];
            }
        }

        /// <summary>
        /// Default, process-wide buffer pool instance.
        /// </summary>
        public static BufferPool Default { get; } = new BufferPool();

        /// <summary>
        /// Clears the buffer pool by releasing all buffers.
        /// </summary>
        public void Clear()
        {
            _servedBytes = 0;
            for (int i = 0; i < _pools.Length; i++)
            {
                _pools[i] = []; // There's no clear method on ConcurrentBag...
            }
        }

        /// <summary>
        /// Number of bytes served over the pool's lifetime.
        /// </summary>
        public long ServedBytes => Interlocked.Read(ref _servedBytes);

        /// <summary>
        /// Gets a buffer from the buffer pool of the exact specified size.
        /// If the size if not a power of 2, a buffer is still returned, but it is not poolable.
        /// </summary>
        /// <param name="bufferSize">The size of buffer requested.</param>
        /// <param name="logger">Logger for debug spew about what the buffer pool did.</param>
        /// <returns>The byte[] buffer.</returns>
        public byte[] RentBuffer(int bufferSize, ILogger logger)
        {
            if (bufferSize == 0)
            {
                return [];
            }

            Interlocked.Add(ref _servedBytes, bufferSize);

            // If the number is not a power of 2, we have nothing to offer.
            int poolIndex = GetPoolIndex(bufferSize);
            if (poolIndex == -1 || poolIndex >= _pools.Length)
            {
                if (logger.DebugEnabled)
                {
                    logger.Debug($"Buffer size {bufferSize} not power of 2 or too large, returning unpooled buffer.");
                }

                return new byte[bufferSize];
            }

            // Try getting a buffer from the pool. If it's empty, make a new buffer.
            ConcurrentBag<byte[]> pool = _pools[poolIndex];
            if (pool.TryTake(out var buffer))
            {
                if (logger.DebugEnabled)
                {
                    logger.Debug($"Using pooled buffer from pool {poolIndex}.");
                }
            }
            else
            {
                if (logger.DebugEnabled)
                {
                    logger.Debug($"Pool {poolIndex} empty, creating new buffer.");
                }

                buffer = new byte[bufferSize];
            }

            return buffer;
        }

        /// <summary>
        /// Returns a previously rented buffer to the buffer pool.
        /// If the buffer size is not an exact power of 2, the buffer is ignored.
        /// </summary>
        /// <param name="buffer">The buffer to return.</param>
        /// <param name="logger">Logger for debug spew about what the buffer pool did.</param>
        public void ReturnBuffer(byte[] buffer, ILogger logger)
        {
            if (buffer.Length == 0)
            {
                return; // Do nothing - _emptyArray caches this statically.
            }

            // If the buffer is a power of 2 and below max pooled size, return it to the appropriate pool.
            int poolIndex = GetPoolIndex(buffer.Length);
            if (poolIndex >= 0 && poolIndex < _pools.Length)
            {
                // Check if the pool is full. This is racy if multiple threads return buffers concurrently,
                // but it's close enough - we'd just get a couple extra buffers in the pool at worst.
                ConcurrentBag<byte[]> pool = _pools[poolIndex];
                if (pool.Count < _maxBuffersPerPool)
                {
                    Array.Clear(buffer, 0, buffer.Length);
                    pool.Add(buffer);
                    if (logger.DebugEnabled)
                    {
                        logger.Debug($"Returned buffer to pool {poolIndex}.");
                    }
                }
                else
                {
                    if (logger.DebugEnabled)
                    {
                        logger.Debug($"Pool {poolIndex} is full, discarding buffer.");
                    }
                }
            }
            else
            {
                if (logger.DebugEnabled)
                {
                    logger.Debug($"{poolIndex} (size {buffer.Length}) outside pool range, discarding buffer.");
                }
            }
        }

        /// <summary>
        /// Computes the pool index given a buffer size. The pool index is log2(size),
        /// if size is a power of 2. If size is not a power of 2, -1 is returned (invalid pool index).
        /// </summary>
        /// <param name="bufferSize">Buffer size in bytes.</param>
        /// <returns>The pool index, log2(number), or -1 if bufferSize is not a power of 2.</returns>
        private static int GetPoolIndex(int bufferSize)
        {
            // Fast calculate two-log for bufferSize
            var log2 = 0;

            for (var i = bufferSize; i > 1; i >>= 1)
            {
                log2++;
            }

            // If not equal, the number is not a power of 2.
            if (1 << log2 != bufferSize)
            {
                return -1;
            }

            return log2;
        }
    }
}

```

### ByHandleFileInformation.cs

```using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace DokanNet;

/// <summary>
/// Used to provide file information to %Dokan during operations by
///  - <see cref="IDokanOperations2.GetFileInformation"/>
///  - <see cref="IDokanOperations2.FindFiles"/>
///  - <see cref="IDokanOperations2.FindStreams"/> 
///  - <see cref="IDokanOperations2.FindFilesWithPattern"/>.
/// </summary>
[StructLayout(LayoutKind.Auto)]
[DebuggerDisplay("{Length}, {CreationTime}, {LastWriteTime}, {LastAccessTime}, {Attributes}")]
public struct ByHandleFileInformation
{
    /// <summary>
    /// Initializes with <see cref="NumberOfLinks"/> set to 1.
    /// </summary>
    public ByHandleFileInformation()
    {
        this = default;
        NumberOfLinks = 1;
    }

    /// <summary>
    /// Gets or sets the <c><see cref="FileAttributes"/></c> for the file or directory.
    /// </summary>
    public FileAttributes Attributes { get; set; }

    /// <summary>
    /// Gets or sets the creation time of the file or directory.
    /// If equal to <c>null</c>, the value will not be set or the file has no creation time.
    /// </summary>
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// Gets or sets the last access time of the file or directory.
    /// If equal to <c>null</c>, the value will not be set or the file has no last access time.
    /// </summary>
    public DateTime? LastAccessTime { get; set; }

    /// <summary>
    /// Gets or sets the last write time of the file or directory.
    /// If equal to <c>null</c>, the value will not be set or the file has no last write time.
    /// </summary>
    public DateTime? LastWriteTime { get; set; }

    /// <summary>
    /// Gets or sets the length of the file.
    /// </summary>
    public long Length { get; set; }

    /// <summary>
    /// Number of links to the same file.
    /// </summary>
    public int NumberOfLinks { get; set; }

    /// <summary>
    /// Index number of file in the file system.
    /// </summary>
    public long FileIndex { get; set; }
}

```

### Dokan.cs

```using System;
using System.Runtime.Versioning;
using DokanNet.Logging;
using DokanNet.Native;

namespace DokanNet
{
    /// <summary>
    /// Helper methods to %Dokan.
    /// </summary>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("windows")]
#endif
    public class Dokan : IDisposable
    {
        private readonly ILogger _logger;
        private bool _disposed;

        /// <summary>
        /// Initialize all required Dokan internal resources.
        /// 
        /// This needs to be called only once before trying to use <see cref="DokanInstance.DokanInstance"/> for the first time.
        /// Otherwise both will fail and raise an exception.
        /// </summary>
        /// <param name="logger"><see cref="ILogger"/> that will log all DokanNet debug informations.</param>
        public Dokan(ILogger logger)
        {
            _logger = logger;
            NativeMethods.DokanInit();
        }

        /// <summary>
        /// Unmount a dokan device from a driver letter.
        /// </summary>
        /// <param name="driveLetter">Driver letter to unmount.</param>
        /// <returns><c>true</c> if device was unmount 
        /// -or- <c>false</c> in case of failure or device not found.</returns>
        public bool Unmount(char driveLetter)
        {
            return NativeMethods.DokanUnmount(driveLetter);
        }

        /// <summary>
        /// Unmount a dokan device from a mount point.
        /// </summary>
        /// <param name="mountPoint">Mount point to unmount (<c>Z</c>, <c>Z:</c>, <c>Z:\\</c>, <c>Z:\\MyMountPoint</c>).</param>
        /// <returns><c>true</c> if device was unmount 
        /// -or- <c>false</c> in case of failure or device not found.</returns>
        public bool RemoveMountPoint(string mountPoint)
        {
            return NativeMethods.DokanRemoveMountPoint(mountPoint);
        }

        /// <summary>
        /// Retrieve native dokan dll version supported.
        /// </summary>
        /// <returns>Return native dokan dll version supported.</returns>
        public int Version => (int)NativeMethods.DokanVersion();

        /// <summary>
        /// Retrieve native dokan driver version supported.
        /// </summary>
        /// <returns>Return native dokan driver version supported.</returns>
        public int DriverVersion => (int)NativeMethods.DokanDriverVersion();

        /// <summary>
        /// Dokan User FS file-change notifications
        /// </summary>
        /// <remarks> If <see cref="DokanOptions.EnableNotificationAPI"/> is passed to <see cref="DOKAN_OPTIONS.Options"/>,
        /// the application implementing the user file system can notify
        /// the Dokan kernel driver of external file- and directory-changes.
        /// 
        /// For example, the mirror application can notify the driver about
        /// changes made in the mirrored directory so that those changes will
        /// be automatically reflected in the implemented mirror file system.
        /// 
        /// This requires the filePath passed to the respective methods
        /// to include the absolute path of the changed file including the drive-letter
        /// and the path to the mount point, e.g. "C:\Dokan\ChangedFile.txt".
        /// 
        /// These functions SHOULD NOT be called from within the implemented
        /// file system and thus be independent of any Dokan file system operation.
        ///</remarks>
        public class Notify
        {
            /// <summary>
            /// Notify Dokan that a file or directory has been created.
            /// </summary>
            /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanInstance.DokanInstance"/></param>
            /// <param name="filePath">Absolute path to the file or directory, including the mount-point of the file system.</param>
            /// <param name="isDirectory">Indicates if the path is a directory.</param>
            /// <returns>true if the notification succeeded.</returns>
            public static bool Create(DokanInstance dokanInstance, string filePath, bool isDirectory)
            {
                return dokanInstance.NotifyCreate(filePath, isDirectory);
            }

            /// <summary>
            /// Notify Dokan that a file or directory has been deleted.
            /// </summary>
            /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanInstance.DokanInstance"/></param>
            /// <param name="filePath">Absolute path to the file or directory, including the mount-point of the file system.</param>
            /// <param name="isDirectory">Indicates if the path is a directory.</param>
            /// <returns>true if notification succeeded.</returns>
            /// <remarks><see cref="DokanOptions.EnableNotificationAPI"/> must be set in the mount options for this to succeed.</remarks>
            public static bool Delete(DokanInstance dokanInstance, string filePath, bool isDirectory)
            {
                return dokanInstance.NotifyDelete(filePath, isDirectory);
            }

            /// <summary>
            /// Notify Dokan that file or directory attributes have changed.
            /// </summary>
            /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanInstance.DokanInstance"/></param>
            /// <param name="filePath">Absolute path to the file or directory, including the mount-point of the file system.</param>
            /// <returns>true if notification succeeded.</returns>
            /// <remarks><see cref="DokanOptions.EnableNotificationAPI"/> must be set in the mount options for this to succeed.</remarks>
            public static bool Update(DokanInstance dokanInstance, string filePath)
            {
                return dokanInstance.NotifyUpdate(filePath);
            }

            /// <summary>
            /// Notify Dokan that file or directory extended attributes have changed.
            /// </summary>
            /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanInstance.DokanInstance"/></param>
            /// <param name="filePath">Absolute path to the file or directory, including the mount-point of the file system.</param>
            /// <returns>true if notification succeeded.</returns>
            /// <remarks><see cref="DokanOptions.EnableNotificationAPI"/> must be set in the mount options for this to succeed.</remarks>
            public static bool XAttrUpdate(DokanInstance dokanInstance, string filePath)
            {
                return dokanInstance.NotifyXAttrUpdate(filePath);
            }

            /// <summary>
            /// Notify Dokan that a file or directory has been renamed.
            /// This method supports in-place rename for file/directory within the same parent.
            /// </summary>
            /// <param name="dokanInstance">The dokan mount context created by <see cref="DokanInstance.DokanInstance"/></param>
            /// <param name="oldPath">Old, absolute path to the file or directory, including the mount-point of the file system.</param>
            /// <param name="newPath">New, absolute path to the file or directory, including the mount-point of the file system.</param>
            /// <param name="isDirectory">Indicates if the path is a directory.</param>
            /// <param name="isInSameDirectory">Indicates if the file or directory have the same parent directory.</param>
            /// <returns>true if notification succeeded.</returns>
            /// <remarks><see cref="DokanOptions.EnableNotificationAPI"/> must be set in the mount options for this to succeed.</remarks>
            public static bool Rename(DokanInstance dokanInstance, string oldPath, string newPath, bool isDirectory, bool isInSameDirectory)
            {
                return dokanInstance.NotifyRename(oldPath,
                    newPath,
                    isDirectory,
                    isInSameDirectory);
            }
        }

        /// <summary>
        /// Dispose the native Dokan Library resources
        /// </summary>
        /// <param name="disposing">Whether this was called from <see cref="Dispose()"/></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects)
                }
                //  free unmanaged resources
                NativeMethods.DokanShutdown();
                // set fields to null
                _disposed = true;
            }
        }

        /// <summary>
        /// Dispose the native Dokan Library resources
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        /// </summary>
        ~Dokan()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }
    }
}

```

### DokanException.cs

```using System;
using DokanNet.Properties;

namespace DokanNet
{
    /// <summary>
    /// The dokan exception.
    /// </summary>
    [Serializable]
    public class DokanException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DokanException"/> class with a <see cref="Exception.HResult"/>.
        /// </summary>
        /// <param name="status">
        /// The error status also written to <see cref="Exception.HResult"/>.
        /// </param>
        internal DokanException(DokanStatus status)
            : this(status, GetStatusErrorMessage(status)) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DokanException"/> class with a <see cref="Exception.HResult"/>.
        /// </summary>
        /// <param name="status">
        /// The error status also written to <see cref="Exception.HResult"/>.
        /// </param>
        /// <param name="message">
        /// The error message.
        /// </param>
        internal DokanException(DokanStatus status, string message)
            : base(message)
        {
            ErrorStatus = status;
            HResult = (int)status;
        }

        private static string GetStatusErrorMessage(DokanStatus status)
        {
            switch (status)
            {
                case DokanStatus.Error:
                    return Resources.ErrorDokan;
                case DokanStatus.DriveLetterError:
                    return Resources.ErrorBadDriveLetter;
                case DokanStatus.DriverInstallError:
                    return Resources.ErrorDriverInstall;
                case DokanStatus.MountError:
                    return Resources.ErrorAssignDriveLetter;
                case DokanStatus.StartError:
                    return Resources.ErrorStart;
                case DokanStatus.MountPointError:
                    return Resources.ErrorMountPointInvalid;
                case DokanStatus.VersionError:
                    return Resources.ErrorVersion;
                default:
                    return Resources.ErrorUnknown;
            }
        }

        /// <summary>
        /// Dokan error status <see cref="DokanStatus"/>.
        /// </summary>
        public DokanStatus ErrorStatus { get; private set; }
    }
}
```

### DokanFileInfo.cs

```using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Principal;
using DokanNet.Native;
using Microsoft.Win32.SafeHandles;
using static DokanNet.FormatProviders;

namespace DokanNet;

/// <summary>
/// %Dokan file information on the current operation.
/// </summary>
/// <remarks>
/// This class cannot be instantiated in C#, it is created by the kernel %Dokan driver.
/// This is the same structure as <c>_DOKAN_FILE_INFO</c> (dokan.h) in the C version of Dokan.
/// </remarks>
#if NET5_0_OR_GREATER
[SupportedOSPlatform("windows")]
#endif
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct DokanFileInfo
{
    private long context;

    /// <summary>
    /// Used internally, never modify.
    /// </summary>
    private readonly ulong dokanContext;

    /// <summary>
    /// A pointer to the <see cref="DOKAN_OPTIONS"/> which was passed to <see cref="Native.NativeMethods.DokanMain(DOKAN_OPTIONS, DOKAN_OPERATIONS)"/>.
    /// </summary>
    private readonly nint dokanOptions;

    /// <summary>
    /// Reserved. Used internally by Dokan library. Never modify.
    /// If the processing for the event requires extra data to be associated with it
    /// then a pointer to that data can be placed here
    /// </summary>
    private readonly nint processingContext;

    /// <summary>
    /// Process id for the thread that originally requested a given I/O
    /// operation.
    /// </summary>
    public readonly int ProcessId { get; }

    private byte isDirectory;
    private byte deletePending;
    private readonly byte pagingIo;
    private readonly byte synchronousIo;
    private readonly byte noCache;
    private readonly byte writeToEndOfFile;

    /// <summary>
    /// Gets or sets a value indicating whether it requesting a directory
    /// file. Must be set in <see cref="IDokanOperations2.CreateFile"/> if
    /// the file appear to be a folder.
    /// </summary>
    public bool IsDirectory { readonly get => isDirectory != 0; set => isDirectory = value ? (byte)1 : (byte)0; }

    /// <summary>
    /// Gets or sets a value indicating whether the file has to be deleted
    /// during the <see cref="IDokanOperations2.Cleanup"/> event.
    /// </summary>
    public bool DeletePending { readonly get => deletePending != 0; set => deletePending = value ? (byte)1 : (byte)0; }

    /// <summary>
    /// Read or write is paging IO.
    /// </summary>
    public readonly bool PagingIo => pagingIo != 0;

    /// <summary>
    /// Read or write is synchronous IO.
    /// </summary>
    public readonly bool SynchronousIo => synchronousIo != 0;

    /// <summary>
    /// Read or write directly from data source without cache.
    /// </summary>
    public readonly bool NoCache => noCache != 0;
    
    /// <summary>
    /// If <c>true</c>, write to the current end of file instead 
    /// of using the <c>Offset</c> parameter.
    /// </summary>
    public readonly bool WriteToEndOfFile => writeToEndOfFile != 0;
    
    /// <summary>
    /// Gets or sets context that can be used to carry information between operation.
    /// The Context can carry whatever type like <c><see cref="System.IO.FileStream"/></c>, <c>struct</c>, <c>int</c>,
    /// or internal reference that will help the implementation understand the request context of the event.
    /// </summary>
    public object? Context
    {
        readonly get
        {
            if (context != 0)
            {
                return ((GCHandle)(nint)context).Target;
            }

            return null;
        }

        set
        {
            if (context != 0)
            {
                ((GCHandle)(nint)context).Free();
                context = 0;
            }

            if (value is not null)
            {
                context = (nint)GCHandle.Alloc(value);
            }
        }
    }

    /// <summary>
    /// This method needs to be called in <see cref="IDokanOperations2.CreateFile"/>.
    /// </summary>
    /// <returns>An <c><see cref="WindowsIdentity"/></c> with the access token.</returns>
    public readonly WindowsIdentity GetRequestor()
    {
        using var sfh = GetRequestorToken();

        return new(sfh.DangerousGetHandle());
    }

    /// <summary>
    /// This method needs to be called in <see cref="IDokanOperations2.CreateFile"/>.
    /// </summary>
    /// <returns>A <c><see cref="SafeAccessTokenHandle"/></c> with the access token.</returns>
    public readonly SafeAccessTokenHandle GetRequestorToken() => NativeMethods.DokanOpenRequestorToken(this);

    /// <summary>
    /// Extends the time out of the current IO operation in driver.
    /// </summary>
    /// <param name="milliseconds">Number of milliseconds to extend with.</param>
    /// <returns>If the operation was successful.</returns>
    public readonly bool TryResetTimeout(int milliseconds) => NativeMethods.DokanResetTimeout((uint)milliseconds, this);

    /// <summary>Returns a string that represents the current object.</summary>
    /// <returns>A string that represents the current object.</returns>
    public override readonly string ToString() => DokanFormat(
        $"{{{nameof(Context)}=0x{context:X}:'{Context}', {nameof(DeletePending)}={DeletePending}, {nameof(IsDirectory)}={IsDirectory}, {nameof(NoCache)}={NoCache}, {nameof(PagingIo)}={PagingIo}, {nameof(ProcessId)}={ProcessId}, {nameof(SynchronousIo)}={SynchronousIo}, {nameof(WriteToEndOfFile)}={WriteToEndOfFile}}}")!;
}

```

### DokanHandle.cs

```using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using DokanNet.Native;
using Microsoft.Win32.SafeHandles;

namespace DokanNet
{
    /// <summary>
    /// This class wraps a native DOKAN_HANDLE.
    /// 
    /// Since this class derives form SafeHandle, it is automatically marshalled as
    /// the native handle it represents to and from native code in for example P/Invoke
    /// calls. It also uses reference counting and guaranteed to stay alive during such calls.
    /// <see cref="SafeHandle"/>
    /// </summary>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("windows")]
#endif
    internal class DokanHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        /// <summary>
        /// Initializes a new empty instance, specifying whether the handle is to be reliably released.
        /// Used internally by native marshaller and not intended to be used directly from user code.
        /// </summary>
        /// <param name="ownsHandle">true to reliably release the handle during the finalization phase; false to prevent
        /// reliable release (not recommended).</param>
        public DokanHandle(bool ownsHandle) : base(ownsHandle)
        {
        }

        /// <summary>
        /// Initializes an empty instance. Used internally by native marshaller and
        /// not intended to be used directly from user code.
        /// </summary>
        public DokanHandle() : base(ownsHandle: true)
        {
        }

        /// <summary>
        /// Releases the native DOKAN_HANDLE wrapped by this instance.
        /// </summary>
        /// <returns>Always returns true</returns>
        protected override bool ReleaseHandle()
        {
            NativeMethods.DokanCloseHandle(handle);
            return true;
        }
    }
}

```

### DokanHelper.cs

```using DokanNet.Native;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Versioning;
using System.Threading;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable IDE0057 // Use range operator

namespace DokanNet;

/// <summary>
/// %Dokan functions helpers for user <see cref="IDokanOperations2"/> implementation.
/// </summary>
public static class DokanHelper
{
    /// <summary>
    /// Matches zero or more characters until encountering and matching the final . in the name.
    /// </summary>
    private const char DOS_STAR = '<';

    /// <summary>
    /// Matches any single character or, upon encountering a period or end
    /// of name string, advances the expression to the end of the set of
    /// contiguous DOS_QMs.
    /// </summary>
    private const char DOS_QM = '>';

    /// <summary>
    /// Matches either a period or zero characters beyond the name string.
    /// </summary>
    private const char DOS_DOT = '"';

    /// <summary>
    /// Matches zero or more characters.
    /// </summary>
    private const char ASTERISK = '*';

    /// <summary>
    /// Matches a single character.
    /// </summary>
    private const char QUESTION_MARK = '?';

    private readonly static char[] CharsThatMatchEmptyStringsAtEnd = [DOS_DOT, DOS_STAR, ASTERISK];

    /// <summary>
    /// Check whether <paramref name="name">Name</paramref> matches <paramref name="expression">Expression</paramref>.
    /// </summary>
    /// <remarks>
    /// This method is mainly used in <see cref="IDokanOperations.FindFilesWithPattern"/> to filter a list of possible files.
    /// For example "F0_&lt;&quot;*" match "f0_001.txt"
    /// \see <a href="http://msdn.microsoft.com/en-us/library/ff546850(v=VS.85).aspx">See FsRtlIsNameInExpression routine (MSDN)</a>
    /// </remarks>
    /// <param name="expression">The matching pattern. Can contain: ?, *, &lt;, &quot;, &gt;.</param>
    /// <param name="name">The string that will be tested.</param>
    /// <param name="ignoreCase">When set to true a case insensitive match will be performed.</param>
    /// <returns>Returns true if Expression match Name, false otherwise.</returns>
    public static bool DokanIsNameInExpression(string expression, string name, bool ignoreCase)
        => DokanIsNameInExpression(expression.AsSpan(), name.AsSpan(), ignoreCase);

    /// <summary>
    /// Check whether <paramref name="name">Name</paramref> matches <paramref name="expression">Expression</paramref>.
    /// </summary>
    /// <remarks>
    /// This method is mainly used in <see cref="IDokanOperations2.FindFilesWithPattern"/> to filter a list of possible files.
    /// For example "F0_&lt;&quot;*" match "f0_001.txt"
    /// \see <a href="http://msdn.microsoft.com/en-us/library/ff546850(v=VS.85).aspx">See FsRtlIsNameInExpression routine (MSDN)</a>
    /// </remarks>
    /// <param name="expression">The matching pattern. Can contain: ?, *, &lt;, &quot;, &gt;.</param>
    /// <param name="name">The string that will be tested.</param>
    /// <param name="ignoreCase">When set to true a case insensitive match will be performed.</param>
    /// <returns>Returns true if Expression match Name, false otherwise.</returns>
    public static bool DokanIsNameInExpression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase)
    {
        var ei = 0;
        var ni = 0;

        while (ei < expression.Length && ni < name.Length)
        {
            switch (expression[ei])
            {
                case ASTERISK:
                    ei++;
                    if (ei > expression.Length)
                    {
                        return true;
                    }

                    while (ni < name.Length)
                    {
                        if (DokanIsNameInExpression(expression.Slice(ei), name.Slice(ni), ignoreCase))
                        {
                            return true;
                        }

                        ni++;
                    }

                    break;
                case DOS_STAR:
                    var lastDotIndex = name.LastIndexOf('.');
                    ei++;

                    var endReached = false;
                    while (!endReached)
                    {
                        endReached = ni >= name.Length || lastDotIndex > -1 && ni > lastDotIndex;

                        if (!endReached)
                        {
                            if (DokanIsNameInExpression(expression.Slice(ei), name.Slice(ni), ignoreCase))
                            {
                                return true;
                            }

                            ni++;
                        }
                    }

                    break;
                case DOS_QM:
                    ei++;
                    if (name[ni] != '.')
                    {
                        ni++;
                    }
                    else
                    {
                        var p = ni + 1;
                        while (p < name.Length)
                        {
                            if (name[p] == '.')
                            {
                                break;
                            }

                            p++;
                        }

                        if (p < name.Length && name[p] == '.')
                        {
                            ni++;
                        }
                    }

                    break;
                case DOS_DOT:
                    if (ei < expression.Length)
                    {
                        if (name[ni] != '.')
                        {
                            return false;
                        }
                        else
                        {
                            ni++;
                        }
                    }
                    else
                    {
                        if (name[ni] == '.')
                        {
                            ni++;
                        }
                    }

                    ei++;
                    break;
                case QUESTION_MARK:
                    ei++;
                    ni++;
                    break;
                default:
                    if (ignoreCase && char.ToUpperInvariant(expression[ei]) == char.ToUpperInvariant(name[ni]))
                    {
                        ei++;
                        ni++;
                    }
                    else if (!ignoreCase && expression[ei] == name[ni])
                    {
                        ei++;
                        ni++;
                    }
                    else
                    {
                        return false;
                    }

                    break;
            }
        }

        var nextExpressionChars = expression.Slice(ei);

        var areNextExpressionCharsAllNullMatchers = false;

        if (!expression.IsEmpty &&
            !nextExpressionChars.IsEmpty)
        {
            areNextExpressionCharsAllNullMatchers = true;

            foreach (var chr in nextExpressionChars)
            {
                if (Array.IndexOf(CharsThatMatchEmptyStringsAtEnd, chr) < 0)
                {
                    areNextExpressionCharsAllNullMatchers = false;
                    break;
                }
            }
        }

        var isNameCurrentCharTheLast = ni == name.Length;

        if (ei == expression.Length && isNameCurrentCharTheLast || isNameCurrentCharTheLast && areNextExpressionCharsAllNullMatchers)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Converts an <see cref="Exception"/> to an <see cref="NtStatus"/> value for use with native code.
    /// </summary>
    /// <param name="ex"><see cref="Exception"/> object to convert.</param>
    /// <returns><see cref="NtStatus"/> value corresponding to <paramref name="ex"/>.</returns>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("windows")]
#endif
    public static NtStatus ToNtStatus(this Exception? ex)
    {
        while (ex is TargetInvocationException or AggregateException)
        {
#pragma warning disable CA1062 // Validate arguments of public methods
            ex = ex.InnerException;
#pragma warning restore CA1062 // Validate arguments of public methods
        }

        if (ex is null)
        {
            return NtStatus.Unsuccessful;
        }

        if (ex is Win32Exception win32Exception)
        {
            return NativeMethods.DokanNtStatusFromWin32(win32Exception.NativeErrorCode);
        }

        if ((unchecked((uint)ex.HResult) & 0xffff0000) == 0x80070000)
        {
            return NativeMethods.DokanNtStatusFromWin32(ex.HResult & 0xffff);
        }

        // First try to match types directly, then normalize from hresult
        var status = ex switch
        {
            InvalidOperationException => NtStatus.NotImplemented,
            NotSupportedException or NotImplementedException => NtStatus.NotImplemented,
            ThreadAbortException or ThreadInterruptedException or OperationCanceledException => NtStatus.Cancelled,
            ArgumentOutOfRangeException or IndexOutOfRangeException or
                ArgumentNullException or NullReferenceException => NtStatus.InvalidParameter,
            _ => unchecked((uint)ex.HResult) switch
            {
                0x80131509 => NtStatus.NotImplemented,
                0x80131515 or 0x80131509 => NtStatus.NotImplemented,
                0x80131519 or 0x8013153B => NtStatus.Cancelled,
                0x80131502 or 0x80131508 or 0x80004003 or 0x80004003 => NtStatus.InvalidParameter,
                _ => NtStatus.Unsuccessful
            }
        };

        return status;
    }
}

```

### DokanInstance.cs

```using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;
using DokanNet.Logging;
using DokanNet.Native;
using LTRData.Extensions.Native.Memory;

namespace DokanNet;

/// <summary>
/// Created by <see cref="DokanInstanceBuilder.Build(IDokanOperations2)"/>.
/// It holds all the resources required to be alive for the time of the mount.
/// </summary>
#if NET5_0_OR_GREATER
[SupportedOSPlatform("windows")]
#endif
public class DokanInstance : IDisposable
{
    internal NativeStructWrapper<DOKAN_OPTIONS> DokanOptions { get; private set; }
    internal NativeStructWrapper<DOKAN_OPERATIONS> DokanOperations { get; private set; }
    internal DokanHandle DokanHandle { get; private set; }
    internal Dokan Dokan { get; private set; }

#if NET9_0_OR_GREATER
    private readonly Lock _disposeLock = new();
#else
    private readonly object _disposeLock = new();
#endif

    private bool _disposed = false;

    /// <summary>
    /// Event when this object is about to be disposed.
    /// </summary>
    public event EventHandler? Disposing;

    /// <summary>
    /// Event when this object has been disposed.
    /// </summary>
    public event EventHandler? Disposed;

    /// <summary>
    /// True when this object is about to be disposed.
    /// </summary>
    public bool IsDisposing { get; private set; }

    /// <summary>
    /// True when this object has been disposed and is no longer valid.
    /// </summary>
    public bool IsDisposed
    {
        get
        {
            lock (_disposeLock)
            {
                return _disposed;
            }
        }
    }

    /// <summary>
    /// Event when this object is about to be disposed.
    /// </summary>
    protected void OnDisposing(EventArgs e) => Disposing?.Invoke(this, e);

    /// <summary>
    /// Event when this object has been disposed.
    /// </summary>
    protected void OnDisposed(EventArgs e) => Disposed?.Invoke(this, e);

    /// <summary>
    /// Mount the filesystem described by <see cref="DOKAN_OPTIONS"/>.
    /// <see cref="IDokanOperations2"/> will start to received operations from the system and applications for this device.
    /// See <see cref="DokanInstanceBuilder"/>
    /// </summary>
    internal DokanInstance(ILogger logger, DOKAN_OPTIONS options, Dokan dokan, IDokanOperations2 operations)
    {
        DokanOptions = NativeStructWrapper.Wrap(options);
        var preparedOperations = PrepareOperations(logger, operations);
        DokanOperations = NativeStructWrapper.Wrap(preparedOperations);
        var status = NativeMethods.DokanCreateFileSystem(DokanOptions, DokanOperations, out var handle);
        if (status != DokanStatus.Success)
        {
            throw new DokanException(status);
        }

        DokanHandle = handle;
        Dokan = dokan;

        // This is just a way to keep a reference alive to this object and associated
        // operations as long as the file system is mounted
        KeepReferenceAlive();

        async void KeepReferenceAlive()
        {
            var gchandle = GCHandle.Alloc(this);

            try
            {
                await WaitForFileSystemClosedAsync(uint.MaxValue).ConfigureAwait(false);
            }
            catch
            {
            }
            finally
            {
                if (gchandle.IsAllocated)
                {
                    gchandle.Free();
                }
            }
        }
    }

    /// <summary>
    /// Check if the FileSystem is still running or not.
    /// </summary>
    /// <returns>Whether the FileSystem is still running or not.</returns>
    public bool IsFileSystemRunning()
    {
        return DokanHandle is not null && !DokanHandle.IsInvalid && !DokanHandle.IsClosed
            && NativeMethods.DokanIsFileSystemRunning(DokanHandle);
    }

    /// <summary>
    /// Wait until the FileSystem is unmount.
    /// </summary>
    /// <param name="milliSeconds">The time-out interval, in milliseconds. If a nonzero value is specified, the function waits until the object is signaled or the interval elapses. If set to zero,
    /// the function does not enter a wait state if the object is not signaled; it always returns immediately. If set to INFINITE, the function will return only when the object is signaled.</param>
    /// <returns>See <a href="https://docs.microsoft.com/en-us/windows/win32/api/synchapi/nf-synchapi-waitforsingleobject">WaitForSingleObject</a> for a description of return values.</returns>
    public uint WaitForFileSystemClosed(uint milliSeconds)
    {
        return DokanHandle is null || DokanHandle.IsClosed || DokanHandle.IsInvalid ?
            0 : NativeMethods.DokanWaitForFileSystemClosed(DokanHandle, milliSeconds);
    }

#if NET45_OR_GREATER || NETSTANDARD || NETCOREAPP

    /// <summary>
    /// Wait asynchronously until the FileSystem is unmounted.
    /// </summary>
    /// <param name="milliSeconds">The time-out interval, in milliseconds. If a nonzero value is specified, the function waits until the object is signaled or the interval elapses. If <paramref name="milliSeconds" /> is zero,
    /// the function does not enter a wait state if the object is not signaled; it always returns immediately. If <paramref name="milliSeconds"/> is INFINITE, the function will return only when the object is signaled.</param>
    /// <returns>True if instance was dismounted or false if time out occurred.</returns>
    public async Task<bool> WaitForFileSystemClosedAsync(uint milliSeconds)
        => DokanHandle is null || DokanHandle.IsClosed || DokanHandle.IsInvalid
        || await new DokanInstanceNotifyCompletion(this, milliSeconds);
#endif

    /// <summary>
    /// Notify Dokan that a file or directory has been created.
    /// </summary>
    /// <param name="filePath">Absolute path to the file or directory, including the mount-point of the file system.</param>
    /// <param name="isDirectory">Indicates if the path is a directory.</param>
    /// <returns>true if the notification succeeded.</returns>
    public bool NotifyCreate(string filePath, bool isDirectory)
    {
        return NativeMethods.DokanNotifyCreate(DokanHandle, filePath, isDirectory);
    }

    /// <summary>
    /// Notify Dokan that a file or directory has been deleted.
    /// </summary>
    /// <param name="filePath">Absolute path to the file or directory, including the mount-point of the file system.</param>
    /// <param name="isDirectory">Indicates if the path is a directory.</param>
    /// <returns>true if notification succeeded.</returns>
    /// <remarks><see cref="DokanOptions.EnableNotificationAPI"/> must be set in the mount options for this to succeed.</remarks>
    public bool NotifyDelete(string filePath, bool isDirectory)
    {
        return NativeMethods.DokanNotifyDelete(DokanHandle, filePath, isDirectory);
    }

    /// <summary>
    /// Notify Dokan that file or directory attributes have changed.
    /// </summary>
    /// <param name="filePath">Absolute path to the file or directory, including the mount-point of the file system.</param>
    /// <returns>true if notification succeeded.</returns>
    /// <remarks><see cref="DokanOptions.EnableNotificationAPI"/> must be set in the mount options for this to succeed.</remarks>
    public bool NotifyUpdate(string filePath)
    {
        return NativeMethods.DokanNotifyUpdate(DokanHandle, filePath);
    }

    /// <summary>
    /// Notify Dokan that file or directory extended attributes have changed.
    /// </summary>
    /// <param name="filePath">Absolute path to the file or directory, including the mount-point of the file system.</param>
    /// <returns>true if notification succeeded.</returns>
    /// <remarks><see cref="DokanOptions.EnableNotificationAPI"/> must be set in the mount options for this to succeed.</remarks>
    public bool NotifyXAttrUpdate(string filePath)
    {
        return NativeMethods.DokanNotifyXAttrUpdate(DokanHandle, filePath);
    }

    /// <summary>
    /// Notify Dokan that a file or directory has been renamed.
    /// This method supports in-place rename for file/directory within the same parent.
    /// </summary>
    /// <param name="oldPath">Old, absolute path to the file or directory, including the mount-point of the file system.</param>
    /// <param name="newPath">New, absolute path to the file or directory, including the mount-point of the file system.</param>
    /// <param name="isDirectory">Indicates if the path is a directory.</param>
    /// <param name="isInSameDirectory">Indicates if the file or directory have the same parent directory.</param>
    /// <returns>true if notification succeeded.</returns>
    /// <remarks><see cref="DokanOptions.EnableNotificationAPI"/> must be set in the mount options for this to succeed.</remarks>
    public bool NotifyRename(string oldPath, string newPath, bool isDirectory, bool isInSameDirectory)
    {
        return NativeMethods.DokanNotifyRename(DokanHandle, oldPath,
            newPath,
            isDirectory,
            isInSameDirectory);
    }

    /// <inheritdoc/>
    protected virtual void Dispose(bool disposing)
    {
        lock (_disposeLock)
        {
            if (!IsDisposed)
            {
                IsDisposing = true;

                if (disposing)
                {
                    OnDisposing(EventArgs.Empty);

                    // Dispose managed state (managed objects)
                    DokanHandle?.Dispose();     // This calls DokanCloseHandle and waits for dismount
                    DokanOptions?.Dispose();    // After that, it is safe to free unmanaged memory
                    DokanOperations?.Dispose();

                    OnDisposed(EventArgs.Empty);
                }

                // Free unmanaged resources (unmanaged objects) and override finalizer

                // Set fields to null
                DokanOptions = null!;
                DokanOperations = null!;
                DokanHandle = null!;

                _disposed = true;
            }
        }
    }

    /// <inheritdoc/>
    ~DokanInstance()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    private static unsafe DOKAN_OPERATIONS PrepareOperations(ILogger logger, IDokanOperations2 operations)
    {
        var dokanOperationProxy = new DokanOperationProxy(logger, operations);

        return new DOKAN_OPERATIONS
        {
            ZwCreateFile = dokanOperationProxy.ZwCreateFileProxy,
            Cleanup = dokanOperationProxy.CleanupProxy,
            CloseFile = dokanOperationProxy.CloseFileProxy,
            ReadFile = dokanOperationProxy.ReadFileProxy,
            WriteFile = dokanOperationProxy.WriteFileProxy,
            FlushFileBuffers = dokanOperationProxy.FlushFileBuffersProxy,
            GetFileInformation = dokanOperationProxy.GetFileInformationProxy,
            FindFiles = dokanOperationProxy.FindFilesProxy,
            FindFilesWithPattern = dokanOperationProxy.FindFilesWithPatternProxy,
            SetFileAttributes = dokanOperationProxy.SetFileAttributesProxy,
            SetFileTime = dokanOperationProxy.SetFileTimeProxy,
            DeleteFile = dokanOperationProxy.DeleteFileProxy,
            DeleteDirectory = dokanOperationProxy.DeleteDirectoryProxy,
            MoveFile = dokanOperationProxy.MoveFileProxy,
            SetEndOfFile = dokanOperationProxy.SetEndOfFileProxy,
            SetAllocationSize = dokanOperationProxy.SetAllocationSizeProxy,
            LockFile = dokanOperationProxy.LockFileProxy,
            UnlockFile = dokanOperationProxy.UnlockFileProxy,
            GetDiskFreeSpace = dokanOperationProxy.GetDiskFreeSpaceProxy,
            GetVolumeInformation = dokanOperationProxy.GetVolumeInformationProxy,
            Mounted = dokanOperationProxy.MountedProxy,
            Unmounted = dokanOperationProxy.UnmountedProxy,
            GetFileSecurity = dokanOperationProxy.GetFileSecurityProxy,
            SetFileSecurity = dokanOperationProxy.SetFileSecurityProxy,
            FindStreams = dokanOperationProxy.FindStreamsProxy
        };
    }
}

```

### DokanInstanceBuilder.cs

```using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using DokanNet.Legacy;
using DokanNet.Logging;
using DokanNet.Native;

namespace DokanNet;

/// <summary>
/// Dokan FileSystem build helper. Allows to create one or multiple <see cref="DokanInstance"/> based on a given configuration.
/// </summary>
public class DokanInstanceBuilder
{
    /// <summary>
    /// Delegate used by <see cref="ConfigureOptions"/> to customize th internal <see cref="DOKAN_OPTIONS"/>.
    /// </summary>
    public delegate void OptionsConfigurationDelegate(DOKAN_OPTIONS options);

    /// <summary>
    /// The Dokan version that DokanNet is compatible with.
    /// </summary>
    /// <see cref="DOKAN_OPTIONS.Version"/>
    public const ushort DOKAN_VERSION = 200;

    private readonly DOKAN_OPTIONS _options;

    private readonly Dokan _dokan;

    private ILogger _logger;

    /// <summary>
    /// Constructure an object with a <see cref="NullLogger"/> and default <see cref="DOKAN_OPTIONS"/> that will use the given <paramref name="dokan"/>.
    /// </summary>
    public DokanInstanceBuilder(Dokan dokan)
    {
        _logger = new NullLogger();
        _options = new DOKAN_OPTIONS
        {
            Version = DOKAN_VERSION,
            MountPoint = "",
            UNCName = string.Empty,
            SingleThread = false,
            Options = DokanOptions.FixedDrive,
            TimeOut = TimeSpan.FromSeconds(20),
            AllocationUnitSize = 512,
            SectorSize = 512,
            VolumeSecurityDescriptorLength = 0,

        };
        _dokan = dokan;
    }

    /// <summary>
    /// Allows to set a custom <see cref="ILogger"/> like <see cref="Logger"/>, <see cref="TraceLogger"/> to be used
    /// for the instance created by <see cref="Build(IDokanOperations2)"/>.
    /// </summary>
    public DokanInstanceBuilder ConfigureLogger(Func<ILogger> IlogegrFactory)
    {
        _logger = IlogegrFactory();
        return this;
    }

    /// <summary>
    /// Allows to personalize the <see cref="DOKAN_OPTIONS"/> use for <see cref="Build(IDokanOperations2)"/>.
    /// </summary>
    public DokanInstanceBuilder ConfigureOptions(OptionsConfigurationDelegate optionsConfigurationDelegate)
    {
        optionsConfigurationDelegate(_options);
        return this;
    }

    /// <summary>
    /// Verify that the provided configuration is valid.
    /// Note: Has no effect for now.
    /// </summary>
    public DokanInstanceBuilder Validate()
    {
        // throw on errors
        return this;
    }

    /// <summary>
    /// Create a <see cref="DokanInstance"/> based on the previously provided information
    /// through <see cref="ConfigureOptions"/> and <see cref="ConfigureLogger"/>.
    /// </summary>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("windows")]
#endif
    public DokanInstance Build(IDokanOperations2 operations)
    {
        return new DokanInstance(_logger, _options, _dokan, operations);
    }

    /// <summary>
    /// Create a <see cref="DokanInstance"/> based on the previously provided information
    /// through <see cref="ConfigureOptions"/> and <see cref="ConfigureLogger"/>.
    /// </summary>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("windows")]
#endif
    public DokanInstance Build(IDokanOperations operations)
    {
        return new DokanInstance(_logger, _options, _dokan, new DokanOperationsAdapter(operations, _logger));
    }
}

```

### DokanInstanceNotifyCompletion.cs

```using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System;
using DokanNet.Native;
using System.Runtime.Versioning;

namespace DokanNet;

#if NET45_OR_GREATER || NETSTANDARD || NETCOREAPP

/// <summary>
/// Support for async/await operation on DokanInstance objects
/// </summary>
#if NET5_0_OR_GREATER
[SupportedOSPlatform("windows")]
#endif
internal sealed class DokanInstanceNotifyCompletion : ICriticalNotifyCompletion
{
    public DokanInstanceNotifyCompletion(DokanInstance dokanInstance, uint milliSeconds)
    {
        DokanInstance = dokanInstance;
        MilliSeconds = milliSeconds;
    }

    public DokanInstance DokanInstance { get; }
    public uint MilliSeconds { get; }
    public bool IsCompleted => !DokanInstance.IsFileSystemRunning();
    private nint waitHandle;
    private bool timedOut;
    private Action? continuation;

    public DokanInstanceNotifyCompletion GetAwaiter() => this;

    public void OnCompleted(Action continuation) => throw new NotSupportedException();

    public void UnsafeOnCompleted(Action continuation)
    {
        this.continuation = continuation;

        if (!NativeMethods.DokanRegisterWaitForFileSystemClosed(DokanInstance.DokanHandle,
                                                                out waitHandle,
                                                                Callback,
                                                                (nint)GCHandle.Alloc(this),
                                                                MilliSeconds))
        {
            throw new Win32Exception();
        }
    }

    private static void Callback(nint state, bool timedOut)
    {
        var handle = GCHandle.FromIntPtr(state);
        var target = (DokanInstanceNotifyCompletion)handle.Target!;

        handle.Free();

        while (target.waitHandle == 0)
        {
            Thread.Sleep(20);
        }

        NativeMethods.DokanUnregisterWaitForFileSystemClosed(target.waitHandle,
            waitForCallbacks: false);

        target.waitHandle = 0;

        target.timedOut = timedOut;

        target.continuation!();
    }

    /// <summary>
    /// Gets a value indicating whether DokanInstance was closed or if await timed out
    /// </summary>
    /// <returns>True if DokanInstance was closed or false if await timed out</returns>
    public bool GetResult()
    {
        if (timedOut)
        {
            return false;
        }

        if (!IsCompleted)
        {
            throw new InvalidOperationException($"Invalid state for {nameof(GetResult)}");
        }

        return true;
    }
}

#endif

```

### DokanOperationProxy.cs

```using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using DokanNet.Logging;
using DokanNet.Native;
using LTRData.Extensions.Native.Memory;
using FILETIME = System.Runtime.InteropServices.ComTypes.FILETIME;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable IDE0060 // Remove unused parameter

namespace DokanNet;

/// <summary>
/// The dokan operation proxy.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="DokanOperationProxy"/> class.
/// </remarks>
/// <param name="operations">
/// A <see cref="IDokanOperations2"/> that contains the custom implementation of the driver.
/// </param>
/// <param name="logger">
/// A <see cref="ILogger"/> that handle all logging.
/// </param>
#if NET5_0_OR_GREATER
[SupportedOSPlatform("windows")]
#endif
internal sealed unsafe class DokanOperationProxy(ILogger logger, IDokanOperations2 operations)
{
#if NET6_0_OR_GREATER

    private static unsafe ReadOnlyNativeMemory<char> MemoryFromIntPtr(nint ptr)
        => new(ptr, MemoryMarshal.CreateReadOnlySpanFromNullTerminated((char*)ptr).Length);

#else

    [DllImport("msvcrt", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
    private static extern int wcslen(nint ptr);

    private static ReadOnlyNativeMemory<char> MemoryFromIntPtr(nint ptr)
    {
        if (ptr == 0)
        {
            return default;
        }

        return new(ptr, wcslen(ptr));
    }

#endif

    private readonly IDokanOperations2 operations = operations;

    private readonly ILogger logger = logger;

    private uint serialNumber = (uint)operations.GetHashCode();

    #region Enum masks
    /// <summary>
    /// To be used to mask out the <see cref="FileOptions"/> flags from what is returned 
    /// from <see cref="Native.NativeMethods.DokanMapKernelToUserCreateFileFlags"/>.
    /// </summary>
    private const int FileOptionsMask =
        (int)
        (FileOptions.Asynchronous | FileOptions.DeleteOnClose | FileOptions.Encrypted
        | FileOptions.None | FileOptions.RandomAccess | FileOptions.SequentialScan
        | FileOptions.WriteThrough);

    /// <summary>
    /// To be used to mask out the <see cref="FileAttributes"/> flags from what is returned 
    /// from <see cref="Native.NativeMethods.DokanMapKernelToUserCreateFileFlags"/>.
    /// Note that some flags where introduces in .NET Framework 4.5, and is not supported 
    /// in .NET Framework 4. 
    /// </summary>
    private const int FileAttributeMask = (int)(
        FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System
        | FileAttributes.Directory | FileAttributes.Archive | FileAttributes.Device
        | FileAttributes.Normal | FileAttributes.Temporary | FileAttributes.SparseFile
        | FileAttributes.ReparsePoint | FileAttributes.Compressed | FileAttributes.Offline
        | FileAttributes.NotContentIndexed | FileAttributes.Encrypted
#if NET45_OR_GREATER || NETSTANDARD || NETCOREAPP
        | FileAttributes.IntegrityStream | FileAttributes.NoScrubData
#endif
    );

    /// <summary>
    /// To be used to mask out the <see cref="FileAccess"/> flags.
    /// </summary>
    private const uint FileAccessMask =
        (uint)
        (FileAccess.ReadData | FileAccess.WriteData | FileAccess.AppendData
        | FileAccess.ReadExtendedAttributes | FileAccess.WriteExtendedAttributes | FileAccess.Execute
        | FileAccess.DeleteChild | FileAccess.ReadAttributes | FileAccess.WriteAttributes
        | FileAccess.Delete | FileAccess.ReadPermissions | FileAccess.ChangePermissions
        | FileAccess.SetOwnership | FileAccess.Synchronize | FileAccess.AccessSystemSecurity
        | FileAccess.MaximumAllowed | FileAccess.GenericAll | FileAccess.GenericExecute
        | FileAccess.GenericWrite | FileAccess.GenericRead);

    /// <summary>
    /// To be used to mask out the <see cref="FileShare"/> flags.
    /// </summary>
    private const int FileShareMask =
        (int)
        (FileShare.ReadWrite | FileShare.Delete | FileShare.Inheritable);

    #endregion

    /// <summary>
    /// CreateFile is called each time a request is made on a file system object.
    /// 
    /// In case <see cref="FileMode.OpenOrCreate"/> and
    /// <see cref="FileMode.Create"/> are opening successfully a already
    /// existing file, you have to return <see cref="DokanResult.AlreadyExists"/> instead of <see cref="NtStatus.Success"/>.
    /// 
    /// If the file is a directory, CreateFile is also called.
    /// In this case, CreateFile should return <see cref="NtStatus.Success"/> when that directory
    /// can be opened and <see cref="DokanFileInfo.IsDirectory"/> has to be set to <c>true</c>.
    /// 
    /// <see cref="DokanFileInfo.Context"/> can be used to store data (like <see cref="FileStream"/>)
    /// that can be retrieved in all other request related to the context.
    /// </summary>
    /// <param name="rawFileName">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="securityContext">SecurityContext, see <a href="https://msdn.microsoft.com/en-us/library/windows/hardware/ff550613(v=vs.85).aspx">IO_SECURITY_CONTEXT structure (MSDN)</a>.</param>
    /// <param name="rawDesiredAccess">Specifies an <a href="https://msdn.microsoft.com/en-us/library/windows/hardware/ff540466(v=vs.85).aspx">ACCESS_MASK (MSDN)</a> value that determines the requested access to the object.</param>
    /// <param name="rawFileAttributes">Specifies one or more FILE_ATTRIBUTE_XXX flags, which represent the file attributes to set if you create or overwrite a file.</param>
    /// <param name="rawShareAccess">Type of share access, which is specified as zero or any combination of <see cref="FileShare"/>.</param>
    /// <param name="rawCreateDisposition">Specifies the action to perform if the file does or does not exist.</param>
    /// <param name="rawCreateOptions">Specifies the options to apply when the driver creates or opens the file.</param>
    /// <param name="rawFileInfo">>An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns>The <see cref="NtStatus"/>.</returns>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/hardware/ff566424(v=vs.85).aspx">ZwCreateFile routine (MSDN)</a>
    /// <see cref="DokanNet.IDokanOperations2.CreateFile"/>
    public NtStatus ZwCreateFileProxy(
        nint rawFileName,
        nint securityContext,
        uint rawDesiredAccess,
        uint rawFileAttributes,
        uint rawShareAccess,
        uint rawCreateDisposition,
        uint rawCreateOptions,
        DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            NativeMethods.DokanMapKernelToUserCreateFileFlags(
                rawDesiredAccess,
                rawFileAttributes,
                rawCreateOptions,
                rawCreateDisposition,
                out var outDesiredAccess,
                out var fileAttributesAndFlags,
                out var creationDisposition);

            var fileAttributes = (FileAttributes)(fileAttributesAndFlags & FileAttributeMask);
            var fileOptions = (FileOptions)(fileAttributesAndFlags & FileOptionsMask);
            var desiredAccess = (FileAccess)(outDesiredAccess & FileAccessMask);
            var shareAccess = (FileShare)(rawShareAccess & FileShareMask);

            if (logger.DebugEnabled)
            {
                logger.Debug($"CreateFileProxy : {fileNamePtr}");
                logger.Debug($"\tCreationDisposition\t{(FileMode)creationDisposition}");
                logger.Debug($"\tRawDesiredAccess\t0x{rawDesiredAccess:X}");
                logger.Debug($"\tDesiredAccess\t{desiredAccess}");
                logger.Debug($"\tFileShare\t{(FileShare)rawShareAccess}");
                logger.Debug($"\tFileOptions\t{fileOptions}");
                logger.Debug($"\tFileAttributes\t{fileAttributes}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.CreateFile(
                fileNamePtr,
                desiredAccess,
                shareAccess,
                (FileMode)creationDisposition,
                fileOptions,
                fileAttributes,
                ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"CreateFileProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"CreateFileProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public void CleanupProxy(nint rawFileName, DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"CleanupProxy : {fileNamePtr}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            operations.Cleanup(fileNamePtr, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"CleanupProxy : {fileNamePtr}");
            }
        }
        catch (Exception ex)
        {
            logger.Error($"CleanupProxy : {fileNamePtr} Throw : {ex.Message}");
        }
    }

    ////

    public void CloseFileProxy(nint rawFileName, DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"CloseFileProxy : {fileNamePtr}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            operations.CloseFile(fileNamePtr, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"CloseFileProxy : {fileNamePtr}");
            }
        }
        catch (Exception ex)
        {
            logger.Error($"CloseFileProxy : {fileNamePtr} Throw : {ex.Message}");
        }
        finally
        {
            rawFileInfo->Context = null;
        }
    }

    ////

    public NtStatus ReadFileProxy(
        nint rawFileName,
        nint rawBuffer,
        uint rawBufferLength,
        int* rawReadLength,
        long rawOffset,
        DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"ReadFileProxy : {fileNamePtr}");
                logger.Debug($"\tBufferLength\t{rawBufferLength}");
                logger.Debug($"\tOffset\t{rawOffset}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.ReadFile(fileNamePtr, new(rawBuffer, (int)rawBufferLength), out *rawReadLength, rawOffset, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"ReadFileProxy : {fileNamePtr} Return : {result} ReadLength : {*rawReadLength}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"ReadFileProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public NtStatus WriteFileProxy(
        nint rawFileName,
        nint rawBuffer,
        uint rawNumberOfBytesToWrite,
        int* rawNumberOfBytesWritten,
        long rawOffset,
        DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"WriteFileProxy : {fileNamePtr}");
                logger.Debug($"\tNumberOfBytesToWrite\t{rawNumberOfBytesToWrite}");
                logger.Debug($"\tOffset\t{rawOffset}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.WriteFile(fileNamePtr, new(rawBuffer, (int)rawNumberOfBytesToWrite), out *rawNumberOfBytesWritten, rawOffset, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"WriteFileProxy : {fileNamePtr} Return : {result} NumberOfBytesWritten : {*rawNumberOfBytesWritten}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"WriteFileProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public NtStatus FlushFileBuffersProxy(nint rawFileName, DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"FlushFileBuffersProxy : {fileNamePtr}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.FlushFileBuffers(fileNamePtr, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"FlushFileBuffersProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"FlushFileBuffersProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public NtStatus GetFileInformationProxy(
        nint rawFileName,
        BY_HANDLE_FILE_INFORMATION* rawHandleFileInformation,
        DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"GetFileInformationProxy : {fileNamePtr}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.GetFileInformation(fileNamePtr, out var fi, ref *rawFileInfo);

            if (result == DokanResult.Success)
            {
                //Debug.Assert(fi.FileName is not null, "FileName must not be null");
                if (logger.DebugEnabled)
                {
                    logger.Debug($"\tFileName\t{fileNamePtr}");
                    logger.Debug($"\tAttributes\t{fi.Attributes}");
                    logger.Debug($"\tCreationTime\t{fi.CreationTime}");
                    logger.Debug($"\tLastAccessTime\t{fi.LastAccessTime}");
                    logger.Debug($"\tLastWriteTime\t{fi.LastWriteTime}");
                    logger.Debug($"\tLength\t\t{fi.Length}");
                }

                rawHandleFileInformation->dwFileAttributes = (uint)fi.Attributes /* + FILE_ATTRIBUTE_VIRTUAL*/;

                var ctime = ToFileTime(fi.CreationTime);
                rawHandleFileInformation->ftCreationTime.dwHighDateTime = (int)(ctime >> 32);
                rawHandleFileInformation->ftCreationTime.dwLowDateTime = (int)(ctime & 0xffffffff);

                var atime = ToFileTime(fi.LastAccessTime);
                rawHandleFileInformation->ftLastAccessTime.dwHighDateTime = (int)(atime >> 32);
                rawHandleFileInformation->ftLastAccessTime.dwLowDateTime = (int)(atime & 0xffffffff);

                var mtime = ToFileTime(fi.LastWriteTime);
                rawHandleFileInformation->ftLastWriteTime.dwHighDateTime = (int)(mtime >> 32);
                rawHandleFileInformation->ftLastWriteTime.dwLowDateTime = (int)(mtime & 0xffffffff);

                rawHandleFileInformation->dwVolumeSerialNumber = serialNumber;

                rawHandleFileInformation->nFileSizeLow = (uint)(fi.Length & 0xffffffff);
                rawHandleFileInformation->nFileSizeHigh = (uint)(fi.Length >> 32);

                rawHandleFileInformation->dwNumberOfLinks = fi.NumberOfLinks;

                var index = fi.FileIndex;

                if (index == 0)
                {
#if NETCOREAPP
                    index = string.GetHashCode(fileNamePtr.Span, StringComparison.Ordinal);
#elif NETSTANDARD2_1_OR_GREATER
                    index = rawFileName.ToString().GetHashCode(StringComparison.Ordinal);
#else
                    index = rawFileName.ToString().GetHashCode();
#endif
                }

                rawHandleFileInformation->nFileIndexHigh = (uint)(index >> 32);
                rawHandleFileInformation->nFileIndexLow = (uint)(index & 0xffffffff);
            }

            if (logger.DebugEnabled)
            {
                logger.Debug($"GetFileInformationProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"GetFileInformationProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public NtStatus FindFilesProxy(nint rawFileName, nint rawFillFindData, DokanFileInfo* rawFileInfo)
    {
        var startTime = Environment.TickCount;

        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"FindFilesProxy : {fileNamePtr}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.FindFiles(fileNamePtr, out var files, ref *rawFileInfo);

            if (result == DokanResult.Success)
            {
                Debug.Assert(files is not null, "Files must not be null");

                var count = 0L;

                // used a single entry call to speed up the "enumeration" of the list
                foreach (var fi in files!)
                {
                    count++;

                    if (operations.DirectoryListingTimeoutResetIntervalMs != 0
                        && unchecked(Environment.TickCount - startTime) >= operations.DirectoryListingTimeoutResetIntervalMs)
                    {
                        logger.Info($"FindFilesWithPatternProxy : Listing {fileNamePtr} takes more than {operations.DirectoryListingTimeoutResetIntervalMs}, {count} files");
                        rawFileInfo->TryResetTimeout(operations.DirectoryListingTimeoutResetIntervalMs * 2);
                        startTime = Environment.TickCount;
                    }

                    if (logger.DebugEnabled)
                    {
                        logger.Debug($"\tFileName\t{fi.FileName}");
                        logger.Debug($"\t\tAttributes\t{fi.Attributes}");
                        logger.Debug($"\t\tCreationTime\t{fi.CreationTime}");
                        logger.Debug($"\t\tLastAccessTime\t{fi.LastAccessTime}");
                        logger.Debug($"\t\tLastWriteTime\t{fi.LastWriteTime}");
                        logger.Debug($"\t\tLength\t\t{fi.Length}");
                    }

                    AddFileFindDataTo(rawFillFindData, *rawFileInfo, fi);
                }
            }

            if (logger.DebugEnabled)
            {
                logger.Debug($"FindFilesProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"FindFilesProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    public NtStatus FindFilesWithPatternProxy(
        nint rawFileName,
        nint rawSearchPattern,
        nint rawFillFindData,
        DokanFileInfo* rawFileInfo)
    {
        var startTime = Environment.TickCount;

        var fileNamePtr = MemoryFromIntPtr(rawFileName);
        var searchPatternPtr = MemoryFromIntPtr(rawSearchPattern);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"FindFilesWithPatternProxy : {fileNamePtr}");
                logger.Debug($"\trawSearchPattern\t{searchPatternPtr}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            // TODO(someone): Allow userland FS to set FindFiles preference at mount time and nullify the callback not used.
            var result = operations.FindFilesWithPattern(fileNamePtr, searchPatternPtr, out var files, ref *rawFileInfo);

            Debug.Assert(files is not null, "Files must not be null");

            if (result == DokanResult.Success)
            {
                var count = 0L;

                // used a single entry call to speed up the "enumeration" of the list
                foreach (var fi in files!)
                {
                    count++;

                    if (operations.DirectoryListingTimeoutResetIntervalMs != 0
                        && unchecked(Environment.TickCount - startTime) >= operations.DirectoryListingTimeoutResetIntervalMs)
                    {
                        logger.Info($"FindFilesWithPatternProxy : Listing {fileNamePtr} with pattern {searchPatternPtr} takes more than {operations.DirectoryListingTimeoutResetIntervalMs}, {count} files");
                        rawFileInfo->TryResetTimeout(operations.DirectoryListingTimeoutResetIntervalMs * 2);
                        startTime = Environment.TickCount;
                    }

                    if (logger.DebugEnabled)
                    {
                        logger.Debug($"\tFileName\t{fi.FileName}");
                        logger.Debug($"\t\tAttributes\t{fi.Attributes}");
                        logger.Debug($"\t\tCreationTime\t{fi.CreationTime}");
                        logger.Debug($"\t\tLastAccessTime\t{fi.LastAccessTime}");
                        logger.Debug($"\t\tLastWriteTime\t{fi.LastWriteTime}");
                        logger.Debug($"\t\tLength\t\t{fi.Length}");
                    }

                    AddFileFindDataTo(rawFillFindData, *rawFileInfo, fi);
                }
            }

            if (logger.DebugEnabled)
            {
                logger.Debug($"FindFilesWithPatternProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"FindFilesWithPatternProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    /// <summary>
    /// Call the function pointer <paramref name="rawFillFindData"/> using data in <paramref name="rawFileInfo"/> and <paramref name="fi"/>.
    /// </summary>
    /// <param name="rawFillFindData">Pointer to unmanaged function of type <see cref="FILL_FIND_FILE_DATA"/> to be called.</param>
    /// <param name="rawFileInfo">A <see cref="DokanFileInfo"/> to be used when calling <paramref name="rawFillFindData"/>.</param>
    /// <param name="fi">A <see cref="ByHandleFileInformation"/> with information to be used when calling <paramref name="rawFillFindData"/>.</param>
    private static unsafe void AddFileFindDataTo(nint rawFillFindData, in DokanFileInfo rawFileInfo, in FindFileInformation fi)
    {
        var fill = (delegate* unmanaged[Stdcall]<in WIN32_FIND_DATA, in DokanFileInfo, long>)rawFillFindData;

        Debug.Assert(!fi.FileName.IsEmpty, "FileName must not be empty or null");
        var ctime = ToFileTime(fi.CreationTime);
        var atime = ToFileTime(fi.LastAccessTime);
        var mtime = ToFileTime(fi.LastWriteTime);
        var data = new WIN32_FIND_DATA
        {
            dwFileAttributes = fi.Attributes,
            ftCreationTime =
                {
                    dwHighDateTime = (int) (ctime >> 32),
                    dwLowDateTime = (int) (ctime & 0xffffffff)
                },
            ftLastAccessTime =
                {
                    dwHighDateTime = (int) (atime >> 32),
                    dwLowDateTime = (int) (atime & 0xffffffff)
                },
            ftLastWriteTime =
                {
                    dwHighDateTime = (int) (mtime >> 32),
                    dwLowDateTime = (int) (mtime & 0xffffffff)
                },
            nFileSizeLow = (uint)(fi.Length & 0xffffffff),
            nFileSizeHigh = (uint)(fi.Length >> 32),
            FileName = fi.FileName.Span,
            AlternateFileName = fi.ShortFileName.Span
        };

        fill(data, rawFileInfo);
    }

    public NtStatus FindStreamsProxy(nint rawFileName, nint rawFillFindData, nint findStreamContext, DokanFileInfo* rawFileInfo)
    {
        var startTime = Environment.TickCount;

        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"FindStreamsProxy: {fileNamePtr}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.FindStreams(fileNamePtr, out var files, ref *rawFileInfo);

            Debug.Assert(!(result == DokanResult.NotImplemented && files is null));
            if (result == DokanResult.Success)
            {
                var count = 0L;

                // used a single entry call to speed up the "enumeration" of the list
                foreach (var fi in files!)
                {
                    count++;

                    if (operations.DirectoryListingTimeoutResetIntervalMs != 0
                        && unchecked(Environment.TickCount - startTime) >= operations.DirectoryListingTimeoutResetIntervalMs)
                    {
                        logger.Info($"FindFilesWithPatternProxy : Listing streams of {fileNamePtr} takes more than {operations.DirectoryListingTimeoutResetIntervalMs}, {count} files");
                        rawFileInfo->TryResetTimeout(operations.DirectoryListingTimeoutResetIntervalMs * 2);
                        startTime = Environment.TickCount;
                    }

                    if (logger.DebugEnabled)
                    {
                        logger.Debug($"\tFileName\t{fi.FileName}");
                        logger.Debug($"\t\tLength\t{fi.Length}");
                    }

                    AddFindStreamDataTo(rawFillFindData, *rawFileInfo, fi);
                }
            }

            if (logger.DebugEnabled)
            {
                logger.Debug($"FindStreamsProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"FindStreamsProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    /// <summary>
    /// Call the function pointer <paramref name="rawFillStreamData"/> using data in <paramref name="rawFileInfo"/> and <paramref name="fi"/>.
    /// </summary>
    /// <param name="rawFillStreamData">Pointer to unmanaged function of type <see cref="FILL_FIND_STREAM_DATA"/> to be called.</param>
    /// <param name="rawFileInfo">A <see cref="DokanFileInfo"/> to be used when calling <paramref name="rawFillStreamData"/>.</param>
    /// <param name="fi">A <see cref="ByHandleFileInformation"/> with information to be used when calling <paramref name="rawFillStreamData"/>.</param>
    private static unsafe void AddFindStreamDataTo(nint rawFillStreamData, in DokanFileInfo rawFileInfo, FindFileInformation fi)
    {
        var fill = (delegate* unmanaged[Stdcall]<in WIN32_FIND_STREAM_DATA, in DokanFileInfo, long>)rawFillStreamData;

        Debug.Assert(!fi.FileName.IsEmpty, "FileName must not be empty or null");

        var data = new WIN32_FIND_STREAM_DATA
        {
            StreamSize = fi.Length,
            StreamName = fi.FileName.Span
        };
        //ZeroMemory(&data, sizeof(WIN32_FIND_DATAW));

        fill(data, rawFileInfo);
    }

    ////

    public NtStatus SetEndOfFileProxy(nint rawFileName, long rawByteOffset, DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"SetEndOfFileProxy : {rawFileName}");
                logger.Debug($"\tByteOffset\t{rawByteOffset}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.SetEndOfFile(fileNamePtr, rawByteOffset, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"SetEndOfFileProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"SetEndOfFileProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    public NtStatus SetAllocationSizeProxy(nint rawFileName, long rawLength, DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"SetAllocationSizeProxy : {fileNamePtr}");
                logger.Debug($"\tLength\t{rawLength}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.SetAllocationSize(fileNamePtr, rawLength, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"SetAllocationSizeProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"SetAllocationSizeProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public NtStatus SetFileAttributesProxy(nint rawFileName, uint rawAttributes, DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"SetFileAttributesProxy : {fileNamePtr}");
                logger.Debug($"\tAttributes\t{(FileAttributes)rawAttributes}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.SetFileAttributes(fileNamePtr, (FileAttributes)rawAttributes, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"SetFileAttributesProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"SetFileAttributesProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public NtStatus SetFileTimeProxy(
        nint rawFileName,
        FILETIME* rawCreationTime,
        FILETIME* rawLastAccessTime,
        FILETIME* rawLastWriteTime,
        DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            var ctime = (rawCreationTime->dwLowDateTime != 0 || rawCreationTime->dwHighDateTime != 0) &&
                        (rawCreationTime->dwLowDateTime != -1 || rawCreationTime->dwHighDateTime != -1)
                ? DateTime.FromFileTime((long)rawCreationTime->dwHighDateTime << 32 |
                                        (uint)rawCreationTime->dwLowDateTime)
                : (DateTime?)null;
            var atime = (rawLastAccessTime->dwLowDateTime != 0 || rawLastAccessTime->dwHighDateTime != 0) &&
                        (rawLastAccessTime->dwLowDateTime != -1 || rawLastAccessTime->dwHighDateTime != -1)
                ? DateTime.FromFileTime((long)rawLastAccessTime->dwHighDateTime << 32 |
                                        (uint)rawLastAccessTime->dwLowDateTime)
                : (DateTime?)null;
            var mtime = (rawLastWriteTime->dwLowDateTime != 0 || rawLastWriteTime->dwHighDateTime != 0) &&
                        (rawLastWriteTime->dwLowDateTime != -1 || rawLastWriteTime->dwHighDateTime != -1)
                ? DateTime.FromFileTime((long)rawLastWriteTime->dwHighDateTime << 32 |
                                        (uint)rawLastWriteTime->dwLowDateTime)
                : (DateTime?)null;

            if (logger.DebugEnabled)
            {
                logger.Debug($"SetFileTimeProxy : {fileNamePtr}");
                logger.Debug($"\tCreateTime\t{ctime}");
                logger.Debug($"\tAccessTime\t{atime}");
                logger.Debug($"\tWriteTime\t{mtime}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.SetFileTime(fileNamePtr, ctime, atime, mtime, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"SetFileTimeProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"SetFileTimeProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public NtStatus DeleteFileProxy(nint rawFileName, DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"DeleteFileProxy : {fileNamePtr}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.DeleteFile(fileNamePtr, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"DeleteFileProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"DeleteFileProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public NtStatus DeleteDirectoryProxy(nint rawFileName, DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"DeleteDirectoryProxy : {fileNamePtr}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.DeleteDirectory(fileNamePtr, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"DeleteDirectoryProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"DeleteDirectoryProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public NtStatus MoveFileProxy(
        nint rawFileName,
        nint rawNewFileName,
        bool rawReplaceIfExisting,
        DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"MoveFileProxy : {fileNamePtr}");
                logger.Debug($"\tNewFileName\t{rawNewFileName}");
                logger.Debug($"\tReplaceIfExisting\t{rawReplaceIfExisting}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.MoveFile(fileNamePtr, MemoryFromIntPtr(rawNewFileName), rawReplaceIfExisting, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"MoveFileProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"MoveFileProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public NtStatus LockFileProxy(nint rawFileName, long rawByteOffset, long rawLength, DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"LockFileProxy : {fileNamePtr}");
                logger.Debug($"\tByteOffset\t{rawByteOffset}");
                logger.Debug($"\tLength\t{rawLength}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.LockFile(fileNamePtr, rawByteOffset, rawLength, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"LockFileProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"LockFileProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public NtStatus UnlockFileProxy(
        nint rawFileName,
        long rawByteOffset,
        long rawLength,
        DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"UnlockFileProxy : {fileNamePtr}");
                logger.Debug($"\tByteOffset\t{rawByteOffset}");
                logger.Debug($"\tLength\t{rawLength}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.UnlockFile(fileNamePtr, rawByteOffset, rawLength, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"UnlockFileProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"UnlockFileProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    ////

    public NtStatus GetDiskFreeSpaceProxy(
        long* rawFreeBytesAvailable,
        long* rawTotalNumberOfBytes,
        long* rawTotalNumberOfFreeBytes,
        DokanFileInfo* rawFileInfo)
    {
        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"GetDiskFreeSpaceProxy:");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.GetDiskFreeSpace(
                out *rawFreeBytesAvailable,
                out *rawTotalNumberOfBytes,
                out *rawTotalNumberOfFreeBytes,
                ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"\tFreeBytesAvailable\t{*rawFreeBytesAvailable}");
                logger.Debug($"\tTotalNumberOfBytes\t{*rawTotalNumberOfBytes}");
                logger.Debug($"\tTotalNumberOfFreeBytes\t{*rawTotalNumberOfFreeBytes}");
                logger.Debug($"GetDiskFreeSpaceProxy Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"GetDiskFreeSpaceProxy Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    public NtStatus GetVolumeInformationProxy(
        nint rawVolumeNameBuffer,
        uint rawVolumeNameSize,
        uint* volumeSerialNumber,
        uint* maximumComponentLength,
        FileSystemFeatures* fileSystemFlags,
        nint rawFileSystemNameBuffer,
        uint rawFileSystemNameSize,
        DokanFileInfo* rawFileInfo)
    {
        *volumeSerialNumber = serialNumber;

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"GetVolumeInformationProxy:");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var volumeNameBuffer = new NativeMemory<char>(rawVolumeNameBuffer, (int)rawVolumeNameSize);
            var fileSystemNameBuffer = new NativeMemory<char>(rawFileSystemNameBuffer, (int)rawFileSystemNameSize);

            var result = operations.GetVolumeInformation(volumeNameBuffer,
                                                         out *fileSystemFlags,
                                                         fileSystemNameBuffer,
                                                         out *maximumComponentLength,
                                                         ref *volumeSerialNumber,
                                                         ref *rawFileInfo);

            if (result == DokanResult.Success)
            {
                serialNumber = *volumeSerialNumber;

                if (logger.DebugEnabled)
                {
                    logger.Debug($"\tVolumeNameBuffer\t{volumeNameBuffer}");
                    logger.Debug($"\tFileSystemNameBuffer\t{fileSystemNameBuffer}");
                    logger.Debug($"\tVolumeSerialNumber\t{*volumeSerialNumber:X8}");
                    logger.Debug($"\tFileSystemFlags\t{*fileSystemFlags}");
                    logger.Debug($"\tMaximumComponentLength\t{*maximumComponentLength}");
                }
            }

            if (logger.DebugEnabled)
            {
                logger.Debug($"GetVolumeInformationProxy Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"GetVolumeInformationProxy Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    public NtStatus MountedProxy(nint mountPoint, DokanFileInfo* rawFileInfo)
    {
        var mountPointPtr = MemoryFromIntPtr(mountPoint);

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"MountedProxy:");
                logger.Debug($"\tMountPoint\t{mountPointPtr}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.Mounted(mountPointPtr, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"MountedProxy Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"MountedProxy {mountPointPtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    public NtStatus UnmountedProxy(DokanFileInfo* rawFileInfo)
    {
        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"UnmountedProxy:");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.Unmounted(ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"UnmountedProxy Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"UnmountedProxy Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    public NtStatus GetFileSecurityProxy(
        nint rawFileName,
        SECURITY_INFORMATION* rawRequestedInformation,
        nint rawSecurityDescriptor,
        uint rawSecurityDescriptorLength,
        uint* rawSecurityDescriptorLengthNeeded,
        DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        var sect = AccessControlSections.None;

        if (rawRequestedInformation->HasFlag(SECURITY_INFORMATION.OWNER_SECURITY_INFORMATION))
        {
            sect |= AccessControlSections.Owner;
        }

        if (rawRequestedInformation->HasFlag(SECURITY_INFORMATION.GROUP_SECURITY_INFORMATION))
        {
            sect |= AccessControlSections.Group;
        }

        if (rawRequestedInformation->HasFlag(SECURITY_INFORMATION.DACL_SECURITY_INFORMATION) ||
            rawRequestedInformation->HasFlag(SECURITY_INFORMATION.PROTECTED_DACL_SECURITY_INFORMATION) ||
            rawRequestedInformation->HasFlag(SECURITY_INFORMATION.UNPROTECTED_DACL_SECURITY_INFORMATION))
        {
            sect |= AccessControlSections.Access;
        }

        if (rawRequestedInformation->HasFlag(SECURITY_INFORMATION.SACL_SECURITY_INFORMATION) ||
            rawRequestedInformation->HasFlag(SECURITY_INFORMATION.PROTECTED_SACL_SECURITY_INFORMATION) ||
            rawRequestedInformation->HasFlag(SECURITY_INFORMATION.UNPROTECTED_SACL_SECURITY_INFORMATION))
        {
            sect |= AccessControlSections.Audit;
        }

        try
        {
            if (logger.DebugEnabled)
            {
                logger.Debug($"GetFileSecurityProxy : {fileNamePtr}");
                logger.Debug($"\tFileSystemSecurity\t{sect}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.GetFileSecurity(fileNamePtr, out var sec, sect, ref *rawFileInfo);
            if (result == DokanResult.Success /*&& sec is not null*/)
            {
                Debug.Assert(sec is not null, $"{nameof(sec)} must not be null");

                if (logger.DebugEnabled)
                {
                    logger.Debug($"\tFileSystemSecurity Result : {sec!.GetSecurityDescriptorSddlForm(sect)}");
                }

                var buffer = sec!.GetSecurityDescriptorBinaryForm();
                *rawSecurityDescriptorLengthNeeded = (uint)buffer.Length;
                if (buffer.Length > rawSecurityDescriptorLength)
                {
                    return DokanResult.BufferOverflow;
                }

                Marshal.Copy(buffer, 0, rawSecurityDescriptor, buffer.Length);
            }

            if (logger.DebugEnabled)
            {
                logger.Debug($"GetFileSecurityProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"GetFileSecurityProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    public NtStatus SetFileSecurityProxy(
        nint rawFileName,
        SECURITY_INFORMATION* rawSecurityInformation,
        nint rawSecurityDescriptor,
        uint rawSecurityDescriptorLength,
        DokanFileInfo* rawFileInfo)
    {
        var fileNamePtr = MemoryFromIntPtr(rawFileName);

        var sect = AccessControlSections.None;

        if (rawSecurityInformation->HasFlag(SECURITY_INFORMATION.OWNER_SECURITY_INFORMATION))
        {
            sect |= AccessControlSections.Owner;
        }

        if (rawSecurityInformation->HasFlag(SECURITY_INFORMATION.GROUP_SECURITY_INFORMATION))
        {
            sect |= AccessControlSections.Group;
        }

        if (rawSecurityInformation->HasFlag(SECURITY_INFORMATION.DACL_SECURITY_INFORMATION) ||
            rawSecurityInformation->HasFlag(SECURITY_INFORMATION.PROTECTED_DACL_SECURITY_INFORMATION) ||
            rawSecurityInformation->HasFlag(SECURITY_INFORMATION.UNPROTECTED_DACL_SECURITY_INFORMATION))
        {
            sect |= AccessControlSections.Access;
        }

        if (rawSecurityInformation->HasFlag(SECURITY_INFORMATION.SACL_SECURITY_INFORMATION) ||
            rawSecurityInformation->HasFlag(SECURITY_INFORMATION.PROTECTED_SACL_SECURITY_INFORMATION) ||
            rawSecurityInformation->HasFlag(SECURITY_INFORMATION.UNPROTECTED_SACL_SECURITY_INFORMATION))
        {
            sect |= AccessControlSections.Audit;
        }

        var buffer = new byte[rawSecurityDescriptorLength];

        try
        {
            Marshal.Copy(rawSecurityDescriptor, buffer, 0, (int)rawSecurityDescriptorLength);
            var sec = rawFileInfo->IsDirectory ? (FileSystemSecurity)new DirectorySecurity() : new FileSecurity();
            sec.SetSecurityDescriptorBinaryForm(buffer);

            if (logger.DebugEnabled)
            {
                logger.Debug($"SetFileSecurityProxy : {fileNamePtr}");
                logger.Debug($"\tAccessControlSections\t{sect}");
                logger.Debug($"\tFileSystemSecurity\t{sec.GetSecurityDescriptorSddlForm(sect)}");
                logger.Debug($"\tContext\t{*rawFileInfo}");
            }

            var result = operations.SetFileSecurity(fileNamePtr, sec, sect, ref *rawFileInfo);

            if (logger.DebugEnabled)
            {
                logger.Debug($"SetFileSecurityProxy : {fileNamePtr} Return : {result}");
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.Error($"SetFileSecurityProxy : {fileNamePtr} Throw : {ex.Message}");
            return ex.ToNtStatus();
        }
    }

    /// <summary>
    /// Converts the value of <paramref name="dateTime"/> to a Windows file time.
    /// If <paramref name="dateTime"/> is <c>null</c> or before 12:00 midnight January 1, 1601 C.E. UTC, it returns <c>0</c>.
    /// </summary>
    /// <param name="dateTime">
    /// The date Time.
    /// </param>
    /// <returns>
    /// The value of <paramref name="dateTime"/> expressed as a Windows file time
    /// -or- it returns <c>0</c> if <paramref name="dateTime"/> is before 12:00 midnight January 1, 1601 C.E. UTC or <c>null</c>.
    /// </returns>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365739(v=vs.85).aspx">WIN32_FILE_ATTRIBUTE_DATA structure (MSDN)</a>
    [Pure]
    private static long ToFileTime(DateTime? dateTime) => dateTime.HasValue && dateTime.Value >= DateTime.FromFileTime(0)
            ? dateTime.Value.ToFileTime()
            : 0;

    #region Nested type: FILL_FIND_FILE_DATA

    /// <summary>
    /// Used to add an entry in <see cref="FindFilesProxy"/> and <see cref="FindFilesWithPatternProxy"/>.
    /// </summary>
    /// <param name="rawFindData">A <see cref="WIN32_FIND_DATA"/>.</param>
    /// <param name="rawFileInfo">A <see cref="DokanFileInfo"/>.</param>
    /// <returns><c>1</c> if buffer is full, otherwise <c>0</c> (currently it never returns <c>1</c>)</returns>
    /// <remarks>This is the same delegate as <c>PFillFindData</c> (dokan.h) in the C++ version of Dokan.</remarks>
    private delegate long FILL_FIND_FILE_DATA(
        ref WIN32_FIND_DATA rawFindData, DokanFileInfo* rawFileInfo);

    #endregion Nested type: FILL_FIND_FILE_DATA

    #region Nested type: FILL_FIND_STREAM_DATA

    /// <summary>
    /// Used to add an entry in <see cref="FindStreamsProxy"/>.
    /// </summary>
    /// <param name="rawFindData">A <see cref="WIN32_FIND_STREAM_DATA"/>.</param>
    /// <param name="rawFileInfo">A <see cref="DokanFileInfo"/>.</param>
    /// <returns><c>1</c> if buffer is full, otherwise <c>0</c> (currently it never returns <c>1</c>)</returns>
    /// <remarks>This is the same delegate as <c>PFillFindStreamData</c> (dokan.h) in the C++ version of Dokan.</remarks>
    private delegate long FILL_FIND_STREAM_DATA(
        ref WIN32_FIND_STREAM_DATA rawFindData, DokanFileInfo* rawFileInfo);

    #endregion Nested type: FILL_FIND_STREAM_DATA
}

```

### DokanOptions.cs

```using System;
using DokanNet.Native;

namespace DokanNet
{
    /// <summary>
    /// Dokan mount options used to describe dokan device behavior. 
    /// </summary>
    /// \if PRIVATE
    /// <seealso cref="DOKAN_OPTIONS.Options"/>
    /// \endif
    [Flags]
    public enum DokanOptions : uint
    {
        /// <summary>Fixed Drive.</summary>
        FixedDrive = 0,

        /// <summary>Enable output debug message.</summary>
        DebugMode = 1,

        /// <summary>Enable output debug message to stderr.</summary>
        StderrOutput = 2,

        /// <summary>Use alternate stream.</summary>
        AltStream = 4,

        /// <summary>Enable mount drive as write-protected.</summary>
        WriteProtection = 8,

        /// <summary>Use network drive - Dokan network provider need to be installed.</summary>
        NetworkDrive = 16,

        /// <summary>Use removable drive.</summary>
        RemovableDrive = 32,

        /// <summary>Use mount manager.</summary>
        MountManager = 64,

        /// <summary>Mount the drive on current session only.</summary>
        CurrentSession = 128,

        /// <summary>Enable Lockfile/Unlockfile operations.</summary>
        UserModeLock = 256,

        /// <summary>
        /// Enable methods in <see cref="Dokan.Notify"/>, which require this library to maintain a special
        /// handle while the file system is mounted.
        /// Without this flag, the methods in that inner class always return false if invoked.
        /// </summary>
        EnableNotificationAPI = 512,

        /// <summary>
        /// Enable Case sensitive path.
        /// By default all path are case insensitive.
        /// For case sensitive: \\dir\\File and \\diR\\file are different files
        /// but for case insensitive they are the same.
        /// </summary>
        CaseSensitive = 1024,

        /// <summary>
        /// Enables unmounting of network drives via file explorer
        /// </summary>
        EnableNetworkUnmount = 2048,

        /// <summary>
        /// Forward the kernel driver global and volume logs to the userland
        /// </summary>
        DispatchDriverLogs = 4096,
    }
}

```

### DokanResult.cs

```namespace DokanNet;

/// <summary>
/// Defines common result status codes in <see cref="NtStatus"/> for %Dokan
/// operations.
/// </summary>
public static class DokanResult
{
    /// <summary>
    /// Success - The operation completed successfully.
    /// </summary>
    public const NtStatus Success = NtStatus.Success;

    /// <summary>
    /// Error - Incorrect function.
    /// </summary>
    public const NtStatus Error = NtStatus.Error;

    /// <summary>
    /// Error - The system cannot find the file specified.
    /// </summary>
    public const NtStatus FileNotFound = NtStatus.ObjectNameNotFound;

    /// <summary>
    /// Error - The system cannot find the path specified.
    /// </summary>
    public const NtStatus PathNotFound = NtStatus.ObjectPathNotFound;

    /// <summary>
    /// Error - Access is denied.
    /// </summary>
    public const NtStatus AccessDenied = NtStatus.AccessDenied;

    /// <summary>
    /// Error - The handle is invalid.
    /// </summary>
    public const NtStatus InvalidHandle = NtStatus.InvalidHandle;

    /// <summary>
    /// Warning - The device is not ready.
    /// </summary>
    public const NtStatus NotReady = NtStatus.DeviceBusy;

    /// <summary>
    /// Error - The process cannot access the file because it is being used
    /// by another process.
    /// </summary>
    public const NtStatus SharingViolation = NtStatus.SharingViolation;

    /// <summary>
    /// Error - The file exists.
    /// </summary>
    public const NtStatus FileExists = NtStatus.ObjectNameCollision;

    /// <summary>
    /// Error - There is not enough space on the disk.
    /// </summary>
    public const NtStatus DiskFull = NtStatus.DiskFull;

    /// <summary>
    /// Error - This function is not supported on this system.
    /// </summary>
    public const NtStatus NotImplemented = NtStatus.NotImplemented;

    /// <summary>
    /// Error - The data area passed to a system call is too small.
    /// </summary>
    public const NtStatus BufferTooSmall = NtStatus.BufferTooSmall;

    /// <summary>
    /// Warning - The data area passed to a system call is too small.
    /// </summary>
    public const NtStatus BufferOverflow = NtStatus.BufferOverflow;

    /// <summary>
    /// Error - The filename, directory name, or volume label syntax is
    /// incorrect.
    /// </summary>
    public const NtStatus InvalidName = NtStatus.ObjectNameInvalid;

    /// <summary>
    /// Error - The directory is not empty.
    /// </summary>
    public const NtStatus DirectoryNotEmpty = NtStatus.DirectoryNotEmpty;

    /// <summary>
    /// Error - Cannot create a file when that file already exists.
    /// </summary>
    public const NtStatus AlreadyExists = NtStatus.ObjectNameCollision;

    /// <summary>
    /// Error - An exception occurred in the service when handling the
    /// control request.
    /// </summary>
    public const NtStatus InternalError = NtStatus.InternalError;

    /// <summary>
    /// Error - A required privilege is not held by the client.
    /// </summary>
    public const NtStatus PrivilegeNotHeld = NtStatus.PrivilegeNotHeld;

    /// <summary>
    /// Error - The requested operation was unsuccessful.
    /// </summary>
    public const NtStatus Unsuccessful = NtStatus.Unsuccessful;

    /// <summary>
    /// Error - A directory semantics call was made but the accessed file was not a directory.
    /// </summary>
    public const NtStatus NotADirectory = NtStatus.NotADirectory;

    /// <summary>
    /// Error - The parameter is incorrect.
    /// </summary>
    public const NtStatus InvalidParameter = NtStatus.InvalidParameter;
}
```

### DokanStatus.cs

```namespace DokanNet
{
    /// <summary>
    /// Error codes returned by DokanMain.
    /// </summary>
    public enum DokanStatus : int
    {
        /// <summary>
        /// Dokan mount succeed.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Dokan mount error.
        /// </summary>
        Error = -1,

        /// <summary>
        /// Dokan mount failed - Bad drive letter.
        /// </summary>
        DriveLetterError = -2,

        /// <summary>
        /// Dokan mount failed - Can't install driver.
        /// </summary>
        DriverInstallError = -3,

        /// <summary>
        /// Dokan mount failed - Driver answer that something is wrong.
        /// </summary>
        StartError = -4,

        /// <summary>
        /// Dokan mount failed.
        /// Can't assign a drive letter or mount point.
        /// Probably already used by another volume.
        /// </summary>
        MountError = -5,

        /// <summary>
        /// Dokan mount failed.
        /// Mount point is invalid.
        /// </summary>
        MountPointError = -6,

        /// <summary>
        /// Dokan mount failed.
        /// Requested an incompatible version.
        /// </summary>
        VersionError = -7
    }
}

```

### FileAccess.cs

```using System;

namespace DokanNet
{
    /// <summary>
    /// Defines standard, specific, and generic rights. 
    /// These rights are used in access control entries (ACEs) and are the primary means of 
    /// specifying the requested or granted access to an object. 
    /// </summary>
    /// <remarks>
    /// This extends the <c><see cref="System.IO.FileAccess"/></c> enumerator in .NET that only 
    /// contains flags for <c>Read</c> (<c>0x01</c>) and <c>Write</c> (<c>0x10</c>).
    /// </remarks>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa374896(v=vs.85).aspx">Access Mask Format (MSDN)</a>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa374892(v=vs.85).aspx">ACCESS_MASK (MSDN)</a>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/4z36sx0f.aspx">FileAccess Enumeration (MSDN)</a>
    [Flags]
    public enum FileAccess : long
    {
        /// <summary>
        /// No access defined.
        /// </summary>
        None = 0,

        /// <summary>
        /// Read access right to an object.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{FILE_READ_DATA,0x00000001,File &amp; pipe}
        /// \nativeconst{FILE_LIST_DIRECTORY,0x00000001,Directory}
        /// \endtable
        /// \endnative
        ReadData = 1,

        /// <summary>
        /// Write access right to an object.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{FILE_WRITE_DATA,0x00000002,File &amp; pipe}
        /// \nativeconst{FILE_ADD_FILE,0x00000002,Directory}
        /// \endtable
        /// \endnative
        WriteData = 1L << 1,

        /// <summary>
        /// For a file object, the right to append data to the file.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{FILE_APPEND_DATA,0x00000004,File}
        /// \nativeconst{FILE_ADD_SUBDIRECTORY,0x00000004,Directory}
        /// \nativeconst{FILE_CREATE_PIPE_INSTANCE,0x00000004,Named pipe}
        /// \endtable
        /// \endnative
        AppendData = 1L << 2,

        /// <summary>
        /// The right to read extended file attributes.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{FILE_READ_EA,0x00000008,File &amp; directory}
        /// \endtable
        /// \endnative
        ReadExtendedAttributes = 1L << 3,

        /// <summary>
        /// The right to write extended file attributes.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{FILE_WRITE_EA,0x00000010,File &amp; directory}
        /// \endtable
        /// \endnative
        WriteExtendedAttributes = 1L << 4,

        /// <summary>
        /// For a native code file, the right to execute the file.
        /// This access right given to scripts may cause the script to be executable, depending on the script interpreter.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{FILE_EXECUTE,0x00000020,File}
        /// \nativeconst{FILE_TRAVERSE,0x00000020,Directory}
        /// \endtable
        /// \endnative
        Execute = 1L << 5,

        /// <summary>
        /// For a directory, the right to delete a directory and all the files it contains, including read-only files.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{FILE_DELETE_CHILD,0x00000040,Directory}
        /// \endtable
        /// \endnative
        DeleteChild = 1L << 6,

        /// <summary>
        /// The right to read file attributes.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{FILE_READ_ATTRIBUTES,0x00000080,All}
        /// \endtable
        /// \endnative
        ReadAttributes = 1L << 7,

        /// <summary>
        /// The right to write file attributes.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{FILE_WRITE_ATTRIBUTES,0x00000100,All}
        /// \endtable
        /// \endnative
        WriteAttributes = 1L << 8,

        /// <summary>
        /// The right to delete the object.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{DELETE,0x00010000}
        /// \endtable
        /// \endnative
        Delete = 1L << 16,

        /// <summary>
        /// The right to read the information in the object's security descriptor, 
        /// not including the information in the system access control list (SACL).
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{READ_CONTROL,0x00020000}
        /// \endtable
        /// \endnative
        ReadPermissions = 1L << 17,

        /// <summary>
        /// The right to modify the discretionary access control list (DACL) in 
        /// the object's security descriptor.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{WRITE_DAC,0x00040000}
        /// \endtable
        /// \endnative
        ChangePermissions = 1L << 18,

        /// <summary>
        /// The right to change the owner in the object's security descriptor.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{WRITE_OWNER,0x00080000}
        /// \endtable
        /// \endnative
        SetOwnership = 1L << 19,

        /// <summary>
        /// The right to use the object for synchronization. 
        /// This enables a thread to wait until the object is in the signaled state. 
        /// Some object types do not support this access right.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{SYNCHRONIZE,0x00100000}
        /// \endtable
        /// \endnative
        Synchronize = 1L << 20,

        /// <summary>
        /// Obsolete, use <see cref="FileAccess.AccessSystemSecurity"/> instead. 
        /// </summary>
        [Obsolete("Use AccessSystemSecurity instead")]
        Reserved = AccessSystemSecurity,

        /// <summary>
        /// Access system security. 
        /// It is used to indicate access to a system access control list (SACL). 
        /// This type of access requires the calling process to have the <c>SE_SECURITY_NAME</c> 
        /// (Manage auditing and security log) privilege. If this flag is set in 
        /// the access mask of an audit access ACE (successful or unsuccessful access), 
        /// the SACL access will be audited.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{ACCESS_SYSTEM_SECURITY,0x01000000}
        /// \endtable
        /// \endnative
        AccessSystemSecurity = 1L << 24,

        /// <summary>
        /// All the access rights that are valid for the caller.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{MAXIMUM_ALLOWED,0x02000000}
        /// \endtable
        /// \endnative
        MaximumAllowed = 1L << 25,

        /// <summary>
        /// All possible access rights.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{GENERIC_ALL,0x10000000}
        /// \endtable
        /// \endnative
        GenericAll = 1L << 28,

        /// <summary>
        /// Generic execute access. 
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{GENERIC_EXECUTE,0x20000000}
        /// \endtable
        /// \endnative
        GenericExecute = 1L << 29,

        /// <summary>
        /// Generic write access.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{GENERIC_WRITE,0x40000000}
        /// \endtable
        /// \endnative
        GenericWrite = 1L << 30,

        /// <summary>
        /// Generic read access.
        /// </summary>
        /// \native
        /// \table
        /// \nativeconst{GENERIC_READ,0x80000000}
        /// \endtable
        /// \endnative
        GenericRead = 1L << 31
    }
}
```

### FileInformation.cs

```using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace DokanNet
{
    /// <summary>
    /// Used to provide file information to %Dokan during operations by
    ///  - <see cref="IDokanOperations.GetFileInformation"/>
    ///  - <see cref="IDokanOperations.FindFiles"/>
    ///  - <see cref="IDokanOperations.FindStreams"/> 
    ///  - <see cref="IDokanOperations.FindFilesWithPattern"/>.
    /// </summary>
    [StructLayout(LayoutKind.Auto)]
    [DebuggerDisplay("{FileName}, {Length}, {CreationTime}, {LastWriteTime}, {LastAccessTime}, {Attributes}")]
    public struct FileInformation
    {
        /// <summary>
        /// Gets or sets the name of the file or directory.
        /// <see cref="IDokanOperations.GetFileInformation"/> required the file path
        /// when other operations only need the file name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the <c><see cref="FileAttributes"/></c> for the file or directory.
        /// </summary>
        public FileAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the file or directory.
        /// If equal to <c>null</c>, the value will not be set or the file has no creation time.
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the last access time of the file or directory.
        /// If equal to <c>null</c>, the value will not be set or the file has no last access time.
        /// </summary>
        public DateTime? LastAccessTime { get; set; }

        /// <summary>
        /// Gets or sets the last write time of the file or directory.
        /// If equal to <c>null</c>, the value will not be set or the file has no last write time.
        /// </summary>
        public DateTime? LastWriteTime { get; set; }

        /// <summary>
        /// Gets or sets the length of the file.
        /// </summary>
        public long Length { get; set; }
    }
}
```

### FileSystemFeatures.cs

```using System;

namespace DokanNet;

/// <summary>
/// Defines feature flags for the file system.
/// </summary>
/// \see <a href="https://msdn.microsoft.com/en-us/library/cc246323.aspx">File System Attribute Extensions (MSDN)</a>
[Flags]
#pragma warning disable 3009
public enum FileSystemFeatures : uint
#pragma warning restore 3009
{
    /// <summary>
    /// No features defined.
    /// </summary>
    None = 0,

    /// <summary>
    /// The file system supports case-sensitive file names.
    /// </summary>
    CaseSensitiveSearch = 1,

    /// <summary>
    /// The file system preserves the case of file names when it stores the name on disk.
    /// </summary>
    CasePreservedNames = 2,

    /// <summary>
    /// The file system supports Unicode in file names.
    /// </summary>
    UnicodeOnDisk = 4,

    /// <summary>
    /// The file system preserves and enforces access control lists.
    /// </summary>
    PersistentAcls = 8,

    /// <summary>
    /// The file system supports per-user quotas.
    /// </summary>
    VolumeQuotas = 0x20,

    /// <summary>
    /// The file system supports sparse files.
    /// 
    /// This feature allows programs to create very large files, but to consume disk space only as needed.
    /// A sparse file is a file that contains much of zeros, and a file system that support
    /// this are removing repeating zeros to save space.
    /// </summary>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365564(v=vs.85).aspx">Sparse Files (MSDN)</a>
    SupportsSparseFiles = 0x40,

    /// <summary>
    /// The file system supports reparse points.
    /// 
    /// Programs can trap open operations against objects in the file system and run their
    /// own code before returning file data. This feature can be used to extend file 
    /// system features such as mount points, which you can use to redirect data read
    /// and written from a folder to another volume or physical disk.
    /// </summary>
    SupportsReparsePoints = 0x80,

    /// <summary>
    /// The file system supports remote storage.
    /// </summary>
    SupportsRemoteStorage = 0x100,

    /// <summary>
    /// Volume is a compressed volume. This flag is incompatible with FILE_FILE_COMPRESSION.
    /// This does not affect how data is transferred over the network.
    /// </summary>
    VolumeIsCompressed = 0x00008000,

    /// <summary>
    /// File system supports object identifiers.
    /// </summary>
    SupportsObjectIDs = 0x00010000,

    /// <summary>
    /// File system supports encryption.
    /// </summary>
    SupportsEncryption = 0x00020000,

    /// <summary>
    /// File system supports multiple named data streams for a file.
    /// 
    /// The unnamed data stream is the stream where the content in the file is stored.
    /// A named stream is a stream where extra data can be stored. The data is connected to the file
    /// and if the file is moved, the data is copied to the new place if that file system support it.
    /// \see <a href="https://blogs.technet.microsoft.com/askcore/2013/03/24/alternate-data-streams-in-ntfs/">Alternate Data Streams in NTFS (TechNet)</a>
    /// </summary>
    NamedStreams = 0x00040000,

    /// <summary>
    /// Specified volume is read-only.
    /// </summary>
    ReadOnlyVolume = 0x00080000,

    /// <summary>
    /// Specified volume can be written to one time only. The write MUST be performed in sequential order.
    /// </summary>
    SequentialWriteOnce = 0x00100000,

    /// <summary>
    /// The file system supports transaction processing to group changes to files into a transaction.
    /// The transaction will guarantee that all changes happens, or none of them.
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365993(v=vs.85).aspx">About KTM (MSDN)</a>
    /// </summary>
    SupportsTransactions = 0x00200000
}
```

### FindFileInformation.cs

```using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace DokanNet;

/// <summary>
/// Used to provide file information to %Dokan during operations by
///  - <see cref="IDokanOperations.GetFileInformation"/>
///  - <see cref="IDokanOperations.FindFiles"/>
///  - <see cref="IDokanOperations.FindStreams"/> 
///  - <see cref="IDokanOperations.FindFilesWithPattern"/>.
/// </summary>
[StructLayout(LayoutKind.Auto)]
[DebuggerDisplay("{FileName}, {Length}, {CreationTime}, {LastWriteTime}, {LastAccessTime}, {Attributes}")]
public struct FindFileInformation
{
    /// <summary>
    /// Gets or sets the name of the file or directory.
    /// <see cref="IDokanOperations.GetFileInformation"/> required the file path
    /// when other operations only need the file name.
    /// </summary>
    public ReadOnlyMemory<char> FileName { get; set; }

    /// <summary>
    /// Gets or sets the <c><see cref="FileAttributes"/></c> for the file or directory.
    /// </summary>
    public FileAttributes Attributes { get; set; }

    /// <summary>
    /// Gets or sets the creation time of the file or directory.
    /// If equal to <c>null</c>, the value will not be set or the file has no creation time.
    /// </summary>
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// Gets or sets the last access time of the file or directory.
    /// If equal to <c>null</c>, the value will not be set or the file has no last access time.
    /// </summary>
    public DateTime? LastAccessTime { get; set; }

    /// <summary>
    /// Gets or sets the last write time of the file or directory.
    /// If equal to <c>null</c>, the value will not be set or the file has no last write time.
    /// </summary>
    public DateTime? LastWriteTime { get; set; }

    /// <summary>
    /// Gets or sets the length of the file.
    /// </summary>
    public long Length { get; set; }

    /// <summary>
    /// Short file name in 8.3 format.
    /// </summary>
    public ReadOnlyMemory<char> ShortFileName { get; set; }

    /// <summary>
    /// Returns value of <see cref="FileName"/> property converted to a <see cref="string"/>.
    /// </summary>
    /// <returns></returns>
    public override readonly string ToString() => FileName.ToString();
}

```

### IDokanFileInfo.cs

```using System.Security.Principal;

namespace DokanNet
{
    /// <summary>
    /// %Dokan file information interface.
    /// </summary>
    /// <remarks>
    /// This interface can be inherited in order to testunit user <see cref="IDokanOperations"/> implementation.
    /// </remarks>
    public interface IDokanFileInfo
    {
        /// <summary>
        /// Gets or sets context that can be used to carry information between operation.
        /// The Context can carry whatever type like <c><see cref="System.IO.FileStream"/></c>, <c>struct</c>, <c>int</c>,
        /// or internal reference that will help the implementation understand the request context of the event.
        /// </summary>
        object? Context { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the file has to be delete
        /// during the <see cref="IDokanOperations.Cleanup"/> event.
        /// </summary>
        bool DeletePending { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it requesting a directory
        /// file. Must be set in <see cref="IDokanOperations.CreateFile"/> if
        /// the file appear to be a folder.
        /// </summary>
        bool IsDirectory { get; set; }

        /// <summary>
        /// Read or write directly from data source without cache.
        /// </summary>
        bool NoCache { get; }

        /// <summary>
        /// Read or write is paging IO.
        /// </summary>
        bool PagingIo { get; }

        /// <summary>
        /// Process id for the thread that originally requested a given I/O
        /// operation.
        /// </summary>
        int ProcessId { get; }

        /// <summary>
        /// Read or write is synchronous IO.
        /// </summary>
        bool SynchronousIo { get; }

        /// <summary>
        /// If <c>true</c>, write to the current end of file instead 
        /// of using the <c>Offset</c> parameter.
        /// </summary>
        bool WriteToEndOfFile { get; }

        /// <summary>
        /// This method needs to be called in <see cref="IDokanOperations.CreateFile"/>.
        /// </summary>
        /// <returns>An <c><see cref="WindowsIdentity"/></c> with the access token, 
        /// -or- <c>null</c> if the operation was not successful.</returns>
        WindowsIdentity GetRequestor();

        /// <summary>
        /// Extends the time out of the current IO operation in driver.
        /// </summary>
        /// <param name="milliseconds">Number of milliseconds to extend with.</param>
        /// <returns>If the operation was successful.</returns>
        bool TryResetTimeout(int milliseconds);
    }
}
```

### IDokanOperations.cs

```using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace DokanNet
{
    /// <summary>
    /// %Dokan API callbacks interface.
    /// 
    /// A interface of callbacks that describe all %Dokan API operation
    /// that will be called when Windows access to the file system.
    /// 
    /// All this callbacks can return <see cref="NtStatus.NotImplemented"/>
    /// if you dont want to support one of them. Be aware that returning such value to important callbacks
    /// such <see cref="CreateFile"/>/<see cref="ReadFile"/>/... would make the filesystem not working or unstable.
    /// </summary>
    /// <remarks>This is the same struct as <c>DOKAN_OPERATIONS</c> (dokan.h) in the C version of Dokan.</remarks>
    public interface IDokanOperations
    {
        /// <summary>
        /// CreateFile is called each time a request is made on a file system object.
        /// 
        /// In case <paramref name="mode"/> is <c><see cref="FileMode.OpenOrCreate"/></c> and
        /// <c><see cref="FileMode.Create"/></c> and CreateFile are successfully opening a already
        /// existing file, you have to return <see cref="DokanResult.AlreadyExists"/> instead of <see cref="NtStatus.Success"/>.
        /// 
        /// If the file is a directory, CreateFile is also called.
        /// In this case, CreateFile should return <see cref="NtStatus.Success"/> when that directory
        /// can be opened and <see cref="IDokanFileInfo.IsDirectory"/> must be set to <c>true</c>.
        /// On the other hand, if <see cref="IDokanFileInfo.IsDirectory"/> is set to <c>true</c>
        /// but the path target a file, you need to return <see cref="DokanResult.NotADirectory"/>
        /// 
        /// <see cref="IDokanFileInfo.Context"/> can be used to store data (like <c><see cref="FileStream"/></c>)
        /// that can be retrieved in all other request related to the context.
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="access">A <see cref="FileAccess"/> with permissions for file or directory.</param>
        /// <param name="share">Type of share access to other threads, which is specified as
        /// <see cref="FileShare.None"/> or any combination of <see cref="FileShare"/>.
        /// Device and intermediate drivers usually set ShareAccess to zero,
        /// which gives the caller exclusive access to the open file.</param>
        /// <param name="mode">Specifies how the operating system should open a file. See <a href="https://msdn.microsoft.com/en-us/library/system.io.filemode(v=vs.110).aspx">FileMode Enumeration (MSDN)</a>.</param>
        /// <param name="options">Represents advanced options for creating a FileStream object. See <a href="https://msdn.microsoft.com/en-us/library/system.io.fileoptions(v=vs.110).aspx">FileOptions Enumeration (MSDN)</a>.</param>
        /// <param name="attributes">Provides attributes for files and directories. See <a href="https://msdn.microsoft.com/en-us/library/system.io.fileattributes(v=vs.110).aspx">FileAttributes Enumeration (MSDN></a>.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// \see See <a href="https://msdn.microsoft.com/en-us/library/windows/hardware/ff566424(v=vs.85).aspx">ZwCreateFile (MSDN)</a> for more information about the parameters of this callback.
        NtStatus CreateFile(
            string fileName,
            FileAccess access,
            FileShare share,
            FileMode mode,
            FileOptions options,
            FileAttributes attributes,
            IDokanFileInfo info);

        /// <summary>
        /// Receipt of this request indicates that the last handle for a file object that is associated 
        /// with the target device object has been closed (but, due to outstanding I/O requests, 
        /// might not have been released). 
        /// 
        /// Cleanup is requested before <see cref="CloseFile"/> is called.
        /// </summary>
        /// <remarks>
        /// When <see cref="IDokanFileInfo.DeletePending"/> is <c>true</c>, you must delete the file in Cleanup.
        /// Refer to <see cref="DeleteFile"/> and <see cref="DeleteDirectory"/> for explanation.
        /// </remarks>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <seealso cref="DeleteFile"/>
        /// <seealso cref="DeleteDirectory"/>
        /// <seealso cref="CloseFile"/>
        void Cleanup(string fileName, IDokanFileInfo info);

        /// <summary>
        /// CloseFile is called at the end of the life of the context.
        /// 
        /// Receipt of this request indicates that the last handle of the file object that is associated 
        /// with the target device object has been closed and released. All outstanding I/O requests 
        /// have been completed or canceled.
        /// 
        /// CloseFile is requested after <see cref="Cleanup"/> is called.
        /// 
        /// Remainings in <see cref="IDokanFileInfo.Context"/> has to be cleared before return.
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <seealso cref="Cleanup"/>
        void CloseFile(string fileName, IDokanFileInfo info);

        /// <summary>
        /// ReadFile callback on the file previously opened in <see cref="CreateFile"/>.
        /// It can be called by different thread at the same time,
        /// therefor the read has to be thread safe.
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="buffer">Read buffer that has to be fill with the read result.
        /// The buffer size depend of the read size requested by the kernel.</param>
        /// <param name="bytesRead">Total number of bytes that has been read.</param>
        /// <param name="offset">Offset from where the read has to be proceed.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// <seealso cref="WriteFile"/>
        NtStatus ReadFile(string fileName, byte[] buffer, out int bytesRead, long offset, IDokanFileInfo info);

        /// <summary>
        /// WriteFile callback on the file previously opened in <see cref="CreateFile"/>
        /// It can be called by different thread at the same time,
        /// therefor the write/context has to be thread safe.
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="buffer">Data that has to be written.</param>
        /// <param name="bytesWritten">Total number of bytes that has been write.</param>
        /// <param name="offset">Offset from where the write has to be proceed.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// <seealso cref="ReadFile"/>
        NtStatus WriteFile(string fileName, byte[] buffer, out int bytesWritten, long offset, IDokanFileInfo info);

        /// <summary>
        /// Clears buffers for this context and causes any buffered data to be written to the file.
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        NtStatus FlushFileBuffers(string fileName, IDokanFileInfo info);

        /// <summary>
        /// Get specific informations on a file.
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="fileInfo"><see cref="FileInformation"/> struct to fill</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        NtStatus GetFileInformation(string fileName, out FileInformation fileInfo, IDokanFileInfo info);

        /// <summary>
        /// List all files in the path requested
        /// 
        /// <see cref="FindFilesWithPattern"/> is checking first. If it is not implemented or
        /// returns <see cref="NtStatus.NotImplemented"/>, then FindFiles is called.
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="files">A list of <see cref="FileInformation"/> to return.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// <seealso cref="FindFilesWithPattern"/>
        NtStatus FindFiles(string fileName, out IList<FileInformation> files, IDokanFileInfo info);

        /// <summary>
        /// Same as <see cref="FindFiles"/> but with a search pattern to filter the result.
        /// </summary>
        /// <param name="fileName">Path requested by the Kernel on the FileSystem.</param>
        /// <param name="searchPattern">Search pattern</param>
        /// <param name="files">A list of <see cref="FileInformation"/> to return.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// <seealso cref="FindFiles"/>
        NtStatus FindFilesWithPattern(
            string fileName,
            string searchPattern,
            out IList<FileInformation> files,
            IDokanFileInfo info);

        /// <summary>
        /// Set file attributes on a specific file.
        /// </summary>
        /// <remarks>SetFileAttributes and <see cref="SetFileTime"/> are called only if both of them are implemented.</remarks>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="attributes"><see cref="FileAttributes"/> to set on file</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        NtStatus SetFileAttributes(string fileName, FileAttributes attributes, IDokanFileInfo info);

        /// <summary>
        /// Set file times on a specific file.
        /// If <see cref="DateTime"/> is <c>null</c>, this should not be updated.
        /// </summary>
        /// <remarks><see cref="SetFileAttributes"/> and SetFileTime are called only if both of them are implemented.</remarks>
        /// <param name="fileName">File or directory name.</param>
        /// <param name="creationTime"><see cref="DateTime"/> when the file was created.</param>
        /// <param name="lastAccessTime"><see cref="DateTime"/> when the file was last accessed.</param>
        /// <param name="lastWriteTime"><see cref="DateTime"/> when the file was last written to.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        NtStatus SetFileTime(
            string fileName,
            DateTime? creationTime,
            DateTime? lastAccessTime,
            DateTime? lastWriteTime,
            IDokanFileInfo info);

        /// <summary>
        /// Check if it is possible to delete a file.
        /// </summary>
        /// <remarks>
        /// You should NOT delete the file in DeleteFile, but instead
        /// you must only check whether you can delete the file or not,
        /// and return <see cref="NtStatus.Success"/> (when you can delete it) or appropriate error
        /// codes such as <see cref="NtStatus.AccessDenied"/>, <see cref="NtStatus.ObjectNameNotFound"/>.
        ///
        /// DeleteFile will also be called with <see cref="IDokanFileInfo.DeletePending"/> set to <c>false</c>
        /// to notify the driver when the file is no longer requested to be deleted.
        /// 
        /// When you return <see cref="NtStatus.Success"/>, you get a <see cref="Cleanup"/> call afterwards with
        /// <see cref="IDokanFileInfo.DeletePending"/> set to <c>true</c> and only then you have to actually
        /// delete the file being closed.
        /// </remarks>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns>Return <see cref="DokanResult.Success"/> if file can be delete or <see cref="NtStatus"/> appropriate.</returns>
        /// <seealso cref="DeleteDirectory"/>
        /// <seealso cref="Cleanup"/>
        NtStatus DeleteFile(string fileName, IDokanFileInfo info);

        /// <summary>
        /// Check if it is possible to delete a directory.
        /// </summary>
        /// <remarks>
        /// You should NOT delete the file in <see cref="DeleteDirectory"/>, but instead
        /// you must only check whether you can delete the file or not,
        /// and return <see cref="NtStatus.Success"/> (when you can delete it) or appropriate error
        /// codes such as <see cref="NtStatus.AccessDenied"/>, <see cref="NtStatus.ObjectPathNotFound"/>,
        /// <see cref="NtStatus.ObjectNameNotFound"/>.
        ///
        /// DeleteFile will also be called with <see cref="IDokanFileInfo.DeletePending"/> set to <c>false</c>
        /// to notify the driver when the file is no longer requested to be deleted.
        ///
        /// When you return <see cref="NtStatus.Success"/>, you get a <see cref="Cleanup"/> call afterwards with
        /// <see cref="IDokanFileInfo.DeletePending"/> set to <c>true</c> and only then you have to actually
        /// delete the file being closed.
        /// </remarks>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns>Return <see cref="DokanResult.Success"/> if file can be delete or <see cref="NtStatus"/> appropriate.</returns>
        /// <seealso cref="DeleteFile"/>
        /// <seealso cref="Cleanup"/>
        NtStatus DeleteDirectory(string fileName, IDokanFileInfo info);

        /// <summary>
        /// Move a file or directory to a new location.
        /// </summary>
        /// <param name="oldName">Path to the file to move.</param>
        /// <param name="newName">Path to the new location for the file.</param>
        /// <param name="replace">If the file should be replaced if it already exist a file with path <paramref name="newName"/>.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        NtStatus MoveFile(string oldName, string newName, bool replace, IDokanFileInfo info);

        /// <summary>
        /// SetEndOfFile is used to truncate or extend a file (physical file size).
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="length">File length to set</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        NtStatus SetEndOfFile(string fileName, long length, IDokanFileInfo info);

        /// <summary>
        /// SetAllocationSize is used to truncate or extend a file.
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="length">File length to set</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        NtStatus SetAllocationSize(string fileName, long length, IDokanFileInfo info);

        /// <summary>
        /// Lock file at a specific offset and data length.
        /// This is only used if <see cref="DokanOptions.UserModeLock"/> is enabled.
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="offset">Offset from where the lock has to be proceed.</param>
        /// <param name="length">Data length to lock.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// <seealso cref="UnlockFile"/>
        NtStatus LockFile(string fileName, long offset, long length, IDokanFileInfo info);

        /// <summary>
        /// Unlock file at a specific offset and data length.
        /// This is only used if <see cref="DokanOptions.UserModeLock"/> is enabled.
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="offset">Offset from where the unlock has to be proceed.</param>
        /// <param name="length">Data length to lock.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// <seealso cref="LockFile"/>
        NtStatus UnlockFile(string fileName, long offset, long length, IDokanFileInfo info);

        /// <summary>
        /// Retrieves information about the amount of space that is available on a disk volume, which is the total amount of space, 
        /// the total amount of free space, and the total amount of free space available to the user that is associated with the calling thread.
        /// </summary>
        /// <remarks>
        /// Neither GetDiskFreeSpace nor <see cref="GetVolumeInformation"/> save the <see cref="IDokanFileInfo.Context"/>.
        /// Before these methods are called, <see cref="CreateFile"/> may not be called. (ditto <see cref="CloseFile"/> and <see cref="Cleanup"/>).
        /// </remarks>
        /// <param name="freeBytesAvailable">Amount of available space.</param>
        /// <param name="totalNumberOfBytes">Total size of storage space.</param>
        /// <param name="totalNumberOfFreeBytes">Amount of free space.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa364937(v=vs.85).aspx"> GetDiskFreeSpaceEx function (MSDN)</a>
        /// <seealso cref="GetVolumeInformation"/>
        NtStatus GetDiskFreeSpace(
            out long freeBytesAvailable,
            out long totalNumberOfBytes,
            out long totalNumberOfFreeBytes,
            IDokanFileInfo info);

        /// <summary>
        /// Retrieves information about the file system and volume associated with the specified root directory.
        /// </summary>
        /// <remarks>
        /// Neither GetVolumeInformation nor <see cref="GetDiskFreeSpace"/> save the <see cref="IDokanFileInfo.Context"/>.
        /// Before these methods are called, <see cref="CreateFile"/> may not be called. (ditto <see cref="CloseFile"/> and <see cref="Cleanup"/>).
        /// 
        /// <see cref="FileSystemFeatures.ReadOnlyVolume"/> is automatically added to the <paramref name="features"/> if <see cref="DokanOptions.WriteProtection"/> was
        /// specified when the volume was mounted.
        /// 
        /// If <see cref="NtStatus.NotImplemented"/> is returned, the %Dokan kernel driver use following settings by default:
        /// | Parameter                    | Default value                                                                                    |
        /// |------------------------------|--------------------------------------------------------------------------------------------------|
        /// | \a rawVolumeNameBuffer       | <c>"DOKAN"</c>                                                                                   |
        /// | \a rawVolumeSerialNumber     | <c>0x19831116</c>                                                                                |
        /// | \a rawMaximumComponentLength | <c>256</c>                                                                                       |
        /// | \a rawFileSystemFlags        | <c>CaseSensitiveSearch \|\| CasePreservedNames \|\| SupportsRemoteStorage \|\| UnicodeOnDisk</c> |
        /// | \a rawFileSystemNameBuffer   | <c>"NTFS"</c>                                                                                    |
        /// </remarks>
        /// <param name="volumeLabel">Volume name</param>
        /// <param name="features"><see cref="FileSystemFeatures"/> with features enabled on the volume.</param>
        /// <param name="fileSystemName">The name of the specified volume.</param>
        /// <param name="maximumComponentLength">File name component that the specified file system supports.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa364993(v=vs.85).aspx"> GetVolumeInformation function (MSDN)</a>
        NtStatus GetVolumeInformation(
            out string volumeLabel,
            out FileSystemFeatures features,
            out string fileSystemName,
            out uint maximumComponentLength,
            IDokanFileInfo info);

        /// <summary>
        /// Get specified information about the security of a file or directory. 
        /// </summary>
        /// <remarks>
        /// If <see cref="NtStatus.NotImplemented"/> is returned, dokan library will handle the request by
        /// building a sddl of the current process user with authenticate user rights for context menu.
        /// </remarks>
        /// \since Supported since version 0.6.0. You must specify the <see cref="Native.DOKAN_OPTIONS.Version"/> during <see cref="DokanInstance.DokanInstance"/>.
        /// 
        /// <param name="fileName">File or directory name.</param>
        /// <param name="security">A <see cref="FileSystemSecurity"/> with security information to return.</param>
        /// <param name="sections">A <see cref="AccessControlSections"/> with access sections to return.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// <seealso cref="SetFileSecurity"/>
        /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa446639(v=vs.85).aspx">GetFileSecurity function (MSDN)</a>
        NtStatus GetFileSecurity(
            string fileName,
            out FileSystemSecurity? security,
            AccessControlSections sections,
            IDokanFileInfo info);

        /// <summary>
        /// Sets the security of a file or directory object.
        /// </summary>
        /// \since Supported since version 0.6.0. You must specify the <see cref="Native.DOKAN_OPTIONS.Version"/> during <see cref="DokanInstance.DokanInstance"/>.
        /// 
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="security">A <see cref="FileSystemSecurity"/> with security information to set.</param>
        /// <param name="sections">A <see cref="AccessControlSections"/> with access sections on which.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// <seealso cref="GetFileSecurity"/>
        /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa379577(v=vs.85).aspx">SetFileSecurity function (MSDN)</a>
        NtStatus SetFileSecurity(
            string fileName,
            FileSystemSecurity security,
            AccessControlSections sections,
            IDokanFileInfo info);

        /// <summary>
        /// Is called when %Dokan succeed to mount the volume.
        /// 
        /// If <see cref="DokanOptions.MountManager"/> is enabled and the drive letter requested is busy,
        /// the <paramref name="mountPoint"/> can contain a different drive letter that the mount manager assigned us.
        /// </summary>
        /// <param name="mountPoint">The mount point assign to the instance.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// <see cref="Unmounted"/>
        NtStatus Mounted(string mountPoint, IDokanFileInfo info);

        /// <summary>
        /// Is called when %Dokan is unmounting the volume.
        /// </summary>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// <seealso cref="Mounted"/>
        NtStatus Unmounted(IDokanFileInfo info);

        /// <summary>
        /// Retrieve all NTFS Streams informations on the file.
        /// This is only called if <see cref="DokanOptions.AltStream"/> is enabled.
        /// </summary>
        /// <remarks>For files, the first item in <paramref name="streams"/> is information about the 
        /// default data stream <c>"::$DATA"</c>.</remarks>
        /// \since Supported since version 0.8.0. You must specify the <see cref="Native.DOKAN_OPTIONS.Version"/> during <see cref="DokanInstance.DokanInstance"/>.
        /// 
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="streams">List of <see cref="FileInformation"/> for each streams present on the file.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns>Return <see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa364424(v=vs.85).aspx">FindFirstStreamW function (MSDN)</a>
        /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365993(v=vs.85).aspx">About KTM (MSDN)</a>
        NtStatus FindStreams(string fileName, out IList<FileInformation> streams, IDokanFileInfo info);
    }
}
```

### IDokanOperations2.cs

```using LTRData.Extensions.Native.Memory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1021 // Avoid out parameters
#pragma warning disable CA1045 // Do not pass types by reference

namespace DokanNet;

/// <summary>
/// %Dokan API callbacks interface.
/// 
/// A interface of callbacks that describe all %Dokan API operation
/// that will be called when Windows access to the file system.
/// 
/// All this callbacks can return <see cref="NtStatus.NotImplemented"/>
/// if you dont want to support one of them. Be aware that returning such value to important callbacks
/// such <see cref="CreateFile"/>/<see cref="ReadFile"/>/... would make the filesystem not working or unstable.
/// </summary>
/// <remarks>This is the same struct as <c>DOKAN_OPERATIONS</c> (dokan.h) in the C version of Dokan.</remarks>
public interface IDokanOperations2
{
    /// <summary>
    /// Number of milliseconds between each automatic reset of timeout timer during enumeration
    /// of files returned from <see cref="FindFiles(ReadOnlyNativeMemory{char}, out IEnumerable{FindFileInformation}, ref DokanFileInfo)"/> and <see cref="FindFilesWithPattern(ReadOnlyNativeMemory{char}, ReadOnlyNativeMemory{char}, out IEnumerable{FindFileInformation}, ref DokanFileInfo)"/>.
    /// Set to zero (default) to disable this behavior.
    /// </summary>
    int DirectoryListingTimeoutResetIntervalMs { get; }

    /// <summary>
    /// CreateFile is called each time a request is made on a file system object.
    /// 
    /// In case <paramref name="mode"/> is <c><see cref="FileMode.OpenOrCreate"/></c> and
    /// <c><see cref="FileMode.Create"/></c> and CreateFile are successfully opening a already
    /// existing file, you have to return <see cref="DokanResult.AlreadyExists"/> instead of <see cref="NtStatus.Success"/>.
    /// 
    /// If the file is a directory, CreateFile is also called.
    /// In this case, CreateFile should return <see cref="NtStatus.Success"/> when that directory
    /// can be opened and <see cref="DokanFileInfo.IsDirectory"/> must be set to <c>true</c>.
    /// On the other hand, if <see cref="DokanFileInfo.IsDirectory"/> is set to <c>true</c>
    /// but the path target a file, you need to return <see cref="DokanResult.NotADirectory"/>
    /// 
    /// <see cref="DokanFileInfo.Context"/> can be used to store data (like <c><see cref="FileStream"/></c>)
    /// that can be retrieved in all other request related to the context.
    /// </summary>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="access">A <see cref="FileAccess"/> with permissions for file or directory.</param>
    /// <param name="share">Type of share access to other threads, which is specified as
    /// <see cref="FileShare.None"/> or any combination of <see cref="FileShare"/>.
    /// Device and intermediate drivers usually set ShareAccess to zero,
    /// which gives the caller exclusive access to the open file.</param>
    /// <param name="mode">Specifies how the operating system should open a file. See <a href="https://msdn.microsoft.com/en-us/library/system.io.filemode(v=vs.110).aspx">FileMode Enumeration (MSDN)</a>.</param>
    /// <param name="options">Represents advanced options for creating a FileStream object. See <a href="https://msdn.microsoft.com/en-us/library/system.io.fileoptions(v=vs.110).aspx">FileOptions Enumeration (MSDN)</a>.</param>
    /// <param name="attributes">Provides attributes for files and directories. See <a href="https://msdn.microsoft.com/en-us/library/system.io.fileattributes(v=vs.110).aspx">FileAttributes Enumeration (MSDN></a>.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// \see See <a href="https://msdn.microsoft.com/en-us/library/windows/hardware/ff566424(v=vs.85).aspx">ZwCreateFile (MSDN)</a> for more information about the parameters of this callback.
    NtStatus CreateFile(
        ReadOnlyNativeMemory<char> fileNamePtr,
        FileAccess access,
        FileShare share,
        FileMode mode,
        FileOptions options,
        FileAttributes attributes,
        ref DokanFileInfo info);

    /// <summary>
    /// Receipt of this request indicates that the last handle for a file object that is associated 
    /// with the target device object has been closed (but, due to outstanding I/O requests, 
    /// might not have been released). 
    /// 
    /// Cleanup is requested before <see cref="CloseFile"/> is called.
    /// </summary>
    /// <remarks>
    /// When <see cref="DokanFileInfo.DeletePending"/> is <c>true</c>, you must delete the file in Cleanup.
    /// Refer to <see cref="DeleteFile"/> and <see cref="DeleteDirectory"/> for explanation.
    /// </remarks>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <seealso cref="DeleteFile"/>
    /// <seealso cref="DeleteDirectory"/>
    /// <seealso cref="CloseFile"/>
    void Cleanup(ReadOnlyNativeMemory<char> fileNamePtr, ref DokanFileInfo info);

    /// <summary>
    /// CloseFile is called at the end of the life of the context.
    /// 
    /// Receipt of this request indicates that the last handle of the file object that is associated 
    /// with the target device object has been closed and released. All outstanding I/O requests 
    /// have been completed or canceled.
    /// 
    /// CloseFile is requested after <see cref="Cleanup"/> is called.
    /// 
    /// Remainings in <see cref="DokanFileInfo.Context"/> has to be cleared before return.
    /// </summary>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <seealso cref="Cleanup"/>
    void CloseFile(ReadOnlyNativeMemory<char> fileNamePtr, ref DokanFileInfo info);

    /// <summary>
    /// ReadFile callback on the file previously opened in <see cref="CreateFile"/>.
    /// It can be called by different thread at the same time,
    /// therefor the read has to be thread safe.
    /// </summary>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="buffer">Read buffer that has to be fill with the read result.
    /// The buffer size depend of the read size requested by the kernel.</param>
    /// <param name="bytesRead">Total number of bytes that has been read.</param>
    /// <param name="offset">Offset from where the read has to be proceed.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// <seealso cref="WriteFile"/>
    NtStatus ReadFile(ReadOnlyNativeMemory<char> fileNamePtr, NativeMemory<byte> buffer, out int bytesRead, long offset, ref DokanFileInfo info);

    /// <summary>
    /// WriteFile callback on the file previously opened in <see cref="CreateFile"/>
    /// It can be called by different thread at the same time,
    /// therefor the write/context has to be thread safe.
    /// </summary>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="buffer">Data that has to be written.</param>
    /// <param name="bytesWritten">Total number of bytes that has been write.</param>
    /// <param name="offset">Offset from where the write has to be proceed.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// <seealso cref="ReadFile"/>
    NtStatus WriteFile(ReadOnlyNativeMemory<char> fileNamePtr, ReadOnlyNativeMemory<byte> buffer, out int bytesWritten, long offset, ref DokanFileInfo info);

    /// <summary>
    /// Clears buffers for this context and causes any buffered data to be written to the file.
    /// </summary>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    NtStatus FlushFileBuffers(ReadOnlyNativeMemory<char> fileNamePtr, ref DokanFileInfo info);

    /// <summary>
    /// Get specific informations on a file.
    /// </summary>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="fileInfo"><see cref="ByHandleFileInformation"/> struct to fill</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    NtStatus GetFileInformation(ReadOnlyNativeMemory<char> fileNamePtr, out ByHandleFileInformation fileInfo, ref DokanFileInfo info);

    /// <summary>
    /// List all files in the path requested
    /// 
    /// <see cref="FindFilesWithPattern"/> is checking first. If it is not implemented or
    /// returns <see cref="NtStatus.NotImplemented"/>, then FindFiles is called.
    /// </summary>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="files">A list of <see cref="ByHandleFileInformation"/> to return.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// <seealso cref="FindFilesWithPattern"/>
    NtStatus FindFiles(ReadOnlyNativeMemory<char> fileNamePtr, out IEnumerable<FindFileInformation> files, ref DokanFileInfo info);

    /// <summary>
    /// Same as <see cref="FindFiles"/> but with a search pattern to filter the result.
    /// </summary>
    /// <param name="fileNamePtr">Path requested by the Kernel on the FileSystem.</param>
    /// <param name="searchPatternPtr">Search pattern</param>
    /// <param name="files">A list of <see cref="ByHandleFileInformation"/> to return.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// <seealso cref="FindFiles"/>
    NtStatus FindFilesWithPattern(
        ReadOnlyNativeMemory<char> fileNamePtr,
        ReadOnlyNativeMemory<char> searchPatternPtr,
        out IEnumerable<FindFileInformation> files,
        ref DokanFileInfo info);

    /// <summary>
    /// Set file attributes on a specific file.
    /// </summary>
    /// <remarks>SetFileAttributes and <see cref="SetFileTime"/> are called only if both of them are implemented.</remarks>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="attributes"><see cref="FileAttributes"/> to set on file</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    NtStatus SetFileAttributes(ReadOnlyNativeMemory<char> fileNamePtr, FileAttributes attributes, ref DokanFileInfo info);

    /// <summary>
    /// Set file times on a specific file.
    /// If <see cref="DateTime"/> is <c>null</c>, this should not be updated.
    /// </summary>
    /// <remarks><see cref="SetFileAttributes"/> and SetFileTime are called only if both of them are implemented.</remarks>
    /// <param name="fileNamePtr">File or directory name.</param>
    /// <param name="creationTime"><see cref="DateTime"/> when the file was created.</param>
    /// <param name="lastAccessTime"><see cref="DateTime"/> when the file was last accessed.</param>
    /// <param name="lastWriteTime"><see cref="DateTime"/> when the file was last written to.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    NtStatus SetFileTime(
        ReadOnlyNativeMemory<char> fileNamePtr,
        DateTime? creationTime,
        DateTime? lastAccessTime,
        DateTime? lastWriteTime,
        ref DokanFileInfo info);

    /// <summary>
    /// Check if it is possible to delete a file.
    /// </summary>
    /// <remarks>
    /// You should NOT delete the file in DeleteFile, but instead
    /// you must only check whether you can delete the file or not,
    /// and return <see cref="NtStatus.Success"/> (when you can delete it) or appropriate error
    /// codes such as <see cref="NtStatus.AccessDenied"/>, <see cref="NtStatus.ObjectNameNotFound"/>.
    ///
    /// DeleteFile will also be called with <see cref="DokanFileInfo.DeletePending"/> set to <c>false</c>
    /// to notify the driver when the file is no longer requested to be deleted.
    /// 
    /// When you return <see cref="NtStatus.Success"/>, you get a <see cref="Cleanup"/> call afterwards with
    /// <see cref="DokanFileInfo.DeletePending"/> set to <c>true</c> and only then you have to actually
    /// delete the file being closed.
    /// </remarks>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns>Return <see cref="DokanResult.Success"/> if file can be delete or <see cref="NtStatus"/> appropriate.</returns>
    /// <seealso cref="DeleteDirectory"/>
    /// <seealso cref="Cleanup"/>
    NtStatus DeleteFile(ReadOnlyNativeMemory<char> fileNamePtr, ref DokanFileInfo info);

    /// <summary>
    /// Check if it is possible to delete a directory.
    /// </summary>
    /// <remarks>
    /// You should NOT delete the file in <see cref="DeleteDirectory"/>, but instead
    /// you must only check whether you can delete the file or not,
    /// and return <see cref="NtStatus.Success"/> (when you can delete it) or appropriate error
    /// codes such as <see cref="NtStatus.AccessDenied"/>, <see cref="NtStatus.ObjectPathNotFound"/>,
    /// <see cref="NtStatus.ObjectNameNotFound"/>.
    ///
    /// DeleteFile will also be called with <see cref="DokanFileInfo.DeletePending"/> set to <c>false</c>
    /// to notify the driver when the file is no longer requested to be deleted.
    ///
    /// When you return <see cref="NtStatus.Success"/>, you get a <see cref="Cleanup"/> call afterwards with
    /// <see cref="DokanFileInfo.DeletePending"/> set to <c>true</c> and only then you have to actually
    /// delete the file being closed.
    /// </remarks>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns>Return <see cref="DokanResult.Success"/> if file can be delete or <see cref="NtStatus"/> appropriate.</returns>
    /// <seealso cref="DeleteFile"/>
    /// <seealso cref="Cleanup"/>
    NtStatus DeleteDirectory(ReadOnlyNativeMemory<char> fileNamePtr, ref DokanFileInfo info);

    /// <summary>
    /// Move a file or directory to a new location.
    /// </summary>
    /// <param name="oldNamePtr">Path to the file to move.</param>
    /// <param name="newNamePtr">Path to the new location for the file.</param>
    /// <param name="replace">If the file should be replaced if it already exist a file with path <paramref name="newNamePtr"/>.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    NtStatus MoveFile(ReadOnlyNativeMemory<char> oldNamePtr, ReadOnlyNativeMemory<char> newNamePtr, bool replace, ref DokanFileInfo info);

    /// <summary>
    /// SetEndOfFile is used to truncate or extend a file (physical file size).
    /// </summary>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="length">File length to set</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    NtStatus SetEndOfFile(ReadOnlyNativeMemory<char> fileNamePtr, long length, ref DokanFileInfo info);

    /// <summary>
    /// SetAllocationSize is used to truncate or extend a file.
    /// </summary>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="length">File length to set</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    NtStatus SetAllocationSize(ReadOnlyNativeMemory<char> fileNamePtr, long length, ref DokanFileInfo info);

    /// <summary>
    /// Lock file at a specific offset and data length.
    /// This is only used if <see cref="DokanOptions.UserModeLock"/> is enabled.
    /// </summary>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="offset">Offset from where the lock has to be proceed.</param>
    /// <param name="length">Data length to lock.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// <seealso cref="UnlockFile"/>
    NtStatus LockFile(ReadOnlyNativeMemory<char> fileNamePtr, long offset, long length, ref DokanFileInfo info);

    /// <summary>
    /// Unlock file at a specific offset and data length.
    /// This is only used if <see cref="DokanOptions.UserModeLock"/> is enabled.
    /// </summary>
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="offset">Offset from where the unlock has to be proceed.</param>
    /// <param name="length">Data length to lock.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// <seealso cref="LockFile"/>
    NtStatus UnlockFile(ReadOnlyNativeMemory<char> fileNamePtr, long offset, long length, ref DokanFileInfo info);

    /// <summary>
    /// Retrieves information about the amount of space that is available on a disk volume, which is the total amount of space, 
    /// the total amount of free space, and the total amount of free space available to the user that is associated with the calling thread.
    /// </summary>
    /// <remarks>
    /// Neither GetDiskFreeSpace nor <see cref="GetVolumeInformation"/> save the <see cref="DokanFileInfo.Context"/>.
    /// Before these methods are called, <see cref="CreateFile"/> may not be called. (ditto <see cref="CloseFile"/> and <see cref="Cleanup"/>).
    /// </remarks>
    /// <param name="freeBytesAvailable">Amount of available space.</param>
    /// <param name="totalNumberOfBytes">Total size of storage space.</param>
    /// <param name="totalNumberOfFreeBytes">Amount of free space.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa364937(v=vs.85).aspx"> GetDiskFreeSpaceEx function (MSDN)</a>
    /// <seealso cref="GetVolumeInformation"/>
    NtStatus GetDiskFreeSpace(
        out long freeBytesAvailable,
        out long totalNumberOfBytes,
        out long totalNumberOfFreeBytes,
        ref DokanFileInfo info);

    /// <summary>
    /// Retrieves information about the file system and volume associated with the specified root directory.
    /// </summary>
    /// <remarks>
    /// Neither GetVolumeInformation nor <see cref="GetDiskFreeSpace"/> save the <see cref="DokanFileInfo.Context"/>.
    /// Before these methods are called, <see cref="CreateFile"/> may not be called. (ditto <see cref="CloseFile"/> and <see cref="Cleanup"/>).
    /// 
    /// <see cref="FileSystemFeatures.ReadOnlyVolume"/> is automatically added to the <paramref name="features"/> if <see cref="DokanOptions.WriteProtection"/> was
    /// specified when the volume was mounted.
    /// 
    /// If <see cref="NtStatus.NotImplemented"/> is returned, the %Dokan kernel driver use following settings by default:
    /// | Parameter                    | Default value                                                                                    |
    /// |------------------------------|--------------------------------------------------------------------------------------------------|
    /// | \a rawVolumeNameBuffer       | <c>"DOKAN"</c>                                                                                   |
    /// | \a rawVolumeSerialNumber     | <c>0x19831116</c>                                                                                |
    /// | \a rawMaximumComponentLength | <c>256</c>                                                                                       |
    /// | \a rawFileSystemFlags        | <c>CaseSensitiveSearch \|\| CasePreservedNames \|\| SupportsRemoteStorage \|\| UnicodeOnDisk</c> |
    /// | \a rawFileSystemNameBuffer   | <c>"NTFS"</c>                                                                                    |
    /// </remarks>
    /// <param name="volumeLabel">Volume name</param>
    /// <param name="features"><see cref="FileSystemFeatures"/> with features enabled on the volume.</param>
    /// <param name="fileSystemName">The name of the specified volume.</param>
    /// <param name="maximumComponentLength">File name component that the specified file system supports.</param>
    /// <param name="volumeSerialNumber"></param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa364993(v=vs.85).aspx"> GetVolumeInformation function (MSDN)</a>
    NtStatus GetVolumeInformation(
        NativeMemory<char> volumeLabel,
        out FileSystemFeatures features,
        NativeMemory<char> fileSystemName,
        out uint maximumComponentLength,
        ref uint volumeSerialNumber,
        ref DokanFileInfo info);

    /// <summary>
    /// Get specified information about the security of a file or directory. 
    /// </summary>
    /// <remarks>
    /// If <see cref="NtStatus.NotImplemented"/> is returned, dokan library will handle the request by
    /// building a sddl of the current process user with authenticate user rights for context menu.
    /// </remarks>
    /// \since Supported since version 0.6.0. You must specify the <see cref="Native.DOKAN_OPTIONS.Version"/> during <see cref="DokanInstance.DokanInstance"/>.
    /// 
    /// <param name="fileNamePtr">File or directory name.</param>
    /// <param name="security">A <see cref="FileSystemSecurity"/> with security information to return.</param>
    /// <param name="sections">A <see cref="AccessControlSections"/> with access sections to return.</param>
    /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// <seealso cref="SetFileSecurity"/>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa446639(v=vs.85).aspx">GetFileSecurity function (MSDN)</a>
    NtStatus GetFileSecurity(
        ReadOnlyNativeMemory<char> fileNamePtr,
        out FileSystemSecurity? security,
        AccessControlSections sections,
        ref DokanFileInfo info);

    /// <summary>
    /// Sets the security of a file or directory object.
    /// </summary>
    /// \since Supported since version 0.6.0. You must specify the <see cref="Native.DOKAN_OPTIONS.Version"/> during <see cref="DokanInstance.DokanInstance"/>.
    /// 
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="security">A <see cref="FileSystemSecurity"/> with security information to set.</param>
    /// <param name="sections">A <see cref="AccessControlSections"/> with access sections on which.</param>
    /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// <seealso cref="GetFileSecurity"/>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa379577(v=vs.85).aspx">SetFileSecurity function (MSDN)</a>
    NtStatus SetFileSecurity(
        ReadOnlyNativeMemory<char> fileNamePtr,
        FileSystemSecurity security,
        AccessControlSections sections,
        ref DokanFileInfo info);

    /// <summary>
    /// Is called when %Dokan succeed to mount the volume.
    /// 
    /// If <see cref="DokanOptions.MountManager"/> is enabled and the drive letter requested is busy,
    /// the <paramref name="mountPoint"/> can contain a different drive letter that the mount manager assigned us.
    /// </summary>
    /// <param name="mountPoint">The mount point assign to the instance.</param>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// <see cref="Unmounted"/>
    NtStatus Mounted(ReadOnlyNativeMemory<char> mountPoint, ref DokanFileInfo info);

    /// <summary>
    /// Is called when %Dokan is unmounting the volume.
    /// </summary>
    /// <param name="info">An <see cref="DokanFileInfo"/> with information about the file or directory.</param>
    /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// <seealso cref="Mounted"/>
    NtStatus Unmounted(ref DokanFileInfo info);

    /// <summary>
    /// Retrieve all NTFS Streams informations on the file.
    /// This is only called if <see cref="DokanOptions.AltStream"/> is enabled.
    /// </summary>
    /// <remarks>For files, the first item in <paramref name="streams"/> is information about the 
    /// default data stream <c>"::$DATA"</c>.</remarks>
    /// \since Supported since version 0.8.0. You must specify the <see cref="Native.DOKAN_OPTIONS.Version"/> during <see cref="DokanInstance.DokanInstance"/>.
    /// 
    /// <param name="fileNamePtr">File path requested by the Kernel on the FileSystem.</param>
    /// <param name="streams">List of <see cref="FileInformation"/> for each streams present on the file.</param>
    /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
    /// <returns>Return <see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa364424(v=vs.85).aspx">FindFirstStreamW function (MSDN)</a>
    /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365993(v=vs.85).aspx">About KTM (MSDN)</a>
    NtStatus FindStreams(ReadOnlyNativeMemory<char> fileNamePtr, out IEnumerable<FindFileInformation> streams, ref DokanFileInfo info);
}

```

### IDokanOperationsUnsafe.cs

```using System;

namespace DokanNet
{
    /// <summary>
    /// This is a sub-interface of <see cref="IDokanOperations"/> that can optionally be implemented
    /// to get access to the raw, unmanaged buffers for ReadFile() and WriteFile() for performance optimization.
    /// Marshalling the unmanaged buffers to and from byte[] arrays for every call of these APIs incurs an extra copy
    /// that can be avoided by reading from or writing directly to the unmanaged buffers.
    /// 
    /// Implementation of this interface is optional. If it is implemented, the overloads of
    /// Read/WriteFile(IntPtr, length) will be called instead of Read/WriteFile(byte[]). The caller can fill or read
    /// from the unmanaged API with Marshal.Copy, Buffer.MemoryCopy or similar.
    /// </summary>
    public interface IDokanOperationsUnsafe : IDokanOperations
    {
        /// <summary>
        /// ReadFile callback on the file previously opened in <see cref="IDokanOperations.CreateFile"/>.
        /// It can be called by different thread at the same time,
        /// therefore the read has to be thread safe.
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="buffer">Read buffer that has to be fill with the read result.</param>
        /// <param name="bufferLength">The size of 'buffer' in bytes.
        /// The buffer size depends of the read size requested by the kernel.</param>
        /// <param name="bytesRead">Total number of bytes that has been read.</param>
        /// <param name="offset">Offset from where the read has to be proceed.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// <seealso cref="WriteFile"/>
        NtStatus ReadFile(string fileName, IntPtr buffer, uint bufferLength, out int bytesRead, long offset, IDokanFileInfo info);

        /// <summary>
        /// WriteFile callback on the file previously opened in <see cref="IDokanOperations.CreateFile"/>
        /// It can be called by different thread at the same time,
        /// therefore the write/context has to be thread safe.
        /// </summary>
        /// <param name="fileName">File path requested by the Kernel on the FileSystem.</param>
        /// <param name="buffer">Data that has to be written.</param>
        /// <param name="bufferLength">The size of 'buffer' in bytes.</param>
        /// <param name="bytesWritten">Total number of bytes that has been write.</param>
        /// <param name="offset">Offset from where the write has to be proceed.</param>
        /// <param name="info">An <see cref="IDokanFileInfo"/> with information about the file or directory.</param>
        /// <returns><see cref="NtStatus"/> or <see cref="DokanResult"/> appropriate to the request result.</returns>
        /// <seealso cref="ReadFile"/>
        NtStatus WriteFile(string fileName, IntPtr buffer, uint bufferLength, out int bytesWritten, long offset, IDokanFileInfo info);
    }
}

```

### MockDokanFileInfo.cs

```using System.Runtime.Versioning;
using System.Security.Principal;
using DokanNet.Native;
using static DokanNet.FormatProviders;

#pragma warning disable 649,169

namespace DokanNet
{
    /// <summary>
    /// Mockable Dokan file information on the current operation.
    /// </summary>
    /// <remarks>
    /// Because <see cref="DokanFileInfo"/> cannot be instantiated in C#, it's very difficult to write
    /// test harnesses for unit testing.  This class implements the same public interface so it's
    /// possible to mock it, such that the implementor of IDokanOperations can essentially act like
    /// the dokany kernel driver and call into that implementation to verify correct behavior.  It
    /// also has support methods available to cause it (and the Dokan.Net library) to behave in certain
    /// ways useful for testing all potential returns, both success and failure.
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("windows")]
#endif
    public sealed class MockDokanFileInfo : IDokanFileInfo
    {
        /// <summary>
        /// A <see cref="DOKAN_OPTIONS"/> structure used to help the kernel notification functions work.
        /// </summary>
        private DOKAN_OPTIONS _dokanOptions = new DOKAN_OPTIONS();

        /// <summary>
        /// This must be set to a potentially valid path. Examples might be @"M:\\" or @"C:\\JunctionPoint".
        /// </summary>
        /// <remarks>The trailing backslash is not optional for drive letters, and must be omitted for paths.</remarks>
        public string? MountPoint
        {
            get => _dokanOptions.MountPoint;
            set => _dokanOptions.MountPoint = value;
        }

        /// <summary>
        /// Gets or sets context that can be used to carry information between operation.
        /// The Context can carry an arbitrary type, like <c><see cref="System.IO.FileStream"/></c>, <c>struct</c>, <c>int</c>,
        /// or internal reference that will help the implementation understand the request context of the event.
        /// </summary>
        public object? Context
        {
            get; set;
        }

        /// <summary>
        /// Process id for the thread that originally requested a given I/O
        /// operation.
        /// </summary>
        public int ProcessId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a filename references a directory.
        /// Must be set in <see cref="IDokanOperations.CreateFile"/> if the file is to
        /// appear to be a folder.
        /// </summary>
        public bool IsDirectory { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the file has to be deleted
        /// during the <see cref="IDokanOperations.Cleanup"/> event.
        /// </summary>
        public bool DeletePending { get; set; }

        /// <summary>
        /// Read or write is paging IO.
        /// </summary>
        public bool PagingIo { get; set; }

        /// <summary>
        /// Read or write is synchronous IO.
        /// </summary>
        public bool SynchronousIo { get; set; }

        /// <summary>
        /// Read or write directly from data source without cache.
        /// </summary>
        public bool NoCache { get; set; }

        /// <summary>
        /// If <c>true</c>, write to the current end of file instead 
        /// of using the <c>Offset</c> parameter.
        /// </summary>
        public bool WriteToEndOfFile { get; set; }

        /// <summary>
        /// Set this to null if you want to test against token unavailability.
        /// </summary>
        /// <remarks>Initialized to the current process token, which is the only
        /// token a standard user account can get.</remarks>
        public WindowsIdentity WhatGetRequestorShouldReturn = WindowsIdentity.GetCurrent();

        /// <summary>
        /// This method needs to be called in <see cref="IDokanOperations.CreateFile"/> to
        /// determine what account and what privileges are available to the filesystem client.
        /// </summary>
        /// <returns>An <c><see cref="WindowsIdentity"/></c> with the access token, 
        /// -or- <c>null</c> if the operation was not successful.</returns>
        /// <remarks>This Mock implementation returns <see cref="WhatGetRequestorShouldReturn"/>.
        /// </remarks>
        public WindowsIdentity GetRequestor() => WhatGetRequestorShouldReturn;

        /// <summary>
        /// Set this to false if you want to test against TryResetTimeout failure
        /// </summary>
        public bool WhatTryResetTimeoutShouldReturn { get; set; }

        /// <summary>
        /// Extends the time out of the current IO operation in driver.
        /// </summary>
        /// <param name="milliseconds">Number of milliseconds to extend with.</param>
        /// <returns>true if the operation was successful.</returns>
        /// <remarks>This Mock implementation returns <see cref="WhatTryResetTimeoutShouldReturn"/>.
        /// </remarks>
        public bool TryResetTimeout(int milliseconds) => WhatTryResetTimeoutShouldReturn;

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return
                DokanFormat(
                    $"mock: {{{Context}, {DeletePending}, {IsDirectory}, {NoCache}, {PagingIo}, #{ProcessId}, {SynchronousIo}, {WriteToEndOfFile}}}");
        }
    }
}

#pragma warning restore 649, 169
```

### NtStatus.cs

```namespace DokanNet;

/// <summary>
/// NT status values.
/// </summary>
/// \see <a href="https://msdn.microsoft.com/en-us/library/cc704588.aspx">NTSTATUS Values (MSDN)</a>
public enum NtStatus : long
{
    // ***********
    // * Success *
    // ***********

    /// <summary>
    /// Success - The operation completed successfully.
    /// </summary>
    Success = 0x00000000,

    /// <summary>
    /// Success - The caller specified WaitAny for WaitType and one of the dispatcher objects in 
    /// the Object array has been set to the signaled state.
    /// </summary>
    Wait1 = 0x00000001,

    /// <summary>
    /// Success - The caller specified WaitAny for WaitType and one of the dispatcher objects in 
    /// the Object array has been set to the signaled state.
    /// </summary>
    Wait2 = 0x00000002,

    /// <summary>
    /// Success - The caller specified WaitAny for WaitType and one of the dispatcher objects in 
    /// the Object array has been set to the signaled state.
    /// </summary>
    Wait3 = 0x00000003,

    /// <summary>
    /// Success - The caller specified WaitAny for WaitType and one of the dispatcher objects in 
    /// the Object array has been set to the signaled state.
    /// </summary>
    Wait63 = 0x0000003f,

    /// <summary>
    /// Success - The caller attempted to wait for a mutex that has been abandoned.
    /// </summary>
    Abandoned = AbandonedWait0,

    /// <summary>
    /// Success - The caller attempted to wait for a mutex that has been abandoned.
    /// </summary>
    AbandonedWait0 = 0x00000080,

    /// <summary>
    /// Success - The caller attempted to wait for a mutex that has been abandoned.
    /// </summary>
    AbandonedWait1 = 0x00000081,

    /// <summary>
    /// Success - The caller attempted to wait for a mutex that has been abandoned.
    /// </summary>
    AbandonedWait2 = 0x00000082,

    /// <summary>
    /// Success - The caller attempted to wait for a mutex that has been abandoned.
    /// </summary>
    AbandonedWait3 = 0x00000083,

    /// <summary>
    /// Success - The caller attempted to wait for a mutex that has been abandoned.
    /// </summary>
    AbandonedWait63 = 0x000000bf,

    /// <summary>
    /// Success - A user-mode APC was delivered before the given Interval expired.
    /// </summary>
    UserApc = 0x000000c0,

    /// <summary>
    /// Success - ?
    /// </summary>
    KernelApc = 0x00000100,

    /// <summary>
    /// Success - The delay completed because the thread was alerted.
    /// </summary>
    Alerted = 0x00000101,

    /// <summary>
    /// Success - The given Timeout interval expired.
    /// </summary>
    Timeout = 0x00000102,

    /// <summary>
    /// Success - The operation that was requested is pending completion.
    /// </summary>
    Pending = 0x00000103,

    /// <summary>
    /// Success - A reparse should be performed by the Object Manager
    /// because the name of the file resulted in a symbolic link.
    /// </summary>
    Reparse = 0x00000104,

    /// <summary>
    /// Success - Returned by enumeration APIs to indicate more information
    /// is available to successive calls.
    /// </summary>
    MoreEntries = 0x00000105,

    /// <summary>
    /// Success - Indicates not all privileges or groups that are referenced
    /// are assigned to the caller. This allows, for example, all privileges
    /// to be disabled without having to know exactly which privileges are
    /// assigned.
    /// </summary>
    NotAllAssigned = 0x00000106,

    /// <summary>
    /// Success - Some of the information to be translated has not been translated.
    /// </summary>
    SomeNotMapped = 0x00000107,

    /// <summary>
    /// Success - An open/create operation completed while an opportunistic
    /// lock (<c>oplock</c>) break is underway.
    /// </summary>
    OpLockBreakInProgress = 0x00000108,

    /// <summary>
    /// Success - A new volume has been mounted by a file system.
    /// </summary>
    VolumeMounted = 0x00000109,

    /// <summary>
    /// Success - This success level status indicates that the transaction
    /// state already exists for the registry sub-tree but that a transaction
    /// commit was previously aborted. The commit has now been completed.
    /// </summary>
    RxActCommitted = 0x0000010a,

    /// <summary>
    /// Success - Indicates that a notify change request has been completed
    /// due to closing the handle that made the notify change request.
    /// </summary>
    NotifyCleanup = 0x0000010b,

    /// <summary>
    /// Success - Indicates that a notify change request is being completed
    /// and that the information is not being returned in the caller's
    /// buffer. The caller now needs to enumerate the files to find the
    /// changes.
    /// </summary>
    NotifyEnumDir = 0x0000010c,

    /// <summary>
    /// Success - {No Quotas} No system quota limits are specifically set for this account.
    /// </summary>
    NoQuotasForAccount = 0x0000010d,

    /// <summary>
    /// Success - {Connect Failure on Primary Transport} An attempt was made
    /// to connect to the remote server on the primary transport, but
    /// the connection failed. The computer WAS able to connect on a
    /// secondary transport.
    /// </summary>
    PrimaryTransportConnectFailed = 0x0000010e,

    /// <summary>
    /// Success - The page fault was a transition fault.
    /// </summary>
    PageFaultTransition = 0x00000110,

    /// <summary>
    /// Success - The page fault was a demand zero fault.
    /// </summary>
    PageFaultDemandZero = 0x00000111,

    /// <summary>
    /// Success - The page fault was a demand zero fault.
    /// </summary>
    PageFaultCopyOnWrite = 0x00000112,

    /// <summary>
    /// Success - The page fault was a demand zero fault.
    /// </summary>
    PageFaultGuardPage = 0x00000113,

    /// <summary>
    /// Success - The page fault was satisfied by reading from a secondary
    /// storage device.
    /// </summary>
    PageFaultPagingFile = 0x00000114,

    /// <summary>
    /// Success - The crash dump exists in a paging file.
    /// </summary>
    CrashDump = 0x00000116,

    /// <summary>
    /// Success - A reparse should be performed by the Object Manager
    /// because the name of the file resulted in a symbolic link.
    /// </summary>
    ReparseObject = 0x00000118,

    /// <summary>
    /// Success - A process being terminated has no threads to terminate.
    /// </summary>
    NothingToTerminate = 0x00000122,

    /// <summary>
    /// Success - The specified process is not part of a job.
    /// </summary>
    ProcessNotInJob = 0x00000123,

    /// <summary>
    /// Success - The specified process is part of a job.
    /// </summary>
    ProcessInJob = 0x00000124,

    /// <summary>
    /// Success - The current process is a cloned process.
    /// </summary>
    ProcessCloned = 0x00000129,

    /// <summary>
    /// Success - The file was locked and all users of the file can only read.
    /// </summary>
    FileLockedWithOnlyReaders = 0x0000012a,

    /// <summary>
    /// Success - The file was locked and at least one user of the file can write.
    /// </summary>
    FileLockedWithWriters = 0x0000012b,

    // *****************
    // * Informational *
    // *****************

    /// <summary>
    /// Informational - General information
    /// </summary>
    Informational = 0x40000000,

    /// <summary>
    /// Informational - {Object Exists} An attempt was made to create an object but 
    /// the object name already exists.
    /// </summary>
    ObjectNameExists = 0x40000000,

    /// <summary>
    /// Informational - {Thread Suspended} A thread termination occurred while 
    /// the thread was suspended. The thread resumed, and termination proceeded.
    /// </summary>
    ThreadWasSuspended = 0x40000001,

    /// <summary>
    /// Informational - {Working Set Range Error} An attempt was made to set the working set 
    /// minimum or maximum to values that are outside the allowable range.
    /// </summary>
    WorkingSetLimitRange = 0x40000002,

    /// <summary>
    /// Informational - {Image Relocated} An image file could not be mapped at the address 
    /// that is specified in the image file. Local fixes must be performed on this image.
    /// </summary>
    ImageNotAtBase = 0x40000003,

    /// <summary>
    /// Informational - {Registry Recovery} One of the files that contains the system 
    /// registry data had to be recovered by using a log or alternate copy. 
    /// The recovery was successful.
    /// </summary>
    RegistryRecovered = 0x40000009,

    /// <summary>
    /// Informational - Transaction - The transactional resource manager is already consistent.
    /// Recovery is not needed.
    /// </summary>
    RecoveryNotNeeded = 0x40190034,

    /// <summary>
    /// Informational - Transaction - The transactional resource manager has
    /// already been started.
    /// </summary>
    RmAlreadyStarted = 0x40190035,

    // ***********
    // * Warning *
    // ***********

    /// <summary>
    /// Warning - General warning
    /// </summary>
    Warning = 0x80000000,

    /// <summary>
    /// Warning - {EXCEPTION} Guard Page Exception A page of memory that marks 
    /// the end of a data structure, such as a stack or an array, 
    /// has been accessed.
    /// </summary>
    GuardPageViolation = 0x80000001,

    /// <summary>
    /// Warning - {EXCEPTION} Alignment Fault A data type misalignment was detected 
    /// in a load or store instruction.
    /// </summary>
    DatatypeMisalignment = 0x80000002,

    /// <summary>
    /// Warning - {EXCEPTION} Breakpoint A breakpoint has been reached.
    /// </summary>
    Breakpoint = 0x80000003,

    /// <summary>
    /// Warning - {EXCEPTION} Single Step A single step or trace operation has just been completed.
    /// </summary>
    SingleStep = 0x80000004,

    /// <summary>
    /// Warning - {Buffer Overflow} The data was too large to fit into the specified buffer.
    /// </summary>
    BufferOverflow = 0x80000005,

    /// <summary>
    /// Warning - {No More Files} No more files were found which match the file specification.
    /// </summary>
    NoMoreFiles = 0x80000006,

    /// <summary>
    /// Warning - {Handles Closed} Handles to objects have been automatically closed 
    /// because of the requested operation.
    /// </summary>
    HandlesClosed = 0x8000000a,

    /// <summary>
    /// Warning - Because of protection conflicts, not all the requested bytes could be copied.
    /// </summary>
    PartialCopy = 0x8000000d,

    /// <summary>
    /// Warning - {Device Busy} The device is currently busy.
    /// </summary>
    DeviceBusy = 0x80000011,

    /// <summary>
    /// Warning - {Illegal EA} The specified extended attribute (EA) name
    /// contains at least one illegal character.
    /// </summary>
    InvalidEaName = 0x80000013,

    /// <summary>
    /// Warning - {Inconsistent EA List} The extended attribute (EA) list is
    /// inconsistent.
    /// </summary>
    EaListInconsistent = 0x80000014,

    /// <summary>
    /// Warning - {No More Entries} No more entries are available from an
    /// enumeration operation.
    /// </summary>
    NoMoreEntries = 0x8000001a,

    /// <summary>
    /// Warning - A long jump has been executed.
    /// </summary>
    LongJump = 0x80000026,

    /// <summary>
    /// Warning - The application is attempting to run executable code. 
    /// This may be insecure. 
    /// </summary>
    DllMightBeInsecure = 0x8000002b,

    /// <summary>
    /// Warning - Transaction - There is no transaction metadata on the file.
    /// </summary>
    LogCorruptionDetected = 0x80190029,

    /// <summary>
    /// Warning - Transaction - The file cannot be recovered because there
    /// is a handle still open on it.
    /// </summary>
    CantRecoverWithHandleOpen = 0x80190031,

    /// <summary>
    /// Warning - Transaction - Transaction metadata is already present on
    /// this file and cannot be superseded.
    /// </summary>
    TxfMetadataAlreadyPresent = 0x80190041,

    /// <summary>
    /// Warning - Transaction - A transaction scope could not be entered
    /// because the scope handler has not been initialized.
    /// </summary>
    TransactionScopeCallbacksNotSet = 0x80190042,

    // *********
    // * Error *
    // *********

    /// <summary>
    /// Error - General error
    /// </summary>
    Error = 0xc0000000,

    /// <summary>
    /// Error - {Operation Failed} The requested operation was unsuccessful.
    /// </summary>
    Unsuccessful = 0xc0000001,

    /// <summary>
    /// Error - {Not Implemented} The requested operation is not implemented.
    /// </summary>
    NotImplemented = 0xc0000002,

    /// <summary>
    /// Error - {Invalid Parameter} The specified information class is not a 
    /// valid information class for the specified object.
    /// </summary>
    InvalidInfoClass = 0xc0000003,

    /// <summary>
    /// Error - The specified information record length does not match the
    /// length that is required for the specified information class.
    /// </summary>
    InfoLengthMismatch = 0xc0000004,

    /// <summary>
    /// Error - The instruction referenced memory it do not have access to.
    /// </summary>
    AccessViolation = 0xc0000005,

    /// <summary>
    /// Error - The required data was not placed into memory because of an
    /// I/O error status.
    /// </summary>
    InPageError = 0xc0000006,

    /// <summary>
    /// Error - The page file quota for the process has been exhausted.
    /// </summary>
    PagefileQuota = 0xc0000007,

    /// <summary>
    /// Error - An invalid HANDLE was specified.
    /// </summary>
    InvalidHandle = 0xc0000008,

    /// <summary>
    /// Error - An invalid initial stack was specified in a call to
    /// <c>NtCreateThread</c>.
    /// </summary>
    BadInitialStack = 0xc0000009,

    /// <summary>
    /// Error - An invalid initial start address was specified in a call to
    /// <c>NtCreateThread</c>.
    /// </summary>
    BadInitialPc = 0xc000000a,

    /// <summary>
    /// Error - An invalid client ID was specified.
    /// </summary>
    InvalidCid = 0xc000000b,

    /// <summary>
    /// Error - An attempt was made to cancel or set a timer that has an
    /// associated APC and the specified thread is not the thread that
    /// originally set the timer with an associated APC routine.
    /// </summary>
    TimerNotCanceled = 0xc000000c,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function.
    /// </summary>
    InvalidParameter = 0xc000000d,

    /// <summary>
    /// Error - A device that does not exist was specified.
    /// </summary>
    NoSuchDevice = 0xc000000e,

    /// <summary>
    /// Error - {File Not Found} The file does not exist.
    /// </summary>
    NoSuchFile = 0xc000000f,

    /// <summary>
    /// Error - The specified request is not a valid operation for the
    /// target device.
    /// </summary>
    InvalidDeviceRequest = 0xc0000010,

    /// <summary>
    /// Error - The end-of-file marker has been reached. There is no valid
    /// data in the file beyond this marker.
    /// </summary>
    EndOfFile = 0xc0000011,

    /// <summary>
    /// Error - {Wrong Volume} The wrong volume is in the drive. Insert
    /// volume into drive.
    /// </summary>
    WrongVolume = 0xc0000012,

    /// <summary>
    /// Error - {No Disk} There is no disk in the drive. Insert a disk into
    /// drive.
    /// </summary>
    NoMediaInDevice = 0xc0000013,

    /// <summary>
    /// Error - {Not Enough Quota} Not enough virtual memory or paging file
    /// quota is available to complete the specified operation.
    /// </summary>
    NoMemory = 0xc0000017,

    /// <summary>
    /// Error - The address range to un-map is not a mapped view.
    /// </summary>
    NotMappedView = 0xc0000019,

    /// <summary>
    /// Error - The virtual memory cannot be freed.
    /// </summary>
    UnableToFreeVm = 0xc000001a,

    /// <summary>
    /// Error - The specified section cannot be deleted.
    /// </summary>
    UnableToDeleteSection = 0xc000001b,

    /// <summary>
    /// Error - {EXCEPTION} Illegal Instruction. An attempt was made to
    /// execute an illegal instruction.
    /// </summary>
    IllegalInstruction = 0xc000001d,

    /// <summary>
    /// Error - {Already Committed} The specified address range is already
    /// committed.
    /// </summary>
    AlreadyCommitted = 0xc0000021,

    /// <summary>
    /// Error - {Access Denied} A process has requested access to an object
    /// but has not been granted those access rights.
    /// </summary>
    AccessDenied = 0xc0000022,

    /// <summary>
    /// Error - {Buffer Too Small} The buffer is too small to contain the
    /// entry. No information has been written to the buffer.
    /// </summary>
    BufferTooSmall = 0xc0000023,

    /// <summary>
    /// Error - {Wrong Type} There is a mismatch between the type of object
    /// that is required by the requested operation and the type of object
    /// that is specified in the request.
    /// </summary>
    ObjectTypeMismatch = 0xc0000024,

    /// <summary>
    /// Error - {EXCEPTION} Cannot Continue. Windows cannot continue from
    /// this exception.
    /// </summary>
    NonContinuableException = 0xc0000025,

    /// <summary>
    /// Error - An invalid or unaligned stack was encountered during an
    /// unwind operation.
    /// </summary>
    BadStack = 0xc0000028,

    /// <summary>
    /// Error - An attempt was made to unlock a page of memory that was not
    /// locked.
    /// </summary>
    NotLocked = 0xc000002a,

    /// <summary>
    /// Error - An attempt was made to change the attributes on memory that
    /// has not been committed.
    /// </summary>
    NotCommitted = 0xc000002d,

    /// <summary>
    /// Error - An invalid combination of parameters was specified.
    /// </summary>
    InvalidParameterMix = 0xc0000030,

    /// <summary>
    /// Error - The object name is invalid.
    /// </summary>
    ObjectNameInvalid = 0xc0000033,

    /// <summary>
    /// Error - The object name is not found.
    /// </summary>
    ObjectNameNotFound = 0xc0000034,

    /// <summary>
    /// Error - The object name already exists.
    /// </summary>
    ObjectNameCollision = 0xc0000035,

    /// <summary>
    /// Error - The object path component was not a directory object.
    /// </summary>
    ObjectPathInvalid = 0xc0000039,

    /// <summary>
    /// Error - {Path Not Found} The path does not exist.
    /// </summary>
    ObjectPathNotFound = 0xc000003a,

    /// <summary>
    /// Error - The object path component was not a directory object.
    /// </summary>
    ObjectPathSyntaxBad = 0xc000003b,

    /// <summary>
    /// Error - {Data Overrun} A data overrun error occurred.
    /// </summary>
    DataOverrun = 0xc000003c,

    /// <summary>
    /// Error - {Data Late} A data late error occurred.
    /// </summary>
    DataLate = 0xc000003d,

    /// <summary>
    /// Error - {Data Error} An error occurred in reading or writing data.
    /// </summary>
    DataError = 0xc000003e,

    /// <summary>
    /// Error - {Bad CRC} A cyclic redundancy check (CRC) checksum error
    /// occurred.
    /// </summary>
    CrcError = 0xc000003f,

    /// <summary>
    /// Error - {Section Too Large} The specified section is too big to map
    /// the file.
    /// </summary>
    SectionTooBig = 0xc0000040,

    /// <summary>
    /// Error - The <c>NtConnectPort</c> request is refused.
    /// </summary>
    PortConnectionRefused = 0xc0000041,

    /// <summary>
    /// Error - The type of port handle is invalid for the operation that is
    /// requested.
    /// </summary>
    InvalidPortHandle = 0xc0000042,

    /// <summary>
    /// Error - A file cannot be opened because the share access flags are
    /// incompatible.
    /// </summary>
    SharingViolation = 0xc0000043,

    /// <summary>
    /// Error - Insufficient quota exists to complete the operation.
    /// </summary>
    QuotaExceeded = 0xc0000044,

    /// <summary>
    /// Error - The specified page protection was not valid.
    /// </summary>
    InvalidPageProtection = 0xc0000045,

    /// <summary>
    /// Error - An attempt to release a mutant object was made by a thread
    /// that was not the owner of the mutant object.
    /// </summary>
    MutantNotOwned = 0xc0000046,

    /// <summary>
    /// Error - An attempt was made to release a semaphore such that its
    /// maximum count would have been exceeded.
    /// </summary>
    SemaphoreLimitExceeded = 0xc0000047,

    /// <summary>
    /// Error - An attempt was made to set the DebugPort or ExceptionPort of
    /// a process, but a port already exists in the process, or an attempt
    /// was made to set the CompletionPort of a file but a port was already
    /// set in the file, or an attempt was made to set the associated
    /// completion port of an ALPC port but it is already set.
    /// </summary>
    PortAlreadySet = 0xc0000048,

    /// <summary>
    /// Error - An attempt was made to query image information on a section
    /// that does not map an image.
    /// </summary>
    SectionNotImage = 0xc0000049,

    /// <summary>
    /// Error - An attempt was made to suspend a thread whose suspend count
    /// was at its maximum.
    /// </summary>
    SuspendCountExceeded = 0xc000004a,

    /// <summary>
    /// Error - An attempt was made to suspend a thread that has begun
    /// termination.
    /// </summary>
    ThreadIsTerminating = 0xc000004b,

    /// <summary>
    /// Error - An attempt was made to set the working set limit to an
    /// invalid value (for example, the minimum greater than maximum).
    /// </summary>
    BadWorkingSetLimit = 0xc000004c,

    /// <summary>
    /// Error - A section was created to map a file that is not compatible
    /// with an already existing section that maps the same file.
    /// </summary>
    IncompatibleFileMap = 0xc000004d,

    /// <summary>
    /// Error - A view to a section specifies a protection that is
    /// incompatible with the protection of the initial view.
    /// </summary>
    SectionProtection = 0xc000004e,

    /// <summary>
    /// Error - An operation involving EAs failed because the file system
    /// does not support EAs.
    /// </summary>
    EasNotSupported = 0xc000004f,

    /// <summary>
    /// Error - An EA operation failed because the EA set is too large.
    /// </summary>
    EaTooLarge = 0xc0000050,

    /// <summary>
    /// Error - An EA operation failed because the name or EA index is
    /// invalid.
    /// </summary>
    NonExistentEaEntry = 0xc0000051,

    /// <summary>
    /// Error - The file for which EAs were requested has no EAs.
    /// </summary>
    NoEasOnFile = 0xc0000052,

    /// <summary>
    /// Error - The EA is corrupt and cannot be read.
    /// </summary>
    EaCorruptError = 0xc0000053,

    /// <summary>
    /// Error - A requested read/write cannot be granted due to a
    /// conflicting file lock.
    /// </summary>
    FileLockConflict = 0xc0000054,

    /// <summary>
    /// Error - A requested file lock cannot be granted due to other
    /// existing locks.
    /// </summary>
    LockNotGranted = 0xc0000055,

    /// <summary>
    /// Error - A non-close operation has been requested of a file object
    /// that has a delete pending.
    /// </summary>
    DeletePending = 0xc0000056,

    /// <summary>
    /// Error - An attempt was made to set the control attribute on a file.
    /// This attribute is not supported in the destination file system.
    /// </summary>
    CtlFileNotSupported = 0xc0000057,

    /// <summary>
    /// Error - Indicates a revision number that was encountered or
    /// specified is not one that is known by the service. It might be a
    /// more recent revision than the service is aware of.
    /// </summary>
    UnknownRevision = 0xc0000058,

    /// <summary>
    /// Error - Indicates that two revision levels are incompatible.
    /// </summary>
    RevisionMismatch = 0xc0000059,

    /// <summary>
    /// Error - Indicates a particular security ID cannot be assigned as
    /// the owner of an object.
    /// </summary>
    InvalidOwner = 0xc000005a,

    /// <summary>
    /// Error - Indicates a particular security ID cannot be assigned as the
    /// primary group of an object.
    /// </summary>
    InvalidPrimaryGroup = 0xc000005b,

    /// <summary>
    /// Error - An attempt has been made to operate on an impersonation
    /// token by a thread that is not currently impersonating a client.
    /// </summary>
    NoImpersonationToken = 0xc000005c,

    /// <summary>
    /// Error - A mandatory group cannot be disabled.
    /// </summary>
    CantDisableMandatory = 0xc000005d,

    /// <summary>
    /// Error - No logon servers are currently available to service the
    /// logon request.
    /// </summary>
    NoLogonServers = 0xc000005e,

    /// <summary>
    /// Error - A specified logon session does not exist. It might already
    /// have been terminated.
    /// </summary>
    NoSuchLogonSession = 0xc000005f,

    /// <summary>
    /// Error - A specified privilege does not exist.
    /// </summary>
    NoSuchPrivilege = 0xc0000060,

    /// <summary>
    /// Error - A required privilege is not held by the client.
    /// </summary>
    PrivilegeNotHeld = 0xc0000061,

    /// <summary>
    /// Error - The name provided is not a properly formed account name.
    /// </summary>
    InvalidAccountName = 0xc0000062,

    /// <summary>
    /// Error - The specified account already exists.
    /// </summary>
    UserExists = 0xc0000063,

    /// <summary>
    /// Error - The specified account does not exist.
    /// </summary>
    NoSuchUser = 0xc0000064,

    /// <summary>
    /// Error - The specified group already exists.
    /// </summary>
    GroupExists = 0xc0000065,

    /// <summary>
    /// Error - The specified group does not exist.
    /// </summary>
    NoSuchGroup = 0xc0000066,

    /// <summary>
    /// Error - The specified user account is already in the specified group
    /// account. Also used to indicate a group cannot be deleted because it
    /// contains a member.
    /// </summary>
    MemberInGroup = 0xc0000067,

    /// <summary>
    /// Error - The specified user account is not a member of the specified
    /// group account.
    /// </summary>
    MemberNotInGroup = 0xc0000068,

    /// <summary>
    /// Error - Indicates the requested operation would disable or delete
    /// the last remaining administration account. This is not allowed to
    /// prevent creating a situation in which the system cannot be
    /// administrated.
    /// </summary>
    LastAdmin = 0xc0000069,

    /// <summary>
    /// Error - When trying to update a password, this return status
    /// indicates that the value provided as the current password is not
    /// correct.
    /// </summary>
    WrongPassword = 0xc000006a,

    /// <summary>
    /// Error - When trying to update a password, this return status
    /// indicates that the value provided for the new password contains
    /// values that are not allowed in passwords.
    /// </summary>
    IllFormedPassword = 0xc000006b,

    /// <summary>
    /// Error - When trying to update a password, this status indicates that
    /// some password update rule has been violated. For example, the
    /// password might not meet length criteria.
    /// </summary>
    PasswordRestriction = 0xc000006c,

    /// <summary>
    /// Error - The attempted logon is invalid. This is either due to a bad
    /// username or authentication information.
    /// </summary>
    LogonFailure = 0xc000006d,

    /// <summary>
    /// Error - Indicates a referenced user name and authentication
    /// information are valid, but some user account restriction has
    /// prevented successful authentication (such as time-of-day
    /// restrictions).
    /// </summary>
    AccountRestriction = 0xc000006e,

    /// <summary>
    /// Error - The user account has time restrictions and cannot be logged
    /// onto at this time.
    /// </summary>
    InvalidLogonHours = 0xc000006f,

    /// <summary>
    /// Error - The user account is restricted so that it cannot be used to
    /// log on from the source workstation.
    /// </summary>
    InvalidWorkstation = 0xc0000070,

    /// <summary>
    /// Error - The user account password has expired.
    /// </summary>
    PasswordExpired = 0xc0000071,

    /// <summary>
    /// Error - The referenced account is currently disabled and cannot be
    /// logged on to.
    /// </summary>
    AccountDisabled = 0xc0000072,

    /// <summary>
    /// Error - None of the information to be translated has been
    /// translated.
    /// </summary>
    NoneMapped = 0xc0000073,

    /// <summary>
    /// Error - The number of LUIDs requested cannot be allocated with a
    /// single allocation.
    /// </summary>
    TooManyLuidsRequested = 0xc0000074,

    /// <summary>
    /// Error - Indicates there are no more LUIDs to allocate.
    /// </summary>
    LuidsExhausted = 0xc0000075,

    /// <summary>
    /// Error - Indicates the sub-authority value is invalid for the
    /// particular use.
    /// </summary>
    InvalidSubAuthority = 0xc0000076,

    /// <summary>
    /// Error - Indicates the ACL structure is not valid.
    /// </summary>
    InvalidAcl = 0xc0000077,

    /// <summary>
    /// Error - Indicates the SID structure is not valid.
    /// </summary>
    InvalidSid = 0xc0000078,

    /// <summary>
    /// Error - Indicates the <c>SECURITY_DESCRIPTOR</c> structure is not valid.
    /// </summary>
    InvalidSecurityDescr = 0xc0000079,

    /// <summary>
    /// Error - Indicates the specified procedure address cannot be found in
    /// the DLL.
    /// </summary>
    ProcedureNotFound = 0xc000007a,

    /// <summary>
    /// Error - {Bad Image} Image is either not designed to run on Windows or
    /// it contains an error. Try installing the program again using the
    /// original installation media or contact your system administrator or
    /// the software vendor for support.
    /// </summary>
    InvalidImageFormat = 0xc000007b,

    /// <summary>
    /// Error - An attempt was made to reference a token that does not
    /// exist. This is typically done by referencing the token that is
    /// associated with a thread when the thread is not impersonating a
    /// client.
    /// </summary>
    NoToken = 0xc000007c,

    /// <summary>
    /// Error - Indicates that an attempt to build either an inherited ACL
    /// or ACE was not successful. This can be caused by a number of things.
    /// One of the more probable causes is the replacement of a CreatorId
    /// with a SID that did not fit into the ACE or ACL.
    /// </summary>
    BadInheritanceAcl = 0xc000007d,

    /// <summary>
    /// Error - The range specified in <c>NtUnlockFile</c> was not locked.
    /// </summary>
    RangeNotLocked = 0xc000007e,

    /// <summary>
    /// Error - An operation failed because the disk was full.
    /// </summary>
    DiskFull = 0xc000007f,

    /// <summary>
    /// Error - The GUID allocation server is disabled at the moment.
    /// </summary>
    ServerDisabled = 0xc0000080,

    /// <summary>
    /// Error - The GUID allocation server is enabled at the moment.
    /// </summary>
    ServerNotDisabled = 0xc0000081,

    /// <summary>
    /// Error - Too many GUIDs were requested from the allocation server at
    /// once.
    /// </summary>
    TooManyGuidsRequested = 0xc0000082,

    /// <summary>
    /// Error - The GUIDs could not be allocated because the Authority Agent
    /// was exhausted.
    /// </summary>
    GuidsExhausted = 0xc0000083,

    /// <summary>
    /// Error - The value provided was an invalid value for an identifier
    /// authority.
    /// </summary>
    InvalidIdAuthority = 0xc0000084,

    /// <summary>
    /// Error - No more authority agent values are available for the
    /// particular identifier authority value.
    /// </summary>
    AgentsExhausted = 0xc0000085,

    /// <summary>
    /// Error - An invalid volume label has been specified.
    /// </summary>
    InvalidVolumeLabel = 0xc0000086,

    /// <summary>
    /// Error - A mapped section could not be extended.
    /// </summary>
    SectionNotExtended = 0xc0000087,

    /// <summary>
    /// Error - Specified section to flush does not map a data file.
    /// </summary>
    NotMappedData = 0xc0000088,

    /// <summary>
    /// Error - Indicates the specified image file did not contain a
    /// resource section.
    /// </summary>
    ResourceDataNotFound = 0xc0000089,

    /// <summary>
    /// Error - Indicates the specified resource type cannot be found in the
    /// image file.
    /// </summary>
    ResourceTypeNotFound = 0xc000008a,

    /// <summary>
    /// Error - Indicates the specified resource name cannot be found in the
    /// image file.
    /// </summary>
    ResourceNameNotFound = 0xc000008b,

    /// <summary>
    /// Error - {EXCEPTION} Array bounds exceeded.
    /// </summary>
    ArrayBoundsExceeded = 0xc000008c,

    /// <summary>
    /// Error - {EXCEPTION} Floating-point denormal operand.
    /// </summary>
    FloatDenormalOperand = 0xc000008d,

    /// <summary>
    /// Error - {EXCEPTION} Floating-point division by zero.
    /// </summary>
    FloatDivideByZero = 0xc000008e,

    /// <summary>
    /// Error - {EXCEPTION} Floating-point inexact result.
    /// </summary>
    FloatInexactResult = 0xc000008f,

    /// <summary>
    /// Error - {EXCEPTION} Floating-point invalid operation.
    /// </summary>
    FloatInvalidOperation = 0xc0000090,

    /// <summary>
    /// Error - {EXCEPTION} Floating-point overflow.
    /// </summary>
    FloatOverflow = 0xc0000091,

    /// <summary>
    /// Error - {EXCEPTION} Floating-point stack check.
    /// </summary>
    FloatStackCheck = 0xc0000092,

    /// <summary>
    /// Error - {EXCEPTION} Floating-point underflow.
    /// </summary>
    FloatUnderflow = 0xc0000093,

    /// <summary>
    /// Error - {EXCEPTION} Integer division by zero.
    /// </summary>
    IntegerDivideByZero = 0xc0000094,

    /// <summary>
    /// Error - {EXCEPTION} Integer overflow.
    /// </summary>
    IntegerOverflow = 0xc0000095,

    /// <summary>
    /// Error - {EXCEPTION} Privileged instruction.
    /// </summary>
    PrivilegedInstruction = 0xc0000096,

    /// <summary>
    /// Error - An attempt was made to install more paging files than the
    /// system supports.
    /// </summary>
    TooManyPagingFiles = 0xc0000097,

    /// <summary>
    /// Error - The volume for a file has been externally altered such that
    /// the opened file is no longer valid.
    /// </summary>
    FileInvalid = 0xc0000098,

    /// <summary>
    /// Error - The maximum named pipe instance count has been reached.
    /// </summary>
    InstanceNotAvailable = 0xc00000ab,

    /// <summary>
    /// Error - An instance of a named pipe cannot be found in the listening
    /// state.
    /// </summary>
    PipeNotAvailable = 0xc00000ac,

    /// <summary>
    /// Error - The named pipe is not in the connected or closing state.
    /// </summary>
    InvalidPipeState = 0xc00000ad,

    /// <summary>
    /// Error - The specified pipe is set to complete operations and there
    /// are current I/O operations queued so that it cannot be changed to
    /// queue operations.
    /// </summary>
    PipeBusy = 0xc00000ae,

    /// <summary>
    /// Error - The specified handle is not open to the server end of the
    /// named pipe.
    /// </summary>
    IllegalFunction = 0xc00000af,

    /// <summary>
    /// Error - The specified named pipe is in the disconnected state.
    /// </summary>
    PipeDisconnected = 0xc00000b0,

    /// <summary>
    /// Error - The specified named pipe is in the closing state.
    /// </summary>
    PipeClosing = 0xc00000b1,

    /// <summary>
    /// Error - The specified named pipe is in the connected state.
    /// </summary>
    PipeConnected = 0xc00000b2,

    /// <summary>
    /// Error - The specified named pipe is in the listening state.
    /// </summary>
    PipeListening = 0xc00000b3,

    /// <summary>
    /// Error - The specified named pipe is not in message mode.
    /// </summary>
    InvalidReadMode = 0xc00000b4,

    /// <summary>
    /// Error - {Device Timeout} The specified I/O operation was not
    /// completed before the time-out period expired.
    /// </summary>
    IoTimeout = 0xc00000b5,

    /// <summary>
    /// Error - The specified file has been closed by another process.
    /// </summary>
    FileForcedClosed = 0xc00000b6,

    /// <summary>
    /// Error - Profiling is not started.
    /// </summary>
    ProfilingNotStarted = 0xc00000b7,

    /// <summary>
    /// Error - Profiling is not stopped.
    /// </summary>
    ProfilingNotStopped = 0xc00000b8,

    /// <summary>
    /// Error - {Incorrect Volume} The destination file of a rename request
    /// is located on a different device than the source of the rename
    /// request.
    /// </summary>
    NotSameDevice = 0xc00000d4,

    /// <summary>
    /// Error - The specified file has been renamed and thus cannot be
    /// modified.
    /// </summary>
    FileRenamed = 0xc00000d5,

    /// <summary>
    /// Error - Used to indicate that an operation cannot continue without
    /// blocking for I/O.
    /// </summary>
    CantWait = 0xc00000d8,

    /// <summary>
    /// Error - Used to indicate that a read operation was done on an empty
    /// pipe.
    /// </summary>
    PipeEmpty = 0xc00000d9,

    /// <summary>
    /// Error - Indicates that a thread attempted to terminate itself by
    /// default (called <c>NtTerminateThread</c> with <c>NULL</c>) and it was the last
    /// thread in the current process.
    /// </summary>
    CantTerminateSelf = 0xc00000db,

    /// <summary>
    /// Error - An internal error occurred.
    /// </summary>
    InternalError = 0xc00000e5,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function as
    /// the first argument.
    /// </summary>
    InvalidParameter1 = 0xc00000ef,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function as
    /// the second argument.
    /// </summary>
    InvalidParameter2 = 0xc00000f0,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function as
    /// the third argument.
    /// </summary>
    InvalidParameter3 = 0xc00000f1,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function as
    /// the fourth argument.
    /// </summary>
    InvalidParameter4 = 0xc00000f2,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function as
    /// the fifth argument.
    /// </summary>
    InvalidParameter5 = 0xc00000f3,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function as
    /// the sixth argument.
    /// </summary>
    InvalidParameter6 = 0xc00000f4,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function as
    /// the seventh argument.
    /// </summary>
    InvalidParameter7 = 0xc00000f5,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function as
    /// the eighth argument.
    /// </summary>
    InvalidParameter8 = 0xc00000f6,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function as
    /// the ninth argument.
    /// </summary>
    InvalidParameter9 = 0xc00000f7,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function as
    /// the tenth argument.
    /// </summary>
    InvalidParameter10 = 0xc00000f8,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function as
    /// the eleventh argument.
    /// </summary>
    InvalidParameter11 = 0xc00000f9,

    /// <summary>
    /// Error - An invalid parameter was passed to a service or function as
    /// the twelfth argument.
    /// </summary>
    InvalidParameter12 = 0xc00000fa,

    /// <summary>
    /// Error - Indicates that the directory trying to be deleted is not empty.
    /// </summary>
    DirectoryNotEmpty = 0xc0000101,

    /// <summary>
    /// Error - A requested opened file is not a directory.
    /// </summary>
    NotADirectory = 0xc0000103,

    /// <summary>
    /// Error - An attempt was made to map a file of size zero with the
    /// maximum size specified as zero.
    /// </summary>
    MappedFileSizeZero = 0xc000011e,

    /// <summary>
    /// Error - Too many files are opened on a remote server. This error
    /// should only be returned by the Windows redirector on a remote drive.
    /// </summary>
    TooManyOpenedFiles = 0xc000011f,

    /// <summary>
    /// Error - The I/O request was canceled.
    /// </summary>
    Cancelled = 0xc0000120,

    /// <summary>
    /// Error - An attempt has been made to remove a file or directory that
    /// cannot be deleted.
    /// </summary>
    CannotDelete = 0xc0000121,

    /// <summary>
    /// Error - Indicates a name that was specified as a remote computer
    /// name is syntactically invalid.
    /// </summary>
    InvalidComputerName = 0xc0000122,

    /// <summary>
    /// Error - An I/O request other than <c>close</c> was performed on a file
    /// after it was deleted, which can only happen to a request that did
    /// not complete before the last handle was closed via <c>NtClose</c>.
    /// </summary>
    FileDeleted = 0xc0000123,

    /// <summary>
    /// Error - Indicates an operation that is incompatible with built-in
    /// accounts has been attempted on a built-in (special) SAM account. For
    /// example, built-in accounts cannot be deleted.
    /// </summary>
    SpecialAccount = 0xc0000124,

    /// <summary>
    /// Error - The operation requested cannot be performed on the specified
    /// group because it is a built-in special group.
    /// </summary>
    SpecialGroup = 0xc0000125,

    /// <summary>
    /// Error - The operation requested cannot be performed on the specified
    /// user because it is a built-in special user.
    /// </summary>
    SpecialUser = 0xc0000126,

    /// <summary>
    /// Error - Indicates a member cannot be removed from a group because
    /// the group is currently the member's primary group.
    /// </summary>
    MembersPrimaryGroup = 0xc0000127,

    /// <summary>
    /// Error - An I/O request other than <c>close</c> and several other special
    /// case operations was attempted using a file object that had already
    /// been closed.
    /// </summary>
    FileClosed = 0xc0000128,

    /// <summary>
    /// Error - Indicates a process has too many threads to perform the
    /// requested action. For example, assignment of a primary token can be
    /// performed only when a process has zero or one threads.
    /// </summary>
    TooManyThreads = 0xc0000129,

    /// <summary>
    /// Error - An attempt was made to operate on a thread within a specific
    /// process, but the specified thread is not in the specified process.
    /// </summary>
    ThreadNotInProcess = 0xc000012a,

    /// <summary>
    /// Error - An attempt was made to establish a token for use as a
    /// primary token but the token is already in use. A token can only be
    /// the primary token of one process at a time.
    /// </summary>
    TokenAlreadyInUse = 0xc000012b,

    /// <summary>
    /// Error - The page file quota was exceeded.
    /// </summary>
    PagefileQuotaExceeded = 0xc000012c,

    /// <summary>
    /// Error - {Out of Virtual Memory} Your system is low on virtual
    /// memory. To ensure that Windows runs correctly, increase the size of
    /// your virtual memory paging file.
    /// </summary>
    CommitmentLimit = 0xc000012d,

    /// <summary>
    /// Error - The specified image file did not have the correct format: it
    /// appears to be LE format.
    /// </summary>
    InvalidImageLeFormat = 0xc000012e,

    /// <summary>
    /// Error - The specified image file did not have the correct format: it
    /// did not have an initial MZ.
    /// </summary>
    InvalidImageNotMz = 0xc000012f,

    /// <summary>
    /// Error - The specified image file did not have the correct format: it
    /// did not have a proper <c>e_lfarlc</c> in the MZ header.
    /// </summary>
    InvalidImageProtect = 0xc0000130,

    /// <summary>
    /// Error - The specified image file did not have the correct format: it
    /// appears to be a 16-bit Windows image.
    /// </summary>
    InvalidImageWin16 = 0xc0000131,

    /// <summary>
    /// Error - The <c>Netlogon</c> service cannot start because another <c>Netlogon</c>
    /// service running in the domain conflicts with the specified role.
    /// </summary>
    LogonServer = 0xc0000132,

    /// <summary>
    /// Error - The time at the primary domain controller is different from
    /// the time at the backup domain controller or member server by too
    /// large an amount.
    /// </summary>
    DifferenceAtDc = 0xc0000133,

    /// <summary>
    /// Error - The SAM database on a Windows Server operating system is
    /// significantly out of synchronization with the copy on the domain
    /// controller. A complete synchronization is required.
    /// </summary>
    SynchronizationRequired = 0xc0000134,

    /// <summary>
    /// Error - {Unable To Locate Component} This application has failed to
    /// start because DLL was not found. Reinstalling the application might
    /// fix this problem.
    /// </summary>
    DllNotFound = 0xc0000135,

    /// <summary>
    /// Error - {Privilege Failed} The I/O permissions for the process could
    /// not be changed.
    /// </summary>
    IoPrivilegeFailed = 0xc0000137,

    /// <summary>
    /// Error - {Ordinal Not Found} The ordinal could not be located in the
    /// dynamic link library.
    /// </summary>
    OrdinalNotFound = 0xc0000138,

    /// <summary>
    /// Error - {Entry Point Not Found} The procedure entry point could
    /// not be located in the dynamic link library.
    /// </summary>
    EntryPointNotFound = 0xc0000139,

    /// <summary>
    /// Error - {Application Exit by CTRL+C} The application terminated as a
    /// result of a CTRL+C.
    /// </summary>
    ControlCExit = 0xc000013a,

    /// <summary>
    /// Error - An attempt to remove a processes DebugPort was made, but a
    /// port was not already associated with the process.
    /// </summary>
    PortNotSet = 0xc0000353,

    /// <summary>
    /// Error - An attempt to do an operation on a debug port failed because
    /// the port is in the process of being deleted.
    /// </summary>
    DebuggerInactive = 0xc0000354,

    /// <summary>
    /// Error - A callback has requested to bypass native code.
    /// </summary>
    CallbackBypass = 0xc0000503,

    /// <summary>
    /// Error - The ALPC port is closed.
    /// </summary>
    PortClosed = 0xc0000700,

    /// <summary>
    /// Error - The ALPC message requested is no longer available.
    /// </summary>
    MessageLost = 0xc0000701,

    /// <summary>
    /// Error - The ALPC message supplied is invalid.
    /// </summary>
    InvalidMessage = 0xc0000702,

    /// <summary>
    /// Error - The ALPC message has been canceled.
    /// </summary>
    RequestCanceled = 0xc0000703,

    /// <summary>
    /// Error - Invalid recursive dispatch attempt.
    /// </summary>
    RecursiveDispatch = 0xc0000704,

    /// <summary>
    /// Error - No receive buffer has been supplied in a synchronous
    /// request.
    /// </summary>
    LpcReceiveBufferExpected = 0xc0000705,

    /// <summary>
    /// Error - The connection port is used in an invalid context.
    /// </summary>
    LpcInvalidConnectionUsage = 0xc0000706,

    /// <summary>
    /// Error - The ALPC port does not accept new request messages.
    /// </summary>
    LpcRequestsNotAllowed = 0xc0000707,

    /// <summary>
    /// Error - The resource requested is already in use.
    /// </summary>
    ResourceInUse = 0xc0000708,

    /// <summary>
    /// Error - Either the target process, or the target thread's containing
    /// process, is a protected process.
    /// </summary>
    ProcessIsProtected = 0xc0000712,

    /// <summary>
    /// Error - The operation could not be completed because the volume is
    /// dirty. Please run the Chkdsk utility and try again.
    /// </summary>
    VolumeDirty = 0xc0000806,

    /// <summary>
    /// Error - This file is checked out or locked for editing by another
    /// user.
    /// </summary>
    FileCheckedOut = 0xc0000901,

    /// <summary>
    /// Error - The file must be checked out before saving changes.
    /// </summary>
    CheckOutRequired = 0xc0000902,

    /// <summary>
    /// Error - The file type being saved or retrieved has been blocked.
    /// </summary>
    BadFileType = 0xc0000903,

    /// <summary>
    /// Error - The file size exceeds the limit allowed and cannot be saved.
    /// </summary>
    FileTooLarge = 0xc0000904,

    /// <summary>
    /// Error - Access Denied. Before opening files in this location, you
    /// must first browse to the e.g. site and select the option to log on
    /// automatically.
    /// </summary>
    FormsAuthRequired = 0xc0000905,

    /// <summary>
    /// Error - The operation did not complete successfully because the file
    /// contains a virus.
    /// </summary>
    VirusInfected = 0xc0000906,

    /// <summary>
    /// Error - This file contains a virus and cannot be opened. Due to the
    /// nature of this virus, the file has been removed from this location.
    /// </summary>
    VirusDeleted = 0xc0000907,

    /// <summary>
    /// Error - Transaction - The function attempted to use a name that is
    /// reserved for use by another transaction.
    /// </summary>
    TransactionalConflict = 0xc0190001,

    /// <summary>
    /// Error - Transaction - The transaction handle associated with this
    /// operation is invalid.
    /// </summary>
    InvalidTransaction = 0xc0190002,

    /// <summary>
    /// Error - Transaction - The requested operation was made in the
    /// context of a transaction that is no longer active.
    /// </summary>
    TransactionNotActive = 0xc0190003,

    /// <summary>
    /// Error - Transaction - The transaction manager was unable to be
    /// successfully initialized. Transacted operations are not supported.
    /// </summary>
    TmInitializationFailed = 0xc0190004,

    /// <summary>
    /// Error - Transaction - Transaction support within the specified file
    /// system resource manager was not started or was shut down due to an
    /// error.
    /// </summary>
    RmNotActive = 0xc0190005,

    /// <summary>
    /// Error - Transaction - The metadata of the resource manager has been
    /// corrupted. The resource manager will not function.
    /// </summary>
    RmMetadataCorrupt = 0xc0190006,

    /// <summary>
    /// Error - Transaction - The resource manager attempted to prepare a
    /// transaction that it has not successfully joined.
    /// </summary>
    TransactionNotJoined = 0xc0190007,

    /// <summary>
    /// Error - Transaction - The specified directory does not contain a
    /// file system resource manager.
    /// </summary>
    DirectoryNotRm = 0xc0190008,

    /// <summary>
    /// Error - Transaction - The log could not be set to the requested
    /// size.
    /// </summary>
    CouldNotResizeLog = 0xc0190009,

    /// <summary>
    /// Error - Transaction - The remote server or share does not support
    /// transacted file operations.
    /// </summary>
    TransactionsUnsupportedRemote = 0xc019000a,

    /// <summary>
    /// Error - Transaction - The requested log size for the file system
    /// resource manager is invalid.
    /// </summary>
    LogResizeInvalidSize = 0xc019000b,

    /// <summary>
    /// Error - Transaction - The remote server sent mismatching version
    /// number or Fid for a file opened with transactions.
    /// </summary>
    RemoteFileVersionMismatch = 0xc019000c,

    /// <summary>
    /// Error - Transaction - The resource manager tried to register a
    /// protocol that already exists.
    /// </summary>
    CrmProtocolAlreadyExists = 0xc019000f,

    /// <summary>
    /// Error - Transaction - The attempt to propagate the transaction
    /// failed.
    /// </summary>
    TransactionPropagationFailed = 0xc0190010,

    /// <summary>
    /// Error - Transaction - The requested propagation protocol was not
    /// registered as a CRM.
    /// </summary>
    CrmProtocolNotFound = 0xc0190011,

    /// <summary>
    /// Error - Transaction - The transaction object already has a superior
    /// enlistment, and the caller attempted an operation that would have
    /// created a new superior. Only a single superior enlistment is
    /// allowed.
    /// </summary>
    TransactionSuperiorExists = 0xc0190012,

    /// <summary>
    /// Error - Transaction - The requested operation is not valid on the
    /// transaction object in its current state.
    /// </summary>
    TransactionRequestNotValid = 0xc0190013,

    /// <summary>
    /// Error - Transaction - The caller has called a response API, but the
    /// response is not expected because the transaction manager did not
    /// issue the corresponding request to the caller.
    /// </summary>
    TransactionNotRequested = 0xc0190014,

    /// <summary>
    /// Error - Transaction - It is too late to perform the requested
    /// operation, because the transaction has already been aborted.
    /// </summary>
    TransactionAlreadyAborted = 0xc0190015,

    /// <summary>
    /// Error - Transaction - It is too late to perform the requested
    /// operation, because the transaction has already been committed.
    /// </summary>
    TransactionAlreadyCommitted = 0xc0190016,

    /// <summary>
    /// Error - Transaction - The buffer passed in to 
    /// <c>NtPushTransaction</c> or
    /// <c>NtPullTransaction</c> is not in a valid format.
    /// </summary>
    TransactionInvalidMarshallBuffer = 0xc0190017,

    /// <summary>
    /// Error - Transaction - The current transaction context associated
    /// with the thread is not a valid handle to a transaction object.
    /// </summary>
    CurrentTransactionNotValid = 0xc0190018,

    /// <summary>
    /// Error - Transaction - An attempt to create space in the
    /// transactional resource manager's log failed. The failure status has
    /// been recorded in the event log.
    /// </summary>
    LogGrowthFailed = 0xc0190019,

    /// <summary>
    /// Error - Transaction - The object (file, stream, or link) that
    /// corresponds to the handle has been deleted by a transaction
    /// save-point rollback.
    /// </summary>
    ObjectNoLongerExists = 0xc0190021,

    /// <summary>
    /// Error - Transaction - The specified file mini-version was not found
    /// for this transacted file open.
    /// </summary>
    StreamMiniversionNotFound = 0xc0190022,

    /// <summary>
    /// Error - Transaction - The specified file mini-version was found but
    /// has been invalidated. The most likely cause is a transaction
    /// save-point rollback.
    /// </summary>
    StreamMiniversionNotValid = 0xc0190023,

    /// <summary>
    /// Error - Transaction - A mini-version can be opened only in the
    /// context of the transaction that created it.
    /// </summary>
    MiniversionInaccessibleFromSpecifiedTransaction = 0xc0190024,

    /// <summary>
    /// Error - Transaction - It is not possible to open a mini-version with
    /// modify access.
    /// </summary>
    CantOpenMiniversionWithModifyIntent = 0xc0190025,

    /// <summary>
    /// Error - Transaction - It is not possible to create any more
    /// mini-versions for this stream.
    /// </summary>
    CantCreateMoreStreamMiniversions = 0xc0190026,

    /// <summary>
    /// Error - Transaction - The handle has been invalidated by a
    /// transaction. The most likely cause is the presence of memory mapping
    /// on a file or an open handle when the transaction ended or rolled
    /// back to save-point.
    /// </summary>
    HandleNoLongerValid = 0xc0190028,

    /// <summary>
    /// Error - Transaction - There is no transaction metadata on the file.
    /// </summary>
    NoTxfMetadata = 0xc0190029,

    /// <summary>
    /// Error - Transaction - The transaction outcome is unavailable because
    /// the resource manager responsible for it is disconnected.
    /// </summary>

    /// <summary>
    /// Error - The transaction outcome is unavailable because the resource
    /// manager responsible for it is disconnected.
    /// </summary>
    RmDisconnected = 0xc0190032,

    /// <summary>
    /// Error - Transaction - The request was rejected because the
    /// enlistment in question is not a superior enlistment.
    /// </summary>
    EnlistmentNotSuperior = 0xc0190033,

    /// <summary>
    /// Error - Transaction - The file cannot be opened in a transaction
    /// because its identity depends on the outcome of an unresolved
    /// transaction.
    /// </summary>

    /// <summary>
    /// Error - The file cannot be opened in a transaction because its
    /// identity depends on the outcome of an unresolved transaction.
    /// </summary>
    FileIdentityNotPersistent = 0xc0190036,

    /// <summary>
    /// Error - Transaction - The operation cannot be performed because
    /// another transaction is depending on this property not changing.
    /// </summary>
    CantBreakTransactionalDependency = 0xc0190037,

    /// <summary>
    /// Error - Transaction - The operation would involve a single file with
    /// two transactional resource managers and is, therefore, not allowed.
    /// </summary>
    CantCrossRmBoundary = 0xc0190038,

    /// <summary>
    /// Error - Transaction - The <c>$Txf</c> directory must be empty for
    /// this operation to succeed.
    /// </summary>
    TxfDirNotEmpty = 0xc0190039,

    /// <summary>
    /// Error - Transaction - The operation would leave a transactional
    /// resource manager in an inconsistent state and is therefore not
    /// allowed.
    /// </summary>
    IndoubtTransactionsExist = 0xc019003a,

    /// <summary>
    /// Error - Transaction - The operation could not be completed because
    /// the transaction manager does not have a log.
    /// </summary>
    TmVolatile = 0xc019003b,

    /// <summary>
    /// Error - Transaction - A rollback could not be scheduled because a
    /// previously scheduled rollback has already executed or been queued
    /// for execution.
    /// </summary>
    RollbackTimerExpired = 0xc019003c,

    /// <summary>
    /// Error - Transaction - The transactional metadata attribute on the
    /// file or directory is corrupt and unreadable.
    /// </summary>
    TxfAttributeCorrupt = 0xc019003d,

    /// <summary>
    /// Error - Transaction - The encryption operation could not be
    /// completed because a transaction is active.
    /// </summary>
    EfsNotAllowedInTransaction = 0xc019003e,

    /// <summary>
    /// Error - Transaction - This object is not allowed to be opened in a
    /// transaction.
    /// </summary>
    TransactionalOpenNotAllowed = 0xc019003f,

    /// <summary>
    /// Error - Transaction - Memory mapping (creating a mapped section) a
    /// remote file under a transaction is not supported.
    /// </summary>
    TransactedMappingUnsupportedRemote = 0xc0190040,

    /// <summary>
    /// Error - Transaction - Promotion was required to allow the resource
    /// manager to enlist, but the transaction was set to disallow it.
    /// </summary>

    /// <summary>
    /// Error - Promotion was required to allow the resource manager to
    /// enlist, but the transaction was set to disallow it.
    /// </summary>
    TransactionRequiredPromotion = 0xc0190043,

    /// <summary>
    /// Error - Transaction - This file is open for modification in an
    /// unresolved transaction and can be opened for execute only by a
    /// transacted reader.
    /// </summary>
    CannotExecuteFileInTransaction = 0xc0190044,

    /// <summary>
    /// Error - Transaction - The request to thaw frozen transactions was
    /// ignored because transactions were not previously frozen.
    /// </summary>
    TransactionsNotFrozen = 0xc0190045,

    /// <summary>
    /// Maximal value
    /// </summary>
    MaximumNtStatus = 0xffffffff
}
```

### NullFormatProvider.cs

```using System;

namespace DokanNet
{
    /// <summary>
    /// Provide support to format object with <c>null</c>.
    /// </summary>
    public class FormatProviders : IFormatProvider, ICustomFormatter
    {
        /// <summary>
        /// A Singleton instance of this class.
        /// </summary>
        public static readonly FormatProviders DefaultFormatProvider = new FormatProviders();

        /// <summary>
        /// A constant string that represents what to use if the formated object is <c>null</c>.
        /// </summary>
        public const string NullStringRepresentation = "<null>";

        /// <summary>
        /// Prevents a default instance of the <see cref="FormatProviders"/> class from being created. 
        /// </summary>
        private FormatProviders()
        {
        }

        /// <summary>
        /// Format a <see cref="FormattableString"/> using <see cref="DefaultFormatProvider"/>.
        /// </summary>
        /// <param name="formattable">The <see cref="FormattableString"/> to format.</param>
        /// <returns>The formated string.</returns>
#pragma warning disable 3001
        public static string DokanFormat(FormattableString formattable)
            => formattable.ToString(DefaultFormatProvider);
#pragma warning restore 3001

        /// <summary>
        /// Returns an object that provides formatting services for the
        /// specified type.
        /// </summary>
        /// <returns>An instance of the object specified by 
        /// <paramref name="formatType" />, if the 
        /// <see cref="T:System.IFormatProvider" /> implementation can supply
        /// that type of object; otherwise, <c>null</c>.</returns>
        /// <param name="formatType">An object that specifies the type of format
        /// object to return. </param>
        public object? GetFormat(Type? formatType)
        {
            return formatType == typeof(ICustomFormatter) ? this : null;
        }

        /// <summary>
        /// Converts the value of a specified object to an equivalent string
        /// representation using specified format and culture-specific
        /// formatting information.
        /// </summary>
        /// <returns>The string representation of the value of 
        /// <paramref name="arg" />, formatted as specified by 
        /// <paramref name="format" /> and <paramref name="formatProvider" />.
        /// </returns>
        /// <param name="format">A format string containing formatting
        /// specifications. </param>
        /// <param name="arg">An object to format. </param>
        /// <param name="formatProvider">An object that supplies format
        /// information about the current instance. </param>
        public string Format(string? format, object? arg, IFormatProvider? formatProvider)
        {
            if (arg == null)
            {
                return NullStringRepresentation;
            }

            var formattable = arg as IFormattable;

            return formattable?.ToString(format, formatProvider)
                ?? arg.ToString() ?? "";
        }
    }
}
```

## Project: DokanNet.Tests

### Project File: DokanNet.Tests.csproj

```<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <!--
    Each target framework is testing against a specific target framework of Dokan.
    
    To be able to test against netstandard1.3, .NET Core 1.X needs to be used, 
    but unfortunately, too much functionality is missing for it to work (e.g. TestContext.DataRow). 
    Maybe it will work with .NET Core 2.0 when launched.
    
    To be able to test net4.0, we have to use net4.5 (the lowest supported framework by MSTest).
    
    DokanNet            Test
    **************************
    net4.0              net4.5
    net4.6              net4.6
    netstandard1.3      <missing>
    -->
    <TargetFrameworks>net48</TargetFrameworks>
    <!--Add the Target Framework to the output file names. -->
    <AssemblyName>$(MSBuildProjectName)</AssemblyName>
    <CLSCompliant>True</CLSCompliant>
    <Nullable>disable</Nullable>
    <!-- We need to sign the test assembly to use it in InternalsVisibleTo for DokanNet.dll. -->
    <SignAssembly>false</SignAssembly>
    <AssemblyOriginatorKeyFile>..\DokanNet\Dokan.snk</AssemblyOriginatorKeyFile>
  </PropertyGroup>
  <ItemGroup>
    <Content Include="OverlappedTests.Configuration.xml">
      <DependentUpon>OverlappedTests.cs</DependentUpon>
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.13.0" />
    <PackageReference Include="Moq" Version="4.7.1" />
    <PackageReference Include="MSTest.TestAdapter" Version="3.8.3" />
    <PackageReference Include="MSTest.TestFramework" Version="3.8.3" />
  </ItemGroup>
  <ItemGroup>
    <ProjectReference Include="..\DokanNet\DokanNet.csproj" />
  </ItemGroup>
  <ItemGroup>
    <Service Include="{82a7f48d-3b50-4b1e-b82e-3ada8210c358}" />
  </ItemGroup>
  <PropertyGroup Condition="'$(Configuration)' == 'Release'">
    <CodeAnalysisRuleSet>DokanNet.Tests.ruleset</CodeAnalysisRuleSet>
    <!--Set to True to run Code Analysis-->
    <RunCodeAnalysis>False</RunCodeAnalysis>
  </PropertyGroup>
</Project>
```

### BufferPoolTests.cs

```using System;
using DokanNet.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DokanNet.Tests
{
    /// <summary>
    /// Tests for <see cref="BufferPool"/>.
    /// </summary>
    [TestClass]
    public sealed class BufferPoolTests
    {
        /// <summary>
        /// Rudimentary test for <see cref="BufferPool"/>.
        /// </summary>
        [TestMethod, TestCategory(TestCategories.Success)]
        public void BufferPoolBasicTest()
        {
            BufferPool pool = new BufferPool();
            ILogger logger = new TraceLogger();

            // Verify buffer is pooled.
            const int MB = 1024 * 1024;
            byte[] buffer = pool.RentBuffer(MB, logger);
            pool.ReturnBuffer(buffer, logger);

            byte[] buffer2 = pool.RentBuffer(MB, logger);
            Assert.AreSame(buffer, buffer2, "Expected recycling of 1 MB buffer.");

            // Verify buffer that buffer not power of 2 is not pooled.
            buffer = pool.RentBuffer(MB - 1, logger);
            pool.ReturnBuffer(buffer, logger);

            buffer2 = pool.RentBuffer(MB - 1, logger);
            Assert.AreNotSame(buffer, buffer2, "Did not expect recycling of 1 MB - 1 byte buffer.");

            // Run through a bunch of random buffer sizes and make sure we always get a buffer of the right size.
            int seed = Environment.TickCount;
            Console.WriteLine($"Random seed: {seed}");
            Random random = new Random(seed);

            for (int i = 0; i < 1000; i++)
            {
                int size = random.Next(0, 2 * MB);
                buffer = pool.RentBuffer(size, logger);
                Assert.AreEqual(size, buffer.Length, "Wrong buffer size.");
                pool.ReturnBuffer(buffer, logger);
            }
        }
    }
}
```

### ContextTests.cs

```using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DokanNet.Tests.FileSettings;

namespace DokanNet.Tests
{
    [TestClass]
    public sealed class ContextTests
    {
        private const int FILE_BUFFER_SIZE = 262144;

        private static byte[] smallData;

        private static byte[] largeData;

        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            smallData = new byte[4096];
            for (var i = 0; i < smallData.Length; ++i)
            {
                smallData[i] = (byte)(i % 256);
            }

            largeData = new byte[5 * FILE_BUFFER_SIZE + 65536];
            for (var i = 0; i < largeData.Length; ++i)
            {
                largeData[i] = (byte)(i % 251);
            }
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            largeData = null;
            smallData = null;
        }

        [TestInitialize]
        public void Initialize()
        {
            DokanOperationsFixture.InitInstance(TestContext.TestName);
        }

        [TestCleanup]
        public void Cleanup()
        {
            DokanOperationsFixture.ClearInstance(out bool hasUnmatchedInvocations);
            Assert.IsFalse(hasUnmatchedInvocations, "Found Mock invocations without corresponding setups");
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void Create_PassesContextCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            var value = $"TestValue for test {nameof(Create_PassesContextCorrectly)}";
            var context = new object();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadWriteAccess, WriteShare, FileMode.Create, FileOptions.None, context: context);
            fixture.ExpectWriteFile(path, Encoding.UTF8.GetBytes(value), value.Length, context: context);

            fixture.PermitProbeFile(path, Encoding.UTF8.GetBytes(value));
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.Create())
            {
                stream.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);
            }

#if !LOGONLY
            fixture.VerifyContextWriteInvocations(path, 1);
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenRead_PassesContextCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            var value = $"TestValue for test {nameof(OpenRead_PassesContextCorrectly)}";
            var context = new object();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadOnlyShare, FileMode.Open, FileOptions.None, context: context);
            fixture.ExpectReadFile(path, Encoding.UTF8.GetBytes(value), value.Length, context: context);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenRead())
            {
                var target = new byte[value.Length];
                var readBytes = stream.Read(target, 0, target.Length);
            }

#if !LOGONLY
            fixture.VerifyContextReadInvocations(path, 1);
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenRead_WithLargeFile_PassesContextCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            var context = new object();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadOnlyShare, FileMode.Open, FileOptions.None, context: context);
            fixture.ExpectReadFileInChunks(path, largeData, FILE_BUFFER_SIZE, context: context);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenRead())
            {
                var target = new byte[largeData.Length];
                var totalReadBytes = 0;
                do
                {
                    totalReadBytes += stream.Read(target, totalReadBytes, target.Length - totalReadBytes);

                    if (totalReadBytes == 0)
                    {
                        throw new EndOfStreamException("Unexpected end of file");
                    }
                } while (totalReadBytes < largeData.Length);
            }

#if !LOGONLY
            fixture.VerifyContextReadInvocations(path, 6);
#endif
        }

        [SuppressMessage("Microsoft.Reliability", "CA2002:DoNotLockOnObjectsWithWeakIdentity")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenRead_WithLargeFile_InParallel_PassesContextCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            var context = new object();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadOnlyShare, FileMode.Open, FileOptions.None, context: context);
            fixture.ExpectReadFileInChunks(path, largeData, FILE_BUFFER_SIZE, context: context);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenRead())
            {
                var target = new byte[largeData.Length];
                var totalReadBytes = 0;

                Parallel.For(0, DokanOperationsFixture.NumberOfChunks(FILE_BUFFER_SIZE, largeData.Length), i =>
                {
                    var origin = i * FILE_BUFFER_SIZE;
                    var count = Math.Min(FILE_BUFFER_SIZE, target.Length - origin);
                    lock (stream)
                    {
                        stream.Seek(origin, SeekOrigin.Begin);
                        totalReadBytes += stream.Read(target, origin, count);
                    }
                });
            }

#if !LOGONLY
            fixture.VerifyContextReadInvocations(path, 6);
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenWrite_PassesContextCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            var value = $"TestValue for test {nameof(OpenWrite_PassesContextCorrectly)}";
            var context = new object();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None, context: context);
            fixture.ExpectWriteFile(path, Encoding.UTF8.GetBytes(value), value.Length, context: context);

            fixture.PermitProbeFile(path, Encoding.UTF8.GetBytes(value));
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenWrite())
            {
                stream.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);
            }

#if !LOGONLY
            fixture.VerifyContextWriteInvocations(path, 1);
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenWrite_WithLargeFile_PassesContextCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            var context = new object();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None, context: context);
            fixture.ExpectWriteFileInChunks(path, largeData, FILE_BUFFER_SIZE, context: context);

            fixture.PermitProbeFile(path, largeData);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenWrite())
            {
                var totalWrittenBytes = 0;

                do
                {
                    var writtenBytes = Math.Min(FILE_BUFFER_SIZE, largeData.Length - totalWrittenBytes);
                    stream.Write(largeData, totalWrittenBytes, writtenBytes);
                    totalWrittenBytes += writtenBytes;
                } while (totalWrittenBytes < largeData.Length);
            }

#if !LOGONLY
            fixture.VerifyContextWriteInvocations(path, 6);
#endif
        }

        [SuppressMessage("Microsoft.Reliability", "CA2002:DoNotLockOnObjectsWithWeakIdentity")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenWrite_WithLargeFile_InParallel_PassesContextCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            var context = new object();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None, context: context);
            fixture.ExpectWriteFileInChunks(path, largeData, FILE_BUFFER_SIZE, context: context);

            fixture.PermitProbeFile(path, largeData);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenWrite())
            {
                var totalWrittenBytes = 0;

                Parallel.For(0, DokanOperationsFixture.NumberOfChunks(FILE_BUFFER_SIZE, largeData.Length), i =>
                {
                    var origin = i * FILE_BUFFER_SIZE;
                    var count = Math.Min(FILE_BUFFER_SIZE, largeData.Length - origin);
                    lock (stream)
                    {
                        stream.Seek(origin, SeekOrigin.Begin);
                        stream.Write(largeData, origin, count);
                        totalWrittenBytes += count;
                    }
                });
            }

#if !LOGONLY
            fixture.VerifyContextWriteInvocations(path, 6);
#endif
        }
    }
}
```

### DirectoryInfoTest.cs

```using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DokanNet.Tests.FileSettings;

namespace DokanNet.Tests
{
    [TestClass]
    public sealed class DirectoryInfoTest
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            DokanOperationsFixture.InitInstance(TestContext.TestName);
        }

        [TestCleanup]
        public void Cleanup()
        {
            DokanOperationsFixture.ClearInstance(out bool hasUnmatchedInvocations);
            Assert.IsFalse(hasUnmatchedInvocations, "Found Mock invocations without corresponding setups");
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetAttributes_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            var attributes = FileAttributes.Directory;
            var creationTime = new DateTime(2015, 1, 1, 12, 0, 0);
            var lastWriteTime = new DateTime(2015, 3, 31, 12, 0, 0);
            var lastAccessTime = new DateTime(2015, 4, 1, 6, 0, 0);
            fixture.ExpectCreateFile(path, ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, attributes, creationTime: creationTime, lastWriteTime: lastWriteTime, lastAccessTime: lastAccessTime);
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.Name, nameof(sut.Name));
            Assert.AreNotEqual(default(FileAttributes), sut.Attributes, nameof(sut.Attributes));
            Assert.AreNotEqual(DateTime.MinValue, sut.CreationTime, nameof(sut.CreationTime));
            Assert.AreNotEqual(DateTime.MinValue, sut.LastWriteTime, nameof(sut.LastWriteTime));
            Assert.AreNotEqual(DateTime.MinValue, sut.LastAccessTime, nameof(sut.LastAccessTime));
#else
            Assert.AreEqual(fixture.DirectoryName, sut.Name, nameof(sut.Name));
            Assert.AreEqual(fixture.DirectoryName.AsDriveBasedPath(), sut.FullName, nameof(sut.FullName));
            Assert.AreEqual(attributes, sut.Attributes, nameof(sut.Attributes));
            Assert.AreEqual(creationTime, sut.CreationTime, nameof(sut.CreationTime));
            Assert.AreEqual(lastWriteTime, sut.LastWriteTime, nameof(sut.LastWriteTime));
            Assert.AreEqual(lastAccessTime, sut.LastAccessTime, nameof(sut.LastAccessTime));

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetExists_WhereDirectoryExists_ReturnsCorrectResult()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName;
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path.AsRootedPath(), ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path.AsRootedPath(), FileAttributes.Directory);
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());
            Assert.IsTrue(sut.Exists, "Directory should exist");

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Failure)]
        public void GetExists_WhereDirectoryDoesNotExist_ReturnsCorrectResult()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName;
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileToFail(path.AsRootedPath(), DokanResult.PathNotFound);
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());
            Assert.IsFalse(sut.Exists, "Directory should not exist");

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetExtension_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#endif

            var sut = new DirectoryInfo(fixture.DirectoryName.AsDriveBasedPath());

            Assert.AreEqual(Path.GetExtension(path), sut.Extension, "Unexpected extension");

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetParent_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName;
#if LOGONLY
            fixture.PermitAny();
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());

            Assert.AreEqual(DokanOperationsFixture.RootName.AsDriveBasedPath(), sut.Parent.FullName, "Unexpected parent directory");

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetRoot_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName;
#if LOGONLY
            fixture.PermitAny();
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());

            Assert.AreEqual(DokanOperationsFixture.RootName.AsDriveBasedPath(), sut.Root.FullName, "Unexpected parent directory");

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void Create_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName;
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileToFail(path.AsRootedPath(), DokanResult.PathNotFound);
            fixture.ExpectCreateDirectory(path.AsRootedPath());
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());
            sut.Create();

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void Create_WhereTargetExists_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName;
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path.AsRootedPath(), ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path.AsRootedPath(), FileAttributes.Directory);
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());
            sut.Create();

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Failure)]
        [ExpectedException(typeof(IOException))]
        public void Create_WhereTargetIsFile_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName;
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path.AsRootedPath(), ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path.AsRootedPath(), FileAttributes.Normal);
            fixture.ExpectOpenDirectory(DokanOperationsFixture.RootName, FileAccess.Synchronize, FileShare.None);
            fixture.ExpectFindFiles(DokanOperationsFixture.RootName,
            [
                new FileInformation()
                {
                    FileName = path, Attributes = FileAttributes.Normal,
                    Length = 0,
                    CreationTime = DateTime.Today, LastWriteTime = DateTime.Today, LastAccessTime = DateTime.Today
                }
            ]);
            fixture.ExpectCreateDirectoryToFail(path.AsRootedPath(), DokanResult.FileExists);
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());
            sut.Create();
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void CreateSubdirectory_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            string basePath = fixture.DirectoryName,
                path = Path.Combine(basePath, fixture.SubDirectoryName);
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileToFail(path.AsRootedPath(), DokanResult.FileNotFound);
            fixture.ExpectCreateFile(basePath.AsRootedPath(), ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(basePath.AsRootedPath(), FileAttributes.Directory);
            fixture.ExpectCreateDirectory(path.AsRootedPath());
#endif

            var sut = new DirectoryInfo(basePath.AsDriveBasedPath());
            var directory = sut.CreateSubdirectory(fixture.SubDirectoryName);

#if LOGONLY
            Assert.IsNotNull(directory, nameof(sut.CreateSubdirectory));
            Console.WriteLine(sut.GetDirectories().Length);
#else
            Assert.IsNotNull(directory, nameof(sut.CreateSubdirectory));
            Assert.AreEqual(path.AsDriveBasedPath(), directory.FullName);

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void CreateSubdirectory_WhereTargetExists_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            string basePath = fixture.DirectoryName,
                path = Path.Combine(basePath, fixture.SubDirectoryName);
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path.AsRootedPath(), ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path.AsRootedPath(), FileAttributes.Directory);
#endif

            var sut = new DirectoryInfo(basePath.AsDriveBasedPath());
            var directory = sut.CreateSubdirectory(fixture.SubDirectoryName);

#if LOGONLY
            Assert.IsNotNull(directory, nameof(sut.CreateSubdirectory));
            Console.WriteLine(sut.GetDirectories().Length);
#else
            Assert.IsNotNull(directory, nameof(sut.CreateSubdirectory));
            Assert.AreEqual(path.AsDriveBasedPath(), directory.FullName);

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Failure)]
        [ExpectedException(typeof(IOException))]
        public void CreateSubdirectory_WhereTargetIsFile_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            string basePath = fixture.DirectoryName,
                path = Path.Combine(basePath, fixture.SubDirectoryName);
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path.AsRootedPath(), ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path.AsRootedPath(), FileAttributes.Normal);
            fixture.ExpectCreateFile(basePath.AsRootedPath(), ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(basePath.AsRootedPath(), FileAttributes.Directory);
            fixture.ExpectCreateDirectoryToFail(path.AsRootedPath(), DokanResult.FileExists);
#endif

            var sut = new DirectoryInfo(basePath.AsDriveBasedPath());
            sut.CreateSubdirectory(fixture.SubDirectoryName);
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void Delete_WhereRecurseIsFalse_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, FileAttributes.Directory);
            fixture.ExpectOpenDirectory(path, DeleteFromDirectoryAccess);
            fixture.ExpectDeleteDirectory(path);
#endif

            var sut = new DirectoryInfo(fixture.DirectoryName.AsDriveBasedPath());

            sut.Delete(false);

#if !LOGONLY
            fixture.Verify();
#endif
        }

        public static IEnumerable<object[]> ConfigFindFilesData
            => [[true], [false]];

        [DataTestMethod, TestCategory(TestCategories.Success), DynamicData(nameof(ConfigFindFilesData))]
        public void Delete_WhereRecurseIsTrueAndDirectoryIsNonempty_CallsApiCorrectly(bool supportsPatternSearch)
        {
            var fixture = DokanOperationsFixture.Instance;

            string path = fixture.DirectoryName.AsRootedPath(),
                subFileName = "SubFile.ext",
                subFilePath = Path.DirectorySeparatorChar + subFileName;
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, FileAttributes.Directory);
            fixture.ExpectOpenDirectory(path);
            if (supportsPatternSearch)
            {
                fixture.ExpectFindFilesWithPattern(path, "*", DokanOperationsFixture.GetEmptyDirectoryDefaultFiles().Concat(
                    [
                        new FileInformation()
                        {
                            FileName = subFileName, Attributes = FileAttributes.Normal,
                            Length = 100,
                            CreationTime = DateTime.Today, LastWriteTime = DateTime.Today, LastAccessTime = DateTime.Today
                        }
                    ]).ToArray());
            }
            else
            {
                fixture.ExpectFindFilesWithPatternToFail(path, "*", DokanResult.NotImplemented);
                fixture.ExpectFindFiles(path, DokanOperationsFixture.GetEmptyDirectoryDefaultFiles().Concat(
                [
                    new FileInformation()
                    {
                        FileName = subFileName, Attributes = FileAttributes.Normal,
                        Length = 100,
                        CreationTime = DateTime.Today, LastWriteTime = DateTime.Today, LastAccessTime = DateTime.Today
                    }
                ]).ToArray());
            }

            fixture.ExpectCreateFile(path + subFilePath, DeleteAccess, ReadWriteShare, FileMode.Open, deleteOnClose: true);
            fixture.ExpectGetFileInformation(path + subFilePath, FileAttributes.Normal);
            fixture.ExpectDeleteFile(path + subFilePath);
            fixture.ExpectOpenDirectory(path, DeleteFromDirectoryAccess);
            fixture.ExpectDeleteDirectory(path);
#endif

            var sut = new DirectoryInfo(fixture.DirectoryName.AsDriveBasedPath());

            sut.Delete(true);

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [DataTestMethod, TestCategory(TestCategories.Success), DynamicData(nameof(ConfigFindFilesData))]
        public void Delete_WhereRecurseIsTrueAndDirectoryIsEmpty_CallsApiCorrectly(bool supportsPatternSearch)
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, FileAttributes.Directory);
            fixture.ExpectOpenDirectory(path);
            if (supportsPatternSearch)
            {
                fixture.ExpectFindFilesWithPattern(path, "*", DokanOperationsFixture.GetEmptyDirectoryDefaultFiles());
            }
            else
            {
                fixture.ExpectFindFilesWithPatternToFail(path, "*", DokanResult.NotImplemented);
                fixture.ExpectFindFiles(path, DokanOperationsFixture.GetEmptyDirectoryDefaultFiles());
            }

            fixture.ExpectOpenDirectory(path, DeleteFromDirectoryAccess);
            fixture.ExpectDeleteDirectory(path);
#endif

            var sut = new DirectoryInfo(fixture.DirectoryName.AsDriveBasedPath());

            sut.Delete(true);

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetAccessControl_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName;
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path.AsRootedPath(), ReadAttributesPermissionsAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path.AsRootedPath(), FileAttributes.Directory);
            fixture.ExpectGetFileSecurity(path.AsRootedPath(), DokanOperationsFixture.DefaultDirectorySecurity);
            //No folder rights requested currently            
            //fixture.ExpectCreateFile(DokanOperationsFixture.RootName, ReadPermissionsAccess, ReadWriteShare, FileMode.Open);
            //fixture.ExpectGetFileInformation(DokanOperationsFixture.RootName, FileAttributes.Directory);
            //fixture.ExpectGetFileSecurity(DokanOperationsFixture.RootName,
            //    DokanOperationsFixture.DefaultDirectorySecurity);
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());
            var security = sut.GetAccessControl();

#if !LOGONLY
            Assert.IsNotNull(security, "Security descriptor should be set");
            Assert.AreEqual(DokanOperationsFixture.DefaultDirectorySecurity.AsString(), security.AsString(), "Security descriptors should match");
            fixture.Verify();
#endif
        }

        private void GetDirectories_OnRootDirectory_CallsApiCorrectly(bool supportsPatternSearch)
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = DokanOperationsFixture.RootName;
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectOpenDirectory(path);
            if (supportsPatternSearch)
            {
                fixture.ExpectFindFilesWithPattern(path, "*", fixture.RootDirectoryItems);
            }
            else
            {
                fixture.ExpectFindFilesWithPatternToFail(path, "*", DokanResult.NotImplemented);
                fixture.ExpectFindFiles(path, fixture.RootDirectoryItems);
            }

#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.GetDirectories(), nameof(sut.GetDirectories));
            Console.WriteLine(sut.GetDirectories().Length);
#else
            CollectionAssert.AreEqual(
                fixture.RootDirectoryItems.Where(i => i.Attributes.HasFlag(FileAttributes.Directory))
                    .Select(i => i.FileName)
                    .ToArray(),
                sut.GetDirectories().Select(d => d.Name).ToArray(),
                nameof(sut.GetDirectories));

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetDirectories_OnRootDirectory_WithPatternSearch_CallsApiCorrectly()
        {
            GetDirectories_OnRootDirectory_CallsApiCorrectly(true);
        }

        [TestMethod, TestCategory(TestCategories.Success), TestCategory(TestCategories.NoPatternSearch)]
        public void GetDirectories_OnRootDirectory_WithoutPatternSearch_CallsApiCorrectly()
        {
            GetDirectories_OnRootDirectory_CallsApiCorrectly(false);
        }

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "SubDirectory")]
        [DataTestMethod, TestCategory(TestCategories.Success), DynamicData(nameof(ConfigFindFilesData))]
        public void GetDirectories_OnSubDirectory_CallsApiCorrectly(bool supportsPatternSearch)
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectOpenDirectory(path);
            if (supportsPatternSearch)
            {
                fixture.ExpectFindFilesWithPattern(path, "*", fixture.DirectoryItems);
            }
            else
            {
                fixture.ExpectFindFilesWithPatternToFail(path, "*", DokanResult.NotImplemented);
                fixture.ExpectFindFiles(path, fixture.DirectoryItems);
            }
#endif

            var sut = new DirectoryInfo(fixture.DirectoryName.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.GetDirectories(), nameof(sut.GetDirectories));
            Console.WriteLine(sut.GetDirectories().Length);
#else
            CollectionAssert.AreEqual(
                fixture.DirectoryItems.Where(i => i.Attributes.HasFlag(FileAttributes.Directory))
                    .Select(i => i.FileName)
                    .ToArray(),
                sut.GetDirectories().Select(d => d.Name).ToArray(),
                nameof(sut.GetDirectories));

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetDirectoriesWithFilter_OnRootDirectory_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = DokanOperationsFixture.RootName;
            var filter = "*r2";
            var regex = new Regex(filter.Replace('?', '.').Replace("*", ".*"));
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectOpenDirectory(path);
            fixture.ExpectFindFilesWithPattern(path, filter, fixture.RootDirectoryItems.Where(i => regex.IsMatch(i.FileName)).ToList());
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.GetDirectories(filter), nameof(sut.GetDirectories));
            Console.WriteLine(sut.GetDirectories(filter).Length);
#else
            CollectionAssert.AreEqual(
                fixture.RootDirectoryItems.Where(
                    i => i.Attributes.HasFlag(FileAttributes.Directory) && regex.IsMatch(i.FileName))
                    .Select(i => i.FileName)
                    .ToArray(),
                sut.GetDirectories(filter).Select(d => d.Name).ToArray(),
                nameof(sut.GetDirectories));

            fixture.Verify();
#endif
        }

        [DataTestMethod, TestCategory(TestCategories.Success), DynamicData(nameof(ConfigFindFilesData))]
        public void GetFiles_OnRootDirectory_CallsApiCorrectly(bool supportsPatternSearch)
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = DokanOperationsFixture.RootName;
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectOpenDirectory(path);
            if (supportsPatternSearch)
            {
                fixture.ExpectFindFilesWithPattern(path, "*", fixture.RootDirectoryItems);
            }
            else
            {
                fixture.ExpectFindFilesWithPatternToFail(path, "*", DokanResult.NotImplemented);
                fixture.ExpectFindFiles(path, fixture.RootDirectoryItems);
            }
#endif

            var sut = new DirectoryInfo(DokanOperationsFixture.RootName.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.GetFiles(), nameof(sut.GetFiles));
            Console.WriteLine(sut.GetFiles().Length);
#else
            CollectionAssert.AreEqual(
                fixture.RootDirectoryItems.Where(i => i.Attributes.HasFlag(FileAttributes.Normal))
                    .Select(i => i.FileName)
                    .ToArray(),
                sut.GetFiles().Select(f => f.Name).ToArray(),
                nameof(sut.GetFiles));

            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "SubDirectory")]
        [DataTestMethod, TestCategory(TestCategories.Success), DynamicData(nameof(ConfigFindFilesData))]
        public void GetFiles_OnSubDirectory_CallsApiCorrectly(bool supportsPatternSearch)
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectOpenDirectory(path);
            if (supportsPatternSearch)
            {
                fixture.ExpectFindFilesWithPattern(path, "*", fixture.DirectoryItems);
            }
            else
            {
                fixture.ExpectFindFilesWithPatternToFail(path, "*", DokanResult.NotImplemented);
                fixture.ExpectFindFiles(path, fixture.DirectoryItems);
            }
#endif

            var sut = new DirectoryInfo(fixture.DirectoryName.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.GetFiles(), nameof(sut.GetFiles));
            Console.WriteLine(sut.GetFiles().Length);
#else
            CollectionAssert.AreEqual(
                fixture.DirectoryItems.Where(i => i.Attributes.HasFlag(FileAttributes.Normal))
                    .Select(i => i.FileName)
                    .ToArray(),
                sut.GetFiles().Select(f => f.Name).ToArray(),
                nameof(sut.GetFiles));

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetFilesWithFilter_OnRootDirectory_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = DokanOperationsFixture.RootName;
            var filter = "*bD*";
            var regex = new Regex(filter.Replace('?', '.').Replace("*", ".*"));
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectOpenDirectory(path);
            fixture.ExpectFindFilesWithPattern(path, filter, fixture.RootDirectoryItems.Where(i => regex.IsMatch(i.FileName)).ToList());
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.GetFiles(filter), nameof(sut.GetFiles));
            Console.WriteLine(sut.GetFiles(filter).Length);
#else
            CollectionAssert.AreEqual(
                fixture.RootDirectoryItems.Where(i => i.Attributes.HasFlag(FileAttributes.Normal) && regex.IsMatch(i.FileName))
                    .Select(i => i.FileName)
                    .ToArray(),
                sut.GetFiles(filter).Select(f => f.Name).ToArray(),
                nameof(sut.GetFiles));

            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "SubDirectory")]
        [DataTestMethod, TestCategory(TestCategories.Success), DynamicData(nameof(ConfigFindFilesData))]
        public void GetFiles_UnknownDates_CallsApiCorrectly(bool supportsPatternSearch)
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectOpenDirectory(path);
            //Remove all dates
            var files = DokanOperationsFixture.RemoveDatesFromFileInformations(fixture.DirectoryItems);

            if (supportsPatternSearch)
            {
                fixture.ExpectFindFilesWithPattern(path, "*", files);
            }
            else
            {
                fixture.ExpectFindFilesWithPatternToFail(path, "*", DokanResult.NotImplemented);
                fixture.ExpectFindFiles(path, files);
            }
#endif

            var sut = new DirectoryInfo(fixture.DirectoryName.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.GetFiles(), nameof(sut.GetFiles));
            Console.WriteLine(sut.GetFiles().Length);
#else
            var receivedFiles = sut.GetFiles();

            // As DirectoryInfo does not handle uninitialized DateTime values correctly
            // it has to be provided with DateTime.FromFileTime(0) as default minimum date
            var defaultDate = DateTime.FromFileTime(0);
            var expectedDateCollection = Enumerable.Repeat(defaultDate, receivedFiles.Length).ToArray();

            CollectionAssert.AreEqual(
                receivedFiles.Select(f => f.Name).ToArray(),
                fixture.DirectoryItems.Where(i => i.Attributes.HasFlag(FileAttributes.Normal)).Select(i => i.FileName).ToArray(),
                nameof(sut.GetFiles));

            CollectionAssert.AreEqual(
                expectedDateCollection,
                receivedFiles.Select(x => x.CreationTime).ToArray(),
                nameof(FileInformation.CreationTime));
            CollectionAssert.AreEqual(
                expectedDateCollection,
                receivedFiles.Select(x => x.LastWriteTime).ToArray(),
                nameof(FileInformation.LastWriteTime));
            CollectionAssert.AreEqual(
                expectedDateCollection,
                receivedFiles.Select(x => x.LastAccessTime).ToArray(),
                nameof(FileInformation.LastAccessTime));

            fixture.Verify();
#endif
        }

        [DataTestMethod, TestCategory(TestCategories.Success), DynamicData(nameof(ConfigFindFilesData))]
        public void GetFileSystemInfos_OnRootDirectory_CallsApiCorrectly(bool supportsPatternSearch)
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = DokanOperationsFixture.RootName;
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectOpenDirectory(path);
            if (supportsPatternSearch)
            {
                fixture.ExpectFindFilesWithPattern(path, "*", fixture.RootDirectoryItems);
            }
            else
            {
                fixture.ExpectFindFilesWithPatternToFail(path, "*", DokanResult.NotImplemented);
                fixture.ExpectFindFiles(path, fixture.RootDirectoryItems);
            }
#endif

            var sut = new DirectoryInfo(DokanOperationsFixture.RootName.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.GetFileSystemInfos(), nameof(sut.GetFileSystemInfos));
            Console.WriteLine(sut.GetFileSystemInfos().Length);
#else
            CollectionAssert.AreEqual(
                fixture.RootDirectoryItems.Select(i => i.FileName).ToArray(),
                sut.GetFileSystemInfos().Select(f => f.Name).ToArray(),
                nameof(sut.GetFileSystemInfos));

            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "SubDirectory")]
        [DataTestMethod, TestCategory(TestCategories.Success), DynamicData(nameof(ConfigFindFilesData))]
        public void GetFileSystemInfos_OnSubDirectory_CallsApiCorrectly(bool supportsPatternSearch)
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectOpenDirectory(path);
            if (supportsPatternSearch)
            {
                fixture.ExpectFindFilesWithPattern(path, "*", fixture.DirectoryItems);
            }
            else
            {
                fixture.ExpectFindFilesWithPatternToFail(path, "*", DokanResult.NotImplemented);
                fixture.ExpectFindFiles(path, fixture.DirectoryItems);
            }
#endif

            var sut = new DirectoryInfo(fixture.DirectoryName.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.GetFileSystemInfos(), nameof(sut.GetFileSystemInfos));
            Console.WriteLine(sut.GetFileSystemInfos().Length);
#else
            CollectionAssert.AreEqual(
                fixture.DirectoryItems.Select(i => i.FileName).ToArray(),
                sut.GetFileSystemInfos().Select(f => f.Name).ToArray(),
                nameof(sut.GetFileSystemInfos));

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetFileSystemInfosWithFilter_OnRootDirectory_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = DokanOperationsFixture.RootName;
            var filter = "*bD*";
            var regex = new Regex(filter.Replace('?', '.').Replace("*", ".*"));
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectOpenDirectory(path);
            fixture.ExpectFindFilesWithPattern(path, filter, fixture.RootDirectoryItems.Where(i => regex.IsMatch(i.FileName)).ToList());
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.GetFileSystemInfos(filter), nameof(sut.GetFileSystemInfos));
            Console.WriteLine(sut.GetFileSystemInfos(filter).Length);
#else
            CollectionAssert.AreEqual(
                fixture.RootDirectoryItems.Where(i => regex.IsMatch(i.FileName)).Select(i => i.FileName).ToArray(),
                sut.GetFileSystemInfos(filter).Select(f => f.Name).ToArray(),
                nameof(sut.GetFileSystemInfos));

            fixture.Verify();
#endif
        }

        [DataTestMethod, TestCategory(TestCategories.Success), DynamicData(nameof(ConfigFindFilesData))]
        public void GetFileSystemInfos_OnRootDirectory_WhereSearchOptionIsAllDirectories_CallsApiCorrectly(bool supportsPatternSearch)
        {
            var fixture = DokanOperationsFixture.Instance;

            var pathsAndItems = new[]
            {
                new { Path = DokanOperationsFixture.RootName, Items = fixture.RootDirectoryItems },
                new { Path = fixture.DirectoryName.AsRootedPath(), Items = DokanOperationsFixture.GetEmptyDirectoryDefaultFiles().Concat(fixture.DirectoryItems).ToArray() },
                new { Path = Path.Combine(fixture.DirectoryName, fixture.SubDirectoryName).AsRootedPath(), Items = DokanOperationsFixture.GetEmptyDirectoryDefaultFiles() .Concat(fixture.SubDirectoryItems) .ToArray() },
                new { Path = fixture.Directory2Name.AsRootedPath(), Items = DokanOperationsFixture.GetEmptyDirectoryDefaultFiles().Concat(fixture.Directory2Items).ToArray() },
                new { Path = Path.Combine(fixture.Directory2Name, fixture.SubDirectory2Name).AsRootedPath(), Items = DokanOperationsFixture.GetEmptyDirectoryDefaultFiles().ToArray() }
            };
#if LOGONLY
            fixture.PermitAny();
#else
            foreach (var pathAndItem in pathsAndItems)
            {
                fixture.ExpectOpenDirectory(pathAndItem.Path);
                if (supportsPatternSearch)
                {
                    fixture.ExpectFindFilesWithPattern(pathAndItem.Path, "*", pathAndItem.Items);
                }
                else
                {
                    fixture.ExpectFindFilesWithPatternToFail(pathAndItem.Path, "*", DokanResult.NotImplemented);
                    fixture.ExpectFindFiles(pathAndItem.Path, pathAndItem.Items);
                }
            }
#endif

            var sut = new DirectoryInfo(DokanOperationsFixture.RootName.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.GetFileSystemInfos(), nameof(sut.GetFileSystemInfos));
            Console.WriteLine(sut.GetFileSystemInfos().Length);
#else
            CollectionAssert.AreEqual(
                pathsAndItems.Select(p => p.Items.Where(f => f.FileName.Any(c => c != '.'))).Aggregate((i1, i2) => i1.Union(i2).ToArray()).Select(i => i.FileName).ToArray(),
                sut.GetFileSystemInfos("*", SearchOption.AllDirectories).Select(f => f.Name).ToArray(),
                nameof(sut.GetFileSystemInfos));

            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ParentIs")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void MoveTo_WhereParentIsRoot_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            string path = fixture.DirectoryName.AsRootedPath(),
                destinationPath = fixture.DestinationDirectoryName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileWithoutCleanup(path, MoveFromAccess, ReadWriteShare, FileMode.Open, FileOptions.None);
            fixture.ExpectGetFileInformation(path, FileAttributes.Directory);
            fixture.ExpectCreateFile(destinationPath, AppendToDirectoryAccess, FileShare.ReadWrite, FileMode.Open);
            fixture.ExpectOpenDirectoryWithoutCleanup(DokanOperationsFixture.RootName, AppendToDirectoryAccess, FileShare.ReadWrite);
            fixture.PermitGetFileInformationToFail(destinationPath, DokanResult.FileNotFound);
            fixture.PermitOpenDirectory(DokanOperationsFixture.RootName, attributes: FileAttributes.Normal);
            fixture.ExpectMoveFile(path, destinationPath, false);
#endif

            var sut = new DirectoryInfo(fixture.DirectoryName.AsDriveBasedPath());

            sut.MoveTo(fixture.DestinationDirectoryName.AsDriveBasedPath());

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ParentIs")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void MoveTo_WhereParentIsDirectory_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            string origin = Path.Combine(fixture.DirectoryName, fixture.SubDirectoryName),
                destination = Path.Combine(fixture.DestinationDirectoryName, fixture.DestinationSubDirectoryName),
                path = origin.AsRootedPath(),
                destinationPath = destination.AsRootedPath();

#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileWithoutCleanup(path, MoveFromAccess, ReadWriteShare, FileMode.Open, FileOptions.None);
            fixture.ExpectGetFileInformation(path, FileAttributes.Directory);
            fixture.ExpectOpenDirectoryWithoutCleanup(fixture.DestinationDirectoryName.AsRootedPath(), AppendToDirectoryAccess, FileShare.ReadWrite);
            fixture.ExpectCreateFile(destinationPath, AppendToDirectoryAccess, FileShare.ReadWrite, FileMode.Open);
            fixture.PermitGetFileInformationToFail(destinationPath, DokanResult.PathNotFound);
            fixture.PermitOpenDirectory(fixture.DestinationDirectoryName.AsRootedPath(), attributes: FileAttributes.Normal);
            fixture.ExpectMoveFile(path, destinationPath, false);
#endif

            var sut = new DirectoryInfo(origin.AsDriveBasedPath());

            sut.MoveTo(destination.AsDriveBasedPath());

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Failure)]
        [ExpectedException(typeof(DirectoryNotFoundException), "Expected DirectoryNotFoundException not thrown")]
        public void MoveTo_WhereSourceDoesNotExist_Throws()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileToFail(path, DokanResult.PathNotFound);
#endif

            var sut = new DirectoryInfo(fixture.DirectoryName.AsDriveBasedPath());

            sut.MoveTo(fixture.DestinationDirectoryName.AsDriveBasedPath());
        }

        [TestMethod, TestCategory(TestCategories.Failure)]
        [ExpectedException(typeof(IOException), "Expected IOException not thrown")]
        public void MoveTo_WhereTargetExists_Throws()
        {
            var fixture = DokanOperationsFixture.Instance;

            string path = fixture.DirectoryName.AsRootedPath(),
                destinationPath = fixture.DestinationDirectoryName.AsRootedPath();
#if LOGONLY
                fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, MoveFromAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, FileAttributes.Directory);
            fixture.ExpectCreateFileToFail(destinationPath, DokanResult.FileExists);
            fixture.ExpectOpenDirectoryWithoutCleanup(DokanOperationsFixture.RootName, AppendToDirectoryAccess, FileShare.ReadWrite);
            fixture.ExpectGetFileInformation(destinationPath, FileAttributes.Directory);
            fixture.ExpectOpenDirectory(DokanOperationsFixture.RootName, attributes: FileAttributes.Normal);
            fixture.ExpectMoveFileToFail(path, destinationPath, false, DokanResult.FileExists);
#endif

            var sut = new DirectoryInfo(fixture.DirectoryName.AsDriveBasedPath());

            sut.MoveTo(fixture.DestinationDirectoryName.AsDriveBasedPath());

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [DataTestMethod, TestCategory(TestCategories.Success), DynamicData(nameof(ConfigFindFilesData))]
        public void SetAccessControl_CallsApiCorrectly(bool supportsPatternSearch)
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.DirectoryName;
            var security = new DirectorySecurity();
            security.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null),
                FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path.AsRootedPath(), ChangePermissionsAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path.AsRootedPath(), FileAttributes.Directory);
            fixture.ExpectGetFileSecurity(path.AsRootedPath(), DokanOperationsFixture.DefaultDirectorySecurity);
            fixture.ExpectOpenDirectory(path.AsRootedPath(), share: FileShare.ReadWrite);
            if (supportsPatternSearch)
            {
                fixture.ExpectFindFilesWithPattern(path.AsRootedPath(), "*", []);
            }
            else
            {
                fixture.ExpectFindFilesWithPatternToFail(path.AsRootedPath(), "*", DokanResult.NotImplemented);
                fixture.ExpectFindFiles(path.AsRootedPath(), []);
            }

            fixture.ExpectSetFileSecurity(path.AsRootedPath(), security);
            fixture.ExpectCreateFile(DokanOperationsFixture.RootName, ReadPermissionsAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(DokanOperationsFixture.RootName, FileAttributes.Directory);
            fixture.ExpectGetFileSecurity(DokanOperationsFixture.RootName, DokanOperationsFixture.DefaultDirectorySecurity, AccessControlSections.Access);
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());
            sut.SetAccessControl(security);

#if !LOGONLY
            fixture.Verify();
#endif
        }
    }
}
```

### DokanOperationsFixture.cs

```using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using Castle.Core.Internal;
using Moq;
using Moq.Language;
using static DokanNet.Tests.FileSettings;

namespace DokanNet.Tests
{
    [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
    internal sealed class DokanOperationsFixture
    {
        private class Proxy : IDokanOperations
        {
            public IDokanOperations Target { get; set; }

            public bool HasUnmatchedInvocations { get; set; }

            #region Delegates
            private delegate TResult FuncOut2<in T1, T2, in T3, out TResult>(T1 arg1, out T2 arg2, T3 arg3);

            private delegate TResult FuncOut2<in T1, T2, in T3, in T4, out TResult>(T1 arg1, out T2 arg2, T3 arg3, T4 arg4);

            private delegate TResult FuncOut123<T1, T2, T3, in T4, out TResult>(out T1 arg1, out T2 arg2, out T3 arg3, T4 arg4);

            private delegate TResult FuncOut1234<T1, T2, T3, T4, in T5, out TResult>(out T1 arg1, out T2 arg2, out T3 arg3, out T4 arg4, T5 arg5);

            private delegate TResult FuncOut23<in T1, in T2, T3, T4, in T5, out TResult>(T1 arg1, T2 arg2, out T3 arg3, out T4 arg4, T5 arg5);

            private delegate TResult FuncOut3<in T1, in T2, T3, in T4, out TResult>(T1 arg1, T2 arg2, out T3 arg3, T4 arg4);

            protected delegate TResult FuncOut3<in T1, in T2, T3, in T4, in T5, out TResult>(T1 arg1, T2 arg2, out T3 arg3, T4 arg4, T5 arg5);
            #endregion

            #region private TryExecute overloads
            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private void TryExecute(string fileName, IDokanFileInfo info, Action<string, IDokanFileInfo> func, string funcName, bool restrictCallingProcessId = true)
            {
                if (restrictCallingProcessId && info.ProcessId != Process.GetCurrentProcess().Id)
                {
                    return;
                }

                try
                {
                    func(fileName, info);
                }
                catch (Exception ex)
                {
                    Trace($"{funcName} (\"{fileName}\", {info.Log()}) -> **{ex.GetType().Name}**: {ex.Message}\n{ex.StackTrace}");
                    if (ex is MockException)
                    {
                        HasUnmatchedInvocations = true;
                    }
                }
            }

            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private NtStatus TryExecute(IDokanFileInfo info, Func<IDokanFileInfo, NtStatus> func, string funcName)
            {
                if (info.ProcessId != Process.GetCurrentProcess().Id)
                {
                    return DokanResult.AccessDenied;
                }

                try
                {
                    return func(info);
                }
                catch (Exception ex)
                {
                    Trace($"{funcName} ({info.Log()}) -> **{ex.GetType().Name}**: {ex.Message}\n{ex.StackTrace}");
                    if (ex is MockException)
                    {
                        HasUnmatchedInvocations = true;
                    }

                    return DokanResult.InvalidParameter;
                }
            }

            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private NtStatus TryExecute(string fileName, IDokanFileInfo info, Func<string, IDokanFileInfo, NtStatus> func, string funcName)
            {
                if (info.ProcessId != Process.GetCurrentProcess().Id)
                {
                    return DokanResult.AccessDenied;
                }

                try
                {
                    return func(fileName, info);
                }
                catch (Exception ex)
                {
                    Trace($"{funcName} (\"{fileName}\", {info.Log()}) -> **{ex.GetType().Name}**: {ex.Message}\n{ex.StackTrace}");
                    if (ex is MockException)
                    {
                        HasUnmatchedInvocations = true;
                    }

                    return DokanResult.InvalidParameter;
                }
            }

            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private NtStatus TryExecute<T>(string fileName, T arg, IDokanFileInfo info, Func<string, T, IDokanFileInfo, NtStatus> func, string funcName)
            {
                if (info.ProcessId != Process.GetCurrentProcess().Id)
                {
                    return DokanResult.AccessDenied;
                }

                try
                {
                    return func(fileName, arg, info);
                }
                catch (Exception ex)
                {
                    Trace($"{funcName} (\"{fileName}\", {arg}, {info.Log()}) -> **{ex.GetType().Name}**: {ex.Message}\n{ex.StackTrace}");
                    if (ex is MockException)
                    {
                        HasUnmatchedInvocations = true;
                    }

                    return DokanResult.InvalidParameter;
                }
            }

            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private NtStatus TryExecute<T1, T2>(string fileName, T1 arg1, T2 arg2, IDokanFileInfo info, Func<string, T1, T2, IDokanFileInfo, NtStatus> func, string funcName)
            {
                if (info.ProcessId != Process.GetCurrentProcess().Id)
                {
                    return DokanResult.AccessDenied;
                }

                try
                {
                    return func(fileName, arg1, arg2, info);
                }
                catch (Exception ex)
                {
                    Trace($"{funcName} (\"{fileName}\", {arg1}, {arg2}, {info.Log()}) -> **{ex.GetType().Name}**: {ex.Message}\n{ex.StackTrace}");
                    if (ex is MockException)
                    {
                        HasUnmatchedInvocations = true;
                    }

                    return DokanResult.InvalidParameter;
                }
            }

            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private NtStatus TryExecute<T1, T2, T3>(string fileName, T1 arg1, T2 arg2, T3 arg3, IDokanFileInfo info, Func<string, T1, T2, T3, IDokanFileInfo, NtStatus> func, string funcName)
            {
                if (info.ProcessId != Process.GetCurrentProcess().Id)
                {
                    return DokanResult.AccessDenied;
                }

                try
                {
                    return func(fileName, arg1, arg2, arg3, info);
                }
                catch (Exception ex)
                {
                    Trace($"{funcName} (\"{fileName}\", {arg1}, {arg2}, {arg3}, {info.Log()}) -> **{ex.GetType().Name}**: {ex.Message}\n{ex.StackTrace}");
                    if (ex is MockException)
                    {
                        HasUnmatchedInvocations = true;
                    }

                    return DokanResult.InvalidParameter;
                }
            }

            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private NtStatus TryExecute<TIn, TOut>(string fileName, TIn argIn, out TOut argOut, IDokanFileInfo info, FuncOut3<string, TIn, TOut, IDokanFileInfo, NtStatus> func, string funcName)
            {
                if (info.ProcessId != Process.GetCurrentProcess().Id)
                {
                    argOut = default(TOut);
                    return DokanResult.AccessDenied;
                }

                try
                {
                    return func(fileName, argIn, out argOut, info);
                }
                catch (Exception ex)
                {
                    Trace($"{funcName} (\"{fileName}\", {argIn}, {info.Log()}) -> **{ex.GetType().Name}**: {ex.Message}\n{ex.StackTrace}");
                    if (ex is MockException)
                    {
                        HasUnmatchedInvocations = true;
                    }

                    argOut = default(TOut);
                    return DokanResult.InvalidParameter;
                }
            }

            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private NtStatus TryExecute<TOut>(string fileName, out TOut argOut, IDokanFileInfo info, FuncOut2<string, TOut, IDokanFileInfo, NtStatus> func, string funcName)
            {
                if (info.ProcessId != Process.GetCurrentProcess().Id)
                {
                    argOut = default(TOut);
                    return DokanResult.AccessDenied;
                }

                try
                {
                    return func(fileName, out argOut, info);
                }
                catch (Exception ex)
                {
                    Trace($"{funcName} (\"{fileName}\", {info.Log()}) -> **{ex.GetType().Name}**: {ex.Message}\n{ex.StackTrace}");
                    if (ex is MockException)
                    {
                        HasUnmatchedInvocations = true;
                    }

                    argOut = default(TOut);
                    return DokanResult.InvalidParameter;
                }
            }

            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private NtStatus TryExecute<TOut, TIn>(string fileName, out TOut argOut, TIn argIn, IDokanFileInfo info, FuncOut2<string, TOut, TIn, IDokanFileInfo, NtStatus> func, string funcName)
            {
                if (info.ProcessId != Process.GetCurrentProcess().Id)
                {
                    argOut = default(TOut);
                    return DokanResult.AccessDenied;
                }

                try
                {
                    return func(fileName, out argOut, argIn, info);
                }
                catch (Exception ex)
                {
                    Trace($"{funcName} (\"{fileName}\", {argIn}, {info.Log()}) -> **{ex.GetType().Name}**: {ex.Message}\n{ex.StackTrace}");
                    if (ex is MockException)
                    {
                        HasUnmatchedInvocations = true;
                    }

                    argOut = default(TOut);
                    return DokanResult.InvalidParameter;
                }
            }

            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private NtStatus TryExecute<TIn1, TOut, TIn2>(string fileName, TIn1 argIn1, out TOut argOut, TIn2 argIn2, IDokanFileInfo info, FuncOut3<string, TIn1, TOut, TIn2, IDokanFileInfo, NtStatus> func, string funcName)
            {
                if (info.ProcessId != Process.GetCurrentProcess().Id)
                {
                    argOut = default(TOut);
                    return DokanResult.AccessDenied;
                }

                try
                {
                    return func(fileName, argIn1, out argOut, argIn2, info);
                }
                catch (Exception ex)
                {
                    Trace($"{funcName} (\"{fileName}\", {argIn1}, {argIn2}, {info.Log()}) -> **{ex.GetType().Name}**: {ex.Message}\n{ex.StackTrace}");
                    if (ex is MockException)
                    {
                        HasUnmatchedInvocations = true;
                    }

                    argOut = default(TOut);
                    return DokanResult.InvalidParameter;
                }
            }

            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private NtStatus TryExecute<TOut1, TOut2, TOut3, TOut4>(out TOut1 argOut1, out TOut2 argOut2, out TOut3 argOut3, out TOut4 argOut4, IDokanFileInfo info, FuncOut1234<TOut1, TOut2, TOut3, TOut4, IDokanFileInfo, NtStatus> func, string funcName)
            {
                if (info.ProcessId != Process.GetCurrentProcess().Id)
                {
                    argOut1 = default(TOut1);
                    argOut2 = default(TOut2);
                    argOut3 = default(TOut3);
                    argOut4 = default(TOut4);
                    return DokanResult.AccessDenied;
                }

                try
                {
                    return func(out argOut1, out argOut2, out argOut3, out argOut4, info);
                }
                catch (Exception ex)
                {
                    Trace($"{funcName} ({info.Log()}) -> **{ex.GetType().Name}**: {ex.Message}\n{ex.StackTrace}");
                    if (ex is MockException)
                    {
                        HasUnmatchedInvocations = true;
                    }

                    argOut1 = default(TOut1);
                    argOut2 = default(TOut2);
                    argOut3 = default(TOut3);
                    argOut4 = default(TOut4);
                    return DokanResult.InvalidParameter;
                }
            }

            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private NtStatus TryExecute<TOut1, TOut2, TOut3>(out TOut1 argOut1, out TOut2 argOut2, out TOut3 argOut3, IDokanFileInfo info, FuncOut123<TOut1, TOut2, TOut3, IDokanFileInfo, NtStatus> func, string funcName)
            {
                if (info.ProcessId != Process.GetCurrentProcess().Id)
                {
                    argOut1 = default(TOut1);
                    argOut2 = default(TOut2);
                    argOut3 = default(TOut3);
                    return DokanResult.AccessDenied;
                }

                try
                {
                    return func(out argOut1, out argOut2, out argOut3, info);
                }
                catch (Exception ex)
                {
                    Trace($"{funcName} ({info.Log()}) -> **{ex.GetType().Name}**: {ex.Message}\n{ex.StackTrace}");
                    if (ex is MockException)
                    {
                        HasUnmatchedInvocations = true;
                    }

                    argOut1 = default(TOut1);
                    argOut2 = default(TOut2);
                    argOut3 = default(TOut3);
                    return DokanResult.InvalidParameter;
                }
            }
            #endregion

            #region IDokanOperations members
            public void Cleanup(string fileName, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                TryExecute(fileName, info, (f, i) => Target.Cleanup(f, i), nameof(Cleanup), false);
            }

            public void CloseFile(string fileName, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                TryExecute(fileName, info, (f, i) => Target.CloseFile(f, i), nameof(CloseFile), false);
            }

            public NtStatus CreateFile(string fileName, FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, info, (f, i) => Target.CreateFile(f, access, share, mode, options, attributes, i), nameof(CreateFile));
            }

            public NtStatus DeleteDirectory(string fileName, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, info, (f, i) => Target.DeleteDirectory(f, i), nameof(DeleteDirectory));
            }

            public NtStatus DeleteFile(string fileName, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, info, (f, i) => Target.DeleteFile(f, i), nameof(DeleteFile));
            }

            public NtStatus FindFiles(string fileName, out IList<FileInformation> files, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, out files, info, (string f, out IList<FileInformation> o, IDokanFileInfo i) => Target.FindFiles(f, out o, i), nameof(FindFiles));
            }

            public NtStatus FindFilesWithPattern(string fileName, string searchPattern, out IList<FileInformation> files, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, searchPattern, out files, info, (string f, string s, out IList<FileInformation> o, IDokanFileInfo i) => Target.FindFilesWithPattern(f, s, out o, i), nameof(FindFilesWithPattern));
            }

            public NtStatus FindStreams(string fileName, out IList<FileInformation> streams, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, out streams, info, (string f, out IList<FileInformation> o, IDokanFileInfo i) => Target.FindStreams(f, out o, i), nameof(FindStreams));
            }

            public NtStatus FlushFileBuffers(string fileName, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, info, (f, i) => Target.FlushFileBuffers(f, i), nameof(FlushFileBuffers));
            }

            public NtStatus GetDiskFreeSpace(out long freeBytesAvailable, out long totalNumberOfBytes, out long totalNumberOfFreeBytes, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(out freeBytesAvailable, out totalNumberOfBytes, out totalNumberOfFreeBytes, info, (out long a, out long t, out long f, IDokanFileInfo i) => Target.GetDiskFreeSpace(out a, out t, out f, i), nameof(GetDiskFreeSpace));
            }

            public NtStatus GetFileInformation(string fileName, out FileInformation fileInfo, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, out fileInfo, info, (string f, out FileInformation fi, IDokanFileInfo i) => Target.GetFileInformation(f, out fi, i), nameof(GetFileInformation));
            }

            public NtStatus GetFileSecurity(string fileName, out FileSystemSecurity security, AccessControlSections sections, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, out security, sections, info, (string f, out FileSystemSecurity s, AccessControlSections a, IDokanFileInfo i) => Target.GetFileSecurity(f, out s, a, i), nameof(GetFileSecurity));
            }

            public NtStatus GetVolumeInformation(out string volumeLabel, out FileSystemFeatures features, out string fileSystemName, out uint maximumComponentLength, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(out volumeLabel, out features, out fileSystemName, out maximumComponentLength, info, (out string v, out FileSystemFeatures f, out string n, out uint c, IDokanFileInfo i) => Target.GetVolumeInformation(out v, out f, out n, out c, i), nameof(GetVolumeInformation));
            }

            public NtStatus LockFile(string fileName, long offset, long length, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, offset, length, info, (f, o, l, i) => Target.LockFile(f, o, l, i), nameof(LockFile));
            }

            public NtStatus MoveFile(string oldName, string newName, bool replace, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(oldName, newName, replace, info, (o, n, r, i) => Target.MoveFile(o, n, r, i), nameof(MoveFile));
            }

            public NtStatus ReadFile(string fileName, byte[] buffer, out int bytesRead, long offset, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, buffer, out bytesRead, offset, info, (string f, byte[] b, out int r, long o, IDokanFileInfo i) => Target.ReadFile(f, b, out r, o, i), nameof(ReadFile));
            }

            public NtStatus SetAllocationSize(string fileName, long length, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, length, info, (f, l, i) => Target.SetAllocationSize(f, l, i), nameof(SetAllocationSize));
            }

            public NtStatus SetEndOfFile(string fileName, long length, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, length, info, (f, l, i) => Target.SetEndOfFile(f, l, i), nameof(SetEndOfFile));
            }

            public NtStatus SetFileAttributes(string fileName, FileAttributes attributes, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, attributes, info, (f, a, i) => Target.SetFileAttributes(f, a, i), nameof(SetFileAttributes));
            }

            public NtStatus SetFileSecurity(string fileName, FileSystemSecurity security, AccessControlSections sections, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, security, sections, info, (f, s, a, i) => Target.SetFileSecurity(f, s, a, i), nameof(SetFileSecurity));
            }

            public NtStatus SetFileTime(string fileName, DateTime? creationTime, DateTime? lastAccessTime, DateTime? lastWriteTime, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, creationTime, lastAccessTime, lastWriteTime, info, (f, c, a, w, i) => Target.SetFileTime(f, c, a, w, i), nameof(SetFileTime));
            }

            public NtStatus UnlockFile(string fileName, long offset, long length, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, offset, length, info, (f, o, l, i) => Target.UnlockFile(f, o, l, i), nameof(UnlockFile));
            }

            public NtStatus Mounted(string mountPoint, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(mountPoint, info, (m, i) => Target.Mounted(m, i), nameof(Mounted));
            }

            public NtStatus Unmounted(IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(info, i => Target.Unmounted(i), nameof(Unmounted));
            }
            public NtStatus WriteFile(string fileName, byte[] buffer, out int bytesWritten, long offset, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return TryExecute(fileName, buffer, out bytesWritten, offset, info, (string f, byte[] b, out int w, long o, IDokanFileInfo i) => Target.WriteFile(f, b, out w, o, i), nameof(WriteFile));
            }
            #endregion
        }

        /// <summary>
        /// Subclass of <see cref="Proxy"/> that implements <see cref="IDokanOperationsUnsafe"/> by manually marshalling the unmanaged buffers
        /// to managed byte[] arrays and subsequently invoking the regular Read/WriteFile(byte[]) overload on the base proxy class.
        /// </summary>
        private class UnsafeProxy : Proxy, IDokanOperationsUnsafe
        {
            public NtStatus ReadFile(string fileName, IntPtr buffer, uint bufferLength, out int bytesRead, long offset, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return MarshalUnsafeCall(fileName, buffer, bufferLength, out bytesRead, offset, info,
                    (string f, byte[] buf, out int r, long o, IDokanFileInfo i) => base.ReadFile(f, buf, out r, o, i));
            }

            public NtStatus WriteFile(string fileName, IntPtr buffer, uint bufferLength, out int bytesWritten, long offset, IDokanFileInfo info)
            {
                if (!(info is IDokanFileInfo))
                {
                    throw new ArgumentException("Not IDokanFileInfo", nameof(info));
                }

                return MarshalUnsafeCall(fileName, buffer, bufferLength, out bytesWritten, offset, info,
                    (string f, byte[] buf, out int r, long o, IDokanFileInfo i) => base.WriteFile(f, buf, out r, o, i));
            }

            #region MarshalUnsafeCall implementation
            [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Explicit Exception handler")]
            private NtStatus MarshalUnsafeCall(string fileName, IntPtr nativeBuffer, uint bufferLength, out int bytes, long offset, IDokanFileInfo info,
                FuncOut3<string, byte[], int, long, IDokanFileInfo, NtStatus> func)
            {
                byte[] managedBuffer = new byte[bufferLength];
                Marshal.Copy(source: nativeBuffer, destination: managedBuffer, startIndex: 0, length: (int)bufferLength);
                NtStatus result = func(fileName, managedBuffer, out bytes, offset, info);
                Marshal.Copy(source: managedBuffer, startIndex: 0, destination: nativeBuffer, length: (int)bufferLength);
                return result;
            }
            #endregion
        }

        /// <summary>The mount point in use for the <see cref="IDokanOperations"/> implementation.</summary>
        public static string NormalMountPoint { get; private set; }

        /// <summary>The mount point in use for the <see cref="IDokanOperationsUnsafe"/> implementation.</summary>
        public static string UnsafeMountPoint { get; private set; }

        /// <summary>
        /// Initializes the mount points by finding the next available drive letters.
        /// </summary>
        private static void InitMountPoints()
        {
            var drives = Environment.GetLogicalDrives()
                .Select(x => x[0])
                .ToArray();

            var alphabet = new Stack<char>("ABCDEFGHILMNOPQRSTUVZ");

            NormalMountPoint = GetMountPoint();
            UnsafeMountPoint = GetMountPoint();

            string GetMountPoint()
            {
                while (alphabet.Any())
                {
                    var letter = alphabet.Pop();
                    if (!drives.Contains(letter))
                    {
                        return $"{letter}:";
                    }
                }

                throw new InvalidOperationException("No drive letters available to test with.");
            }
        }

        public static string MOUNT_POINT { get; private set; }

        public const string VOLUME_LABEL = "Dokan Volume";

        public const string FILESYSTEM_NAME = "Dokan Test";

        internal const int PROBE_BUFFER_SIZE = 512;

        private const FileSystemFeatures TestFileSystemFeatures =
            FileSystemFeatures.CasePreservedNames | FileSystemFeatures.CaseSensitiveSearch |
            FileSystemFeatures.SupportsRemoteStorage | FileSystemFeatures.UnicodeOnDisk;

        private const FileAttributes EmptyFileAttributes = default(FileAttributes);

        private static Proxy proxy = new Proxy();
        private static Proxy unsafeProxy = new UnsafeProxy();

        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private string currentTestName;

        private Mock<IDokanOperations> operations = new Mock<IDokanOperations>();

        private long pendingFiles;

        public static bool HasPendingFiles => Instance?.pendingFiles > 0;

        private HashSet<string> deletePendingExpected = [];
        private HashSet<string> deletePendingExecuted = [];

        internal static IDokanOperations Operations => proxy;
        internal static IDokanOperations UnsafeOperations => unsafeProxy;

        internal static DokanOperationsFixture Instance { get; private set; }

        internal static string DriveName => MOUNT_POINT;

        internal static string RootName => @"\";

        private const string fileName = "File.ext";

        private const string destinationFileName = "DestinationFile.txe";

        private const string destinationBackupFileName = "BackupFile.txe";

        private const string directoryName = "Dir";

        private const string directory2Name = "Dir2";

        private const string destinationDirectoryName = "DestinationDir";

        private const string subDirectoryName = "SubDir";

        private const string subDirectory2Name = "SubDir2";

        private const string destinationSubDirectoryName = "DestinationSubDir";

        private static FileInformation[] rootDirectoryItems =
        [
            new FileInformation()
            {
                FileName = directoryName, Attributes = FileAttributes.Directory,
                CreationTime = ToDateTime("2015-01-01 10:11:12"), LastWriteTime = ToDateTime("2015-01-01 20:21:22"), LastAccessTime = ToDateTime("2015-01-01 20:21:22")
            },
            new FileInformation()
            {
                FileName = directory2Name, Attributes = FileAttributes.Directory,
                CreationTime = ToDateTime("2015-01-01 13:14:15"), LastWriteTime = ToDateTime("2015-01-01 23:24:25"), LastAccessTime = ToDateTime("2015-01-01 23:24:25")
            },
            new FileInformation()
            {
                FileName = fileName, Attributes = FileAttributes.Normal,
                CreationTime = ToDateTime("2015-01-02 10:11:12"), LastWriteTime = ToDateTime("2015-01-02 20:21:22"), LastAccessTime = ToDateTime("2015-01-02 20:21:22")
            },
            new FileInformation()
            {
                FileName = "SecondFile.ext", Attributes = FileAttributes.Normal,
                CreationTime = ToDateTime("2015-01-03 10:11:12"), LastWriteTime = ToDateTime("2015-01-03 20:21:22"), LastAccessTime = ToDateTime("2015-01-03 20:21:22")
            },
            new FileInformation()
            {
                FileName = "ThirdFile.ext", Attributes = FileAttributes.Normal,
                CreationTime = ToDateTime("2015-01-04 10:11:12"), LastWriteTime = ToDateTime("2015-01-04 20:21:22"), LastAccessTime = ToDateTime("2015-01-04 20:21:22")
            }
        ];

        private static FileInformation[] directoryItems =
        [
            new FileInformation()
            {
                FileName = subDirectoryName, Attributes = FileAttributes.Directory,
                CreationTime = ToDateTime("2015-02-01 10:11:12"), LastWriteTime = ToDateTime("2015-02-01 20:21:22"), LastAccessTime = ToDateTime("2015-02-01 20:21:22")
            },
            new FileInformation()
            {
                FileName = "SubFile.ext", Attributes = FileAttributes.Normal,
                CreationTime = ToDateTime("2015-02-02 10:11:12"), LastWriteTime = ToDateTime("2015-02-02 20:21:22"), LastAccessTime = ToDateTime("2015-02-02 20:21:22")
            },
            new FileInformation()
            {
                FileName = "SecondSubFile.ext", Attributes = FileAttributes.Normal,
                CreationTime = ToDateTime("2015-02-03 10:11:12"), LastWriteTime = ToDateTime("2015-02-03 20:21:22"), LastAccessTime = ToDateTime("2015-02-03 20:21:22")
            },
            new FileInformation()
            {
                FileName = "ThirdSubFile.ext", Attributes = FileAttributes.Normal,
                CreationTime = ToDateTime("2015-02-04 10:11:12"), LastWriteTime = ToDateTime("2015-02-04 20:21:22"), LastAccessTime = ToDateTime("2015-02-04 20:21:22")
            }
        ];

        private static FileInformation[] directory2Items =
        [
            new FileInformation()
            {
                FileName = subDirectory2Name, Attributes = FileAttributes.Directory,
                CreationTime = ToDateTime("2015-02-01 10:11:12"), LastWriteTime = ToDateTime("2015-02-01 20:21:22"), LastAccessTime = ToDateTime("2015-02-01 20:21:22")
            },
            new FileInformation()
            {
                FileName = "SubFile2.ext", Attributes = FileAttributes.Normal,
                CreationTime = ToDateTime("2015-02-02 10:11:12"), LastWriteTime = ToDateTime("2015-02-02 20:21:22"), LastAccessTime = ToDateTime("2015-02-02 20:21:22")
            },
            new FileInformation()
            {
                FileName = "SecondSubFile2.ext", Attributes = FileAttributes.Normal,
                CreationTime = ToDateTime("2015-02-03 10:11:12"), LastWriteTime = ToDateTime("2015-02-03 20:21:22"), LastAccessTime = ToDateTime("2015-02-03 20:21:22")
            },
            new FileInformation()
            {
                FileName = "ThirdSubFile2.ext", Attributes = FileAttributes.Normal,
                CreationTime = ToDateTime("2015-02-04 10:11:12"), LastWriteTime = ToDateTime("2015-02-04 20:21:22"), LastAccessTime = ToDateTime("2015-02-04 20:21:22")
            }
        ];

        private static FileInformation[] subDirectoryItems =
        [
            new FileInformation()
            {
                FileName = "SubSubFile.ext", Attributes = FileAttributes.Normal,
                CreationTime = ToDateTime("2015-03-01 10:11:12"), LastWriteTime = ToDateTime("2015-03-01 20:21:22"), LastAccessTime = ToDateTime("2015-03-01 20:21:22")
            },
            new FileInformation()
            {
                FileName = "SecondSubSubFile.ext", Attributes = FileAttributes.Normal,
                CreationTime = ToDateTime("2015-03-02 10:11:12"), LastWriteTime = ToDateTime("2015-03-02 20:21:22"), LastAccessTime = ToDateTime("2015-03-02 20:21:22")
            },
            new FileInformation()
            {
                FileName = "ThirdSubSubFile.ext", Attributes = FileAttributes.Normal,
                CreationTime = ToDateTime("2015-03-03 10:11:12"), LastWriteTime = ToDateTime("2015-03-03 20:21:22"), LastAccessTime = ToDateTime("2015-03-03 20:21:22")
            }
        ];

        internal static DirectorySecurity DefaultDirectorySecurity { get; private set; }

        internal static FileSecurity DefaultFileSecurity { get; private set; }

        internal static TimeSpan IODelay = TimeSpan.FromSeconds(19);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal string FileName => Named(fileName);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal string DestinationFileName => Named(destinationFileName);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal string DestinationBackupFileName => Named(destinationBackupFileName);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal string DirectoryName => Named(directoryName);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal string Directory2Name => Named(directory2Name);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal string DestinationDirectoryName => Named(destinationDirectoryName);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal string SubDirectoryName => Named(subDirectoryName);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal string SubDirectory2Name => Named(subDirectory2Name);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal string DestinationSubDirectoryName => Named(destinationSubDirectoryName);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal FileInformation[] RootDirectoryItems => Named(rootDirectoryItems);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal FileInformation[] DirectoryItems => Named(directoryItems);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal FileInformation[] Directory2Items => Named(directory2Items);

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal FileInformation[] SubDirectoryItems => Named(subDirectoryItems);

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
        static DokanOperationsFixture()
        {
            InitInstance(string.Empty);
            Instance.PermitMount();

            InitSecurity();
            InitMountPoints();
        }

        private static DateTime ToDateTime(string value) => DateTime.Parse(value, CultureInfo.InvariantCulture);

        internal static int NumberOfChunks(long bufferSize, long fileSize)
        {
            var quotient = Math.DivRem(fileSize, bufferSize, out long remainder);
            return (int)quotient + (remainder > 0 ? 1 : 0);
        }

        internal static string DriveBasedPath(string fileName)
            => DriveName + RootedPath(fileName);

        internal static string RootedPath(string fileName)
            => Path.DirectorySeparatorChar + fileName.TrimStart(Path.DirectorySeparatorChar);

        /// <summary>
        /// Initializes the test fixture for running a test.
        /// </summary>
        /// <param name="currentTestName">The name of the test.</param>
        /// <param name="unsafeOperations">True to test IDokanOperationsUnsafe, false to test IDokanOperations.</param>
        internal static void InitInstance(string currentTestName, bool unsafeOperations = false)
        {
            Instance = new DokanOperationsFixture(currentTestName);

            proxy.Target = Instance.operations.Object;
            proxy.HasUnmatchedInvocations = false;
            unsafeProxy.Target = Instance.operations.Object;
            unsafeProxy.HasUnmatchedInvocations = false;

            // Choose the mount point to operate on based on whether we're testing IDokanOperation of IDokanOperationsUnsafe.
            MOUNT_POINT = unsafeOperations ? UnsafeMountPoint : NormalMountPoint;
        }

        internal static void ClearInstance(out bool hasUnmatchedInvocations)
        {
            // Allow pending calls to process
            Thread.Sleep(1);

            Proxy proxyInUse = MOUNT_POINT == UnsafeMountPoint ? unsafeProxy : proxy;
            hasUnmatchedInvocations = proxyInUse.HasUnmatchedInvocations;

            proxy.Target = null;
            unsafeProxy.Target = null;
            Instance = null;
            MOUNT_POINT = null;
        }

        internal static void Trace(string message)
        {
            Console.WriteLine(message);
        }

        internal static void InitSecurity()
        {
            var sid = WindowsIdentity.GetCurrent();

            var sidRights = "O:" + sid.User + "G:" + sid.Groups[0];

            DefaultDirectorySecurity = new DirectorySecurity();
            DefaultDirectorySecurity.SetSecurityDescriptorSddlForm(sidRights + "D:PAI(A;OICI;FA;;;AU)");

            DefaultFileSecurity = new FileSecurity();
            DefaultFileSecurity.SetSecurityDescriptorSddlForm(sidRights + "D:AI(A;ID;FA;;;AU)");
        }

        internal static IList<FileInformation> GetEmptyDirectoryDefaultFiles()
            =>
            [
                new FileInformation()
                {
                    FileName = ".", Attributes = FileAttributes.Directory,
                    CreationTime = DateTime.Today, LastWriteTime = DateTime.Today, LastAccessTime = DateTime.Today
                },
                new FileInformation()
                {
                    FileName = "..", Attributes = FileAttributes.Directory,
                    CreationTime = DateTime.Today, LastWriteTime = DateTime.Today, LastAccessTime = DateTime.Today
                }
            ];

        internal static IList<FileInformation> RemoveDatesFromFileInformations(IEnumerable<FileInformation> fileInformations)
        {
            return fileInformations
                .Select(x => new FileInformation()
                {
                    FileName = x.FileName,
                    Attributes = x.Attributes,
                    CreationTime = null,
                    LastAccessTime = null,
                    LastWriteTime = null,
                    Length = x.Length
                }).ToArray();
        }

        internal static byte[] InitPeriodicTestData(long fileSize)
            => Enumerable.Range(0, (int)fileSize).Select(i => (byte)(i % 251)).ToArray();

        internal static byte[] InitBlockTestData(long bufferSize, long fileSize)
            => Enumerable.Range(0, (int)fileSize).Select(i => (byte)(i / bufferSize + 1)).ToArray();

        public DokanOperationsFixture(string currentTestName)
        {
            this.currentTestName = currentTestName;
        }

#if !SPECIFIC_NAMES
        private string Named(string name) => name;
#else
        private string Named(string name) => $"{currentTestName}_{name}";
#endif

        private FileInformation[] Named(FileInformation[] infos)
            => infos.Aggregate(new List<FileInformation>(), (l, i) =>
            {
                l.Add(Named(i));
                return l;
            }, l => l.ToArray());

        private FileInformation Named(FileInformation info) => new FileInformation()
        {
            FileName = Named(info.FileName),
            Attributes = info.Attributes,
            CreationTime = info.CreationTime,
            LastAccessTime = info.LastAccessTime,
            LastWriteTime = info.LastWriteTime,
            Length = info.Length
        };

        private static Func<IDokanFileInfo, bool> FilterByIsDirectory(bool? isDirectory)
            => f => !isDirectory.HasValue || f.IsDirectory == isDirectory.Value;

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
        [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal void PermitAny()
        {
            operations
                .Setup(d => d.Cleanup(It.IsAny<string>(), It.IsAny<IDokanFileInfo>()))
                .Callback((string fileName, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.Cleanup)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {info.Log()})"));

            operations
                .Setup(d => d.CloseFile(It.IsAny<string>(), It.IsAny<IDokanFileInfo>()))
                .Callback((string fileName, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.CloseFile)}[{Interlocked.Decrement(ref pendingFiles)}] (\"{fileName}\", {info.Log()})"));

            operations
                .Setup(d => d.CreateFile(It.IsAny<string>(), It.IsAny<FileAccess>(), It.IsAny<FileShare>(), It.IsAny<FileMode>(), It.IsAny<FileOptions>(), It.IsAny<FileAttributes>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.CreateFile)}[{Interlocked.Increment(ref pendingFiles)}] (\"{fileName}\", [{access}], [{share}], {mode}, [{options}], [{attributes}], {info.Log()})"));

            operations
                .Setup(d => d.DeleteDirectory(It.IsAny<string>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, IDokanFileInfo info)
                    =>
                {
                    if (info.DeletePending)
                    {
                        deletePendingExpected.Add(fileName);
                    }
                    else
                    {
                        deletePendingExpected.Remove(fileName);
                    }

                    Trace($"{nameof(IDokanOperations.DeleteDirectory)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {info.Log()})");
                });

            operations
                .Setup(d => d.DeleteFile(It.IsAny<string>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, IDokanFileInfo info)
                    =>
                {
                    if (info.DeletePending)
                    {
                        deletePendingExpected.Add(fileName);
                    }
                    else
                    {
                        deletePendingExpected.Remove(fileName);
                    }

                    Trace($"{nameof(IDokanOperations.DeleteFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {info.Log()})");
                });

            var files = GetEmptyDirectoryDefaultFiles();
            operations
                .Setup(d => d.FindFiles(It.IsAny<string>(), out files, It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, IList<FileInformation> _files, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.FindFiles)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", out [{_files.Count}], {info.Log()})"));

            operations
                .Setup(d => d.FlushFileBuffers(It.IsAny<string>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.FlushFileBuffers)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {info.Log()})"));

            long freeBytesAvailable = 0;
            long totalNumberOfBytes = 0;
            long totalNumberOfFreeBytes = 0;
            operations
                .Setup(d => d.GetDiskFreeSpace(out freeBytesAvailable, out totalNumberOfBytes, out totalNumberOfFreeBytes, It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((long _freeBytesAvailable, long _totalNumberOfBytes, long _totalNumberOfFreeBytes, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.GetDiskFreeSpace)}[{Interlocked.Read(ref pendingFiles)}] (out {_freeBytesAvailable}, out {_totalNumberOfBytes}, out {_totalNumberOfFreeBytes}, {info.Log()})"));

            var directoryInfo = new FileInformation()
            {
                FileName = "DummyDir",
                Attributes = FileAttributes.Directory,
                CreationTime = new DateTime(2015, 1, 1, 12, 0, 0),
                LastWriteTime = new DateTime(2015, 3, 31, 12, 0, 0),
                LastAccessTime = new DateTime(2015, 5, 31, 12, 0, 0)
            };
            operations
                .Setup(d => d.GetFileInformation(It.IsAny<string>(), out directoryInfo, It.Is<IDokanFileInfo>(i => i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileInformation _directoryInfo, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.GetFileInformation)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", out [{_directoryInfo.Log()}], {info.Log()})"));
            var fileInfo = new FileInformation()
            {
                FileName = "Dummy.ext",
                Attributes = FileAttributes.Normal,
                CreationTime = new DateTime(2015, 1, 1, 12, 0, 0),
                LastWriteTime = new DateTime(2015, 3, 31, 12, 0, 0),
                LastAccessTime = new DateTime(2015, 5, 31, 12, 0, 0),
                Length = 1024
            };
            operations
                .Setup(d => d.GetFileInformation(It.IsAny<string>(), out fileInfo, It.Is<IDokanFileInfo>(i => !i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileInformation _fileInfo, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.GetFileInformation)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", out [{_fileInfo.Log()}], {info.Log()})"));

            var fileSecurity = new FileSecurity() as FileSystemSecurity;
            operations
                .Setup(d => d.GetFileSecurity(It.IsAny<string>(), out fileSecurity, It.IsAny<AccessControlSections>(), It.Is<IDokanFileInfo>(i => !i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileSystemSecurity _fileSecurity, AccessControlSections sections, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.GetFileSecurity)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", out {_fileSecurity}, {sections}, {info.Log()})"));
            var directorySecurity = new DirectorySecurity() as FileSystemSecurity;
            operations
                .Setup(d => d.GetFileSecurity(It.IsAny<string>(), out directorySecurity, It.IsAny<AccessControlSections>(), It.Is<IDokanFileInfo>(i => i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileSystemSecurity _directorySecurity, AccessControlSections sections, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.GetFileSecurity)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", out {_directorySecurity}, {sections}, {info.Log()})"));

            var volumeLabel = VOLUME_LABEL;
            var features = TestFileSystemFeatures;
            var fileSystemName = FILESYSTEM_NAME;
            uint maximumComponentLength = 256;
            operations
                .Setup(d => d.GetVolumeInformation(out volumeLabel, out features, out fileSystemName, out maximumComponentLength, It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string _volumeLabel, FileSystemFeatures _features, string _fileSystemName, uint _maximumComponentLength, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.GetVolumeInformation)}[{Interlocked.Read(ref pendingFiles)}] (out \"{_volumeLabel}\", out [{_features}], out \"{_fileSystemName}\", out \"{_maximumComponentLength}\", {info.Log()})"));

            operations
                .Setup(d => d.LockFile(It.IsAny<string>(), It.IsAny<long>(), It.IsAny<long>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, long offset, long length, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.LockFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {offset}, {length}, {info.Log()})"));

            operations
                .Setup(d => d.MoveFile(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string oldName, string newName, bool replace, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.MoveFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{oldName}\", \"{newName}\", {replace}, {info.Log()})"));

            var bytesRead = 0;
            operations
                .Setup(d => d.ReadFile(It.IsAny<string>(), It.IsAny<byte[]>(), out bytesRead, It.IsAny<long>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, byte[] buffer, int _bytesRead, long offset, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.ReadFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{buffer.Length}], out {_bytesRead}, {offset}, {info.Log()})"));

            operations
                .Setup(d => d.SetAllocationSize(It.IsAny<string>(), It.IsAny<long>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, long length, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.SetAllocationSize)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {length}, {info.Log()})"));

            operations
                .Setup(d => d.SetEndOfFile(It.IsAny<string>(), It.IsAny<long>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, long length, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.SetEndOfFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {length}, {info.Log()})"));

            operations
                .Setup(d => d.SetFileAttributes(It.IsAny<string>(), It.IsAny<FileAttributes>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileAttributes attributes, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.SetFileAttributes)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{attributes}], {info.Log()})"));

            operations
                .Setup(d => d.SetFileSecurity(It.IsAny<string>(), It.IsAny<FileSystemSecurity>(), It.IsAny<AccessControlSections>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileSystemSecurity security, AccessControlSections sections, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.SetFileSecurity)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{security}], {sections}, {info.Log()})"));

            operations
                .Setup(d => d.SetFileTime(It.IsAny<string>(), It.IsAny<DateTime?>(), It.IsAny<DateTime?>(), It.IsAny<DateTime?>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, DateTime? creationTime, DateTime? lastAccessTime, DateTime? lastWriteTime, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.SetFileTime)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {creationTime}, {lastAccessTime}, {lastWriteTime}, {info.Log()})"));

            operations
                .Setup(d => d.UnlockFile(It.IsAny<string>(), It.IsAny<long>(), It.IsAny<long>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, long offset, long length, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.UnlockFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {offset}, {length}, {info.Log()})"));

            operations
                .Setup(d => d.Mounted(It.IsAny<string>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string mountPoint, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.Mounted)}[{Interlocked.Read(ref pendingFiles)}] ({info.Log()})"));

            operations
                .Setup(d => d.Unmounted(It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.Unmounted)}[{Interlocked.Read(ref pendingFiles)}] ({info.Log()})"));

            var bytesWritten = 0;
            operations
                .Setup(d => d.WriteFile(It.IsAny<string>(), It.IsAny<byte[]>(), out bytesWritten, It.IsAny<long>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, byte[] buffer, int _bytesWritten, long offset, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.WriteFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{buffer.Length}], out {_bytesWritten}, {offset}, {info.Log()})"));
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
        private void PermitMount()
        {
            operations
                .Setup(d => d.Mounted(It.IsAny<string>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string mountPoint, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.Mounted)} {info.Log()}"));
            operations
                .Setup(d => d.CreateFile(RootName, FileAccess.ReadAttributes, ReadWriteShare, FileMode.Open, FileOptions.None, EmptyFileAttributes, It.Is<IDokanFileInfo>(i => !i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.CreateFile)}[{Interlocked.Increment(ref pendingFiles)}] (\"{fileName}\", [{access}], [{share}], {mode}, [{options}], [{attributes}], {info.Log()})"));
            var fileInfo = new FileInformation()
            {
                FileName = RootName,
                Attributes = FileAttributes.Directory,
                CreationTime = new DateTime(2015, 1, 1, 12, 0, 0),
                LastWriteTime = new DateTime(2015, 3, 31, 12, 0, 0),
                LastAccessTime = new DateTime(2015, 3, 31, 12, 0, 0)
            };
            operations
                .Setup(d => d.GetFileInformation(RootName, out fileInfo, It.Is<IDokanFileInfo>(i => !i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileInformation _fileInfo, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.GetFileInformation)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", out [{_fileInfo.Log()}], {info.Log()})"));
            operations
                .Setup(d => d.Cleanup(RootName, It.IsAny<IDokanFileInfo>()))
                .Callback((string fileName, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.Cleanup)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {info.Log()})"));
            operations
                .Setup(d => d.CloseFile(RootName, It.IsAny<IDokanFileInfo>()))
                .Callback((string fileName, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.CloseFile)}[{Interlocked.Decrement(ref pendingFiles)}] (\"{fileName}\", {info.Log()})"));
        }

        internal void ExpectGetDiskFreeSpace(long freeBytesAvailable = 0, long totalNumberOfBytes = 0,
            long totalNumberOfFreeBytes = 0)
        {
            ExpectOpenDirectory(RootName, OpenDirectoryAccess, OpenDirectoryShare);

            operations
                .Setup(d => d.GetDiskFreeSpace(out freeBytesAvailable, out totalNumberOfBytes, out totalNumberOfFreeBytes, It.Is<IDokanFileInfo>(i => i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((long _freeBytesAvailable, long _totalNumberOfBytes, long _totalNumberOfFreeBytes, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.GetDiskFreeSpace)}[{Interlocked.Read(ref pendingFiles)}] (out {_freeBytesAvailable}, out {_totalNumberOfBytes}, out {_totalNumberOfFreeBytes}, {info.Log()})"))
                .Verifiable();
        }

        internal void ExpectGetVolumeInformation(string volumeLabel, string fileSystemName, uint maximumComponentLength)
        {
            var features = TestFileSystemFeatures;
            operations
                .Setup(d => d.GetVolumeInformation(out volumeLabel, out features, out fileSystemName, out maximumComponentLength, It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string _volumeLabel, FileSystemFeatures _features, string _fileSystemName, uint _maximumComponentLength, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.GetVolumeInformation)}[{Interlocked.Read(ref pendingFiles)}] (out \"{_volumeLabel}\", out [{_features}], out \"{_fileSystemName}\", out \"{_maximumComponentLength}\", {info.Log()})"))
                .Verifiable();
        }

        private IVerifies SetupGetFileInformation(string path, FileAttributes attributes, bool? isDirectory = null, DateTime? creationTime = null, DateTime? lastWriteTime = null, DateTime? lastAccessTime = null, long? length = null)
        {
            var fileInfo = new FileInformation()
            {
                FileName = path,
                Attributes = attributes,
                CreationTime = creationTime,
                LastWriteTime = lastWriteTime,
                LastAccessTime = lastAccessTime,
                Length = length ?? 0
            };
            return operations
                .Setup(d => d.GetFileInformation(path, out fileInfo, It.Is<IDokanFileInfo>(i => FilterByIsDirectory(isDirectory)(i))))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileInformation _fileInfo, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.GetFileInformation)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", out [{_fileInfo.Log()}], {info.Log()})"));
        }

        internal void PermitGetFileInformation(string path, FileAttributes attributes, bool? isDirectory = null, DateTime? creationTime = null, DateTime? lastWriteTime = null, DateTime? lastAccessTime = null, long? length = null)
        {
            SetupGetFileInformation(path, attributes, isDirectory, creationTime, lastWriteTime, lastAccessTime, length);
        }

        internal void ExpectGetFileInformation(string path, FileAttributes attributes, bool? isDirectory = null, DateTime? creationTime = null, DateTime? lastWriteTime = null, DateTime? lastAccessTime = null, long? length = null)
        {
            SetupGetFileInformation(path, attributes, isDirectory, creationTime, lastWriteTime, lastAccessTime, length)
                .Verifiable();
        }

        private IVerifies SetupGetFileInformationToFail(string path, NtStatus result, bool? isDirectory = null)
        {
            if (result == DokanResult.Success)
            {
                throw new ArgumentException($"{DokanResult.Success} not supported", nameof(result));
            }

            var fileInfo = default(FileInformation);
            return operations
                .Setup(d => d.GetFileInformation(path, out fileInfo, It.Is<IDokanFileInfo>(i => FilterByIsDirectory(isDirectory)(i))))
                .Returns(result)
                .Callback((string fileName, FileInformation _fileInfo, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.GetFileInformation)}[{Interlocked.Read(ref pendingFiles)}] **{result}** (\"{fileName}\", out [{_fileInfo.Log()}], {info.Log()})"));
        }

        internal void PermitGetFileInformationToFail(string path, NtStatus result, bool? isDirectory = null)
        {
            SetupGetFileInformationToFail(path, result, isDirectory);
        }

        internal void ExpectGetFileInformationToFail(string path, NtStatus result, bool? isDirectory = null)
        {
            SetupGetFileInformationToFail(path, result, isDirectory).Verifiable();
        }

        internal void ExpectFindFiles(string path, IList<FileInformation> fileInfos)
        {
            operations
                .Setup(d => d.FindFiles(path, out fileInfos, It.Is<IDokanFileInfo>(i => i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, IList<FileInformation> _files, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.FindFiles)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", out [{_files.Count}], {info.Log()})"))
                .Verifiable();
        }

        internal void ExpectFindFilesWithPattern(string path, string searchPattern, IList<FileInformation> fileInfos)
        {
            operations
                .Setup(d => d.FindFilesWithPattern(path, searchPattern, out fileInfos, It.Is<IDokanFileInfo>(i => i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, string _searchPattern, IList<FileInformation> _files, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.FindFilesWithPattern)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", \"{_searchPattern}\", out [{_files.Count}], {info.Log()})"))
                .Verifiable();
        }

        internal void ExpectFindFilesWithPatternToFail(string path, string searchPattern, NtStatus result)
        {
            var fileInfos = new List<FileInformation>() as IList<FileInformation>;
            operations
                .Setup(d => d.FindFilesWithPattern(path, searchPattern, out fileInfos, It.Is<IDokanFileInfo>(i => i.IsDirectory)))
                .Returns(result)
                .Callback((string fileName, string _searchPattern, IList<FileInformation> _files, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.FindFilesWithPattern)}[{Interlocked.Read(ref pendingFiles)}] **{result}** (\"{fileName}\", \"{_searchPattern}\", out [{_files.Count}], {info.Log()})"))
                .Verifiable();
        }

        internal void ExpectOpenDirectoryWithoutCleanup(string path, FileAccess access = FileAccess.Synchronize, FileShare share = FileShare.None, FileAttributes attributes = EmptyFileAttributes)
        {
            operations
                .Setup(d => d.CreateFile(path, FileAccessUtils.MapSpecificToGenericAccess(access), share, FileMode.Open, ReadFileOptions, attributes, It.Is<IDokanFileInfo>(i => i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileAccess _access, FileShare _share, FileMode mode, FileOptions options, FileAttributes _attributes, IDokanFileInfo info)
                        => Trace($"{nameof(IDokanOperations.CreateFile)}-NoCleanup[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{_access}], [{_share}], {mode}, [{options}], [{_attributes}], {info.Log()})"))
                .Verifiable();
        }

        internal void PermitOpenDirectory(string path, FileAccess access = ReadDirectoryAccess, FileShare share = ReadWriteShare, FileOptions options = ReadFileOptions, FileAttributes attributes = EmptyFileAttributes)
        {
            PermitCreateDirectory(path, access, share, FileMode.Open, options, attributes);
        }

        internal void ExpectOpenDirectory(string path, FileAccess access = ReadDirectoryAccess, FileShare share = ReadWriteShare, FileOptions options = ReadFileOptions, FileAttributes attributes = EmptyFileAttributes)
        {
            ExpectCreateDirectory(path, access, share, FileMode.Open, options, attributes);
        }

        private IVerifies[] SetupCreateDirectory(string path, FileAccess access = ReadDirectoryAccess, FileShare share = FileShare.ReadWrite, FileMode mode = FileMode.CreateNew, FileOptions options = FileOptions.None, FileAttributes attributes = FileAttributes.Normal)
        {
            return
            [
                operations
                    .Setup(d => d.CreateFile(path, FileAccessUtils.MapSpecificToGenericAccess(access), share, mode, options, attributes, It.Is<IDokanFileInfo>(i => i.IsDirectory)))
                    .Returns(DokanResult.Success)
                    .Callback((string fileName, FileAccess _access, FileShare _share, FileMode _mode, FileOptions _options, FileAttributes _attributes, IDokanFileInfo info)
                        => Trace($"{nameof(IDokanOperations.CreateFile)}[{Interlocked.Increment(ref pendingFiles)}] (\"{fileName}\", [{_access}], [{_share}], {_mode}, [{_options}], [{_attributes}], {info.Log()})")),
                operations
                    .Setup(d => d.Cleanup(path, It.Is<IDokanFileInfo>(i => i.IsDirectory)))
                    .Callback((string fileName, IDokanFileInfo info)
                        => {
                            if (info.DeletePending)
                            {
                                deletePendingExecuted.Add(fileName);
                            }

                            Trace($"{nameof(IDokanOperations.Cleanup)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {info.Log()})");
                            }),
                operations
                    .Setup(d => d.CloseFile(path, It.Is<IDokanFileInfo>(i => i.IsDirectory)))
                    .Callback((string fileName, IDokanFileInfo info)
                        => Trace($"{nameof(IDokanOperations.CloseFile)}[{Interlocked.Decrement(ref pendingFiles)}] (\"{fileName}\", {info.Log()})"))
            ];
        }

        internal void PermitCreateDirectory(string path, FileAccess access = ReadDirectoryAccess, FileShare share = FileShare.ReadWrite, FileMode mode = FileMode.CreateNew, FileOptions options = FileOptions.None, FileAttributes attributes = FileAttributes.Normal)
        {
            SetupCreateDirectory(path, access, share, mode, options, attributes);

            PermitGetFileInformation(path, FileAttributes.Directory);
        }

        internal void ExpectCreateDirectory(string path, FileAccess access = ReadDirectoryAccess, FileShare share = FileShare.ReadWrite, FileMode mode = FileMode.CreateNew, FileOptions options = FileOptions.None, FileAttributes attributes = FileAttributes.Normal)
        {
            Array.ForEach(SetupCreateDirectory(path, access, share, mode, options, attributes), i => i.Verifiable());

            PermitGetFileInformation(path, FileAttributes.Directory);
        }

        internal void ExpectCreateDirectoryToFail(string path, NtStatus result)
        {
            if (result == DokanResult.Success)
            {
                throw new ArgumentException($"{DokanResult.Success} not supported", nameof(result));
            }

            operations
                .Setup(d => d.CreateFile(path, ReadDirectoryAccess, FileShare.ReadWrite, FileMode.CreateNew, It.IsAny<FileOptions>(), It.IsAny<FileAttributes>(), It.Is<IDokanFileInfo>(i => i.IsDirectory)))
                .Returns(result)
                .Callback((string fileName, FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.CreateFile)}[{Interlocked.Increment(ref pendingFiles)}] **{result}** (\"{fileName}\", [{access}], [{share}], {mode}, [{options}], [{attributes}], {info.Log()})"))
                .Verifiable();

            ExpectCloseFile(path, isDirectory: true);
            ExpectCloseFile(path);
        }

        internal void ExpectDeleteDirectory(string path)
        {
            operations
                .Setup(d => d.DeleteDirectory(path, It.Is<IDokanFileInfo>(i => i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, IDokanFileInfo info)
                    =>
                {
                    if (info.DeletePending)
                    {
                        deletePendingExpected.Add(path);
                    }
                    else
                    {
                        deletePendingExpected.Remove(path);
                    }

                    Trace($"{nameof(IDokanOperations.DeleteDirectory)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {info.Log()})");
                })
                .Verifiable();
        }

        private IVerifies SetupCreateFile(string path, FileAccess access, FileShare share, FileMode mode, FileOptions options = FileOptions.None, FileAttributes attributes = default(FileAttributes), object context = null, bool isDirectory = false, bool deleteOnClose = false)
        {
            if (deleteOnClose)
            {
                deletePendingExpected.Add(path);
            }

            return operations
                .Setup(d => d.CreateFile(path, FileAccessUtils.MapSpecificToGenericAccess(access), share, mode, options, attributes, It.Is<IDokanFileInfo>(i => i.IsDirectory == isDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileAccess _access, FileShare _share, FileMode _mode, FileOptions _options, FileAttributes _attributes, IDokanFileInfo info)
                    =>
                    {
                        info.Context = context;
                        Trace($"{nameof(IDokanOperations.CreateFile)}[{Interlocked.Increment(ref pendingFiles)}] (\"{fileName}\", [{_access}], [{_share}], {_mode}, [{_options}], [{_attributes}], {info.Log()})");
                    });
        }

        internal void PermitCreateFile(string path, FileAccess access, FileShare share, FileMode mode, FileOptions options = FileOptions.None, FileAttributes attributes = default(FileAttributes), object context = null, bool isDirectory = false)
        {
            SetupCreateFile(path, access, share, mode, options, attributes, context, isDirectory);
        }

        internal void ExpectCreateFile(string path, FileAccess access, FileShare share, FileMode mode, FileOptions options = FileOptions.None, FileAttributes attributes = default(FileAttributes), object context = null, bool isDirectory = false, bool deleteOnClose = false)
        {
            SetupCreateFile(path, access, share, mode, options, attributes, context, isDirectory, deleteOnClose)
                .Verifiable();

            PermitGetFileInformation(path, FileAttributes.Normal);
            ExpectCleanupFile(path, context, isDirectory);
        }

        internal void ExpectCreateFileWithoutCleanup(string path, FileAccess access, FileShare share, FileMode mode, FileOptions options = FileOptions.None, FileAttributes attributes = default(FileAttributes), object context = null, bool isDirectory = false)
        {
            operations
                .Setup(d => d.CreateFile(path, FileAccessUtils.MapSpecificToGenericAccess(access), share, mode, options, attributes, It.Is<IDokanFileInfo>(i => i.IsDirectory == isDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileAccess _access, FileShare _share, FileMode _mode, FileOptions _options, FileAttributes _attributes, IDokanFileInfo info)
                    =>
                    {
                        info.Context = context;
                        Trace($"{nameof(IDokanOperations.CreateFile)}-NoCleanup[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{_access}], [{_share}], {_mode}, [{_options}], [{_attributes}], {info.Log()})");
                    })
                .Verifiable();
        }

        internal void ExpectCreateFileToFail(string path, NtStatus result, bool closeFile = false)
        {
            if (result == DokanResult.Success)
            {
                throw new ArgumentException($"{DokanResult.Success} not supported", nameof(result));
            }

            operations
                .Setup(d => d.CreateFile(path, It.IsAny<FileAccess>(), It.IsAny<FileShare>(), It.IsAny<FileMode>(), It.IsAny<FileOptions>(), It.IsAny<FileAttributes>(), It.IsAny<IDokanFileInfo>()))
                .Returns(result)
                .Callback((string fileName, FileAccess _access, FileShare _share, FileMode _mode, FileOptions options, FileAttributes _attributes, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.CreateFile)}[{(closeFile ? Interlocked.Increment(ref pendingFiles) : Interlocked.Read(ref pendingFiles))}] **{result}** (\"{fileName}\", [{_access}], [{_share}], {_mode}, [{options}], [{_attributes}], {info.Log()})"))
                .Verifiable();

            if (closeFile)
            {
                ExpectCloseFile(path);
            }
        }

        internal void ExpectCleanupFile(string path, object context = null, bool isDirectory = false)
        {
            operations
                .Setup(d => d.Cleanup(path, It.Is<IDokanFileInfo>(i => i.Context == context && i.IsDirectory == isDirectory)))
                .Callback((string fileName, IDokanFileInfo info) =>
                {
                    if (info.DeletePending)
                    {
                        deletePendingExecuted.Add(path);
                    }

                    Trace($"{nameof(IDokanOperations.Cleanup)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {info.Log()})");
                }).Verifiable();

            ExpectCloseFile(path, context, isDirectory);
        }

        internal void ExpectCloseFile(string path, object context = null, bool isDirectory = false)
        {
            operations
                .Setup(d => d.CloseFile(path, It.Is<IDokanFileInfo>(i => i.Context == context && i.IsDirectory == isDirectory)))
                .Callback((string fileName, IDokanFileInfo info)
                    =>
                    {
                        Trace($"{nameof(IDokanOperations.CloseFile)}[{(isDirectory ? Interlocked.Read(ref pendingFiles) : Interlocked.Decrement(ref pendingFiles))}] (\"{fileName}\", {info.Log()})");
                        info.Context = null;
                    })
                .Verifiable();
        }

        internal void ExpectFlushFileBuffers(string path)
        {
            operations
                .Setup(d => d.FlushFileBuffers(path, It.Is<IDokanFileInfo>(i => !i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.FlushFileBuffers)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {info.Log()})"))
                .Verifiable();
        }

        internal void ExpectLockUnlockFile(string path, long offset, long length)
        {
            operations
                .Setup(d => d.LockFile(path, offset, length, It.Is<IDokanFileInfo>(i => !i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, long _offset, long _length, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.LockFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {_offset}, {_length}, {info.Log()})"))
                .Verifiable();
            operations
                .Setup(d => d.UnlockFile(path, offset, length, It.Is<IDokanFileInfo>(i => !i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, long _offset, long _length, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.UnlockFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {_offset}, {_length}, {info.Log()})"))
                .Verifiable();
        }

        internal void PermitProbeFile(string path, byte[] buffer, int probeBufferSize = PROBE_BUFFER_SIZE)
        {
            operations
                .Setup(d => d.ReadFile(path, It.Is<byte[]>(b => b.Length == probeBufferSize), out probeBufferSize, 0, It.Is<IDokanFileInfo>(i => !i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, byte[] _buffer, int _bytesRead, long _offset, IDokanFileInfo info)
                    =>
                    {
                        Array.ConstrainedCopy(buffer, 0, _buffer, 0, Math.Min(probeBufferSize, buffer.Length));
                        Trace($"ProbeFile[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{_buffer.Length}], {_buffer.SequenceEqual(buffer)}, out {_bytesRead}, {_offset}, {info.Log()})");
                    });
        }

        internal void ExpectReadFile(string path, byte[] buffer, int bytesRead, object context = null,
            bool synchronousIo = true)
        {
            operations
                .Setup(d => d.ReadFile(path, It.IsAny<byte[]>(), out bytesRead, 0, It.Is<IDokanFileInfo>(i => i.Context == context && !i.IsDirectory && i.SynchronousIo == synchronousIo)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, byte[] _buffer, int _bytesRead, long _offset, IDokanFileInfo info)
                    =>
                    {
                        Array.ConstrainedCopy(buffer, 0, _buffer, 0, Math.Min(bytesRead, _buffer.Length));
                        Trace($"{nameof(IDokanOperations.ReadFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{_buffer.Length}], {_buffer.SequenceEqual(buffer)}, out {_bytesRead}, {_offset}, {info.Log()})");
                    })
                .Verifiable();
        }

        internal void ExpectReadFileWithDelay(string path, byte[] buffer, int bytesRead, TimeSpan delay)
        {
            operations
                .Setup(d => d.ReadFile(path, It.IsAny<byte[]>(), out bytesRead, 0, It.Is<IDokanFileInfo>(i => !i.IsDirectory && i.SynchronousIo)))
                .Callback(() => Thread.Sleep(delay))
                .Returns(DokanResult.Success)
                .Callback((string fileName, byte[] _buffer, int _bytesRead, long _offset, IDokanFileInfo info)
                    =>
                    {
                        Array.ConstrainedCopy(buffer, 0, _buffer, 0, Math.Min(bytesRead, _buffer.Length));
                        Trace($"{nameof(IDokanOperations.ReadFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{_buffer.Length}], {_buffer.SequenceEqual(buffer)}, out {_bytesRead}, {_offset}, {info.Log()})");
                    })
                .Verifiable();
        }

        internal void ExpectReadFileInChunks(string path, byte[] buffer, int chunkSize, object context = null, bool synchronousIo = true)
        {
            var offsets = new int[NumberOfChunks(chunkSize, buffer.Length)];
            for (int offset = 0, index = 0; offset < buffer.Length; offset += chunkSize, ++index)
            {
                offsets[index] = offset;
                var bytesRemaining = buffer.Length - offset;
                var bytesRead = Math.Min(chunkSize, bytesRemaining);
                operations
                    .Setup(d => d.ReadFile(path, It.Is<byte[]>(b => b.Length == chunkSize || b.Length == bytesRemaining), out bytesRead, offsets[index],
                                It.Is<IDokanFileInfo>(i => i.Context == context && !i.IsDirectory && i.SynchronousIo == synchronousIo)))
                    .Returns(DokanResult.Success)
                    .Callback((string fileName, byte[] _buffer, int _bytesRead, long _offset, IDokanFileInfo info)
                        =>
                        {
                            Array.ConstrainedCopy(buffer, (int)_offset, _buffer, 0, _bytesRead);
                            Trace($"{nameof(IDokanOperations.ReadFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{_buffer.Length}], {_buffer.Take(_bytesRead).SequenceEqual(buffer.Skip((int)_offset).Take(_bytesRead))}, out {_bytesRead}, {_offset}, {info.Log()})");
                        })
                    .Verifiable();
            }
        }

        internal void ExpectWriteFile(string path, byte[] buffer, int bytesWritten, object context = null, bool synchronousIo = true)
        {
            operations
                .Setup(d => d.WriteFile(path, It.Is<byte[]>(b => b.SequenceEqual(buffer)), out bytesWritten, 0, It.Is<IDokanFileInfo>(i => i.Context == context && !i.IsDirectory && i.SynchronousIo == synchronousIo)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, byte[] _buffer, int _bytesWritten, long offset, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.WriteFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{_buffer.Length}], out {_bytesWritten}, {offset}, {info.Log()})"))
                .Verifiable();
        }

        private static bool IsSequenceEqual(IEnumerable<byte> b, IEnumerable<byte> buffer)
        {
            var result = b.SequenceEqual(buffer);
            return result;
        }

        internal void ExpectWriteFileWithDelay(string path, byte[] buffer, int bytesWritten, TimeSpan delay)
        {
            operations
                .Setup(d => d.WriteFile(path, It.Is<byte[]>(b => IsSequenceEqual(b, buffer) /*b.SequenceEqual(buffer)*/), out bytesWritten, 0, It.Is<IDokanFileInfo>(i => !i.IsDirectory && i.SynchronousIo)))
                .Callback(() => Thread.Sleep(delay))
                .Returns(DokanResult.Success)
                .Callback((string fileName, byte[] _buffer, int _bytesWritten, long offset, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.WriteFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{_buffer.Length}], out {_bytesWritten}, {offset}, {info.Log()})"))
                .Verifiable();
        }

        internal void ExpectWriteFileInChunks(string path, byte[] buffer, int chunkSize, object context = null, bool synchronousIo = true)
        {
            var offsets = new int[NumberOfChunks(chunkSize, buffer.Length)];
            for (int offset = 0, index = 0; offset < buffer.Length; offset += chunkSize, ++index)
            {
                offsets[index] = offset;
                var bytesWritten = Math.Min(chunkSize, buffer.Length - offset);
                var chunk = buffer.Skip(offset).Take(bytesWritten);
                operations
                    .Setup(d => d.WriteFile(path, It.Is<byte[]>(b => IsSequenceEqual(b, chunk) /*b.SequenceEqual(chunk)*/), out bytesWritten, offsets[index],
                                It.Is<IDokanFileInfo>(i => i.Context == context && !i.IsDirectory && i.SynchronousIo == synchronousIo)))
                    .Returns(DokanResult.Success)
                    .Callback((string fileName, byte[] _buffer, int _bytesWritten, long _offset, IDokanFileInfo info)
                        => Trace($"{nameof(IDokanOperations.WriteFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{_buffer.Length}], out {_bytesWritten}, {_offset}, {info.Log()})"))
                    .Verifiable();
            }
        }

        internal void ExpectDeleteFile(string path)
        {
            operations
                .Setup(d => d.DeleteFile(path, It.Is<IDokanFileInfo>(i => !i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, IDokanFileInfo info)
                    =>
                {
                    if (info.DeletePending)
                    {
                        deletePendingExpected.Add(path);
                    }
                    else
                    {
                        deletePendingExpected.Remove(path);
                    }

                    Trace($"{nameof(IDokanOperations.DeleteFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {info.Log()})");
                })
                .Verifiable();
        }

        internal void ExpectMoveFile(string path, string destinationPath, bool replace)
        {
            operations
                .Setup(d => d.MoveFile(path, destinationPath, replace, It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string oldName, string newName, bool _replace, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.MoveFile)}[{Interlocked.Add(ref pendingFiles, 2)}] (\"{oldName}\", \"{newName}\", {_replace}, {info.Log()})"))
                .Verifiable();

            ExpectCleanupFile(destinationPath);
        }

        internal void ExpectMoveFileToFail(string path, string destinationPath, bool replace, NtStatus result)
        {
            operations
                .Setup(d => d.MoveFile(path, destinationPath, replace, It.IsAny<IDokanFileInfo>()))
                .Returns(result)
                .Callback((string oldName, string newName, bool _replace, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.MoveFile)}[{Interlocked.Add(ref pendingFiles, 2)}] **{result}** (\"{oldName}\", \"{newName}\", {_replace}, {info.Log()})"))
                .Verifiable();

            ExpectCleanupFile(destinationPath, isDirectory: true);
            ExpectCleanupFile(destinationPath);
            ExpectCloseFile(path);
        }

        internal void ExpectSetAllocationSize(string path, long length)
        {
            operations
                .Setup(d => d.SetAllocationSize(path, length, It.Is<IDokanFileInfo>(i => !i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, long _length, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.SetAllocationSize)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {_length}, {info.Log()})"))
                .Verifiable();
        }

        internal void ExpectSetEndOfFile(string path, long length)
        {
            operations
                .Setup(d => d.SetEndOfFile(path, length, It.Is<IDokanFileInfo>(i => !i.IsDirectory)))
                .Returns(DokanResult.Success)
                .Callback((string fileName, long _length, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.SetEndOfFile)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {_length}, {info.Log()})"))
                .Verifiable();
        }

        internal void ExpectSetFileAttributes(string path, FileAttributes attributes)
        {
            operations
                .Setup(d => d.SetFileAttributes(path, attributes, It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileAttributes _attributes, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.SetFileAttributes)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", [{_attributes}], {info.Log()})"));
        }

        internal void ExpectSetFileTime(string path)
        {
            operations
                .Setup(d => d.SetFileTime(path, It.IsAny<DateTime?>(), It.IsAny<DateTime?>(), It.IsAny<DateTime?>(), It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, DateTime? creationTime, DateTime? lastAccessTime, DateTime? lastWriteTime, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.SetFileTime)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {creationTime}, {lastAccessTime}, {lastWriteTime}, {info.Log()})"))
                .Verifiable();
        }

        internal void ExpectGetFileSecurity(string path, FileSystemSecurity security, AccessControlSections access = AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group)
        {
            operations
                .Setup(d => d.GetFileSecurity(path, out security, access, It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileSystemSecurity _security, AccessControlSections _access, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.GetFileSecurity)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", out {_security.AsString()}, {_access}, {info.Log()})"))
                .Verifiable();
        }

        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "security", Justification = "Reserved for future use")]
        internal void ExpectSetFileSecurity(string path, FileSystemSecurity _2)
        {
            operations
                //.Setup(d => d.SetFileSecurity(path, security, AccessControlSections.Access, It.IsAny<IDokanFileInfo>()))
                .Setup(d => d.SetFileSecurity(path, It.IsAny<FileSystemSecurity>(), AccessControlSections.Access, It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.Success)
                .Callback((string fileName, FileSystemSecurity _security, AccessControlSections access, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.SetFileSecurity)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", {_security.AsString()}, {access}, {info.Log()})"))
                .Verifiable();
        }

        internal void ExpectFindStreams(string path, IList<FileInformation> streamNames)
        {
            long streamSize = streamNames.Count;
            operations
                .Setup(d => d.FindStreams(path, out streamNames, It.IsAny<IDokanFileInfo>()))
                .Returns(DokanResult.NotImplemented)
                .Callback((string fileName, IList<FileInformation> _streamNames, IDokanFileInfo info)
                    => Trace($"{nameof(IDokanOperations.FindStreams)}[{Interlocked.Read(ref pendingFiles)}] (\"{fileName}\", out [{_streamNames.Count}], {info.Log()})"))
                .Verifiable();
        }

        private void PrepareVerify()
        {
            // For single-core environments, allow other threads to complete
            Thread.Yield();

            if (Interlocked.Read(ref pendingFiles) < 0)
            {
                throw new InvalidOperationException("Negative pending files count");
            }

            for (var i = 1; Interlocked.Read(ref pendingFiles) > 0; ++i)
            {
                if (i > 5)
                {
                    throw new TimeoutException("Cleanup wait cycles exceeded");
                }

                Trace($"Waiting for closure (#{i})");
                Thread.Sleep(1);
            }

            var deletePendingExpectedNotExecuted = deletePendingExpected.Except(deletePendingExecuted);
            foreach (var i in deletePendingExpectedNotExecuted)
            {
                Trace($"DeletePending not executed: {i}");
            }

            var deletePendingUnexpectedlyExecuted = deletePendingExecuted.Except(deletePendingExpected);
            foreach (var i in deletePendingUnexpectedlyExecuted)
            {
                Trace($"DeletePending unexpected: {i}");
            }

            if (!deletePendingExpectedNotExecuted.IsNullOrEmpty() || !deletePendingUnexpectedlyExecuted.IsNullOrEmpty())
            {
                throw new TimeoutException("Found DeletePending expectation difference");
            }
        }

        internal void Verify()
        {
            PrepareVerify();

            operations.Verify();
        }

        internal void VerifyContextReadInvocations(string fileName, int count)
        {
            PrepareVerify();

            int bytesRead;
            operations.Verify();
            operations.Verify(d => d.ReadFile(fileName, It.IsAny<byte[]>(), out bytesRead, It.IsAny<long>(), It.IsAny<IDokanFileInfo>()), Times.Exactly(count));
        }

        internal void VerifyContextWriteInvocations(string fileName, int count)
        {
            PrepareVerify();

            int bytesRead;
            operations.Verify();
            operations.Verify(d => d.WriteFile(fileName, It.IsAny<byte[]>(), out bytesRead, It.IsAny<long>(), It.IsAny<IDokanFileInfo>()), Times.Exactly(count));
        }
    }
}
```

### DriveInfoTests.cs

```using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DokanNet.Tests.FileSettings;

namespace DokanNet.Tests
{
    [TestClass]
    public sealed class DriveInfoTests
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            DokanOperationsFixture.InitInstance(TestContext.TestName);
        }

        [TestCleanup]
        public void Cleanup()
        {
            DokanOperationsFixture.ClearInstance(out bool hasUnmatchedInvocations);
            Assert.IsFalse(hasUnmatchedInvocations, "Found Mock invocations without corresponding setups");
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetAvailableFreeSpace_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

#if LOGONLY
            fixture.PermitAny();
#else
            var availableFreeSpace = 1 << 10;
            fixture.ExpectGetDiskFreeSpace(freeBytesAvailable: availableFreeSpace);
#endif

            var sut = new DriveInfo(DokanOperationsFixture.MOUNT_POINT);

#if LOGONLY
            Assert.AreEqual(0, sut.AvailableFreeSpace, nameof(sut.AvailableFreeSpace));
#else
            Assert.AreEqual(availableFreeSpace, sut.AvailableFreeSpace, nameof(sut.AvailableFreeSpace));

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetDriveFormat_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectOpenDirectory(DokanOperationsFixture.RootName, FileAccess.Synchronize, FileShare.ReadWrite);
            fixture.ExpectGetVolumeInformation(DokanOperationsFixture.VOLUME_LABEL, DokanOperationsFixture.FILESYSTEM_NAME, 256);
#endif

            var sut = new DriveInfo(DokanOperationsFixture.MOUNT_POINT);

#if LOGONLY
            Assert.IsNotNull(sut.DriveFormat, nameof(sut.DriveFormat));
            Console.WriteLine(sut.DriveFormat);
#else
            Assert.AreEqual(DokanOperationsFixture.FILESYSTEM_NAME, sut.DriveFormat, nameof(sut.DriveFormat));

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetDriveType_CallsApiCorrectly()
        {
            var sut = new DriveInfo(DokanOperationsFixture.MOUNT_POINT);

#if NETWORK_DRIVE
            Assert.AreEqual(DriveType.Network, sut.DriveType, nameof(sut.DriveType));
#else
            Assert.AreEqual(DriveType.Removable, sut.DriveType, nameof(sut.DriveType));
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetIsReady_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = DokanOperationsFixture.RootName;
#if LOGONLY
            fixture.PermitAny();
#else
            var anyDateTime = new DateTime(2000, 1, 1, 12, 0, 0);
            fixture.ExpectCreateFile(path, ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, FileAttributes.Directory, creationTime: anyDateTime, lastWriteTime: anyDateTime, lastAccessTime: anyDateTime);
#endif

            var sut = new DriveInfo(DokanOperationsFixture.MOUNT_POINT);

#if LOGONLY
            Console.WriteLine($"sut.IsReady {sut.IsReady}");
#else
            Assert.IsTrue(sut.IsReady, nameof(sut.IsReady));
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetName_CallsApiCorrectly()
        {
            var path = DokanOperationsFixture.RootName.AsDriveBasedPath();

            var sut = new DriveInfo(DokanOperationsFixture.MOUNT_POINT);

            Assert.AreEqual(path, sut.Name, nameof(sut.Name));
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetRootDirectory_CallsApiCorrectly()
        {
            var path = DokanOperationsFixture.RootName.AsDriveBasedPath();

#if LOGONLY
            var fixture = DokanOperationsFixture.Instance;
            fixture.PermitAny();
#endif

            var sut = new DriveInfo(DokanOperationsFixture.MOUNT_POINT);

#if LOGONLY
            Assert.IsNotNull(sut.RootDirectory, nameof(sut.RootDirectory));
            Console.WriteLine(sut.RootDirectory);
#else
            Assert.AreEqual(path, sut.RootDirectory.Name, nameof(sut.RootDirectory));
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetTotalFreeSpace_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

#if LOGONLY
            fixture.PermitAny();
#else
            var totalFreeSpace = 1 << 14;
            fixture.ExpectGetDiskFreeSpace(totalNumberOfFreeBytes: totalFreeSpace);
#endif

            var sut = new DriveInfo(DokanOperationsFixture.MOUNT_POINT);

#if LOGONLY
            Assert.AreEqual(0, sut.TotalFreeSpace, nameof(sut.TotalFreeSpace));
#else
            Assert.AreEqual(totalFreeSpace, sut.TotalFreeSpace, nameof(sut.TotalFreeSpace));

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetTotalSize_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

#if LOGONLY
            fixture.PermitAny();
#else
            var totalSize = 1 << 20;
            fixture.ExpectGetDiskFreeSpace(totalNumberOfBytes: totalSize);
#endif

            var sut = new DriveInfo(DokanOperationsFixture.MOUNT_POINT);

#if LOGONLY
            Assert.AreEqual(0, sut.TotalSize, nameof(sut.TotalSize));
#else
            Assert.AreEqual(totalSize, sut.TotalSize, nameof(sut.TotalSize));

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetVolumeLabel_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectOpenDirectory(DokanOperationsFixture.RootName, FileAccess.Synchronize, FileShare.ReadWrite);
            fixture.ExpectGetVolumeInformation(DokanOperationsFixture.VOLUME_LABEL, DokanOperationsFixture.FILESYSTEM_NAME, 256);
#endif

            var sut = new DriveInfo(DokanOperationsFixture.MOUNT_POINT);

#if LOGONLY
            Assert.IsNotNull(sut.VolumeLabel, nameof(sut.VolumeLabel));
            Console.WriteLine(sut.VolumeLabel);
#else
            Assert.AreEqual(DokanOperationsFixture.VOLUME_LABEL, sut.VolumeLabel, nameof(sut.VolumeLabel));

            fixture.Verify();
#endif
        }
    }
}
```

### FileAccessUtils.cs

```using System;
using System.Linq;

namespace DokanNet.Tests
{
    static class FileAccessUtils
    {
        private const FileAccess FILE_GENERIC_READ =
            FileAccess.ReadAttributes |
            FileAccess.ReadData |
            FileAccess.ReadExtendedAttributes |
            FileAccess.ReadPermissions |
            FileAccess.Synchronize;

        private const FileAccess FILE_GENERIC_WRITE =
            FileAccess.AppendData |
            FileAccess.WriteAttributes |
            FileAccess.WriteData |
            FileAccess.WriteExtendedAttributes |
            FileAccess.ReadPermissions |
            FileAccess.Synchronize;

        private const FileAccess FILE_GENERIC_EXECUTE =
            FileAccess.Execute |
            FileAccess.ReadAttributes |
            FileAccess.ReadPermissions |
            FileAccess.Synchronize;

        private static readonly FileAccess FILE_ALL_ACCESS = (FileAccess)Enum.GetValues(typeof(FileAccess)).Cast<long>().Sum();

        public static FileAccess MapSpecificToGenericAccess(FileAccess desiredAccess)
        {
            var outDesiredAccess = desiredAccess;

            var genericRead = false;
            var genericWrite = false;
            var genericExecute = false;
            var genericAll = false;
            if ((outDesiredAccess & FILE_GENERIC_READ) == FILE_GENERIC_READ)
            {
                outDesiredAccess |= FileAccess.GenericRead;
                genericRead = true;
            }

            if ((outDesiredAccess & FILE_GENERIC_WRITE) == FILE_GENERIC_WRITE)
            {
                outDesiredAccess |= FileAccess.GenericWrite;
                genericWrite = true;
            }

            if ((outDesiredAccess & FILE_GENERIC_EXECUTE) == FILE_GENERIC_EXECUTE)
            {
                outDesiredAccess |= FileAccess.GenericExecute;
                genericExecute = true;
            }

            if ((outDesiredAccess & FILE_ALL_ACCESS) == FILE_ALL_ACCESS)
            {
                outDesiredAccess |= FileAccess.GenericAll;
                genericAll = true;
            }

            if (genericRead)
            {
                outDesiredAccess &= ~FILE_GENERIC_READ;
            }

            if (genericWrite)
            {
                outDesiredAccess &= ~FILE_GENERIC_WRITE;
            }

            if (genericExecute)
            {
                outDesiredAccess &= ~FILE_GENERIC_EXECUTE;
            }

            if (genericAll)
            {
                outDesiredAccess &= ~FILE_ALL_ACCESS;
            }

            return outDesiredAccess;
        }
    }
}

```

### FileInfoTests.cs

```using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DokanNet.Tests.FileSettings;

namespace DokanNet.Tests
{
    [TestClass]
    public class FileInfoTests
    {
        private const int FILE_BUFFER_SIZE = 262144;

        private const int SMALL_DATA_SIZE = 4096;

        private const int LARGE_DATA_SIZE = 5 * FILE_BUFFER_SIZE + FILE_BUFFER_SIZE / 4;

        private static byte[] smallData;

        private static byte[] largeData;

        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            smallData = DokanOperationsFixture.InitPeriodicTestData(SMALL_DATA_SIZE);

            largeData = DokanOperationsFixture.InitPeriodicTestData(LARGE_DATA_SIZE);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            largeData = null;
            smallData = null;
        }

        [TestInitialize]
        public virtual void Initialize()
        {
            DokanOperationsFixture.InitInstance(TestContext.TestName);
        }

        [TestCleanup]
        public virtual void Cleanup()
        {
            DokanOperationsFixture.ClearInstance(out bool hasUnmatchedInvocations);
            Assert.IsFalse(hasUnmatchedInvocations, "Found Mock invocations without corresponding setups");
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetAttributes_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            var attributes = FileAttributes.Normal;
            var creationTime = new DateTime(2015, 6, 1, 12, 0, 0);
            var lastWriteTime = new DateTime(2015, 7, 31, 12, 0, 0);
            var lastAccessTime = new DateTime(2015, 8, 1, 6, 0, 0);
            fixture.ExpectCreateFile(path, ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, attributes, creationTime: creationTime, lastWriteTime: lastWriteTime, lastAccessTime: lastAccessTime);
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());

#if LOGONLY
            Assert.IsNotNull(sut.Name, nameof(sut.Name));
            Assert.AreNotEqual(default(FileAttributes), sut.Attributes, nameof(sut.Attributes));
            Assert.AreNotEqual(DateTime.MinValue, sut.CreationTime, nameof(sut.CreationTime));
            Assert.AreNotEqual(DateTime.MinValue, sut.LastWriteTime, nameof(sut.LastWriteTime));
            Assert.AreNotEqual(DateTime.MinValue, sut.LastAccessTime, nameof(sut.LastAccessTime));
#else
            Assert.AreEqual(fixture.FileName, sut.Name, nameof(sut.Name));
            Assert.AreEqual(fixture.FileName.AsDriveBasedPath(), sut.FullName, nameof(sut.FullName));
            Assert.AreEqual(attributes, sut.Attributes, nameof(sut.Attributes));
            Assert.AreEqual(creationTime, sut.CreationTime, nameof(sut.CreationTime));
            Assert.AreEqual(lastWriteTime, sut.LastWriteTime, nameof(sut.LastWriteTime));
            Assert.AreEqual(lastAccessTime, sut.LastAccessTime, nameof(sut.LastAccessTime));

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetDirectory_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName;
#if LOGONLY
            fixture.PermitAny();
#endif

            var sut = new FileInfo(path.AsDriveBasedPath());

            Assert.AreEqual(DokanOperationsFixture.RootName.AsDriveBasedPath(), sut.Directory.FullName,
                "Unexpected parent directory");

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetExists_WhereFileExists_ReturnsCorrectResult()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            Assert.IsTrue(sut.Exists, "File should exist");

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Failure)]
        public void GetExists_WhereFileDoesNotExist_ReturnsCorrectResult()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileToFail(path, DokanResult.FileNotFound);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            Assert.IsFalse(sut.Exists, "File should not exist");

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetExtension_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            Assert.AreEqual(Path.GetExtension(path), sut.Extension, "Unexpected extension");

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetIsReadOnly_WhereFileIsReadOnly_ReturnsCorrectResult()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, FileAttributes.ReadOnly);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            Assert.IsTrue(sut.IsReadOnly, "File should be read/write");

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetIsReadOnly_WhereFileIsReadWrite_ReturnsCorrectResult()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            Assert.IsFalse(sut.IsReadOnly, "File should be readonly");

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void AppendText_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            string value = $"TestValue for test {nameof(AppendText_CallsApiCorrectly)}";
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, ReadOnlyShare, FileMode.OpenOrCreate, FileOptions.SequentialScan);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
            fixture.ExpectWriteFile(path, Encoding.UTF8.GetBytes(value), value.Length);

            fixture.PermitProbeFile(path, Encoding.UTF8.GetBytes(value));
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var writer = sut.AppendText())
            {
                writer.Write(value);
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void CopyTo_WhereSourceIsEmpty_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            string path = fixture.FileName.AsRootedPath(),
                destinationPath = fixture.DestinationFileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadShare, FileMode.Open, FileOptions.SequentialScan);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
            fixture.ExpectCreateFile(destinationPath, CopyToAccess, WriteShare, FileMode.CreateNew, FileOptions.SequentialScan, attributes: FileAttributes.Normal);
            fixture.PermitCreateFile(destinationPath, CopyToAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.SequentialScan, attributes: FileAttributes.Normal);
            fixture.ExpectGetVolumeInformation(DokanOperationsFixture.VOLUME_LABEL, DokanOperationsFixture.FILESYSTEM_NAME, 256);
            fixture.ExpectGetFileInformation(destinationPath, FileAttributes.Normal);
            fixture.ExpectSetFileAttributes(destinationPath, default(FileAttributes));
            fixture.ExpectSetFileTime(destinationPath);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            sut.CopyTo(fixture.DestinationFileName.AsDriveBasedPath());

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "NonEmpty")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void CopyTo_WhereSourceIsNonEmpty_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            string path = fixture.FileName.AsRootedPath(),
                destinationPath = fixture.DestinationFileName.AsRootedPath();
            string value = $"TestValue for test {nameof(CopyTo_WhereSourceIsNonEmpty_CallsApiCorrectly)}";
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadShare, FileMode.Open, FileOptions.SequentialScan);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal, length: value.Length);
            fixture.ExpectCreateFile(destinationPath, CopyToAccess, WriteShare, FileMode.CreateNew, FileOptions.SequentialScan, attributes: FileAttributes.Normal);
            fixture.ExpectGetVolumeInformation(DokanOperationsFixture.VOLUME_LABEL, DokanOperationsFixture.FILESYSTEM_NAME, 256);
            fixture.ExpectGetFileInformation(destinationPath, FileAttributes.Normal);
            fixture.ExpectSetEndOfFile(destinationPath, value.Length);
#if NETWORK_DRIVE
            fixture.ExpectReadFile(path, Encoding.UTF8.GetBytes(value), value.Length, synchronousIo: false);
            fixture.ExpectWriteFile(destinationPath, Encoding.UTF8.GetBytes(value), value.Length, synchronousIo: false);
#else
            fixture.ExpectReadFile(path, Encoding.UTF8.GetBytes(value), value.Length);
            fixture.ExpectWriteFile(destinationPath, Encoding.UTF8.GetBytes(value), value.Length);
#endif
            fixture.ExpectSetFileAttributes(destinationPath, default(FileAttributes));
            fixture.ExpectSetFileTime(destinationPath);

            fixture.PermitCreateFile(destinationPath, CopyToAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.SequentialScan, attributes: FileAttributes.Normal);
            fixture.PermitProbeFile(destinationPath, Encoding.UTF8.GetBytes(value));
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            sut.CopyTo(fixture.DestinationFileName.AsDriveBasedPath());

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void CopyTo_WhereSourceIsLargeFile_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            string path = fixture.FileName.AsRootedPath(),
                destinationPath = fixture.DestinationFileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadShare, FileMode.Open, FileOptions.SequentialScan);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal, length: largeData.Length);
            fixture.ExpectCreateFile(destinationPath, CopyToAccess, WriteShare, FileMode.CreateNew, FileOptions.SequentialScan, attributes: FileAttributes.Normal);
            fixture.ExpectGetVolumeInformation(DokanOperationsFixture.VOLUME_LABEL, DokanOperationsFixture.FILESYSTEM_NAME, 256);
            fixture.ExpectGetFileInformation(destinationPath, FileAttributes.Normal);
            fixture.ExpectSetEndOfFile(destinationPath, largeData.Length);
#if NETWORK_DRIVE
            fixture.ExpectReadFileInChunks(path, largeData, FILE_BUFFER_SIZE, synchronousIo: false);
            fixture.ExpectWriteFileInChunks(destinationPath, largeData, FILE_BUFFER_SIZE, synchronousIo: false);
#else
            fixture.ExpectReadFileInChunks(path, largeData, FILE_BUFFER_SIZE);
            fixture.ExpectWriteFileInChunks(destinationPath, largeData, FILE_BUFFER_SIZE);
#endif
            fixture.ExpectSetFileAttributes(destinationPath, default(FileAttributes));
            fixture.ExpectSetFileTime(destinationPath);

            fixture.PermitProbeFile(path, largeData);
            fixture.PermitProbeFile(destinationPath, largeData);
            fixture.PermitCreateFile(destinationPath, CopyToAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.SequentialScan, attributes: FileAttributes.Normal);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            sut.CopyTo(fixture.DestinationFileName.AsDriveBasedPath());

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Failure)]
        [ExpectedException(typeof(FileNotFoundException), "Expected FileNotFoundException not thrown")]
        public void CopyTo_WhereSourceDoesNotExists_Throws()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileToFail(path, DokanResult.FileNotFound);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            sut.CopyTo(fixture.DestinationFileName.AsDriveBasedPath());
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        [ExpectedException(typeof(IOException), "Expected IOException not thrown")]
        public void CopyTo_WhereTargetExists_Throws()
        {
            var fixture = DokanOperationsFixture.Instance;

            string path = fixture.FileName.AsRootedPath(),
                destinationPath = fixture.DestinationFileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadShare, FileMode.Open, FileOptions.SequentialScan);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
            fixture.ExpectFindStreams(path, []);
            fixture.ExpectCreateFileToFail(destinationPath, DokanResult.FileExists, true);
            fixture.ExpectCloseFile(path);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            sut.CopyTo(fixture.DestinationFileName.AsDriveBasedPath());
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void Create_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            string value = $"TestValue for test {nameof(Create_CallsApiCorrectly)}";
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadWriteAccess, WriteShare, FileMode.Create, FileOptions.None);
            fixture.ExpectWriteFile(path, Encoding.UTF8.GetBytes(value), value.Length);

            fixture.PermitProbeFile(path, Encoding.UTF8.GetBytes(value));
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.Create())
            {
                stream.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void CreateText_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            string value = $"TestValue for test {nameof(CreateText_CallsApiCorrectly)}";
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, ReadOnlyShare, FileMode.Create, FileOptions.SequentialScan);
            fixture.ExpectWriteFile(path, Encoding.UTF8.GetBytes(value), value.Length);

            fixture.PermitProbeFile(path, Encoding.UTF8.GetBytes(value));
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var writer = sut.CreateText())
            {
                writer.Write(value);
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void Delete_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, DeleteAccess, ReadWriteShare, FileMode.Open, deleteOnClose: true);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
            fixture.ExpectDeleteFile(path);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            sut.Delete();

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Failure)]
        public void Delete_WhereFileDoesNotExists_IgnoresResult()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileToFail(path, DokanResult.FileNotFound);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            sut.Delete();

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetAccessControl_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAttributesPermissionsAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
            fixture.ExpectGetFileSecurity(path, DokanOperationsFixture.DefaultFileSecurity);
            //No folder rights requested currently
            //fixture.ExpectCreateFile(DokanOperationsFixture.RootName, ReadPermissionsAccess, ReadWriteShare, FileMode.Open);
            //fixture.ExpectGetFileInformation(DokanOperationsFixture.RootName, FileAttributes.Directory);
            //fixture.ExpectGetFileSecurity(DokanOperationsFixture.RootName, DokanOperationsFixture.DefaultDirectorySecurity);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());
            var security = sut.GetAccessControl();

#if !LOGONLY
            Assert.IsNotNull(security, "Security descriptor should be set");
            Assert.AreEqual(DokanOperationsFixture.DefaultFileSecurity.AsString(), security.AsString(),
                "Security descriptors should match");
            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ParentIs")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void MoveTo_WhereParentIsRoot_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            string path = fixture.FileName.AsRootedPath(),
                destinationPath = fixture.DestinationFileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileWithoutCleanup(path, MoveFromAccess, ReadWriteShare, FileMode.Open, FileOptions.None);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
            fixture.ExpectCreateFile(destinationPath, WriteDirectoryAccess, FileShare.ReadWrite, FileMode.Open);
            fixture.ExpectOpenDirectoryWithoutCleanup(DokanOperationsFixture.RootName, WriteDirectoryAccess, FileShare.ReadWrite);
            fixture.PermitGetFileInformationToFail(destinationPath, DokanResult.FileNotFound, true);
            fixture.PermitOpenDirectory(DokanOperationsFixture.RootName, attributes: FileAttributes.Normal);
            fixture.ExpectMoveFile(path, destinationPath, false);
            fixture.PermitGetFileInformation(destinationPath, FileAttributes.Normal, false);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            sut.MoveTo(fixture.DestinationFileName.AsDriveBasedPath());

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ParentIs")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void MoveTo_WhereParentIsDirectory_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            string origin = Path.Combine(fixture.DirectoryName, fixture.FileName),
                destination = Path.Combine(fixture.DestinationDirectoryName, fixture.DestinationFileName),
                path = origin.AsRootedPath(),
                destinationPath = destination.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileWithoutCleanup(path, MoveFromAccess, ReadWriteShare, FileMode.Open, FileOptions.None);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
            fixture.ExpectOpenDirectoryWithoutCleanup(fixture.DestinationDirectoryName.AsRootedPath(), WriteDirectoryAccess, FileShare.ReadWrite);
            fixture.ExpectCreateFile(destinationPath, WriteDirectoryAccess, FileShare.ReadWrite, FileMode.Open);
            fixture.PermitGetFileInformationToFail(destinationPath, DokanResult.FileNotFound);
            fixture.PermitOpenDirectory(fixture.DestinationDirectoryName.AsRootedPath(), attributes: FileAttributes.Normal);
            fixture.ExpectMoveFile(path, destinationPath, false);
            fixture.PermitGetFileInformation(destinationPath, FileAttributes.Normal, false);
#endif

            var sut = new FileInfo(origin.AsDriveBasedPath());

            sut.MoveTo(destination.AsDriveBasedPath());

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Failure)]
        [ExpectedException(typeof(FileNotFoundException), "Expected FileNotFoundException not thrown")]
        public void MoveTo_WhereSourceDoesNotExists_Throws()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileToFail(path, DokanResult.FileNotFound);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            sut.MoveTo(fixture.DestinationFileName.AsDriveBasedPath());
        }

        [TestMethod, TestCategory(TestCategories.Failure)]
        [ExpectedException(typeof(IOException), "Expected IOException not thrown")]
        public void MoveTo_WhereTargetExists_Throws()
        {
            var fixture = DokanOperationsFixture.Instance;

            string path = fixture.FileName.AsRootedPath(),
                destinationPath = fixture.DestinationFileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, MoveFromAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
            fixture.ExpectCreateFile(destinationPath, WriteDirectoryAccess, FileShare.ReadWrite, FileMode.Open);
            fixture.ExpectOpenDirectoryWithoutCleanup(fixture.DestinationDirectoryName.AsRootedPath(), WriteDirectoryAccess, FileShare.ReadWrite);
            fixture.ExpectGetFileInformationToFail(destinationPath, DokanResult.FileNotFound);
            fixture.ExpectOpenDirectory(DokanOperationsFixture.RootName, attributes: FileAttributes.Normal);
            fixture.ExpectMoveFileToFail(path, destinationPath, false, DokanResult.FileExists);
            fixture.ExpectOpenDirectoryWithoutCleanup(DokanOperationsFixture.RootName, WriteDirectoryAccess, FileShare.ReadWrite);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            sut.MoveTo(fixture.DestinationFileName.AsDriveBasedPath());
        }

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        private void OpenFile_InSpecifiedMode(FileInfo info, FileMode mode, System.IO.FileAccess[] accessModes)
        {
            foreach (var access in accessModes)
            {
                Console.WriteLine($"{nameof(info.Open)} {mode}/{access}");
                using var stream = info.Open(mode, access);
#if !LOGONLY
                Assert.IsNotNull(stream, $"{nameof(info.Open)} {mode}/{access}");
#endif
                if (access.HasFlag(System.IO.FileAccess.Write))
                {
                    Assert.IsTrue(stream.CanWrite, "Stream should be writable");
                    stream.Write(smallData, 0, smallData.Length);
#if !LOGONLY
                    Assert.AreEqual(smallData.Length, stream.Position, "Unexpected write count");
#endif
                }

                if (access.HasFlag(System.IO.FileAccess.ReadWrite))
                {
                    stream.Seek(0, SeekOrigin.Begin);
                }

                if (access.HasFlag(System.IO.FileAccess.Read))
                {
                    Assert.IsTrue(stream.CanRead, "Stream should be readable");
                    var target = new byte[4096];
                    var readBytes = stream.Read(target, 0, target.Length);
#if !LOGONLY
                    Assert.AreEqual(target.Length, readBytes, "Unexpected read count");
                    CollectionAssert.AreEquivalent(smallData, target, "Unexpected result content");
#endif
                }
            }
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void Open_WhereFileModeIsAppend_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
            fixture.ExpectWriteFile(path, smallData, smallData.Length);

            fixture.PermitProbeFile(path, smallData);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            var parameters = new { Mode = FileMode.Append, AccessModes = new[] { System.IO.FileAccess.Write } };
            OpenFile_InSpecifiedMode(sut, parameters.Mode, parameters.AccessModes);

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void Open_WhereFileModeIsCreate_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            foreach (var access in new[] { WriteAccess, ReadWriteAccess })
            {
                fixture.ExpectCreateFile(path, access, WriteShare, FileMode.Create, FileOptions.None);
            }

            fixture.ExpectReadFile(path, smallData, smallData.Length);
            fixture.ExpectWriteFile(path, smallData, smallData.Length);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            var parameters = new { Mode = FileMode.Create, AccessModes = new[] { System.IO.FileAccess.Write, System.IO.FileAccess.ReadWrite } };
            OpenFile_InSpecifiedMode(sut, parameters.Mode, parameters.AccessModes);

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void Open_WhereFileModeIsCreateNew_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            foreach (var access in new[] { WriteAccess, ReadWriteAccess })
            {
                fixture.ExpectCreateFile(path, access, WriteShare, FileMode.CreateNew, FileOptions.None);
            }

            fixture.ExpectReadFile(path, smallData, smallData.Length);
            fixture.ExpectWriteFile(path, smallData, smallData.Length);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            var parameters = new { Mode = FileMode.CreateNew, AccessModes = new[] { System.IO.FileAccess.Write, System.IO.FileAccess.ReadWrite } };
            OpenFile_InSpecifiedMode(sut, parameters.Mode, parameters.AccessModes);

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Failure)]
        [ExpectedException(typeof(IOException), "Expected IOException not thrown")]
        public void Open_WhereFileModeIsCreateNew_AndFileExists_Throws()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileToFail(path, DokanResult.FileExists);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            var parameters = new { Mode = FileMode.CreateNew, AccessModes = new[] { System.IO.FileAccess.Write, System.IO.FileAccess.ReadWrite } };
            OpenFile_InSpecifiedMode(sut, parameters.Mode, parameters.AccessModes);
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void Open_WhereFileModeIsOpen_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            foreach (var access in new[] { ReadAccess, WriteAccess, ReadWriteAccess })
            {
                fixture.ExpectCreateFile(path, access, WriteShare, FileMode.Open, FileOptions.None);
            }

            fixture.ExpectReadFile(path, smallData, smallData.Length);
            fixture.ExpectWriteFile(path, smallData, smallData.Length);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            var parameters = new { Mode = FileMode.Open, AccessModes = new[] { System.IO.FileAccess.Read, System.IO.FileAccess.Write, System.IO.FileAccess.ReadWrite } };
            OpenFile_InSpecifiedMode(sut, parameters.Mode, parameters.AccessModes);

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Failure)]
        [ExpectedException(typeof(FileNotFoundException), "Expected FileNotFoundException not thrown")]
        public void Open_WhereFileModeIsOpen_AndFileDoesNotExists_Throws()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFileToFail(path, DokanResult.FileNotFound);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            var parameters = new { Mode = FileMode.Open, AccessModes = new[] { System.IO.FileAccess.Read, System.IO.FileAccess.Write, System.IO.FileAccess.ReadWrite } };
            OpenFile_InSpecifiedMode(sut, parameters.Mode, parameters.AccessModes);
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void Open_WhereFileModeIsOpenOrCreate_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None);
            foreach (var access in new[] { WriteAccess, ReadWriteAccess })
            {
                fixture.ExpectCreateFile(path, access, WriteShare, FileMode.OpenOrCreate, FileOptions.None);
            }

            fixture.ExpectWriteFile(path, smallData, smallData.Length);

            fixture.PermitProbeFile(path, smallData, smallData.Length);
            fixture.PermitProbeFile(path, smallData);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            var parameters = new { Mode = FileMode.OpenOrCreate, AccessModes = new[] { System.IO.FileAccess.Read, System.IO.FileAccess.Write, System.IO.FileAccess.ReadWrite } };
            OpenFile_InSpecifiedMode(sut, parameters.Mode, parameters.AccessModes);

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void Open_WhereFileModeIsTruncate_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.Open, FileOptions.None);
            fixture.ExpectSetAllocationSize(path, 0);
            fixture.ExpectWriteFile(path, smallData, smallData.Length);

            fixture.PermitProbeFile(path, smallData);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            var parameters = new { Mode = FileMode.Truncate, AccessModes = new[] { System.IO.FileAccess.Write } };
            OpenFile_InSpecifiedMode(sut, parameters.Mode, parameters.AccessModes);

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenRead_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            string value = $"TestValue for test {nameof(OpenRead_CallsApiCorrectly)}";
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadOnlyShare, FileMode.Open, FileOptions.None);
            fixture.ExpectReadFile(path, Encoding.UTF8.GetBytes(value), value.Length);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenRead())
            {
                Assert.IsTrue(stream.CanRead, "Stream should be readable");
                var target = new byte[value.Length];
                var readBytes = stream.Read(target, 0, target.Length);

#if !LOGONLY
                Assert.AreEqual(value.Length, readBytes, "Unexpected read count");
                Assert.AreEqual(value, Encoding.UTF8.GetString(target), "Unexpected result content");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Timing)]
        public void OpenRead_WithDelay_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            string value = $"TestValue for test {nameof(OpenRead_WithDelay_CallsApiCorrectly)}";
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadOnlyShare, FileMode.Open, FileOptions.None);
            fixture.ExpectReadFileWithDelay(path, Encoding.UTF8.GetBytes(value), value.Length, DokanOperationsFixture.IODelay);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenRead())
            {
                Assert.IsTrue(stream.CanRead, "Stream should be readable");
                var target = new byte[value.Length];
                var readBytes = stream.Read(target, 0, target.Length);

#if !LOGONLY
                Assert.AreEqual(value.Length, readBytes, "Unexpected read count");
                Assert.AreEqual(value, Encoding.UTF8.GetString(target), "Unexpected result content");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenRead_WithLargeFile_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadOnlyShare, FileMode.Open, FileOptions.None);
            fixture.ExpectReadFileInChunks(path, largeData, FILE_BUFFER_SIZE);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenRead())
            {
                Assert.IsTrue(stream.CanRead, "Stream should be readable");
                var target = new byte[largeData.Length];
                var totalReadBytes = 0;
                do
                {
                    var readBytes = stream.Read(target, totalReadBytes, target.Length - totalReadBytes);
                    Assert.AreEqual(Math.Min(FILE_BUFFER_SIZE, target.Length - totalReadBytes), readBytes, $"Unexpected empty read at origin {totalReadBytes}");
                    totalReadBytes += readBytes;
                } while (totalReadBytes < largeData.Length);

#if !LOGONLY
                Assert.AreEqual(largeData.Length, stream.Position, "Unexpected read count");
                CollectionAssert.AreEqual(largeData, target, "Unexpected result content");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenRead_WithLargeFileUsingContext_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadOnlyShare, FileMode.Open, FileOptions.None, context: largeData);
            fixture.ExpectReadFileInChunks(path, largeData, FILE_BUFFER_SIZE, context: largeData);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenRead())
            {
                Assert.IsTrue(stream.CanRead, "Stream should be readable");
                var target = new byte[largeData.Length];
                var totalReadBytes = 0;

                do
                {
                    var readBytes = stream.Read(target, totalReadBytes, target.Length - totalReadBytes);
                    Assert.AreEqual(Math.Min(FILE_BUFFER_SIZE, target.Length - totalReadBytes), readBytes, $"Unexpected empty read at origin {totalReadBytes}");
                    totalReadBytes += readBytes;
                } while (totalReadBytes < largeData.Length);

#if !LOGONLY
                Assert.AreEqual(largeData.Length, stream.Position, "Unexpected read count");
                CollectionAssert.AreEqual(largeData, target, "Unexpected result content");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Reliability", "CA2002:DoNotLockOnObjectsWithWeakIdentity")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenRead_WithLargeFile_InRandomOrder_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadOnlyShare, FileMode.Open, FileOptions.None);
            fixture.ExpectReadFileInChunks(path, largeData, FILE_BUFFER_SIZE);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenRead())
            {
                Assert.IsTrue(stream.CanRead, "Stream should be readable");
                var target = new byte[largeData.Length];
                var totalReadBytes = 0;

                Parallel.For(0, largeData.Length / FILE_BUFFER_SIZE + 1, i =>
                {
                    var origin = i * FILE_BUFFER_SIZE;
                    var count = Math.Min(FILE_BUFFER_SIZE, target.Length - origin);
                    lock (stream)
                    {
                        stream.Seek(origin, SeekOrigin.Begin);
                        var readBytes = stream.Read(target, origin, count);
                        Assert.AreEqual(count, readBytes, $"Unexpected empty read at origin {origin}");
                        totalReadBytes += readBytes;
                    }
                });

#if !LOGONLY
                Assert.AreEqual(largeData.Length, totalReadBytes, "Unexpected read count");
                CollectionAssert.AreEqual(largeData, target, "Unexpected result content");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Reliability", "CA2002:DoNotLockOnObjectsWithWeakIdentity")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenRead_WithLargeFileUsingContext_InRandomOrder_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadOnlyShare, FileMode.Open, FileOptions.None, context: largeData);
            fixture.ExpectReadFileInChunks(path, largeData, FILE_BUFFER_SIZE, context: largeData);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenRead())
            {
                Assert.IsTrue(stream.CanRead, "Stream should be readable");
                var target = new byte[largeData.Length];
                var totalReadBytes = 0;

                Parallel.For(0, largeData.Length / FILE_BUFFER_SIZE + 1, i =>
                {
                    var origin = i * FILE_BUFFER_SIZE;
                    var count = Math.Min(FILE_BUFFER_SIZE, target.Length - origin);
                    lock (stream)
                    {
                        stream.Seek(origin, SeekOrigin.Begin);
                        var readBytes = stream.Read(target, origin, count);
                        Assert.AreEqual(count, readBytes, $"Unexpected empty read at origin {origin}");
                        totalReadBytes += readBytes;
                    }
                });

#if !LOGONLY
                Assert.AreEqual(largeData.Length, totalReadBytes, "Unexpected read count");
                CollectionAssert.AreEqual(largeData, target, "Unexpected result content");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

#if USER_MODE_LOCK
        [TestMethod, TestCategory(TestCategories.Success)]
#endif
        public void OpenRead_WithLockingAndUnlocking_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            string value = $"TestValue for test {nameof(OpenRead_WithLockingAndUnlocking_CallsApiCorrectly)}";
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadOnlyShare, FileMode.Open, FileOptions.None);
            fixture.ExpectReadFile(path, Encoding.UTF8.GetBytes(value), value.Length);
            fixture.ExpectLockUnlockFile(path, 0, value.Length);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenRead())
            {
                Assert.IsTrue(stream.CanRead, "Stream should be readable");
                var target = new byte[value.Length];
                stream.Lock(0, target.Length);
                var readBytes = stream.Read(target, 0, target.Length);
                stream.Unlock(0, target.Length);

#if !LOGONLY
                Assert.AreEqual(value.Length, readBytes, "Unexpected read count");
                Assert.AreEqual(value, Encoding.UTF8.GetString(target), "Unexpected result content");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenText_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            string value = $"TestValue for test {nameof(OpenText_CallsApiCorrectly)}";
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadOnlyShare, FileMode.Open, FileOptions.SequentialScan);
            fixture.ExpectReadFile(path, Encoding.UTF8.GetBytes(value), value.Length);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var reader = sut.OpenText())
            {
                var target = new char[value.Length];
                var readBytes = reader.ReadBlock(target, 0, target.Length);

#if !LOGONLY
                Assert.AreEqual(value.Length, readBytes, "Unexpected read count");
                Assert.AreEqual(value, new string(target), "Unexpected result content");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenWrite_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            string value = $"TestValue for test {nameof(OpenWrite_CallsApiCorrectly)}";
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None);
            fixture.ExpectWriteFile(path, Encoding.UTF8.GetBytes(value), value.Length);

            fixture.PermitProbeFile(path, Encoding.UTF8.GetBytes(value));
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenWrite())
            {
                Assert.IsTrue(stream.CanWrite, "Stream should be writable");
                stream.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);

#if !LOGONLY
                Assert.AreEqual(value.Length, stream.Position, "Unexpected write count");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Timing)]
        public void OpenWrite_WithDelay_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            string value = $"TestValue for test {nameof(OpenWrite_WithDelay_CallsApiCorrectly)}";
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None);
            fixture.ExpectWriteFileWithDelay(path, Encoding.UTF8.GetBytes(value), value.Length, DokanOperationsFixture.IODelay);

            fixture.PermitProbeFile(path, Encoding.UTF8.GetBytes(value));
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenWrite())
            {
                Assert.IsTrue(stream.CanWrite, "Stream should be writable");
                stream.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);

#if !LOGONLY
                Assert.AreEqual(value.Length, stream.Position, "Unexpected write count");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenWrite_WithLargeFile_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None);
            fixture.ExpectWriteFileInChunks(path, largeData, FILE_BUFFER_SIZE);

            fixture.PermitProbeFile(path, largeData);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenWrite())
            {
                Assert.IsTrue(stream.CanWrite, "Stream should be writable");
                var totalWrittenBytes = 0;

                do
                {
                    var writtenBytes = Math.Min(FILE_BUFFER_SIZE, largeData.Length - totalWrittenBytes);
                    stream.Write(largeData, totalWrittenBytes, writtenBytes);
                    totalWrittenBytes += writtenBytes;
                } while (totalWrittenBytes < largeData.Length);

#if !LOGONLY
                Assert.AreEqual(largeData.Length, stream.Position, "Unexpected write count");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenWrite_WithLargeFileUsingContext_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None, context: largeData);
            fixture.ExpectWriteFileInChunks(path, largeData, FILE_BUFFER_SIZE, context: largeData);

            fixture.PermitProbeFile(path, largeData);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenWrite())
            {
                Assert.IsTrue(stream.CanWrite, "Stream should be writable");
                var totalWrittenBytes = 0;

                do
                {
                    var writtenBytes = Math.Min(FILE_BUFFER_SIZE, largeData.Length - totalWrittenBytes);
                    stream.Write(largeData, totalWrittenBytes, writtenBytes);
                    totalWrittenBytes += writtenBytes;
                } while (totalWrittenBytes < largeData.Length);

#if !LOGONLY
                Assert.AreEqual(largeData.Length, stream.Position, "Unexpected write count");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Reliability", "CA2002:DoNotLockOnObjectsWithWeakIdentity")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenWrite_WithLargeFile_InRandomOrder_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None);
            fixture.ExpectWriteFileInChunks(path, largeData, FILE_BUFFER_SIZE);

            fixture.PermitProbeFile(path, largeData);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenWrite())
            {
                Assert.IsTrue(stream.CanWrite, "Stream should be writable");
                var totalWrittenBytes = 0;

                Parallel.For(0, largeData.Length / FILE_BUFFER_SIZE + 1, i =>
                {
                    var origin = i * FILE_BUFFER_SIZE;
                    var count = Math.Min(FILE_BUFFER_SIZE, largeData.Length - origin);
                    lock (stream)
                    {
                        stream.Seek(origin, SeekOrigin.Begin);
                        stream.Write(largeData, origin, count);
                        totalWrittenBytes += count;
                    }
                });

#if !LOGONLY
                Assert.AreEqual(largeData.Length, totalWrittenBytes, "Unexpected write count");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Reliability", "CA2002:DoNotLockOnObjectsWithWeakIdentity")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenWrite_WithLargeFileUsingContext_InRandomOrder_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None, context: largeData);
            fixture.ExpectWriteFileInChunks(path, largeData, FILE_BUFFER_SIZE, context: largeData);

            fixture.PermitProbeFile(path, largeData);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenWrite())
            {
                Assert.IsTrue(stream.CanWrite, "Stream should be writable");
                var totalWrittenBytes = 0;

                Parallel.For(0, largeData.Length / FILE_BUFFER_SIZE + 1, i =>
                {
                    var origin = i * FILE_BUFFER_SIZE;
                    var count = Math.Min(FILE_BUFFER_SIZE, largeData.Length - origin);
                    lock (stream)
                    {
                        stream.Seek(origin, SeekOrigin.Begin);
                        stream.Write(largeData, origin, count);
                        totalWrittenBytes += count;
                    }
                });

#if !LOGONLY
                Assert.AreEqual(largeData.Length, totalWrittenBytes, "Unexpected write count");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void OpenWrite_WithFlush_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            string value = $"TestValue for test {nameof(OpenWrite_WithFlush_CallsApiCorrectly)}";
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None);
            fixture.ExpectWriteFile(path, Encoding.UTF8.GetBytes(value), value.Length);
            fixture.ExpectFlushFileBuffers(path);

            fixture.PermitProbeFile(path, Encoding.UTF8.GetBytes(value));
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenWrite())
            {
                Assert.IsTrue(stream.CanWrite, "Stream should be writable");
                stream.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);
                stream.Flush(true);

#if !LOGONLY
                Assert.AreEqual(value.Length, stream.Position, "Unexpected write count");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

#if USER_MODE_LOCK
        [TestMethod, TestCategory(TestCategories.Success)]
#endif
        public void OpenWrite_WithLockingAndUnlocking_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            string value = $"TestValue for test {nameof(OpenWrite_WithLockingAndUnlocking_CallsApiCorrectly)}";
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.OpenOrCreate, FileOptions.None);
            fixture.ExpectWriteFile(path, Encoding.UTF8.GetBytes(value), value.Length);
            fixture.ExpectLockUnlockFile(path, 0, value.Length);

            fixture.PermitProbeFile(path, Encoding.UTF8.GetBytes(value));
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            using (var stream = sut.OpenWrite())
            {
                Assert.IsTrue(stream.CanWrite, "Stream should be writable");
                stream.Lock(0, value.Length);
                stream.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);
                stream.Unlock(0, value.Length);

#if !LOGONLY
                Assert.AreEqual(value.Length, stream.Position, "Unexpected write count");
#endif
            }

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ParentIs")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void Replace_WhereParentIsRoot_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            string path = fixture.FileName.AsRootedPath(),
                destinationPath = fixture.DestinationFileName.AsRootedPath(),
                destinationBackupPath = fixture.DestinationBackupFileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(destinationPath, ReplaceAccess | FileAccess.AccessSystemSecurity, ReadWriteShare, FileMode.Open);
            fixture.ExpectCreateFileWithoutCleanup(destinationPath, ReplaceAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectCreateFileWithoutCleanup(path, SetOwnershipAccess, WriteShare, FileMode.Open, FileOptions.None);
            fixture.ExpectGetFileInformation(destinationPath, FileAttributes.Normal);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
            fixture.ExpectSetFileAttributes(path, FileAttributes.Normal);
            fixture.ExpectSetFileTime(path);
            fixture.ExpectGetVolumeInformation(DokanOperationsFixture.VOLUME_LABEL, DokanOperationsFixture.FILESYSTEM_NAME, 256);
            fixture.PermitGetFileInformationToFail(destinationBackupPath, NtStatus.ObjectPathNotFound, true);
            fixture.PermitOpenDirectory(DokanOperationsFixture.RootName, ReadDirectoryAccess, ReadWriteShare, attributes: FileAttributes.Normal);
            fixture.ExpectCreateFile(destinationBackupPath, WriteDirectoryAccess, FileShare.ReadWrite, FileMode.Open);
            fixture.ExpectOpenDirectoryWithoutCleanup(DokanOperationsFixture.RootName, WriteDirectoryAccess, FileShare.ReadWrite);
            fixture.ExpectMoveFile(destinationPath, destinationBackupPath, true);
            fixture.PermitGetFileInformation(destinationBackupPath, FileAttributes.Normal, false);
            fixture.ExpectCreateFile(destinationPath, WriteDirectoryAccess, FileShare.ReadWrite, FileMode.Open);
            fixture.ExpectMoveFile(path, destinationPath, true);
#endif

            var sut = new FileInfo(fixture.FileName.AsDriveBasedPath());

            sut.Replace(fixture.DestinationFileName.AsDriveBasedPath(), fixture.DestinationBackupFileName.AsDriveBasedPath());

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ParentIs")]
        [TestMethod, TestCategory(TestCategories.Success)]
        public void Replace_WhereParentIsDirectory_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            string origin = Path.Combine(fixture.DirectoryName, fixture.FileName),
                destination = Path.Combine(fixture.DestinationDirectoryName, fixture.DestinationFileName),
                destinationBackup = Path.Combine(fixture.DestinationDirectoryName, fixture.DestinationBackupFileName),
                path = origin.AsRootedPath(),
                destinationPath = destination.AsRootedPath(),
                destinationBackupPath = destinationBackup.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(destinationPath, ReplaceAccess | FileAccess.AccessSystemSecurity, ReadWriteShare, FileMode.Open);
            fixture.ExpectCreateFileWithoutCleanup(destinationPath, ReplaceAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectCreateFileWithoutCleanup(path, SetOwnershipAccess, WriteShare, FileMode.Open, FileOptions.None);
            fixture.ExpectGetFileInformation(destinationPath, FileAttributes.Normal);
            fixture.ExpectGetFileInformation(path, FileAttributes.Normal);
            fixture.ExpectSetFileAttributes(path, FileAttributes.Normal);
            fixture.ExpectSetFileTime(path);
            fixture.ExpectGetVolumeInformation(DokanOperationsFixture.VOLUME_LABEL, DokanOperationsFixture.FILESYSTEM_NAME, 256);
            fixture.PermitGetFileInformationToFail(destinationBackupPath, NtStatus.ObjectPathNotFound, true);
            fixture.PermitOpenDirectory(fixture.DestinationDirectoryName.AsRootedPath(), ReadDirectoryAccess, ReadWriteShare, attributes: FileAttributes.Normal);
            fixture.ExpectCreateFile(destinationBackupPath, WriteDirectoryAccess, FileShare.ReadWrite, FileMode.Open);
            fixture.ExpectOpenDirectoryWithoutCleanup(fixture.DestinationDirectoryName.AsRootedPath(), WriteDirectoryAccess, FileShare.ReadWrite);
            fixture.ExpectMoveFile(destinationPath, destinationBackupPath, true);
            fixture.PermitGetFileInformation(destinationBackupPath, FileAttributes.Normal, false);
            fixture.ExpectCreateFile(destinationPath, WriteDirectoryAccess, FileShare.ReadWrite, FileMode.Open);
            fixture.ExpectMoveFile(path, destinationPath, true);
#endif

            var sut = new FileInfo(origin.AsDriveBasedPath());

            sut.Replace(destination.AsDriveBasedPath(), destinationBackup.AsDriveBasedPath());

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void SetAccessControl_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName;

            var security = new FileSecurity();
            security.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null), FileSystemRights.FullControl, AccessControlType.Allow));
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path.AsRootedPath(), ChangePermissionsAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path.AsRootedPath(), FileAttributes.Normal);
            fixture.ExpectGetFileSecurity(path.AsRootedPath(), DokanOperationsFixture.DefaultFileSecurity);
            fixture.ExpectSetFileSecurity(path.AsRootedPath(), security);
            fixture.ExpectCreateFile(DokanOperationsFixture.RootName, ReadPermissionsAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(DokanOperationsFixture.RootName, FileAttributes.Directory);
            fixture.ExpectGetFileSecurity(DokanOperationsFixture.RootName, DokanOperationsFixture.DefaultDirectorySecurity, AccessControlSections.Access);
#endif

            var sut = new FileInfo(path.AsDriveBasedPath());
            sut.SetAccessControl(security);

#if !LOGONLY
            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Success)]
        public void GetFileInformation_WhereDatesIsUnknown_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            var attributes = FileAttributes.Normal;
            fixture.ExpectCreateFile(path, ReadAttributesAccess, ReadWriteShare, FileMode.Open);
            fixture.ExpectGetFileInformation(path, attributes, creationTime: DateTime.MinValue, lastWriteTime: DateTime.MinValue, lastAccessTime: DateTime.MinValue);
#endif

            var sut = new DirectoryInfo(path.AsDriveBasedPath());

#if !LOGONLY
            //As DirectoryInfo do not have any handling om uninitialized date
            //do we have to use this date insted of DateTime.MinValue
            var defaultDate = DateTime.FromFileTime(0);
            Assert.AreEqual(defaultDate, sut.CreationTime, $"File should have unknown {nameof(sut.CreationTime)}.");
            Assert.AreEqual(defaultDate, sut.LastWriteTime, $"File should have unknown {nameof(sut.LastWriteTime)}.");
            Assert.AreEqual(defaultDate, sut.LastAccessTime, $"File should have unknown {nameof(sut.LastAccessTime)}.");
            Assert.AreEqual(attributes, sut.Attributes, $"{nameof(sut.Attributes)} is not initialized.");

            fixture.Verify();
#endif
        }
    }
}
```

### FileInfoTestsUnsafe.cs

```using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DokanNet.Tests
{
    /// <summary>
    /// Tests for <see cref="IDokanOperationsUnsafe"/>. This is leveraging the same set of tests as
    /// <see cref="FileInfoTests"/> by deriving from that class, but by calling
    /// DokanOperationsFixture.InitInstance(unsafeOperations: true) from setup to send all
    /// Read/WriteFile calls through the Read/WriteFile(IntPtr buffer, uint bufferLength) overloads instead
    /// of the Read/WriteFile(byte[] buffer) overloads.
    /// </summary>
    [TestClass]
    public sealed class FileInfoTestsUnsafe : FileInfoTests
    {
        [ClassInitialize]
        public static new void ClassInitialize(TestContext context)
        {
            // Just invoke the base class init.
            FileInfoTests.ClassInitialize(context);
        }

        [ClassCleanup]
        public static new void ClassCleanup()
        {
            // Just invoke the base class cleanup.
            FileInfoTests.ClassCleanup();
        }

        [TestInitialize]
        public override void Initialize()
        {
            // Clear the buffer pool (so we can validate in Cleanup()) and init test fixture.
            BufferPool.Default.Clear();
            DokanOperationsFixture.InitInstance(TestContext.TestName, unsafeOperations: true);
        }

        [TestCleanup]
        public override void Cleanup()
        {
            // Verify no buffers were pooled and then call base class Cleanup().
            Assert.AreEqual(0, BufferPool.Default.ServedBytes, "Expected zero buffer pooling activity when using IDokanOperationsUnsafe.");
            BufferPool.Default.Clear();
            base.Cleanup();
        }
    }
}

```

### FileSettings.cs

```using System.IO;

namespace DokanNet.Tests
{
    internal static class FileSettings
    {
        public const FileAccess ReadAttributesAccess = FileAccess.ReadAttributes;

        public const FileAccess ReadPermissionsAccess = FileAccess.ReadPermissions;

        public const FileAccess ReadAttributesPermissionsAccess = ReadAttributesAccess | ReadPermissionsAccess;

        public const FileAccess ChangePermissionsAccess = FileAccess.ReadAttributes | FileAccess.ReadPermissions | FileAccess.ChangePermissions;

        public const FileAccess ReadAccess = FileAccess.ReadData | FileAccess.ReadExtendedAttributes | FileAccess.ReadAttributes | FileAccess.ReadPermissions | FileAccess.Synchronize;

        public const FileAccess WriteAccess =
            FileAccess.WriteData | FileAccess.AppendData | FileAccess.WriteExtendedAttributes |
            FileAccess.ReadAttributes | FileAccess.WriteAttributes | FileAccess.ReadPermissions | FileAccess.Synchronize;

        public const FileAccess ReadWriteAccess = ReadAccess | WriteAccess;

        public const FileAccess SetOwnershipAccess = ReadAccess | WriteAccess | FileAccess.Delete | FileAccess.ChangePermissions | FileAccess.SetOwnership;

        public const FileAccess DeleteAccess = FileAccess.ReadAttributes | FileAccess.Delete;

        public const FileAccess CopyToAccess = ReadAccess | WriteAccess | FileAccess.Delete | FileAccess.ChangePermissions;

        public const FileAccess MoveFromAccess = FileAccess.ReadAttributes | FileAccess.Delete | FileAccess.Synchronize;

        public const FileAccess ReplaceAccess = FileAccess.WriteData | FileAccess.ReadExtendedAttributes | FileAccess.ReadAttributes | FileAccess.Delete | FileAccess.ReadPermissions | FileAccess.Synchronize;

        public const FileAccess OpenDirectoryAccess = FileAccess.Synchronize;

        public const FileAccess ReadDirectoryAccess = FileAccess.ReadData | FileAccess.Synchronize;

        public const FileAccess WriteDirectoryAccess = FileAccess.WriteData | FileAccess.Synchronize;

        public const FileAccess AppendToDirectoryAccess = FileAccess.AppendData | FileAccess.Synchronize;

        public const FileAccess DeleteFromDirectoryAccess = FileAccess.Delete | FileAccess.ReadAttributes | FileAccess.Synchronize;

        public const FileShare ReadOnlyShare = FileShare.Read;

        public const FileShare ReadShare = FileShare.Read | FileShare.Delete;

        public const FileShare ReadWriteShare = FileShare.ReadWrite | FileShare.Delete;

        public const FileShare WriteShare = FileShare.None;

        public const FileShare OpenDirectoryShare = FileShare.None;

        public const FileOptions ReadFileOptions = FileOptions.None;

        public const FileOptions WriteFileOptions = FileOptions.None;

        public const FileOptions OpenReparsePointOptions = (FileOptions)0x00200000;

        public const FileOptions OpenNoBufferingOptions = (FileOptions)0x20000000;
    }
}
```

### FileSystemSecurityExtensions.cs

```using System.Security.AccessControl;

namespace DokanNet.Tests
{
    internal static class FileSystemSecurityExtensions
    {
        public static string AsString(this FileSystemSecurity security)
            => security.GetSecurityDescriptorSddlForm(AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
    }
}
```

### FormatProviderTests.cs

```using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DokanNet.Tests
{
    [TestClass]
    public sealed class FormatProviderTests
    {
        [TestMethod, TestCategory(TestCategories.Success)]
        public void NullValuesShouldBeVisible()
        {
            DateTime? obj = null;
            Assert.AreEqual(FormatProviders.NullStringRepresentation, string.Format(FormatProviders.DefaultFormatProvider, "{0}", obj));
        }
    }
}
```

### GlobalSuppressions.cs

```using System.Diagnostics.CodeAnalysis;

[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dokan",
        Scope = "namespace", Target = "DokanNet.Tests")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dokan")]
// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the
// Code Analysis results, point to "Suppress Message", and click
// "In Suppression File".
// You do not need to add suppressions to this file manually.
```

### LogExtensions.cs

```namespace DokanNet.Tests
{
    internal static class LogExtensions
    {
        public static string Log(this IDokanFileInfo info)
            => $"{nameof(DokanFileInfo)} {{{info.Context ?? "<null>"}, {(info.DeletePending ? nameof(info.DeletePending) : "")}, {(info.IsDirectory ? nameof(info.IsDirectory) : "")}, {(info.NoCache ? nameof(info.NoCache) : "")}, {(info.PagingIo ? nameof(info.PagingIo) : "")}, {info.ProcessId}, {(info.SynchronousIo ? nameof(info.SynchronousIo) : "")}, {(info.WriteToEndOfFile ? nameof(info.WriteToEndOfFile) : "")}}}";

        public static string Log(this FileInformation fileInfo)
            => $"{nameof(FileInformation)} {{{fileInfo.FileName}, [{fileInfo.Attributes}], {fileInfo.CreationTime?.ToString() ?? "<null>"}, {fileInfo.LastWriteTime?.ToString() ?? "<null>"}, {fileInfo.LastAccessTime?.ToString() ?? "<null>"}, {fileInfo.Length}}}";
    }
}
```

### Mounter.cs

```using System.IO;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DokanNet.Tests
{
    [TestClass]
    public static class Mounter
    {
        private static Logging.NullLogger NullLogger = new Logging.NullLogger();
        private static Dokan Dokan;
        private static DokanInstance safeMount;
        private static DokanInstance unsafeMount;

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            var dokanOptions = DokanOptions.DebugMode | DokanOptions.MountManager | DokanOptions.CurrentSession;
#if NETWORK_DRIVE
            dokanOptions |= DokanOptions.NetworkDrive;
#else
            dokanOptions |= DokanOptions.RemovableDrive;
#endif
#if USER_MODE_LOCK
            dokanOptions |= DokanOptions.UserModeLock;
#endif

            Dokan = new Dokan(NullLogger);
            var safeDokanBuilder = new DokanInstanceBuilder(Dokan)
                .ConfigureOptions(options =>
                {
                    options.Options = dokanOptions;
                    options.MountPoint = DokanOperationsFixture.NormalMountPoint;
                });

            safeMount = safeDokanBuilder.Build(DokanOperationsFixture.Operations);

            var unsafeDokanBuilder = new DokanInstanceBuilder(Dokan)
               .ConfigureOptions(options =>
               {
                   options.Options = dokanOptions;
                   options.MountPoint = DokanOperationsFixture.UnsafeMountPoint;
               });
            unsafeMount = unsafeDokanBuilder.Build(DokanOperationsFixture.UnsafeOperations);
            var drive = new DriveInfo(DokanOperationsFixture.NormalMountPoint);
            var drive2 = new DriveInfo(DokanOperationsFixture.UnsafeMountPoint);
            while (!drive.IsReady || !drive2.IsReady)
            {
                Thread.Sleep(50);
            }

            while (DokanOperationsFixture.HasPendingFiles)
            {
                Thread.Sleep(50);
            }
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            safeMount.Dispose();
            unsafeMount.Dispose();
        }
    }
}

```

### OverlappedTests.cs

```using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32.SafeHandles;
using static DokanNet.Tests.FileSettings;

namespace DokanNet.Tests
{
    [TestClass]
    public sealed class OverlappedTests
    {
        private const long FILE_BUFFER_SIZE = 1 << 19;

        private static class NativeMethods
        {
            private const string KERNEL_32_DLL = "kernel32.dll";

            [Flags]
            public enum DesiredAccess : uint
            {
                GENERIC_ALL = 0x10000000,
                GENERIC_EXECUTE = 0x20000000,
                GENERIC_WRITE = 0x40000000,
                GENERIC_READ = 0x80000000
            }

            [Flags]
            public enum ShareMode : uint
            {
                FILE_SHARE_NONE = 0x0,
                FILE_SHARE_READ = 0x1,
                FILE_SHARE_WRITE = 0x2,
                FILE_SHARE_DELETE = 0x4
            }

            public enum CreationDisposition : uint
            {
                CREATE_NEW = 1,
                CREATE_ALWAYS = 2,
                OPEN_EXISTING = 3,
                OPEN_ALWAYS = 4,
                TRUNCATE_EXSTING = 5
            }

            public enum MoveMethod : uint
            {
                FILE_BEGIN = 0,
                FILE_CURRENT = 1,
                FILE_END = 2
            }

            [Flags]
            public enum FlagsAndAttributes : uint
            {
                FILE_ATTRIBUTE_READONLY = 0x0001,
                FILE_ATTRIBUTE_HIDDEN = 0x0002,
                FILE_ATTRIBUTE_SYSTEM = 0x0004,
                FILE_ATTRIBUTE_ARCHIVE = 0x0020,
                FILE_ATTRIBUTE_NORMAL = 0x0080,
                FILE_ATTRIBUTE_TEMPORARY = 0x100,
                FILE_ATTRIBUTE_OFFLINE = 0x1000,
                FILE_ATTRIBUTE_ENCRYPTED = 0x4000,
                FILE_FLAG_OPEN_NO_RECALL = 0x00100000,
                FILE_FLAG_OPEN_REPARSE_POINT = 0x00200000,
                FILE_FLAG_SESSION_AWARE = 0x00800000,
                FILE_FLAG_POSIX_SEMANTICS = 0x01000000,
                FILE_FLAG_BACKUP_SEMANTICS = 0x02000000,
                FILE_FLAG_DELETE_ON_CLOSE = 0x04000000,
                FILE_FLAG_SEQUENTIAL_SCAN = 0x08000000,
                FILE_FLAG_RANDOM_ACCESS = 0x10000000,
                FILE_FLAG_NO_BUFFERING = 0x20000000,
                FILE_FLAG_OVERLAPPED = 0x40000000,
                FILE_FLAG_WRITE_THROUGH = 0x80000000
            }

            [DllImport(KERNEL_32_DLL, SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
            private static extern SafeFileHandle CreateFile(string lpFileName, DesiredAccess dwDesiredAccess,
                ShareMode dwShareMode, IntPtr lpSecurityAttributes, CreationDisposition dwCreationDisposition,
                FlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

            [DllImport(KERNEL_32_DLL, SetLastError = true)]
            private static extern bool ReadFileEx(SafeFileHandle hFile, byte[] lpBuffer, int nNumberOfBytesToRead,
                ref NativeOverlapped lpOverlapped, FileIOCompletionRoutine lpCompletionRoutine);

            [DllImport(KERNEL_32_DLL, SetLastError = true)]
            private static extern bool SetEndOfFile(SafeFileHandle hFile);

            [DllImport(KERNEL_32_DLL, SetLastError = true)]
            private static extern int SetFilePointer(SafeFileHandle hFile, int lDistanceToMove,
                out int lpDistanceToMoveHigh, MoveMethod dwMoveMethod);

            [DllImport(KERNEL_32_DLL, SetLastError = true)]
            private static extern bool WriteFileEx(SafeFileHandle hFile, byte[] lpBuffer, int nNumberOfBytesToWrite,
                ref NativeOverlapped lpOverlapped, FileIOCompletionRoutine lpCompletionRoutine);

            private delegate void FileIOCompletionRoutine(
                int dwErrorCode, int dwNumberOfBytesTransfered, ref NativeOverlapped lpOverlapped);

            [DebuggerDisplay("{DebuggerDisplay(),nq}")]
            internal class OverlappedChunk
            {
                public byte[] Buffer { get; }

                public int BytesTransferred { get; set; }

                public int Win32Error { get; set; }

                public OverlappedChunk(int count) : this(new byte[count])
                {
                }

                public OverlappedChunk(byte[] buffer)
                {
                    Buffer = buffer;
                    BytesTransferred = 0;
                    Win32Error = 0;
                }

                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode",
                    Justification = "Used for debugging only")]
                private string DebuggerDisplay()
                    => $"{nameof(OverlappedChunk)} Buffer={Buffer?.Length ?? -1} BytesTransferred={BytesTransferred}";
            }

            internal static int BufferSize(long bufferSize, long fileSize, int chunks)
                => (int)Math.Min(bufferSize, fileSize - chunks * bufferSize);

            internal static int NumberOfChunks(long bufferSize, long fileSize)
            {
                var quotient = Math.DivRem(fileSize, bufferSize, out long remainder);
                return (int)quotient + (remainder > 0 ? 1 : 0);
            }

            internal static OverlappedChunk[] ReadEx(string fileName, long bufferSize, long fileSize)
            {
                var chunks = Enumerable.Range(0, NumberOfChunks(bufferSize, fileSize))
                    .Select(i => new OverlappedChunk(BufferSize(bufferSize, fileSize, i)))
                    .ToArray();
                var waitHandles = Enumerable.Repeat<Func<EventWaitHandle>>(() => new ManualResetEvent(false), chunks.Length)
                    .Select(e => e())
                    .ToArray();
                var completions = Enumerable.Range(0, chunks.Length)
                    .Select<int, FileIOCompletionRoutine>(
                        i => (int dwErrorCode, int dwNumberOfBytesTransferred, ref NativeOverlapped lpOverlapped) =>
                        {
                            chunks[i].Win32Error = dwErrorCode;
                            chunks[i].BytesTransferred = dwNumberOfBytesTransferred;
                            waitHandles[i].Set();
                        }).ToArray();

                var awaiterThread = new Thread(new ThreadStart(() => WaitHandle.WaitAll(waitHandles)));
                awaiterThread.Start();

                using (var handle = CreateFile(fileName, DesiredAccess.GENERIC_READ, ShareMode.FILE_SHARE_READ | ShareMode.FILE_SHARE_DELETE, IntPtr.Zero,
                        CreationDisposition.OPEN_EXISTING, FlagsAndAttributes.FILE_FLAG_NO_BUFFERING | FlagsAndAttributes.FILE_FLAG_OVERLAPPED, IntPtr.Zero))
                {
                    for (var i = 0; i < chunks.Length; ++i)
                    {
                        var offset = i * bufferSize;
                        var overlapped = new NativeOverlapped()
                        {
                            OffsetHigh = (int)(offset >> 32),
                            OffsetLow = (int)(offset & 0xffffffff),
                            EventHandle = IntPtr.Zero
                        };
                        var buffer = chunks[i].Buffer;

                        if (!ReadFileEx(handle, buffer, buffer.Length, ref overlapped, completions[i]))
                        {
                            chunks[i].Win32Error = Marshal.GetLastWin32Error();
                            waitHandles[i].Set();
                        }
                    }

                    awaiterThread.Join();
                }

                Array.ForEach(completions, c => GC.KeepAlive(c));

                return chunks;
            }

            internal static void WriteEx(string fileName, long bufferSize, long fileSize, OverlappedChunk[] chunks)
            {
                var waitHandles = Enumerable.Repeat<Func<EventWaitHandle>>(() => new ManualResetEvent(false), chunks.Length)
                    .Select(e => e())
                    .ToArray();
                var completions = Enumerable.Range(0, chunks.Length)
                    .Select<int, FileIOCompletionRoutine>(
                        i => (int dwErrorCode, int dwNumberOfBytesTransferred, ref NativeOverlapped lpOverlapped) =>
                        {
                            chunks[i].Win32Error = dwErrorCode;
                            chunks[i].BytesTransferred = dwNumberOfBytesTransferred;
                            waitHandles[i].Set();
                        }).ToArray();

                var awaiterThread = new Thread(new ThreadStart(() => WaitHandle.WaitAll(waitHandles)));
                awaiterThread.Start();

                using (var handle = CreateFile(fileName, DesiredAccess.GENERIC_WRITE, ShareMode.FILE_SHARE_NONE,
                        IntPtr.Zero, CreationDisposition.OPEN_EXISTING, FlagsAndAttributes.FILE_FLAG_NO_BUFFERING | FlagsAndAttributes.FILE_FLAG_OVERLAPPED, IntPtr.Zero))
                {
                    var offsetHigh = (int)(fileSize >> 32);
                    if (SetFilePointer(handle, (int)(fileSize & 0xffffffff), out offsetHigh, MoveMethod.FILE_BEGIN) !=
                        fileSize || offsetHigh != (int)(fileSize >> 32) || !SetEndOfFile(handle))
                    {
                        chunks[0].Win32Error = Marshal.GetLastWin32Error();
                        throw new InvalidOperationException();
                    }

                    for (var i = 0; i < chunks.Length; ++i)
                    {
                        var offset = i * bufferSize;
                        var overlapped = new NativeOverlapped()
                        {
                            OffsetHigh = (int)(offset >> 32),
                            OffsetLow = (int)(offset & 0xffffffff),
                            EventHandle = IntPtr.Zero
                        };
                        var buffer = chunks[i].Buffer;

                        if (!WriteFileEx(handle, buffer, buffer.Length, ref overlapped, completions[i]))
                        {
                            chunks[i].Win32Error = Marshal.GetLastWin32Error();
                        }
                    }

                    awaiterThread.Join();
                }

                Array.ForEach(completions, c => GC.KeepAlive(c));
            }
        }

        private static byte[] testData;

        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            testData = DokanOperationsFixture.InitBlockTestData(FILE_BUFFER_SIZE, 5 * FILE_BUFFER_SIZE + 65536);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            testData = null;
        }

        [TestInitialize]
        public void Initialize()
        {
            DokanOperationsFixture.InitInstance(TestContext.TestName);
        }

        [TestCleanup]
        public void Cleanup()
        {
            DokanOperationsFixture.ClearInstance(out bool hasUnmatchedInvocations);
            Assert.IsFalse(hasUnmatchedInvocations, "Found Mock invocations without corresponding setups");
        }

        [TestMethod, TestCategory(TestCategories.Manual)]
        public void OpenRead_WithLargeFileUsingContext_Overlapped_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadShare, FileMode.Open, context: testData);
            fixture.ExpectReadFileInChunks(path, testData, (int)FILE_BUFFER_SIZE, context: testData, synchronousIo: false);
#endif

            var outputs = NativeMethods.ReadEx(fixture.FileName.AsDriveBasedPath(), FILE_BUFFER_SIZE, testData.Length);

#if !LOGONLY
            for (var i = 0; i < outputs.Length; ++i)
            {
                Assert.AreEqual(0, outputs[i].Win32Error, $"Unexpected Win32 error in output {i}");
                Assert.AreEqual(NativeMethods.BufferSize(FILE_BUFFER_SIZE, testData.Length, i), outputs[i].BytesTransferred, $"Unexpected number of bytes read in output {i}");
                Assert.IsTrue(Enumerable.All(outputs[i].Buffer, b => b == (byte)i + 1), $"Unexpected data in output {i}");
            }

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Manual)]
        public void OpenWrite_WithLargeFileUsingContext_Overlapped_CallsApiCorrectly()
        {
            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.Open, context: testData);
            fixture.ExpectSetAllocationSize(path, testData.Length);
            fixture.ExpectSetEndOfFile(path, testData.Length);
            fixture.ExpectWriteFileInChunks(path, testData, (int)FILE_BUFFER_SIZE, context: testData, synchronousIo: false);
#endif

            var inputs = Enumerable.Range(0, NativeMethods.NumberOfChunks(FILE_BUFFER_SIZE, testData.Length))
                .Select(i => new NativeMethods.OverlappedChunk(Enumerable.Repeat((byte)(i + 1), NativeMethods.BufferSize(FILE_BUFFER_SIZE, testData.Length, i)).ToArray()))
                .ToArray();

            NativeMethods.WriteEx(fixture.FileName.AsDriveBasedPath(), FILE_BUFFER_SIZE, testData.Length, inputs);

#if !LOGONLY
            for (var i = 0; i < inputs.Length; ++i)
            {
                Assert.AreEqual(0, inputs[i].Win32Error, $"Unexpected Win32 error in input {i}");
                Assert.AreEqual(NativeMethods.BufferSize(FILE_BUFFER_SIZE, testData.Length, i), inputs[i].BytesTransferred, $"Unexpected number of bytes written in input {i}");
            }

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Manual)]
        [DeploymentItem("OverlappedTests.Configuration.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\OverlappedTests.Configuration.xml", "ConfigRead", DataAccessMethod.Sequential)]
        public void OpenRead_WithVariableSizes_Overlapped_CallsApiCorrectly()
        {
            var bufferSize = int.Parse((string)TestContext.DataRow["BufferSize"]);
            var fileSize = int.Parse((string)TestContext.DataRow["FileSize"]);

            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            var testData = DokanOperationsFixture.InitBlockTestData(bufferSize, fileSize);
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, ReadAccess, ReadShare, FileMode.Open, context: testData);
            fixture.ExpectReadFileInChunks(path, testData, bufferSize, context: testData, synchronousIo: false);
#endif

            var outputs = NativeMethods.ReadEx(fixture.FileName.AsDriveBasedPath(), bufferSize, testData.Length);

#if !LOGONLY
            for (var i = 0; i < outputs.Length; ++i)
            {
                Assert.AreEqual(0, outputs[i].Win32Error, $"Unexpected Win32 error in output {i} for BufferSize={bufferSize}, FileSize={fileSize}");
                Assert.AreEqual(NativeMethods.BufferSize(bufferSize, fileSize, i), outputs[i].BytesTransferred, $"Unexpected number of bytes read in output {i} for BufferSize={bufferSize}, FileSize={fileSize}");
                Assert.IsTrue(Enumerable.All(outputs[i].Buffer, b => b == (byte)i + 1), $"Unexpected data in output {i} for BufferSize={bufferSize}, FileSize={fileSize}");
            }

            fixture.Verify();
#endif
        }

        [TestMethod, TestCategory(TestCategories.Manual)]
        [DeploymentItem("OverlappedTests.Configuration.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\OverlappedTests.Configuration.xml", "ConfigWrite", DataAccessMethod.Sequential)]
        public void OpenWrite_WithVariableSizes_Overlapped_CallsApiCorrectly()
        {
            var bufferSize = int.Parse((string)TestContext.DataRow["BufferSize"]);
            var fileSize = int.Parse((string)TestContext.DataRow["FileSize"]);

            var fixture = DokanOperationsFixture.Instance;

            var path = fixture.FileName.AsRootedPath();
            var testData = DokanOperationsFixture.InitBlockTestData(bufferSize, fileSize);
#if LOGONLY
            fixture.PermitAny();
#else
            fixture.ExpectCreateFile(path, WriteAccess, WriteShare, FileMode.Open, context: testData);
            fixture.ExpectSetAllocationSize(path, testData.Length);
            fixture.ExpectSetEndOfFile(path, testData.Length);
#if NETWORK_DRIVE
            fixture.ExpectWriteFileInChunks(path, testData, bufferSize, context: testData, synchronousIo: false);
#else
            fixture.ExpectWriteFileInChunks(path, testData, bufferSize, context: testData);
#endif
#endif

            var inputs = Enumerable.Range(0, NativeMethods.NumberOfChunks(bufferSize, fileSize))
                .Select(i => new NativeMethods.OverlappedChunk(Enumerable.Repeat((byte)(i + 1), NativeMethods.BufferSize(bufferSize, testData.Length, i)).ToArray()))
                .ToArray();

            NativeMethods.WriteEx(fixture.FileName.AsDriveBasedPath(), bufferSize, testData.Length, inputs);

#if !LOGONLY
            for (var i = 0; i < inputs.Length; ++i)
            {
                Assert.AreEqual(0, inputs[i].Win32Error, $"Unexpected Win32 error in input {i} for BufferSize={bufferSize}, FileSize={fileSize}");
                Assert.AreEqual(NativeMethods.BufferSize(bufferSize, fileSize, i), inputs[i].BytesTransferred, $"Unexpected number of bytes written in input {i} for BufferSize={bufferSize}, FileSize={fileSize}");
            }

            fixture.Verify();
#endif
        }
    }
}
```

### StringExtensions.cs

```namespace DokanNet.Tests
{
    internal static class StringExtensions
    {
        public static string AsRootedPath(this string path) => DokanOperationsFixture.RootedPath(path);

        public static string AsDriveBasedPath(this string path) => DokanOperationsFixture.DriveBasedPath(path);
    }
}
```

### TestCategories.cs

```namespace DokanNet.Tests
{
    internal static class TestCategories
    {
        public const string Success = nameof(Success);

        public const string Failure = nameof(Failure);

        public const string Timing = nameof(Timing);

        public const string Manual = nameof(Manual);

        public const string NoPatternSearch = nameof(NoPatternSearch);
    }
}
```


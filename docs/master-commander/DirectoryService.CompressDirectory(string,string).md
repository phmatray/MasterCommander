#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Integrations](MasterCommander.md#MasterCommander.Integrations 'MasterCommander.Integrations').[DirectoryService](DirectoryService.md 'MasterCommander.Integrations.DirectoryService')

## DirectoryService.CompressDirectory(string, string) Method

Compresses the specified directory into a ZIP file, including all its files and subdirectories.

```csharp
public void CompressDirectory(string directoryPath, string zipFilePath);
```
#### Parameters

<a name='MasterCommander.Integrations.DirectoryService.CompressDirectory(string,string).directoryPath'></a>

`directoryPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the directory to compress.

<a name='MasterCommander.Integrations.DirectoryService.CompressDirectory(string,string).zipFilePath'></a>

`zipFilePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path where the resulting ZIP file should be saved.

Implements [CompressDirectory(string, string)](IDirectoryService.CompressDirectory(string,string).md 'MasterCommander.Core.Services.IDirectoryService.CompressDirectory(string, string)')
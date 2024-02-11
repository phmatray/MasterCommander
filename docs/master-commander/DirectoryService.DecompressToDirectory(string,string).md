#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Integrations](MasterCommander.md#MasterCommander.Integrations 'MasterCommander.Integrations').[DirectoryService](DirectoryService.md 'MasterCommander.Integrations.DirectoryService')

## DirectoryService.DecompressToDirectory(string, string) Method

Decompresses a ZIP file into a specified directory, extracting all its contents.

```csharp
public void DecompressToDirectory(string zipFilePath, string directoryPath);
```
#### Parameters

<a name='MasterCommander.Integrations.DirectoryService.DecompressToDirectory(string,string).zipFilePath'></a>

`zipFilePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the ZIP file to decompress.

<a name='MasterCommander.Integrations.DirectoryService.DecompressToDirectory(string,string).directoryPath'></a>

`directoryPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The target directory path where the contents of the ZIP file will be extracted.

Implements [DecompressToDirectory(string, string)](IDirectoryService.DecompressToDirectory(string,string).md 'MasterCommander.Core.Services.IDirectoryService.DecompressToDirectory(string, string)')
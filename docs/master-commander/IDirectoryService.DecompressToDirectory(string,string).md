#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Services](MasterCommander.Core.Services.md 'MasterCommander.Core.Services').[IDirectoryService](IDirectoryService.md 'MasterCommander.Core.Services.IDirectoryService')

## IDirectoryService.DecompressToDirectory(string, string) Method

Decompresses a ZIP file into a specified directory, extracting all its contents.

```csharp
void DecompressToDirectory(string zipFilePath, string directoryPath);
```
#### Parameters

<a name='MasterCommander.Core.Services.IDirectoryService.DecompressToDirectory(string,string).zipFilePath'></a>

`zipFilePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the ZIP file to decompress.

<a name='MasterCommander.Core.Services.IDirectoryService.DecompressToDirectory(string,string).directoryPath'></a>

`directoryPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The target directory path where the contents of the ZIP file will be extracted.
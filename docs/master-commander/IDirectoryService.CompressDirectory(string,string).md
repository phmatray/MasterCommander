#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Services](MasterCommander.Core.Services.md 'MasterCommander.Core.Services').[IDirectoryService](IDirectoryService.md 'MasterCommander.Core.Services.IDirectoryService')

## IDirectoryService.CompressDirectory(string, string) Method

Compresses the specified directory into a ZIP file, including all its files and subdirectories.

```csharp
void CompressDirectory(string directoryPath, string zipFilePath);
```
#### Parameters

<a name='MasterCommander.Core.Services.IDirectoryService.CompressDirectory(string,string).directoryPath'></a>

`directoryPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the directory to compress.

<a name='MasterCommander.Core.Services.IDirectoryService.CompressDirectory(string,string).zipFilePath'></a>

`zipFilePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path where the resulting ZIP file should be saved.
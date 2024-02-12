#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Services](MasterCommander.md#MasterCommander.Core.Services 'MasterCommander.Core.Services').[IDirectoryService](IDirectoryService.md 'MasterCommander.Core.Services.IDirectoryService')

## IDirectoryService.CreateNewDirectory(string, string) Method

Creates a new directory within a specified base directory.

```csharp
string CreateNewDirectory(string baseDirectory, string newDirectoryName);
```
#### Parameters

<a name='MasterCommander.Core.Services.IDirectoryService.CreateNewDirectory(string,string).baseDirectory'></a>

`baseDirectory` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The base directory where the new directory will be created.

<a name='MasterCommander.Core.Services.IDirectoryService.CreateNewDirectory(string,string).newDirectoryName'></a>

`newDirectoryName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the new directory to create.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path of the newly created directory.
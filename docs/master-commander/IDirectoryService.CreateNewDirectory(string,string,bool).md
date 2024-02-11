#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Services](MasterCommander.md#MasterCommander.Core.Services 'MasterCommander.Core.Services').[IDirectoryService](IDirectoryService.md 'MasterCommander.Core.Services.IDirectoryService')

## IDirectoryService.CreateNewDirectory(string, string, bool) Method

Creates a new directory within a specified base directory.

```csharp
string CreateNewDirectory(string baseDirectory, string newDirectoryName, bool overwrite=false);
```
#### Parameters

<a name='MasterCommander.Core.Services.IDirectoryService.CreateNewDirectory(string,string,bool).baseDirectory'></a>

`baseDirectory` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The base directory where the new directory will be created.

<a name='MasterCommander.Core.Services.IDirectoryService.CreateNewDirectory(string,string,bool).newDirectoryName'></a>

`newDirectoryName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the new directory to create.

<a name='MasterCommander.Core.Services.IDirectoryService.CreateNewDirectory(string,string,bool).overwrite'></a>

`overwrite` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

A value indicating whether an existing directory should be overwritten.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path of the newly created directory.
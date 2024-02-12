#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Integrations](MasterCommander.md#MasterCommander.Integrations 'MasterCommander.Integrations').[DirectoryService](DirectoryService.md 'MasterCommander.Integrations.DirectoryService')

## DirectoryService.CreateNewDirectory(string, string) Method

Creates a new directory within a specified base directory.

```csharp
public string CreateNewDirectory(string baseDirectory, string newDirectoryName);
```
#### Parameters

<a name='MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string,string).baseDirectory'></a>

`baseDirectory` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The base directory where the new directory will be created.

<a name='MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string,string).newDirectoryName'></a>

`newDirectoryName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the new directory to create.

Implements [CreateNewDirectory(string, string)](IDirectoryService.CreateNewDirectory(string,string).md 'MasterCommander.Core.Services.IDirectoryService.CreateNewDirectory(string, string)')

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path of the newly created directory.
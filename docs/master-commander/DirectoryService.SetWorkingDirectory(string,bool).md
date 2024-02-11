#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Integrations](MasterCommander.md#MasterCommander.Integrations 'MasterCommander.Integrations').[DirectoryService](DirectoryService.md 'MasterCommander.Integrations.DirectoryService')

## DirectoryService.SetWorkingDirectory(string, bool) Method

Sets the working directory to the directory where the specified solution is located.

```csharp
public void SetWorkingDirectory(string relativePath, bool createIfNotExists=false);
```
#### Parameters

<a name='MasterCommander.Integrations.DirectoryService.SetWorkingDirectory(string,bool).relativePath'></a>

`relativePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The relative path from the MasterCommander directory to the solution directory.

<a name='MasterCommander.Integrations.DirectoryService.SetWorkingDirectory(string,bool).createIfNotExists'></a>

`createIfNotExists` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

A value indicating whether the directory should be created if it does not exist.

Implements [SetWorkingDirectory(string, bool)](IDirectoryService.SetWorkingDirectory(string,bool).md 'MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string, bool)')
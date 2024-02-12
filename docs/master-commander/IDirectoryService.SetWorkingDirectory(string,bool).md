#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Services](MasterCommander.md#MasterCommander.Core.Services 'MasterCommander.Core.Services').[IDirectoryService](IDirectoryService.md 'MasterCommander.Core.Services.IDirectoryService')

## IDirectoryService.SetWorkingDirectory(string, bool) Method

Sets the working directory to the directory where the specified solution is located.

```csharp
void SetWorkingDirectory(string relativePath, bool createIfNotExists);
```
#### Parameters

<a name='MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string,bool).relativePath'></a>

`relativePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The relative path from the MasterCommander directory to the solution directory.

<a name='MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string,bool).createIfNotExists'></a>

`createIfNotExists` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

A value indicating whether the directory should be created if it does not exist.
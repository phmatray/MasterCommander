#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Core\.Services](MasterCommander.md#MasterCommander.Core.Services 'MasterCommander\.Core\.Services').[IDirectoryService](IDirectoryService.md 'MasterCommander\.Core\.Services\.IDirectoryService')

## IDirectoryService\.SetWorkingDirectory Method

| Overloads | |
| :--- | :--- |
| [SetWorkingDirectory\(string\)](IDirectoryService.SetWorkingDirectory.md#MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string) 'MasterCommander\.Core\.Services\.IDirectoryService\.SetWorkingDirectory\(string\)') | Sets the working directory to the directory where the specified solution is located\. |
| [SetWorkingDirectory\(string, bool\)](IDirectoryService.SetWorkingDirectory.md#MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string,bool) 'MasterCommander\.Core\.Services\.IDirectoryService\.SetWorkingDirectory\(string, bool\)') | Sets the working directory to the directory where the specified solution is located\. |

<a name='MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string)'></a>

## IDirectoryService\.SetWorkingDirectory\(string\) Method

Sets the working directory to the directory where the specified solution is located\.

```csharp
void SetWorkingDirectory(string relativePath);
```
#### Parameters

<a name='MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string).relativePath'></a>

`relativePath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The relative path from the MasterCommander directory to the solution directory\.

<a name='MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string,bool)'></a>

## IDirectoryService\.SetWorkingDirectory\(string, bool\) Method

Sets the working directory to the directory where the specified solution is located\.

```csharp
void SetWorkingDirectory(string relativePath, bool createIfNotExists);
```
#### Parameters

<a name='MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string,bool).relativePath'></a>

`relativePath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The relative path from the MasterCommander directory to the solution directory\.

<a name='MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string,bool).createIfNotExists'></a>

`createIfNotExists` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the directory should be created if it does not exist\.
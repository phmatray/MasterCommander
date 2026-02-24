#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Integrations](MasterCommander.md#MasterCommander.Integrations 'MasterCommander\.Integrations').[DirectoryService](DirectoryService.md 'MasterCommander\.Integrations\.DirectoryService')

## DirectoryService\.SetWorkingDirectory Method

| Overloads | |
| :--- | :--- |
| [SetWorkingDirectory\(string\)](DirectoryService.SetWorkingDirectory.md#MasterCommander.Integrations.DirectoryService.SetWorkingDirectory(string) 'MasterCommander\.Integrations\.DirectoryService\.SetWorkingDirectory\(string\)') | Sets the working directory to the directory where the specified solution is located\. |
| [SetWorkingDirectory\(string, bool\)](DirectoryService.SetWorkingDirectory.md#MasterCommander.Integrations.DirectoryService.SetWorkingDirectory(string,bool) 'MasterCommander\.Integrations\.DirectoryService\.SetWorkingDirectory\(string, bool\)') | Sets the working directory to the directory where the specified solution is located\. |

<a name='MasterCommander.Integrations.DirectoryService.SetWorkingDirectory(string)'></a>

## DirectoryService\.SetWorkingDirectory\(string\) Method

Sets the working directory to the directory where the specified solution is located\.

```csharp
public void SetWorkingDirectory(string relativePath);
```
#### Parameters

<a name='MasterCommander.Integrations.DirectoryService.SetWorkingDirectory(string).relativePath'></a>

`relativePath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The relative path from the MasterCommander directory to the solution directory\.

Implements [SetWorkingDirectory\(string\)](IDirectoryService.SetWorkingDirectory.md#MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string) 'MasterCommander\.Core\.Services\.IDirectoryService\.SetWorkingDirectory\(string\)')

<a name='MasterCommander.Integrations.DirectoryService.SetWorkingDirectory(string,bool)'></a>

## DirectoryService\.SetWorkingDirectory\(string, bool\) Method

Sets the working directory to the directory where the specified solution is located\.

```csharp
public void SetWorkingDirectory(string relativePath, bool createIfNotExists);
```
#### Parameters

<a name='MasterCommander.Integrations.DirectoryService.SetWorkingDirectory(string,bool).relativePath'></a>

`relativePath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The relative path from the MasterCommander directory to the solution directory\.

<a name='MasterCommander.Integrations.DirectoryService.SetWorkingDirectory(string,bool).createIfNotExists'></a>

`createIfNotExists` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the directory should be created if it does not exist\.

Implements [SetWorkingDirectory\(string, bool\)](IDirectoryService.SetWorkingDirectory.md#MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string,bool) 'MasterCommander\.Core\.Services\.IDirectoryService\.SetWorkingDirectory\(string, bool\)')
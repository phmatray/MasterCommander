#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Integrations](MasterCommander.md#MasterCommander.Integrations 'MasterCommander\.Integrations').[DirectoryService](DirectoryService.md 'MasterCommander\.Integrations\.DirectoryService')

## DirectoryService\.CreateNewDirectory Method

| Overloads | |
| :--- | :--- |
| [CreateNewDirectory\(string, string\)](DirectoryService.CreateNewDirectory.md#MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string,string) 'MasterCommander\.Integrations\.DirectoryService\.CreateNewDirectory\(string, string\)') | Creates a new directory within a specified base directory\. |
| [CreateNewDirectory\(string, string, bool\)](DirectoryService.CreateNewDirectory.md#MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string,string,bool) 'MasterCommander\.Integrations\.DirectoryService\.CreateNewDirectory\(string, string, bool\)') | Creates a new directory within a specified base directory\. |

<a name='MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string,string)'></a>

## DirectoryService\.CreateNewDirectory\(string, string\) Method

Creates a new directory within a specified base directory\.

```csharp
public string CreateNewDirectory(string baseDirectory, string newDirectoryName);
```
#### Parameters

<a name='MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string,string).baseDirectory'></a>

`baseDirectory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The base directory where the new directory will be created\.

<a name='MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string,string).newDirectoryName'></a>

`newDirectoryName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the new directory to create\.

Implements [CreateNewDirectory\(string, string\)](IDirectoryService.CreateNewDirectory.md#MasterCommander.Core.Services.IDirectoryService.CreateNewDirectory(string,string) 'MasterCommander\.Core\.Services\.IDirectoryService\.CreateNewDirectory\(string, string\)')

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The path of the newly created directory\.

<a name='MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string,string,bool)'></a>

## DirectoryService\.CreateNewDirectory\(string, string, bool\) Method

Creates a new directory within a specified base directory\.

```csharp
public string CreateNewDirectory(string baseDirectory, string newDirectoryName, bool overwrite);
```
#### Parameters

<a name='MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string,string,bool).baseDirectory'></a>

`baseDirectory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The base directory where the new directory will be created\.

<a name='MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string,string,bool).newDirectoryName'></a>

`newDirectoryName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the new directory to create\.

<a name='MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string,string,bool).overwrite'></a>

`overwrite` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether an existing directory should be overwritten\.

Implements [CreateNewDirectory\(string, string, bool\)](IDirectoryService.CreateNewDirectory.md#MasterCommander.Core.Services.IDirectoryService.CreateNewDirectory(string,string,bool) 'MasterCommander\.Core\.Services\.IDirectoryService\.CreateNewDirectory\(string, string, bool\)')

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The path of the newly created directory\.
#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Integrations](MasterCommander.md#MasterCommander.Integrations 'MasterCommander.Integrations').[DirectoryService](DirectoryService.md 'MasterCommander.Integrations.DirectoryService')

## DirectoryService.CalculateDirectorySize(string) Method

Calculates the total size of a directory, including all its files and subdirectories.

```csharp
public long CalculateDirectorySize(string directoryPath);
```
#### Parameters

<a name='MasterCommander.Integrations.DirectoryService.CalculateDirectorySize(string).directoryPath'></a>

`directoryPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the directory for which to calculate the size.

Implements [CalculateDirectorySize(string)](IDirectoryService.CalculateDirectorySize(string).md 'MasterCommander.Core.Services.IDirectoryService.CalculateDirectorySize(string)')

#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
The total size of the directory in bytes.
#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Services](MasterCommander.md#MasterCommander.Core.Services 'MasterCommander.Core.Services').[IDirectoryService](IDirectoryService.md 'MasterCommander.Core.Services.IDirectoryService')

## IDirectoryService.CalculateDirectorySize(string) Method

Calculates the total size of a directory, including all its files and subdirectories.

```csharp
long CalculateDirectorySize(string directoryPath);
```
#### Parameters

<a name='MasterCommander.Core.Services.IDirectoryService.CalculateDirectorySize(string).directoryPath'></a>

`directoryPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the directory for which to calculate the size.

#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
The total size of the directory in bytes.
#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Services](MasterCommander.md#MasterCommander.Core.Services 'MasterCommander.Core.Services')

## IDirectoryService Interface

Defines the interface for directory-related operations.

```csharp
public interface IDirectoryService
```

Derived  
&#8627; [DirectoryService](DirectoryService.md 'MasterCommander.Integrations.DirectoryService')

| Properties | |
| :--- | :--- |
| [HomeDirectory](IDirectoryService.HomeDirectory.md 'MasterCommander.Core.Services.IDirectoryService.HomeDirectory') | Gets the path of the home directory for the current user. |
| [MasterCommanderDirectory](IDirectoryService.MasterCommanderDirectory.md 'MasterCommander.Core.Services.IDirectoryService.MasterCommanderDirectory') | Gets the path of the directory where MasterCommander stores its working files. |
| [WorkingDirectory](IDirectoryService.WorkingDirectory.md 'MasterCommander.Core.Services.IDirectoryService.WorkingDirectory') | Gets the working directory. This is the directory where commands will be executed. |

| Methods | |
| :--- | :--- |
| [CalculateDirectorySize(string)](IDirectoryService.CalculateDirectorySize(string).md 'MasterCommander.Core.Services.IDirectoryService.CalculateDirectorySize(string)') | Calculates the total size of a directory, including all its files and subdirectories. |
| [ClearDirectory(string)](IDirectoryService.ClearDirectory(string).md 'MasterCommander.Core.Services.IDirectoryService.ClearDirectory(string)') | Clears the contents of a specified directory. |
| [CompressDirectory(string, string)](IDirectoryService.CompressDirectory(string,string).md 'MasterCommander.Core.Services.IDirectoryService.CompressDirectory(string, string)') | Compresses the specified directory into a ZIP file, including all its files and subdirectories. |
| [CreateNewDirectory(string, string, bool)](IDirectoryService.CreateNewDirectory(string,string,bool).md 'MasterCommander.Core.Services.IDirectoryService.CreateNewDirectory(string, string, bool)') | Creates a new directory within a specified base directory. |
| [CreateNewDirectory(string, string)](IDirectoryService.CreateNewDirectory(string,string).md 'MasterCommander.Core.Services.IDirectoryService.CreateNewDirectory(string, string)') | Creates a new directory within a specified base directory. |
| [CreateTemporaryDirectory()](IDirectoryService.CreateTemporaryDirectory().md 'MasterCommander.Core.Services.IDirectoryService.CreateTemporaryDirectory()') | Creates a temporary directory for use during application execution, which can optionally be cleaned up afterwards. |
| [DecompressToDirectory(string, string)](IDirectoryService.DecompressToDirectory(string,string).md 'MasterCommander.Core.Services.IDirectoryService.DecompressToDirectory(string, string)') | Decompresses a ZIP file into a specified directory, extracting all its contents. |
| [SetWorkingDirectory(string, bool)](IDirectoryService.SetWorkingDirectory(string,bool).md 'MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string, bool)') | Sets the working directory to the directory where the specified solution is located. |
| [SetWorkingDirectory(string)](IDirectoryService.SetWorkingDirectory(string).md 'MasterCommander.Core.Services.IDirectoryService.SetWorkingDirectory(string)') | Sets the working directory to the directory where the specified solution is located. |
| [WatchDirectory(string, Action&lt;FileSystemEventArgs&gt;)](IDirectoryService.WatchDirectory(string,Action_FileSystemEventArgs_).md 'MasterCommander.Core.Services.IDirectoryService.WatchDirectory(string, System.Action<System.IO.FileSystemEventArgs>)') | Monitors a directory for any changes, such as file or subdirectory creation, deletion, or modification, and triggers a callback action when a change is detected. |

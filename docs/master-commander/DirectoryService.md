#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Integrations](MasterCommander.md#MasterCommander.Integrations 'MasterCommander.Integrations')

## DirectoryService Class

Provides functionality for directory-related operations.

```csharp
public class DirectoryService :
MasterCommander.Core.Services.IDirectoryService
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DirectoryService

Implements [IDirectoryService](IDirectoryService.md 'MasterCommander.Core.Services.IDirectoryService')

| Constructors | |
| :--- | :--- |
| [DirectoryService(IConsole)](DirectoryService.DirectoryService(IConsole).md 'MasterCommander.Integrations.DirectoryService.DirectoryService(MasterCommander.Core.Display.IConsole)') | Initializes a new instance of the [DirectoryService](DirectoryService.md 'MasterCommander.Integrations.DirectoryService') class. |

| Properties | |
| :--- | :--- |
| [HomeDirectory](DirectoryService.HomeDirectory.md 'MasterCommander.Integrations.DirectoryService.HomeDirectory') | Gets the path of the home directory for the current user. |
| [MasterCommanderDirectory](DirectoryService.MasterCommanderDirectory.md 'MasterCommander.Integrations.DirectoryService.MasterCommanderDirectory') | Gets the path of the directory where MasterCommander stores its working files. |
| [WorkingDirectory](DirectoryService.WorkingDirectory.md 'MasterCommander.Integrations.DirectoryService.WorkingDirectory') | Gets the working directory. This is the directory where commands will be executed. |

| Methods | |
| :--- | :--- |
| [CalculateDirectorySize(string)](DirectoryService.CalculateDirectorySize(string).md 'MasterCommander.Integrations.DirectoryService.CalculateDirectorySize(string)') | Calculates the total size of a directory, including all its files and subdirectories. |
| [ClearDirectory(string)](DirectoryService.ClearDirectory(string).md 'MasterCommander.Integrations.DirectoryService.ClearDirectory(string)') | Clears the contents of a specified directory. |
| [CompressDirectory(string, string)](DirectoryService.CompressDirectory(string,string).md 'MasterCommander.Integrations.DirectoryService.CompressDirectory(string, string)') | Compresses the specified directory into a ZIP file, including all its files and subdirectories. |
| [CreateNewDirectory(string, string, bool)](DirectoryService.CreateNewDirectory(string,string,bool).md 'MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string, string, bool)') | Creates a new directory within a specified base directory. |
| [CreateNewDirectory(string, string)](DirectoryService.CreateNewDirectory(string,string).md 'MasterCommander.Integrations.DirectoryService.CreateNewDirectory(string, string)') | Creates a new directory within a specified base directory. |
| [CreateTemporaryDirectory()](DirectoryService.CreateTemporaryDirectory().md 'MasterCommander.Integrations.DirectoryService.CreateTemporaryDirectory()') | Creates a temporary directory for use during application execution, which can optionally be cleaned up afterwards. |
| [DecompressToDirectory(string, string)](DirectoryService.DecompressToDirectory(string,string).md 'MasterCommander.Integrations.DirectoryService.DecompressToDirectory(string, string)') | Decompresses a ZIP file into a specified directory, extracting all its contents. |
| [SetWorkingDirectory(string, bool)](DirectoryService.SetWorkingDirectory(string,bool).md 'MasterCommander.Integrations.DirectoryService.SetWorkingDirectory(string, bool)') | Sets the working directory to the directory where the specified solution is located. |
| [SetWorkingDirectory(string)](DirectoryService.SetWorkingDirectory(string).md 'MasterCommander.Integrations.DirectoryService.SetWorkingDirectory(string)') | Sets the working directory to the directory where the specified solution is located. |
| [WatchDirectory(string, Action&lt;FileSystemEventArgs&gt;)](DirectoryService.WatchDirectory(string,Action_FileSystemEventArgs_).md 'MasterCommander.Integrations.DirectoryService.WatchDirectory(string, System.Action<System.IO.FileSystemEventArgs>)') | Monitors a directory for any changes, such as file or subdirectory creation, deletion, or modification, and triggers a callback action when a change is detected. |

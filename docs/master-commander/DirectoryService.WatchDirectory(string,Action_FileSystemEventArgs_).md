#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Integrations](MasterCommander.md#MasterCommander.Integrations 'MasterCommander\.Integrations').[DirectoryService](DirectoryService.md 'MasterCommander\.Integrations\.DirectoryService')

## DirectoryService\.WatchDirectory\(string, Action\<FileSystemEventArgs\>\) Method

Monitors a directory for any changes, such as file or subdirectory creation, deletion, or modification, and triggers a callback action when a change is detected\.

```csharp
public void WatchDirectory(string directoryPath, System.Action<System.IO.FileSystemEventArgs> onChangeCallback);
```
#### Parameters

<a name='MasterCommander.Integrations.DirectoryService.WatchDirectory(string,System.Action_System.IO.FileSystemEventArgs_).directoryPath'></a>

`directoryPath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path of the directory to watch\.

<a name='MasterCommander.Integrations.DirectoryService.WatchDirectory(string,System.Action_System.IO.FileSystemEventArgs_).onChangeCallback'></a>

`onChangeCallback` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[System\.IO\.FileSystemEventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.io.filesystemeventargs 'System\.IO\.FileSystemEventArgs')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')

The callback action to trigger upon detecting a directory change\.

Implements [WatchDirectory\(string, Action&lt;FileSystemEventArgs&gt;\)](IDirectoryService.WatchDirectory(string,Action_FileSystemEventArgs_).md 'MasterCommander\.Core\.Services\.IDirectoryService\.WatchDirectory\(string, System\.Action\<System\.IO\.FileSystemEventArgs\>\)')
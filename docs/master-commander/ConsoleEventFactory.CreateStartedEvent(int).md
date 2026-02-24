#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Core\.Display](MasterCommander.md#MasterCommander.Core.Display 'MasterCommander\.Core\.Display').[ConsoleEventFactory](ConsoleEventFactory.md 'MasterCommander\.Core\.Display\.ConsoleEventFactory')

## ConsoleEventFactory\.CreateStartedEvent\(int\) Method

Creates a console event indicating a process has started\.

```csharp
private static MasterCommander.Core.ConsoleEvents.StartedConsoleEvent CreateStartedEvent(int processId);
```
#### Parameters

<a name='MasterCommander.Core.Display.ConsoleEventFactory.CreateStartedEvent(int).processId'></a>

`processId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The ID of the started process\.

#### Returns
[StartedConsoleEvent](StartedConsoleEvent.md 'MasterCommander\.Core\.ConsoleEvents\.StartedConsoleEvent')  
A console event for a started process\.
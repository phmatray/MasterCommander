#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Display](MasterCommander.md#MasterCommander.Core.Display 'MasterCommander.Core.Display').[ConsoleEventFactory](ConsoleEventFactory.md 'MasterCommander.Core.Display.ConsoleEventFactory')

## ConsoleEventFactory.CreateExitedEvent(int) Method

Creates a console event indicating a process has exited.

```csharp
private static MasterCommander.Core.ConsoleEvents.ExitedConsoleEvent CreateExitedEvent(int exitCode);
```
#### Parameters

<a name='MasterCommander.Core.Display.ConsoleEventFactory.CreateExitedEvent(int).exitCode'></a>

`exitCode` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The exit code of the process.

#### Returns
[ExitedConsoleEvent](ExitedConsoleEvent.md 'MasterCommander.Core.ConsoleEvents.ExitedConsoleEvent')  
A console event for an exited process.
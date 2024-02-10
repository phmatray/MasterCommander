#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Display](MasterCommander.Core.Display.md 'MasterCommander.Core.Display').[ConsoleEventFactory](ConsoleEventFactory.md 'MasterCommander.Core.Display.ConsoleEventFactory')

## ConsoleEventFactory.CreateStandardOutputEvent(string) Method

Creates a console event for standard output messages.

```csharp
private static MasterCommander.Core.ConsoleEvents.StandardOutputConsoleEvent CreateStandardOutputEvent(string message);
```
#### Parameters

<a name='MasterCommander.Core.Display.ConsoleEventFactory.CreateStandardOutputEvent(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message from standard output.

#### Returns
[StandardOutputConsoleEvent](StandardOutputConsoleEvent.md 'MasterCommander.Core.ConsoleEvents.StandardOutputConsoleEvent')  
A console event containing the standard output message.
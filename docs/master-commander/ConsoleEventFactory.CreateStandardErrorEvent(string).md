#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Display](MasterCommander.Core.Display.md 'MasterCommander.Core.Display').[ConsoleEventFactory](ConsoleEventFactory.md 'MasterCommander.Core.Display.ConsoleEventFactory')

## ConsoleEventFactory.CreateStandardErrorEvent(string) Method

Creates a console event for standard error messages.

```csharp
private static MasterCommander.Core.ConsoleEvents.StandardErrorConsoleEvent CreateStandardErrorEvent(string message);
```
#### Parameters

<a name='MasterCommander.Core.Display.ConsoleEventFactory.CreateStandardErrorEvent(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message from standard error.

#### Returns
[StandardErrorConsoleEvent](StandardErrorConsoleEvent.md 'MasterCommander.Core.ConsoleEvents.StandardErrorConsoleEvent')  
A console event containing the standard error message.
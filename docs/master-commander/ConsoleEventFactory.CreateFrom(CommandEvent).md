#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Display](MasterCommander.md#MasterCommander.Core.Display 'MasterCommander.Core.Display').[ConsoleEventFactory](ConsoleEventFactory.md 'MasterCommander.Core.Display.ConsoleEventFactory')

## ConsoleEventFactory.CreateFrom(CommandEvent) Method

Creates a specific type of console event based on the given command event.

```csharp
public static MasterCommander.Core.ConsoleEvents.ConsoleEvent CreateFrom(CliWrap.EventStream.CommandEvent cmdEvent);
```
#### Parameters

<a name='MasterCommander.Core.Display.ConsoleEventFactory.CreateFrom(CliWrap.EventStream.CommandEvent).cmdEvent'></a>

`cmdEvent` [CliWrap.EventStream.CommandEvent](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.EventStream.CommandEvent 'CliWrap.EventStream.CommandEvent')

The command event to create a console event from.

#### Returns
[ConsoleEvent](ConsoleEvent.md 'MasterCommander.Core.ConsoleEvents.ConsoleEvent')  
A console event corresponding to the specified command event.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown when an unknown command event type is provided.
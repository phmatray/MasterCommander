#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Display](MasterCommander.Core.Display.md 'MasterCommander.Core.Display')

## ConsoleEventFactory Class

Provides factory methods for creating various types of console events.

```csharp
public static class ConsoleEventFactory
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ConsoleEventFactory

| Methods | |
| :--- | :--- |
| [CreateExitedEvent(int)](ConsoleEventFactory.CreateExitedEvent(int).md 'MasterCommander.Core.Display.ConsoleEventFactory.CreateExitedEvent(int)') | Creates a console event indicating a process has exited. |
| [CreateFrom(CommandEvent)](ConsoleEventFactory.CreateFrom(CommandEvent).md 'MasterCommander.Core.Display.ConsoleEventFactory.CreateFrom(CliWrap.EventStream.CommandEvent)') | Creates a specific type of console event based on the given command event. |
| [CreateFrom(Stopwatch)](ConsoleEventFactory.CreateFrom(Stopwatch).md 'MasterCommander.Core.Display.ConsoleEventFactory.CreateFrom(System.Diagnostics.Stopwatch)') | Creates a console event based on the elapsed time from a stopwatch. |
| [CreateStandardErrorEvent(string)](ConsoleEventFactory.CreateStandardErrorEvent(string).md 'MasterCommander.Core.Display.ConsoleEventFactory.CreateStandardErrorEvent(string)') | Creates a console event for standard error messages. |
| [CreateStandardOutputEvent(string)](ConsoleEventFactory.CreateStandardOutputEvent(string).md 'MasterCommander.Core.Display.ConsoleEventFactory.CreateStandardOutputEvent(string)') | Creates a console event for standard output messages. |
| [CreateStartedEvent(int)](ConsoleEventFactory.CreateStartedEvent(int).md 'MasterCommander.Core.Display.ConsoleEventFactory.CreateStartedEvent(int)') | Creates a console event indicating a process has started. |

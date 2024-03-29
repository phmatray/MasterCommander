#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Display](MasterCommander.md#MasterCommander.Core.Display 'MasterCommander.Core.Display')

## ConsoleBase Class

Serves as the base class for console output handling, providing a mechanism to write different types of console events.

```csharp
public abstract class ConsoleBase :
MasterCommander.Core.Display.IConsole
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ConsoleBase

Derived  
&#8627; [SpectreConsole](SpectreConsole.md 'MasterCommander.Integrations.Display.SpectreConsole')  
&#8627; [StandardConsole](StandardConsole.md 'MasterCommander.Integrations.Display.StandardConsole')

Implements [IConsole](IConsole.md 'MasterCommander.Core.Display.IConsole')

| Methods | |
| :--- | :--- |
| [WriteAction(string, string)](ConsoleBase.WriteAction(string,string).md 'MasterCommander.Core.Display.ConsoleBase.WriteAction(string, string)') | Writes an action message to the console. |
| [WriteCommand(string)](ConsoleBase.WriteCommand(string).md 'MasterCommander.Core.Display.ConsoleBase.WriteCommand(string)') | Writes a command text to the console. |
| [WriteCompletionMessage()](ConsoleBase.WriteCompletionMessage().md 'MasterCommander.Core.Display.ConsoleBase.WriteCompletionMessage()') | Writes a completion message to the console. This is intended for final console output upon application completion. |
| [WriteConsoleEvent(ConsoleEvent)](ConsoleBase.WriteConsoleEvent(ConsoleEvent).md 'MasterCommander.Core.Display.ConsoleBase.WriteConsoleEvent(MasterCommander.Core.ConsoleEvents.ConsoleEvent)') | Writes a console event to the console. This method is designed to handle and display various types of console events. |
| [WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent)](ConsoleBase.WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent).md 'MasterCommander.Core.Display.ConsoleBase.WriteElapsedConsoleEvent(MasterCommander.Core.ConsoleEvents.ExecutionTimeConsoleEvent)') | Writes an execution time console event to the output. |
| [WriteExitedConsoleEvent(ExitedConsoleEvent)](ConsoleBase.WriteExitedConsoleEvent(ExitedConsoleEvent).md 'MasterCommander.Core.Display.ConsoleBase.WriteExitedConsoleEvent(MasterCommander.Core.ConsoleEvents.ExitedConsoleEvent)') | Writes an exited console event to the output. |
| [WriteLine(string)](ConsoleBase.WriteLine(string).md 'MasterCommander.Core.Display.ConsoleBase.WriteLine(string)') | Writes a line to the console. If the message is null, writes an empty line. |
| [WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent)](ConsoleBase.WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent).md 'MasterCommander.Core.Display.ConsoleBase.WriteStandardErrorConsoleEvent(MasterCommander.Core.ConsoleEvents.StandardErrorConsoleEvent)') | Writes a standard error console event to the output. |
| [WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent)](ConsoleBase.WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent).md 'MasterCommander.Core.Display.ConsoleBase.WriteStandardOutputConsoleEvent(MasterCommander.Core.ConsoleEvents.StandardOutputConsoleEvent)') | Writes a standard output console event to the output. |
| [WriteStartedConsoleEvent(StartedConsoleEvent)](ConsoleBase.WriteStartedConsoleEvent(StartedConsoleEvent).md 'MasterCommander.Core.Display.ConsoleBase.WriteStartedConsoleEvent(MasterCommander.Core.ConsoleEvents.StartedConsoleEvent)') | Writes a started console event to the output. |
| [WriteStartupMessage()](ConsoleBase.WriteStartupMessage().md 'MasterCommander.Core.Display.ConsoleBase.WriteStartupMessage()') | Writes a startup message to the console. This is intended for initial console output upon application start. |

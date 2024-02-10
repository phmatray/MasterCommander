#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Display](MasterCommander.Core.Display.md 'MasterCommander.Core.Display')

## IConsole Interface

Defines an interface for console operations, allowing for writing lines, commands, startup messages, and console events.

```csharp
public interface IConsole
```

Derived  
&#8627; [ConsoleBase](ConsoleBase.md 'MasterCommander.Core.Display.ConsoleBase')

| Methods | |
| :--- | :--- |
| [WriteAction(string, string)](IConsole.WriteAction(string,string).md 'MasterCommander.Core.Display.IConsole.WriteAction(string, string)') | Writes an action message to the console. |
| [WriteCommand(string)](IConsole.WriteCommand(string).md 'MasterCommander.Core.Display.IConsole.WriteCommand(string)') | Writes a command text to the console. |
| [WriteCompletionMessage()](IConsole.WriteCompletionMessage().md 'MasterCommander.Core.Display.IConsole.WriteCompletionMessage()') | Writes a completion message to the console. This is intended for final console output upon application completion. |
| [WriteConsoleEvent(ConsoleEvent)](IConsole.WriteConsoleEvent(ConsoleEvent).md 'MasterCommander.Core.Display.IConsole.WriteConsoleEvent(MasterCommander.Core.ConsoleEvents.ConsoleEvent)') | Writes a console event to the console. This method is designed to handle and display various types of console events. |
| [WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent)](IConsole.WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent).md 'MasterCommander.Core.Display.IConsole.WriteElapsedConsoleEvent(MasterCommander.Core.ConsoleEvents.ExecutionTimeConsoleEvent)') | Writes an execution time console event to the output. |
| [WriteExitedConsoleEvent(ExitedConsoleEvent)](IConsole.WriteExitedConsoleEvent(ExitedConsoleEvent).md 'MasterCommander.Core.Display.IConsole.WriteExitedConsoleEvent(MasterCommander.Core.ConsoleEvents.ExitedConsoleEvent)') | Writes an exited console event to the output. |
| [WriteLine(string)](IConsole.WriteLine(string).md 'MasterCommander.Core.Display.IConsole.WriteLine(string)') | Writes a line to the console. If the message is null, writes an empty line. |
| [WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent)](IConsole.WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent).md 'MasterCommander.Core.Display.IConsole.WriteStandardErrorConsoleEvent(MasterCommander.Core.ConsoleEvents.StandardErrorConsoleEvent)') | Writes a standard error console event to the output. |
| [WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent)](IConsole.WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent).md 'MasterCommander.Core.Display.IConsole.WriteStandardOutputConsoleEvent(MasterCommander.Core.ConsoleEvents.StandardOutputConsoleEvent)') | Writes a standard output console event to the output. |
| [WriteStartedConsoleEvent(StartedConsoleEvent)](IConsole.WriteStartedConsoleEvent(StartedConsoleEvent).md 'MasterCommander.Core.Display.IConsole.WriteStartedConsoleEvent(MasterCommander.Core.ConsoleEvents.StartedConsoleEvent)') | Writes a started console event to the output. |
| [WriteStartupMessage()](IConsole.WriteStartupMessage().md 'MasterCommander.Core.Display.IConsole.WriteStartupMessage()') | Writes a startup message to the console. This is intended for initial console output upon application start. |

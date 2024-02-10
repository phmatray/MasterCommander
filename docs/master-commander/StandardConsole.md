#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Integrations.Display](MasterCommander.Integrations.Display.md 'MasterCommander.Integrations.Display')

## StandardConsole Class

Provides standard console output.

```csharp
public sealed class StandardConsole : MasterCommander.Core.Display.ConsoleBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ConsoleBase](ConsoleBase.md 'MasterCommander.Core.Display.ConsoleBase') &#129106; StandardConsole

| Methods | |
| :--- | :--- |
| [WriteAction(string, string)](StandardConsole.WriteAction(string,string).md 'MasterCommander.Integrations.Display.StandardConsole.WriteAction(string, string)') | Writes an action message to the console. |
| [WriteCommand(string)](StandardConsole.WriteCommand(string).md 'MasterCommander.Integrations.Display.StandardConsole.WriteCommand(string)') | Writes a command text to the console. |
| [WriteCompletionMessage()](StandardConsole.WriteCompletionMessage().md 'MasterCommander.Integrations.Display.StandardConsole.WriteCompletionMessage()') | Writes a completion message to the console. This is intended for final console output upon application completion. |
| [WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent)](StandardConsole.WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent).md 'MasterCommander.Integrations.Display.StandardConsole.WriteElapsedConsoleEvent(MasterCommander.Core.ConsoleEvents.ExecutionTimeConsoleEvent)') | Writes an execution time console event to the output. |
| [WriteExitedConsoleEvent(ExitedConsoleEvent)](StandardConsole.WriteExitedConsoleEvent(ExitedConsoleEvent).md 'MasterCommander.Integrations.Display.StandardConsole.WriteExitedConsoleEvent(MasterCommander.Core.ConsoleEvents.ExitedConsoleEvent)') | Writes an exited console event to the output. |
| [WriteLine(string)](StandardConsole.WriteLine(string).md 'MasterCommander.Integrations.Display.StandardConsole.WriteLine(string)') | Writes a line to the console. If the message is null, writes an empty line. |
| [WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent)](StandardConsole.WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent).md 'MasterCommander.Integrations.Display.StandardConsole.WriteStandardErrorConsoleEvent(MasterCommander.Core.ConsoleEvents.StandardErrorConsoleEvent)') | Writes a standard error console event to the output. |
| [WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent)](StandardConsole.WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent).md 'MasterCommander.Integrations.Display.StandardConsole.WriteStandardOutputConsoleEvent(MasterCommander.Core.ConsoleEvents.StandardOutputConsoleEvent)') | Writes a standard output console event to the output. |
| [WriteStartedConsoleEvent(StartedConsoleEvent)](StandardConsole.WriteStartedConsoleEvent(StartedConsoleEvent).md 'MasterCommander.Integrations.Display.StandardConsole.WriteStartedConsoleEvent(MasterCommander.Core.ConsoleEvents.StartedConsoleEvent)') | Writes a started console event to the output. |
| [WriteStartupMessage()](StandardConsole.WriteStartupMessage().md 'MasterCommander.Integrations.Display.StandardConsole.WriteStartupMessage()') | Writes a startup message to the console. This is intended for initial console output upon application start. |

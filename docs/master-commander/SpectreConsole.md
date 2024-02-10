#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Integrations.Display](MasterCommander.Integrations.Display.md 'MasterCommander.Integrations.Display')

## SpectreConsole Class

Provides Spectre console output.

```csharp
public sealed class SpectreConsole : MasterCommander.Core.Display.ConsoleBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ConsoleBase](ConsoleBase.md 'MasterCommander.Core.Display.ConsoleBase') &#129106; SpectreConsole

| Methods | |
| :--- | :--- |
| [WriteAction(string, string)](SpectreConsole.WriteAction(string,string).md 'MasterCommander.Integrations.Display.SpectreConsole.WriteAction(string, string)') | Writes an action message to the console. |
| [WriteCommand(string)](SpectreConsole.WriteCommand(string).md 'MasterCommander.Integrations.Display.SpectreConsole.WriteCommand(string)') | Writes a command text to the console. |
| [WriteCompletionMessage()](SpectreConsole.WriteCompletionMessage().md 'MasterCommander.Integrations.Display.SpectreConsole.WriteCompletionMessage()') | Writes a completion message to the console. This is intended for final console output upon application completion. |
| [WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent)](SpectreConsole.WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent).md 'MasterCommander.Integrations.Display.SpectreConsole.WriteElapsedConsoleEvent(MasterCommander.Core.ConsoleEvents.ExecutionTimeConsoleEvent)') | Writes an execution time console event to the output. |
| [WriteExitedConsoleEvent(ExitedConsoleEvent)](SpectreConsole.WriteExitedConsoleEvent(ExitedConsoleEvent).md 'MasterCommander.Integrations.Display.SpectreConsole.WriteExitedConsoleEvent(MasterCommander.Core.ConsoleEvents.ExitedConsoleEvent)') | Writes an exited console event to the output. |
| [WriteLine(string)](SpectreConsole.WriteLine(string).md 'MasterCommander.Integrations.Display.SpectreConsole.WriteLine(string)') | Writes a line to the console. If the message is null, writes an empty line. |
| [WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent)](SpectreConsole.WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent).md 'MasterCommander.Integrations.Display.SpectreConsole.WriteStandardErrorConsoleEvent(MasterCommander.Core.ConsoleEvents.StandardErrorConsoleEvent)') | Writes a standard error console event to the output. |
| [WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent)](SpectreConsole.WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent).md 'MasterCommander.Integrations.Display.SpectreConsole.WriteStandardOutputConsoleEvent(MasterCommander.Core.ConsoleEvents.StandardOutputConsoleEvent)') | Writes a standard output console event to the output. |
| [WriteStartedConsoleEvent(StartedConsoleEvent)](SpectreConsole.WriteStartedConsoleEvent(StartedConsoleEvent).md 'MasterCommander.Integrations.Display.SpectreConsole.WriteStartedConsoleEvent(MasterCommander.Core.ConsoleEvents.StartedConsoleEvent)') | Writes a started console event to the output. |
| [WriteStartupMessage()](SpectreConsole.WriteStartupMessage().md 'MasterCommander.Integrations.Display.SpectreConsole.WriteStartupMessage()') | Writes a startup message to the console. This is intended for initial console output upon application start. |

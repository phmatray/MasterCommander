namespace MasterCommander.Integrations.Display;

public abstract class ConsoleEvent;

public class StartedConsoleEvent(int processId) : ConsoleEvent
{
    public int ProcessId { get; } = processId;
    public override string ToString() => $"Process ID: {ProcessId}";
}

public class StandardOutputConsoleEvent(string text) : ConsoleEvent
{
    public string Text { get; } = text;
    public override string ToString() => Text;
}

public class StandardErrorConsoleEvent(string text) : ConsoleEvent
{
    public string Text { get; } = text;
    public override string ToString() => Text;
}

public class ExitedConsoleEvent(int exitCode) : ConsoleEvent
{
    public int ExitCode { get; } = exitCode;
    public override string ToString() => $"Exit code: {ExitCode}";
}

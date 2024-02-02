namespace MasterCommander.Core.ConsoleEvents;

public class ExitedConsoleEvent(int exitCode) : ConsoleEvent
{
    public int ExitCode { get; } = exitCode;
    public override string ToString() => $"Exit code: {ExitCode}";
}
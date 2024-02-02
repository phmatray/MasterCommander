namespace MasterCommander.Core.ConsoleEvents;

public class StartedConsoleEvent(int processId) : ConsoleEvent
{
    public int ProcessId { get; } = processId;
    public override string ToString() => $"Process ID: {ProcessId}";
}
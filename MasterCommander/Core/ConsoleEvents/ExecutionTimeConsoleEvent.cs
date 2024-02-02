namespace MasterCommander.Core.ConsoleEvents;

public class ExecutionTimeConsoleEvent(TimeSpan elapsed) : ConsoleEvent
{
    public TimeSpan Elapsed { get; set; } = elapsed;
    public override string ToString() => $"Elapsed time: {Elapsed}";
}
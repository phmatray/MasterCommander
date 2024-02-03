namespace MasterCommander.Core.ConsoleEvents;

public class ExecutionTimeConsoleEvent(TimeSpan elapsedTime) : ConsoleEvent
{
    public TimeSpan ElapsedTime { get; set; } = elapsedTime;
    public override string ToString() => $"Elapsed time: {ElapsedTime}";
}
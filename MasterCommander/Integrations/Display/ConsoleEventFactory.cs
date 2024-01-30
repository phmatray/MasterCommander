namespace MasterCommander.Integrations.Display;

public static class ConsoleEventFactory
{
    public static ConsoleEvent CreateFrom(CommandEvent cmdEvent)
    {
        return cmdEvent switch
        {
            StartedCommandEvent started => CreateStartedEvent(started.ProcessId),
            StandardOutputCommandEvent stdOut => CreateStandardOutputEvent(stdOut.Text),
            StandardErrorCommandEvent stdErr => CreateStandardErrorEvent(stdErr.Text),
            ExitedCommandEvent exited => CreateExitedEvent(exited.ExitCode),
            _ => throw new ArgumentException($"Unknown command event type: {cmdEvent.GetType()}")
        };
    }
    
    public static ConsoleEvent CreateStartedEvent(int processId)
    {
        return new StartedConsoleEvent(processId);
    }
    
    public static ConsoleEvent CreateStandardOutputEvent(string message)
    {
        return new StandardOutputConsoleEvent(message);
    }
    
    public static ConsoleEvent CreateStandardErrorEvent(string message)
    {
        return new StandardErrorConsoleEvent(message);
    }
    
    public static ConsoleEvent CreateExitedEvent(int exitCode)
    {
        return new ExitedConsoleEvent(exitCode);
    }
}
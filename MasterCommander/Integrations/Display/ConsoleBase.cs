namespace MasterCommander.Integrations.Display;

public abstract class ConsoleBase
{
    public void WriteConsoleEvent(ConsoleEvent consoleEvent)
    {
        switch (consoleEvent)
        {
            case StartedConsoleEvent started:
                WriteStartedConsoleEvent(started);
                break;
            case StandardOutputConsoleEvent stdOutput:
                WriteStandardOutputConsoleEvent(stdOutput);
                break;
            case StandardErrorConsoleEvent stdError:
                WriteStandardErrorConsoleEvent(stdError);
                break;
            case ExitedConsoleEvent exited:
                WriteExitedConsoleEvent(exited);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(consoleEvent));
        }
    }

    protected abstract void WriteStartedConsoleEvent(StartedConsoleEvent started);
    protected abstract void WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent stdOutput);
    protected abstract void WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent stdError);
    protected abstract void WriteExitedConsoleEvent(ExitedConsoleEvent exited);
}
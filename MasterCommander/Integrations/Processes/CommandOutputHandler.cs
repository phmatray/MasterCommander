namespace MasterCommander.Integrations.Processes;

public abstract class CommandOutputHandler(IConsole console)
{
    protected void HandleCommandEvent(CommandEvent cmdEvent)
    {
        var consoleEvent = ConsoleEventFactory.CreateFrom(cmdEvent);
        console.WriteConsoleEvent(consoleEvent);
    }
}
namespace MasterCommander.Integrations.Processes;

public abstract class CommandOutputHandler(IConsole console)
{
    protected async Task ObserveCommandAsync(Command command, CancellationToken ct)
    {
        console.WriteCommand(command.ToString());
        
        await command
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }
    
    protected void HandleCommandEvent(CommandEvent cmdEvent)
    {
        var consoleEvent = ConsoleEventFactory.CreateFrom(cmdEvent);
        console.WriteConsoleEvent(consoleEvent);
    }
}
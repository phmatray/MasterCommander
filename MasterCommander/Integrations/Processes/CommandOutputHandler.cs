using System.Diagnostics;

namespace MasterCommander.Integrations.Processes;

public abstract class CommandOutputHandler(IConsole console)
{
    protected async Task ListenCommandAsync(Command command, CancellationToken ct)
    {
        console.WriteCommand(command.ToString());
        var stopWatch = Stopwatch.StartNew();
        
        await foreach (var commandEvent in command.ListenAsync(ct))
        {
            console.WriteConsoleEvent(ConsoleEventFactory.CreateFrom(commandEvent));
        }
        
        stopWatch.Stop();
        console.WriteConsoleEvent(ConsoleEventFactory.CreateFrom(stopWatch));
    }
}
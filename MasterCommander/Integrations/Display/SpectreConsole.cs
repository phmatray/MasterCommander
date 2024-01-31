using Spectre.Console;

namespace MasterCommander.Integrations.Display;

public class SpectreConsole : IConsole
{
    public void WriteLine(string message)
    {
        AnsiConsole.MarkupLine(message);
    }

    public void WriteConsoleEvent(ConsoleEvent consoleEvent)
    {
        switch (consoleEvent)
        {
            case StartedConsoleEvent started:
                WriteLine($"Starting process [yellow](ID: {started.ProcessId})[/]...");
                break;
            case StandardOutputConsoleEvent stdOutput:
                if (!string.IsNullOrWhiteSpace(stdOutput.Text))
                {
                    WriteLine($"[green]>[/] {stdOutput.Text.Trim()}");
                }
                break;
            case StandardErrorConsoleEvent stdError:
                if (!string.IsNullOrWhiteSpace(stdError.Text))
                {
                    WriteLine($"[red]Error:[/] {stdError.Text.Trim()}");
                }
                break;
            case ExitedConsoleEvent exited:
                WriteLine($"Process completed with exit code [yellow]{exited.ExitCode}[/].\n");
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(consoleEvent));
        }
    }
}
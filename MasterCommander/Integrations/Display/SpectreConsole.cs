using Spectre.Console;

namespace MasterCommander.Integrations.Display;

public sealed class SpectreConsole
    : ConsoleBase, IConsole
{
    public void WriteLine(string message)
    {
        AnsiConsole.MarkupLine(message);
    }

    public void WriteCommand(string command)
    {
        WriteLine($"[blue]Running command:[/] {command}");
    }
    
    public void WriteStartupMessage()
    {
        AnsiConsole.Write(new FigletText("MasterCommander"));
    }

    protected override void WriteStartedConsoleEvent(StartedConsoleEvent started)
    {
        WriteLine($"Starting process [yellow](ID: {started.ProcessId})[/]...");
    }
    
    protected override void WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent stdOutput)
    {
        if (!string.IsNullOrWhiteSpace(stdOutput.Text))
        {
            WriteLine($"[green]>[/] {stdOutput.Text.Trim()}");
        }
    }
    
    protected override void WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent stdError)
    {
        if (!string.IsNullOrWhiteSpace(stdError.Text))
        {
            WriteLine($"[red]Error:[/] {stdError.Text.Trim()}");
        }
    }
    
    protected override void WriteExitedConsoleEvent(ExitedConsoleEvent exited)
    {
        WriteLine(exited.ExitCode == 0
            ? $"Process successfully completed with exit code [green]{exited.ExitCode}[/]."
            : $"Process completed with exit code [red]{exited.ExitCode}[/].");
    }
}
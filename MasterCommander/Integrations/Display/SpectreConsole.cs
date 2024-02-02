using Spectre.Console;

namespace MasterCommander.Integrations.Display;

public sealed class SpectreConsole
    : ConsoleBase, IConsole
{
    public void WriteLine(string? message = null)
    {
        if (message is not null)
        {
            AnsiConsole.MarkupLine(message);
        }
        else
        {
            AnsiConsole.WriteLine();
        }
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
            ? $"{Emoji.Known.CheckMark} Process successfully completed with exit code [green]{exited.ExitCode}[/]."
            : $"{Emoji.Known.CrossMark} Process completed with exit code [red]{exited.ExitCode}[/].");
    }

    protected override void WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent elapsed)
    {
        WriteLine($"{Emoji.Known.TimerClock} Elapsed time: [yellow]{elapsed.Elapsed}[/]");
        WriteLine();
    }
}
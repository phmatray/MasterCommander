namespace MasterCommander.Integrations.Display;

public class StandardConsole
    : ConsoleBase, IConsole
{
    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    public void WriteCommand(string command)
    {
        WriteLine($"Running command: {command}");
    }

    public void WriteStartupMessage()
    {
        WriteLine("\n-----------------");
        WriteLine(" MasterCommander");
        WriteLine("-----------------\n");
    }

    protected override void WriteStartedConsoleEvent(StartedConsoleEvent started)
    {
        WriteLine($"Starting process (ID: {started.ProcessId})...");
    }

    protected override void WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent stdOutput)
    {
        if (!string.IsNullOrWhiteSpace(stdOutput.Text))
        {
            WriteLine($"> {stdOutput.Text.Trim()}");
        }
    }

    protected override void WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent stdError)
    {
        if (!string.IsNullOrWhiteSpace(stdError.Text))
        {
            WriteLine($"Error: {stdError.Text.Trim()}");
        }
    }

    protected override void WriteExitedConsoleEvent(ExitedConsoleEvent exited)
    {
        WriteLine($"Process completed with exit code {exited.ExitCode}.\n");
    }
}
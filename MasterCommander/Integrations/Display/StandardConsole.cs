namespace MasterCommander.Integrations.Display;

public class StandardConsole : IConsole
{
    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    public void WriteConsoleEvent(ConsoleEvent consoleEvent)
    {
        switch (consoleEvent)
        {
            case StartedConsoleEvent started:
                WriteLine($"Starting process (ID: {started.ProcessId})...");
                break;
            case StandardOutputConsoleEvent stdOutput:
                if (!string.IsNullOrWhiteSpace(stdOutput.Text))
                {
                    WriteLine($"> {stdOutput.Text.Trim()}");
                }
                break;
            case StandardErrorConsoleEvent stdError:
                if (!string.IsNullOrWhiteSpace(stdError.Text))
                {
                    WriteLine($"Error: {stdError.Text.Trim()}");
                }
                break;
            case ExitedConsoleEvent exited:
                WriteLine($"Process completed with exit code {exited.ExitCode}.\n");
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(consoleEvent));
        }
    }

    public void WriteCommand(string command)
    {
        WriteLine($"Running command: {command}");
    }
}
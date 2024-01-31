namespace MasterCommander.Integrations.Display;

public interface IConsole
{
    void WriteLine(string message);
    void WriteConsoleEvent(ConsoleEvent consoleEvent);
    void WriteCommand(string command);
}

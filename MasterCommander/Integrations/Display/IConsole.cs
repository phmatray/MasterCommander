namespace MasterCommander.Integrations.Display;

public interface IConsole
{
    void WriteLine(string message);
    void WriteCommand(string command);
    void WriteStartupMessage();
    void WriteConsoleEvent(ConsoleEvent consoleEvent);
}

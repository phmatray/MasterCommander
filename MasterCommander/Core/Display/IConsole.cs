namespace MasterCommander.Core.Display;

public interface IConsole
{
    void WriteLine(string? message = null);
    void WriteCommand(string command);
    void WriteStartupMessage();
    void WriteConsoleEvent(ConsoleEvent consoleEvent);
}

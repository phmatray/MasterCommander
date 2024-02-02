namespace MasterCommander.Core.ConsoleEvents;

public class StandardOutputConsoleEvent(string text) : ConsoleEvent
{
    public string Text { get; } = text;
    public override string ToString() => Text;
}
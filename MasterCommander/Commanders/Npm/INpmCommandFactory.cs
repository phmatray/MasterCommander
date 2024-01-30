namespace MasterCommander.Commanders.Npm;

public interface INpmCommandFactory
{
    Command Init();
    Command Install();
    Command Update();
    Command Start();
    Command RunScript(string scriptName);
}
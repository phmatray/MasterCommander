namespace MasterCommander.Commanders.Npm;

public class NpmService(
    INpmCommandFactory npmCommandFactory, IConsole console)
    : CommandOutputHandler(console), INpmService
{
    public async Task InitAsync(CancellationToken ct = default)
    {
        var command = npmCommandFactory.Init();
        await ListenCommandAsync(command, ct);
    }
    
    public async Task InstallAsync(CancellationToken ct = default)
    {
        var command = npmCommandFactory.Install();
        await ListenCommandAsync(command, ct);
    }

    public async Task UpdateAsync(CancellationToken ct = default)
    {
        var command = npmCommandFactory.Update();
        await ListenCommandAsync(command, ct);
    }

    public async Task StartAsync(CancellationToken ct = default)
    {
        var command = npmCommandFactory.Start();
        await ListenCommandAsync(command, ct);
    }

    public async Task RunScriptAsync(string scriptName, CancellationToken ct = default)
    {
        var command = npmCommandFactory.RunScript(scriptName);
        await ListenCommandAsync(command, ct);
    }
}
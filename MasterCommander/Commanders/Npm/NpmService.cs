namespace MasterCommander.Commanders.Npm;

public class NpmService(NpmCommandFactory npmCommandFactory, IConsole console)
    : CommandOutputHandler(console)
{
    public async Task InstallAsync(CancellationToken ct = default)
    {
        await npmCommandFactory
            .Install()
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }

    public async Task UpdateAsync(CancellationToken ct = default)
    {
        await npmCommandFactory
            .Update()
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }

    public async Task StartAsync(CancellationToken ct = default)
    {
        await npmCommandFactory
            .Start()
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }

    public async Task RunScriptAsync(string scriptName, CancellationToken ct = default)
    {
        await npmCommandFactory
            .RunScript(scriptName)
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }
}
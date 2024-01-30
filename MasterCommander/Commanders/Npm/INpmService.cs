namespace MasterCommander.Commanders.Npm;

public interface INpmService
{
    Task InitAsync(CancellationToken ct = default);
    Task InstallAsync(CancellationToken ct = default);
    Task UpdateAsync(CancellationToken ct = default);
    Task StartAsync(CancellationToken ct = default);
    Task RunScriptAsync(string scriptName, CancellationToken ct = default);
}
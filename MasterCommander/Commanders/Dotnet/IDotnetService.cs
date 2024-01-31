namespace MasterCommander.Commanders.Dotnet;

public interface IDotnetService
{
    Task NewAsync(string template, string name, bool force, CancellationToken ct = default);
    Task BuildAsync(CancellationToken ct = default);
    Task RunAsync(CancellationToken ct = default);
    Task TestAsync(CancellationToken ct = default);
}
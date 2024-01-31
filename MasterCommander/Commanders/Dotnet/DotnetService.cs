namespace MasterCommander.Commanders.Dotnet;

public class DotnetService(
    IDotnetCommandFactory dotnetCommandFactory, IConsole console)
    : CommandOutputHandler(console), IDotnetService
{
    public async Task NewAsync(string template, string name, bool force, CancellationToken ct = default)
    {
        DotnetNewOptions options = new(template, name);
        
        await dotnetCommandFactory
            .New(options)
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }

    public async Task BuildAsync(CancellationToken ct = default)
    {
        await dotnetCommandFactory
            .Build()
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }

    public async Task RunAsync(CancellationToken ct = default)
    {
        await dotnetCommandFactory
            .Run()
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }

    public async Task TestAsync(CancellationToken ct = default)
    {
        await dotnetCommandFactory
            .Test()
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }
}
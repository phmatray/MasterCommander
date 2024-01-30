namespace MasterCommander.Commanders.Dotnet;

public class DotnetService(DotnetCommandFactory dotnetCommandFactory, IConsole console)
    : CommandOutputHandler(console)
{
    public async Task NewAsync(string template, string name, CancellationToken ct = default)
    {
        await dotnetCommandFactory
            .New(template, name)
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
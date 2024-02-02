namespace MasterCommander.Commanders.Dotnet;

/// <summary>
/// Provides .NET related operations.
/// </summary>
public class DotnetService(
    IDotnetCommandFactory dotnetCommandFactory, IConsole console)
    : CommandOutputHandler(console), IDotnetService
{
    /// <inheritdoc/>
    public async Task NewAsync(string template, string? outputName, bool force, CancellationToken ct = default)
    {
        DotnetNewOptions options = new(template) { OutputName = outputName, Force = force };
        var command = dotnetCommandFactory.New(options);
        await ObserveCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task BuildAsync(CancellationToken ct = default)
    {
        var command = dotnetCommandFactory.Build();
        await ObserveCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task RunAsync(CancellationToken ct = default)
    {
        var command = dotnetCommandFactory.Run();
        await ObserveCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task TestAsync(CancellationToken ct = default)
    {
        var command = dotnetCommandFactory.Test();
        await ObserveCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task SlnAddAsync(string csproj, CancellationToken ct = default)
    {
        var command = dotnetCommandFactory.SlnAdd(csproj);
        await ObserveCommandAsync(command, ct);
    }
}
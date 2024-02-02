namespace MasterCommander.Commanders.Dotnet;

/// <summary>
/// Provides .NET related operations.
/// </summary>
public class DotnetService(
    IDotnetCommandFactory dotnetCommandFactory,
    IConsole console)
    : CommandOutputHandler(console), IDotnetService
{
    /// <inheritdoc/>
    public async Task NewAsync(
        DotnetNewOptions? options = null,
        CancellationToken ct = default)
    {
        options ??= new DotnetNewOptions("console");
        var command = dotnetCommandFactory.New(options);
        await ObserveCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task BuildAsync(
        DotnetBuildOptions? options = null,
        CancellationToken ct = default)
    {
        options ??= new DotnetBuildOptions();
        var command = dotnetCommandFactory.Build(options);
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
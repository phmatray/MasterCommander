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
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task BuildAsync(
        DotnetBuildOptions? options = null,
        CancellationToken ct = default)
    {
        options ??= new DotnetBuildOptions();
        var command = dotnetCommandFactory.Build(options);
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task RunAsync(
        DotnetRunOptions? options = null,
        CancellationToken ct = default)
    {
        options ??= new DotnetRunOptions();
        var command = dotnetCommandFactory.Run(options);
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task TestAsync(CancellationToken ct = default)
    {
        var command = dotnetCommandFactory.Test();
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task SlnAddAsync(string csproj, CancellationToken ct = default)
    {
        var command = dotnetCommandFactory.SlnAdd(csproj);
        await ListenCommandAsync(command, ct);
    }
}
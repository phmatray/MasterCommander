namespace MasterCommander.Commanders.Dotnet;

/// <summary>
/// Provides .NET related operations.
/// </summary>
public class DotnetService(
    IDotnetCommandFactory dotnetCommandFactory, IConsole console)
    : CommandOutputHandler(console), IDotnetService
{
    /// <summary>
    /// Creates a new .NET project with the specified template and name.
    /// </summary>
    public async Task NewAsync(string template, string name, bool force, CancellationToken ct = default)
    {
        DotnetNewOptions options = new(template, name, force);
        var command = dotnetCommandFactory.New(options);
        await ObserveCommandAsync(command, ct);
    }

    /// <summary>
    /// Builds the .NET project.
    /// </summary>
    public async Task BuildAsync(CancellationToken ct = default)
    {
        var command = dotnetCommandFactory.Build();
        await ObserveCommandAsync(command, ct);
    }

    /// <summary>
    /// Runs the .NET project.
    /// </summary>
    public async Task RunAsync(CancellationToken ct = default)
    {
        var command = dotnetCommandFactory.Run();
        await ObserveCommandAsync(command, ct);
    }

    /// <summary>
    /// Runs the tests in the .NET project.
    /// </summary>
    public async Task TestAsync(CancellationToken ct = default)
    {
        var command = dotnetCommandFactory.Test();
        await ObserveCommandAsync(command, ct);
    }
}
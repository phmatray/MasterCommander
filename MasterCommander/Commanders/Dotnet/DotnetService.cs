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
        
        await dotnetCommandFactory
            .New(options)
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }

    /// <summary>
    /// Builds the .NET project.
    /// </summary>
    public async Task BuildAsync(CancellationToken ct = default)
    {
        await dotnetCommandFactory
            .Build()
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }

    /// <summary>
    /// Runs the .NET project.
    /// </summary>
    public async Task RunAsync(CancellationToken ct = default)
    {
        await dotnetCommandFactory
            .Run()
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }

    /// <summary>
    /// Runs the tests in the .NET project.
    /// </summary>
    public async Task TestAsync(CancellationToken ct = default)
    {
        await dotnetCommandFactory
            .Test()
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }
}
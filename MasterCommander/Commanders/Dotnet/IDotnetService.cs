namespace MasterCommander.Commanders.Dotnet;

/// <summary>
/// Provides an interface for .NET related operations.
/// </summary>
public interface IDotnetService
{
    /// <summary>
    /// Creates a new .NET project with the specified template and name.
    /// </summary>
    Task NewAsync(string template, string name, bool force, CancellationToken ct = default);

    /// <summary>
    /// Builds the .NET project.
    /// </summary>
    Task BuildAsync(CancellationToken ct = default);

    /// <summary>
    /// Runs the .NET project.
    /// </summary>
    Task RunAsync(CancellationToken ct = default);

    /// <summary>
    /// Runs the tests in the .NET project.
    /// </summary>
    Task TestAsync(CancellationToken ct = default);
}
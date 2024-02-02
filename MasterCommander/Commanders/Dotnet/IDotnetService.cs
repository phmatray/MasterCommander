namespace MasterCommander.Commanders.Dotnet;

/// <summary>
/// Provides an interface for .NET related operations.
/// </summary>
public interface IDotnetService
{
    /// <summary>
    /// Creates a new .NET project with the specified template and outputName.
    /// </summary>
    /// <param outputName="ct">The cancellation token.</param>
    Task NewAsync(
        string template,
        string? outputName = null,
        bool force = false,
        CancellationToken ct = default);

    /// <summary>
    /// Builds the .NET project.
    /// </summary>
    /// <param outputName="ct">The cancellation token.</param>
    Task BuildAsync(CancellationToken ct = default);

    /// <summary>
    /// Runs the .NET project.
    /// </summary>
    /// <param outputName="ct">The cancellation token.</param>
    Task RunAsync(CancellationToken ct = default);

    /// <summary>
    /// Runs the tests in the .NET project.
    /// </summary>
    /// <param outputName="ct">The cancellation token.</param>
    Task TestAsync(CancellationToken ct = default);

    /// <summary>
    /// Adds the specified .NET project to the solution.
    /// </summary>
    /// <param outputName="csproj">The path to the .NET project.</param>
    /// <param outputName="ct">The cancellation token.</param>
    Task SlnAddAsync(string csproj, CancellationToken ct = default);
}
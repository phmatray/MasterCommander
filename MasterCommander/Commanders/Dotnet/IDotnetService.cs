namespace MasterCommander.Commanders.Dotnet;

/// <summary>
/// Provides an interface for .NET related operations.
/// </summary>
public interface IDotnetService
{
    /// <summary>
    /// Creates a new .NET project with the specified template and outputName.
    /// </summary>
    /// <param name="options">The options to use.</param>
    /// <param name="ct">The cancellation token.</param>
    Task NewAsync(
        DotnetNewOptions? options = null,
        CancellationToken ct = default);

    /// <summary>
    /// Builds the .NET project.
    /// </summary>
    /// <param name="options">The options to use.</param>
    /// <param name="ct">The cancellation token.</param>
    Task BuildAsync(
        DotnetBuildOptions? options = null, 
        CancellationToken ct = default);

    /// <summary>
    /// Runs the .NET project.
    /// </summary>
    /// <param name="options">The options to use.</param>
    /// <param name="ct">The cancellation token.</param>
    Task RunAsync(
        DotnetRunOptions? options = null,
        CancellationToken ct = default);

    /// <summary>
    /// Runs the tests in the .NET project.
    /// </summary>
    /// <param name="ct">The cancellation token.</param>
    Task TestAsync(CancellationToken ct = default);

    /// <summary>
    /// Adds the specified .NET project to the solution.
    /// </summary>
    /// <param name="csproj">The path to the .NET project.</param>
    /// <param name="ct">The cancellation token.</param>
    Task SlnAddAsync(string csproj, CancellationToken ct = default);
}
// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Integrations;

/// <summary>
/// Represents the project initialization service.
/// </summary>
public class ProjectInitializationService : IProjectInitializationService
{
    private const string SdkVersion = "8.0.101";
    private const string SolutionName = "AppDemo";
    private const string ConsoleProjectName = $"{SolutionName}.Console";
    private const string ConsoleProjectDirectory = $"src/{ConsoleProjectName}";
    private const string ConsoleCsproj = $"{ConsoleProjectDirectory}/{ConsoleProjectName}.csproj";

    private readonly IGitService _git;
    private readonly IDotnetService _dotnet;
    private readonly IConsole _console;
    private readonly IDirectoryService _directory;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProjectInitializationService"/> class.
    /// </summary>
    /// <param name="git">The git service.</param>
    /// <param name="dotnet">The dotnet service.</param>
    /// <param name="console">The console service.</param>
    /// <param name="directory">The directory service.</param>
    public ProjectInitializationService(
        IGitService git,
        IDotnetService dotnet,
        IConsole console,
        IDirectoryService directory)
    {
        _git = git;
        _dotnet = dotnet;
        _console = console;
        _directory = directory;
    }

    /// <inheritdoc />
    public async Task InitializeConsoleProjectAsync()
    {
        SetWorkingDirectory();

        _console.WriteStartupMessage();

        await _git.InitAsync();
        await _git.StatusAsync();
        await _dotnet.NewAsync(new DotnetNewGitignoreOptions());
        await _dotnet.NewAsync(new DotnetNewEditorConfigOptions());
        await _dotnet.NewAsync(new DotnetNewNuGetConfigOptions());
        await _dotnet.NewAsync(new DotnetNewGlobalJsonOptions { SdkVersion = SdkVersion });
        await _dotnet.NewAsync(new DotnetNewSolutionOptions { OutputName = SolutionName });
        await _dotnet.NewAsync(new DotnetNewConsoleOptions { OutputName = ConsoleProjectName, OutputDirectory = ConsoleProjectDirectory });
        await _dotnet.SlnAddAsync(ConsoleCsproj);
        await _dotnet.BuildAsync();
        await _dotnet.BuildAsync(new DotnetBuildOptions { Configuration = "Release" });
        await _dotnet.RunAsync(new DotnetRunOptions { Project = ConsoleCsproj, Configuration = "Release" });

        CompressSolutionDirectory();
    }

    private void SetWorkingDirectory()
    {
        // Set the working directory to the solution directory
        _directory.SetWorkingDirectory(SolutionName, true);
    }

    private void CompressSolutionDirectory()
    {
        if (_directory.WorkingDirectory == null)
        {
            return;
        }

        var zipPath = Path.Combine(_directory.MasterCommanderDirectory, $"{SolutionName}.zip");
        _directory.CompressDirectory(_directory.WorkingDirectory, zipPath);
    }
}

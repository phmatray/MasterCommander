// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Integrations;

/// <summary>
/// Represents the project initialization service.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="ProjectInitializationService"/> class.
/// </remarks>
/// <param name="git">The git service.</param>
/// <param name="dotnet">The dotnet service.</param>
/// <param name="console">The console service.</param>
/// <param name="directory">The directory service.</param>
public class ProjectInitializationService(
    IGitService git,
    IDotnetService dotnet,
    IConsole console,
    IDirectoryService directory) : IProjectInitializationService
{
    private const string SdkVersion = "8.0.*";
    private const string SolutionName = "AppDemo";
    private const string ConsoleProjectName = $"{SolutionName}.Console";
    private const string ConsoleProjectDirectory = $"src/{ConsoleProjectName}";
    private const string ConsoleCsproj = $"{ConsoleProjectDirectory}/{ConsoleProjectName}.csproj";

    /// <inheritdoc />
    public async Task InitializeConsoleProjectAsync()
    {
        SetWorkingDirectory();

        console.WriteStartupMessage();

        await git.InitAsync();
        await dotnet.NewAsync(new DotnetNewGitignoreOptions());
        await dotnet.NewAsync(new DotnetNewEditorConfigOptions());
        await dotnet.NewAsync(new DotnetNewNuGetConfigOptions());
        await dotnet.NewAsync(new DotnetNewGlobalJsonOptions { SdkVersion = SdkVersion });
        await dotnet.NewAsync(new DotnetNewSolutionOptions { OutputName = SolutionName });
        await dotnet.NewAsync(new DotnetNewConsoleOptions { OutputName = ConsoleProjectName, OutputDirectory = ConsoleProjectDirectory });
        await dotnet.SlnAddAsync(ConsoleCsproj);
        await git.AddAsync("*");
        await git.CommitAsync("initial commit");
        await dotnet.BuildAsync();
        await dotnet.BuildAsync(new DotnetBuildOptions { Configuration = "Release" });
        await dotnet.RunAsync(new DotnetRunOptions { Project = ConsoleCsproj, Configuration = "Release" });

        CompressSolutionDirectory();
    }

    private void SetWorkingDirectory()
    {
        // Set the working directory to the solution directory
        directory.SetWorkingDirectory(SolutionName, true);
    }

    private void CompressSolutionDirectory()
    {
        if (directory.WorkingDirectory == null)
        {
            return;
        }

        var zipPath = Path.Combine(directory.MasterCommanderDirectory, $"{SolutionName}.zip");
        directory.CompressDirectory(directory.WorkingDirectory, zipPath);
    }
}

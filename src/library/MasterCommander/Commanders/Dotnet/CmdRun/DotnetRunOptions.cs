// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet.CmdRun;

/// <summary>
/// Represents options for the 'dotnet run' command, which runs a .NET project in the context of the project's directory or using specified options.
/// </summary>
public record DotnetRunOptions()
    : DotnetCommandOptionsBase("run")
{
    /// <summary>
    /// Gets the name of the launch profile to use from the launchSettings.json configuration file.
    /// </summary>
    [CmdOption("--launch-profile")]
    public string? LaunchProfile { get; init; }

    /// <summary>
    /// Gets a value indicating whether to skip building the project before running.
    /// </summary>
    [CmdOption("--no-build")]
    public bool NoBuild { get; init; }

    /// <summary>
    /// Gets a value indicating whether to run the project without using any launch profile.
    /// </summary>
    [CmdOption("--no-launch-profile")]
    public bool NoLaunchProfile { get; init; }

    /// <summary>
    /// Gets the path to the project file to run. If not specified, the command will search the current directory for a project file.
    /// </summary>
    [CmdOption("--project")]
    public string? Project { get; init; }

    /// <summary>
    /// Gets additional arguments to pass to the application being run.
    /// </summary>
    /// <remarks>
    /// These arguments are passed directly to the application and are not used by the `dotnet run` command itself.
    /// </remarks>
    public string? ApplicationArguments { get; init; }
}

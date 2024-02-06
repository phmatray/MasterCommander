// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using MasterCommander.Commanders.Dotnet.CmdBuild;
using MasterCommander.Commanders.Dotnet.CmdNew.Options;
using MasterCommander.Commanders.Dotnet.CmdRun;

namespace MasterCommander.Commanders.Dotnet;

/// <summary>
/// Defines the interface for creating .NET command instances.
/// </summary>
public interface IDotnetCommandFactory
{
    /// <summary>
    /// Creates a new command to create a new .NET project or file.
    /// </summary>
    /// <param name="options">The options for creating a new .NET project or file.</param>
    /// <returns>A command to create a new .NET project or file.</returns>
    Command CreateCommandNew(DotnetNewOptions options);

    /// <summary>
    /// Creates a new command to build a .NET project.
    /// </summary>
    /// <param name="options">The options for building the .NET project.</param>
    /// <returns>A command to build a .NET project.</returns>
    Command CreateCommandBuild(DotnetBuildOptions options);

    /// <summary>
    /// Creates a new command to run a .NET project.
    /// </summary>
    /// <param name="options">The options for running the .NET project.</param>
    /// <returns>A command to run a .NET project.</returns>
    Command CreateCommandRun(DotnetRunOptions options);

    /// <summary>
    /// Creates a new command to run tests in a .NET project.
    /// </summary>
    /// <returns>A command to run tests in a .NET project.</returns>
    Command CreateCommandTest();

    /// <summary>
    /// Creates a new command to add a C# project file (.csproj) to a solution (.sln).
    /// </summary>
    /// <param name="csproj">The path to the C# project file to add.</param>
    /// <returns>A command to add a C# project file to a solution.</returns>
    Command CreateCommandSlnAdd(string csproj);
}

// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using MasterCommander.Commanders.Dotnet.CmdBuild;
using MasterCommander.Commanders.Dotnet.CmdNew.Options;
using MasterCommander.Commanders.Dotnet.CmdRun;

namespace MasterCommander.Commanders.Dotnet;

/// <summary>
/// A factory for creating .NET command instances.
/// </summary>
/// <param name="workingDirectory">The working directory for the command.</param>
/// <param name="executablePath">The path to the dotnet executable.</param>
public class DotnetCommandFactory(
    string workingDirectory = ".",
    string executablePath = "dotnet")
    : CommandBuilder(workingDirectory, executablePath), IDotnetCommandFactory
{
    /// <inheritdoc />
    public Command CreateCommandNew(DotnetNewOptions options)
    {
        return CreateCommand(options.ToArguments());
    }

    /// <inheritdoc />
    public Command CreateCommandBuild(DotnetBuildOptions options)
    {
        return CreateCommand(options.ToArguments());
    }

    /// <inheritdoc />
    public Command CreateCommandRun(DotnetRunOptions options)
    {
        return CreateCommand(options.ToArguments());
    }

    /// <inheritdoc />
    public Command CreateCommandTest()
    {
        string[] arguments = ["test"];
        return CreateCommand(arguments);
    }

    /// <inheritdoc />
    public Command CreateCommandSlnAdd(string csproj)
    {
        string[] arguments = ["sln", "add", csproj];
        return CreateCommand(arguments);
    }
}

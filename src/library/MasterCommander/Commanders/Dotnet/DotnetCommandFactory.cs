// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet;

/// <summary>
/// A factory for creating .NET command instances.
/// </summary>
/// <param name="directoryService">The directory service to use for working directory operations.</param>
public class DotnetCommandFactory(IDirectoryService directoryService)
    : CommandBuilder(directoryService), IDotnetCommandFactory
{
    /// <inheritdoc />
    protected override string ExecutablePath => "dotnet";

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

// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet;

/// <summary>
/// Base record for .NET command options, providing common options applicable to various .NET CLI commands.
/// </summary>
/// <param name="Command">The command to execute.</param>
public abstract record DotnetCommandOptionsBase(string Command)
    : CmdOptionsBase(Command)
{
    /// <summary>
    /// Gets or initializes the architecture option for the command.
    /// </summary>
    [CmdOption("-a|--arch")]
    [CmdOptionOrder(1)]
    public string? Architecture { get; init; }

    /// <summary>
    /// Gets or initializes the configuration option for the command, such as Debug or Release.
    /// </summary>
    [CmdOption("-c|--configuration")]
    [CmdOptionOrder(2)]
    public string? Configuration { get; init; }

    /// <summary>
    /// Gets or initializes the target framework for the command.
    /// </summary>
    [CmdOption("-f|--framework")]
    [CmdOptionOrder(3)]
    public string? Framework { get; init; }

    /// <summary>
    /// Gets a value indicating whether the command should force the execution without prompt.
    /// </summary>
    [CmdOption("--force")]
    [CmdOptionOrder(4)]
    public bool Force { get; init; }

    /// <summary>
    /// Gets a value indicating whether the command should run in interactive mode.
    /// </summary>
    [CmdOption("--interactive")]
    [CmdOptionOrder(5)]
    public bool Interactive { get; init; }

    /// <summary>
    /// Gets a value indicating whether the command should ignore project-to-project references.
    /// </summary>
    [CmdOption("--no-dependencies")]
    [CmdOptionOrder(6)]
    public bool NoDependencies { get; init; }

    /// <summary>
    /// Gets a value indicating whether the command should not restore dependencies.
    /// </summary>
    [CmdOption("--no-restore")]
    [CmdOptionOrder(7)]
    public bool NoRestore { get; init; }

    /// <summary>
    /// Gets or initializes the operating system option for the command.
    /// </summary>
    [CmdOption("--os")]
    [CmdOptionOrder(8)]
    public string? OS { get; init; }

    /// <summary>
    /// Gets or initializes the runtime identifier for the command, specifying the target runtime.
    /// </summary>
    [CmdOption("-r|--runtime")]
    [CmdOptionOrder(9)]
    public string? RuntimeIdentifier { get; init; }

    /// <summary>
    /// Gets or initializes the terminal logger option with values like auto, on, or off.
    /// </summary>
    [CmdOption("--tl")]
    [CmdOptionOrder(10)]
    [CmdOptionValues(["auto", "on", "off"])]
    public string? TerminalLogger { get; init; }

    /// <summary>
    /// Gets or initializes the verbosity level of the command's output.
    /// </summary>
    [CmdOption("-v|--verbosity")]
    [CmdOptionOrder(11)]
    [CmdOptionValues(["quiet", "minimal", "normal", "detailed", "diagnostic"])]
    public string? VerbosityLevel { get; init; }
}

// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet.CmdNew.Options;

/// <summary>
/// Represents options for the 'dotnet new' command, which creates a .NET project or other artifacts based on a template.
/// This record encapsulates common and template-specific options that can be passed to the command.
/// </summary>
/// <param name="Template">The template to instantiate when the command is invoked. Each template might have specific options you can pass.</param>
public record DotnetNewOptions(string Template)
    : CmdOptionsBase("new", Template)
{
    /// <summary>
    /// Gets a value indicating whether to perform a dry run of the command without making any changes.
    /// </summary>
    [CmdOption("--dry-run")]
    [CmdOptionOrder(1)]
    public bool DryRun { get; init; }

    /// <summary>
    /// Gets a value indicating whether to force content to be generated even if it would overwrite existing files.
    /// </summary>
    [CmdOption("--force")]
    [CmdOptionOrder(2)]
    public bool Force { get; init; }

    /// <summary>
    /// Gets the programming language of the template to create.
    /// </summary>
    [CmdOption("-lang|--language")]
    [CmdOptionOrder(3)]
    [CmdOptionValues(["C#", "F#", "VB"])]
    public string? Language { get; init; }

    /// <summary>
    /// Gets the name for the output being created. If not specified, the name of the current directory is used.
    /// </summary>
    [CmdOption("-n|--name")]
    [CmdOptionOrder(4)]
    public string? OutputName { get; init; }

    /// <summary>
    /// Gets a value indicating whether to skip the automatic check for template updates.
    /// </summary>
    [CmdOption("--no-update-check")]
    [CmdOptionOrder(6)]
    public bool NoUpdateCheck { get; init; }

    /// <summary>
    /// Gets the output directory where the generated artifacts should be placed.
    /// </summary>
    [CmdOption("-o|--output")]
    [CmdOptionOrder(7)]
    public string? OutputDirectory { get; init; }

    /// <summary>
    /// Gets the path to the project file to consider for additional configuration options.
    /// </summary>
    [CmdOption("--project")]
    [CmdOptionOrder(8)]
    public string? ProjectPath { get; init; }

    /// <summary>
    /// Gets a value indicating whether to enable diagnostic output for the command.
    /// </summary>
    [CmdOption("--diagnostics")]
    [CmdOptionOrder(9)]
    public bool Diagnostics { get; init; }

    /// <summary>
    /// Gets the verbosity level of the command's output.
    /// </summary>
    [CmdOption("--verbosity")]
    [CmdOptionOrder(10)]
    [CmdOptionValues(["quiet", "minimal", "normal", "diagnostic"])]
    public string? Verbosity { get; init; }
}

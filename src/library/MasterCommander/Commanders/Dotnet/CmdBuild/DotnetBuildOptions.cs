// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet.CmdBuild;

/// <summary>
/// Represents the options available for the dotnet build command.
/// </summary>
public record DotnetBuildOptions()
    : DotnetCommandOptionsBase("build")
{
    /// <summary>
    /// Gets a value indicating whether to disable the use of build servers.
    /// </summary>
    [CmdOption("--disable-build-servers")]
    [CmdOptionOrder(100)]
    public bool DisableBuildServers { get; init; }

    /// <summary>
    /// Gets a value indicating whether to disable incremental build.
    /// </summary>
    [CmdOption("--no-incremental")]
    [CmdOptionOrder(101)]
    public bool NoIncremental { get; init; }

    /// <summary>
    /// Gets a value indicating whether to build the project without producing a self-contained application.
    /// </summary>
    [CmdOption("--no-self-contained")]
    [CmdOptionOrder(103)]
    public bool NoSelfContained { get; init; }

    /// <summary>
    /// Gets or initializes the output directory for the build.
    /// </summary>
    [CmdOption("-o|--output")]
    [CmdOptionOrder(104)]
    public string? OutputDirectory { get; init; }

    /// <summary>
    /// Gets or initializes the additional properties for the build command.
    /// </summary>
    [CmdOption("-p|--property")]
    [CmdOptionOrder(105)]
    public string? Property { get; init; }

    /// <summary>
    /// Gets a value indicating whether to produce a self-contained application.
    /// </summary>
    [CmdOption("--self-contained")]
    [CmdOptionOrder(106)]
    public bool SelfContained { get; init; }

    /// <summary>
    /// Gets or initializes the source for the build.
    /// </summary>
    [CmdOption("--source")]
    [CmdOptionOrder(107)]
    public string? Source { get; init; }

    /// <summary>
    /// Gets a value indicating whether to use the current runtime for the build.
    /// </summary>
    [CmdOption("--use-current-runtime")]
    [CmdOptionOrder(108)]
    public bool UseCurrentRuntime { get; init; }

    /// <summary>
    /// Gets or initializes the version suffix for the build output.
    /// </summary>
    [CmdOption("--version-suffix")]
    [CmdOptionOrder(109)]
    public string? VersionSuffix { get; init; }
}

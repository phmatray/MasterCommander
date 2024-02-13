// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Git.CmdAdd;

/// <summary>
/// Represents the options available for the git add command.
/// </summary>
public record GitAddOptions()
    : CmdOptionsBase("add")
{
    /// <summary>
    /// Gets a value indicating whether be verbose.
    /// </summary>
    [CmdOption("-v|--verbose")]
    [CmdOptionOrder(1)]
    public bool Verbose { get; init; }

    /// <summary>
    /// Gets a value indicating whether to not actually add the file(s), just show if they exist and/or will be ignored.
    /// </summary>
    [CmdOption("-n|--dry-run")]
    [CmdOptionOrder(2)]
    public bool DryRun { get; init; }

    /// <summary>
    /// Gets a value indicating whether to allow adding otherwise ignored files.
    /// </summary>
    [CmdOption("-f|--force")]
    [CmdOptionOrder(3)]
    public bool Force { get; init; }

    /// <summary>
    /// Gets a value indicating whether to update the index just where it already has an entry matching pathspec.
    /// </summary>
    [CmdOption("-u|--update")]
    [CmdOptionOrder(7)]
    public bool Update { get; init; }
}

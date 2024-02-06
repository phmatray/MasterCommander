// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet.CmdNew.Options;

/// <summary>
/// Options for creating a new .editorconfig file.
/// </summary>
public record DotnetNewEditorConfigOptions()
    : DotnetNewOptions("editorconfig")
{
    /// <summary>
    /// Gets a value indicating whether to create an empty .editorconfig file.
    /// </summary>
    [CmdOption("--empty")]
    [CmdOptionOrder(11)]
    public bool Empty { get; init; }
}

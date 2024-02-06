// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using MasterCommander.Commanders.Dotnet.CmdNew.Abstractions;

namespace MasterCommander.Commanders.Dotnet.CmdNew.Options;

/// <summary>
/// Options for creating a new .NET class library project with specific configurations.
/// </summary>
/// <param name="Template">The template to use, defaults to "classlib" if not specified.</param>
public record DotnetNewClassLibraryOptions(string? Template = null)
    : DotnetNewOptions(Template ?? "classlib"),
        IHasFramework, IHasLangVersion, IHasNoRestore
{
    /// <inheritdoc />
    [CmdOption("-f|--framework")]
    [CmdOptionOrder(11)]
    public string? Framework { get; init; }

    /// <inheritdoc />
    [CmdOption("--lang-version")]
    [CmdOptionOrder(12)]
    public string? LangVersion { get; init; }

    /// <inheritdoc />
    [CmdOption("--no-restore")]
    [CmdOptionOrder(13)]
    public bool NoRestore { get; init; }
}

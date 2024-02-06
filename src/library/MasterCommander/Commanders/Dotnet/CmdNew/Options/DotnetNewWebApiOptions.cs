// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using MasterCommander.Commanders.Dotnet.CmdNew.Abstractions;

namespace MasterCommander.Commanders.Dotnet.CmdNew.Options;

/// <summary>
/// Options for creating a new web API project.
/// </summary>
public record DotnetNewWebApiOptions()
    : DotnetNewClassLibraryOptions("webapi"),
        IHasUseProgramMain
{
    /// <inheritdoc />
    [CmdOption("--use-program-main")]
    [CmdOptionOrder(14)]
    public bool UseProgramMain { get; init; }
}

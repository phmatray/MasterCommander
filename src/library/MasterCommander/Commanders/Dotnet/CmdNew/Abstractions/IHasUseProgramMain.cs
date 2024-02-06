// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet.CmdNew.Abstractions;

/// <summary>
/// Defines a contract for objects that can specify whether to use a Program.Main entry point.
/// </summary>
public interface IHasUseProgramMain
{
    /// <summary>
    /// Gets a value indicating whether to use a Program.Main entry point.
    /// </summary>
    bool UseProgramMain { get; init; }
}

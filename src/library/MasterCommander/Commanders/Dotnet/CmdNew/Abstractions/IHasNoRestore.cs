// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet.CmdNew.Abstractions;

/// <summary>
/// Defines a contract for objects that can specify whether to skip the restore process.
/// </summary>
public interface IHasNoRestore
{
    /// <summary>
    /// Gets a value indicating whether to skip the automatic restore when the project is created.
    /// </summary>
    bool NoRestore { get; init; }
}

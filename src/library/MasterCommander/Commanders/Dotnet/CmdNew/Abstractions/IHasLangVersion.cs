// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet.CmdNew.Abstractions;

/// <summary>
/// Defines a contract for objects that specify a language version.
/// </summary>
public interface IHasLangVersion
{
    /// <summary>
    /// Gets the language version to use for the class library.
    /// </summary>
    string? LangVersion { get; init; }
}

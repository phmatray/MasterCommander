// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet.CmdNew.Abstractions;

/// <summary>
/// Defines a contract for objects that specify a target framework.
/// </summary>
public interface IHasFramework
{
    /// <summary>
    /// Gets the target framework for the class library.
    /// </summary>
    string? Framework { get; init; }
}

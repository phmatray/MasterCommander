// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.Services;

/// <summary>
/// Defines the interface for initializing projects, specifically for creating new console projects.
/// </summary>
public interface IProjectInitializationService
{
    /// <summary>
    /// Initializes a new console project asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation of initializing a new console project.</returns>
    Task InitializeConsoleProjectAsync();
}

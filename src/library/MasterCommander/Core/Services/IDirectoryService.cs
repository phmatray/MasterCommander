// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.Services;

/// <summary>
/// Defines the interface for directory-related operations.
/// </summary>
public interface IDirectoryService
{
    /// <summary>
    /// Gets the path of the home directory for the current user.
    /// </summary>
    /// <returns>The path of the home directory.</returns>
    string GetHomeDirectory();

    /// <summary>
    /// Creates a new directory within a specified base directory.
    /// </summary>
    /// <param name="baseDirectory">The base directory where the new directory will be created.</param>
    /// <param name="newDirectoryName">The name of the new directory to create.</param>
    /// <param name="overwrite">A value indicating whether an existing directory should be overwritten.</param>
    /// <returns>The path of the newly created directory.</returns>
    string CreateNewDirectory(string baseDirectory, string newDirectoryName, bool overwrite = false);

    /// <summary>
    /// Clears the contents of a specified directory.
    /// </summary>
    /// <param name="directoryPath">The path of the directory to clear.</param>
    void ClearDirectory(string directoryPath);
}

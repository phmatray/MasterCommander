// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
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
    /// <value>The path of the home directory.</value>
    string HomeDirectory { get; }

    /// <summary>
    /// Gets the path of the directory where MasterCommander stores its working files.
    /// </summary>
    /// <value>The path of the MasterCommander directory.</value>
    string MasterCommanderDirectory { get; }

    /// <summary>
    /// Gets the working directory. This is the directory where commands will be executed.
    /// </summary>
    /// <value>The working directory.</value>
    string? WorkingDirectory { get; }

    /// <summary>
    /// Sets the working directory to the directory where the specified solution is located.
    /// </summary>
    /// <param name="relativePath">The relative path from the MasterCommander directory to the solution directory.</param>
    void SetWorkingDirectory(string relativePath);

    /// <summary>
    /// Sets the working directory to the directory where the specified solution is located.
    /// </summary>
    /// <param name="relativePath">The relative path from the MasterCommander directory to the solution directory.</param>
    /// <param name="createIfNotExists">A value indicating whether the directory should be created if it does not exist.</param>
    void SetWorkingDirectory(string relativePath, bool createIfNotExists);

    /// <summary>
    /// Creates a new directory within a specified base directory.
    /// </summary>
    /// <param name="baseDirectory">The base directory where the new directory will be created.</param>
    /// <param name="newDirectoryName">The name of the new directory to create.</param>
    /// <returns>The path of the newly created directory.</returns>
    string CreateNewDirectory(string baseDirectory, string newDirectoryName);

    /// <summary>
    /// Creates a new directory within a specified base directory.
    /// </summary>
    /// <param name="baseDirectory">The base directory where the new directory will be created.</param>
    /// <param name="newDirectoryName">The name of the new directory to create.</param>
    /// <param name="overwrite">A value indicating whether an existing directory should be overwritten.</param>
    /// <returns>The path of the newly created directory.</returns>
    string CreateNewDirectory(string baseDirectory, string newDirectoryName, bool overwrite);

    /// <summary>
    /// Clears the contents of a specified directory.
    /// </summary>
    /// <param name="directoryPath">The path of the directory to clear.</param>
    void ClearDirectory(string directoryPath);

    /// <summary>
    /// Calculates the total size of a directory, including all its files and subdirectories.
    /// </summary>
    /// <param name="directoryPath">The path of the directory for which to calculate the size.</param>
    /// <returns>The total size of the directory in bytes.</returns>
    long CalculateDirectorySize(string directoryPath);

    /// <summary>
    /// Creates a temporary directory for use during application execution, which can optionally be cleaned up afterwards.
    /// </summary>
    /// <returns>The path to the newly created temporary directory.</returns>
    string CreateTemporaryDirectory();

    /// <summary>
    /// Monitors a directory for any changes, such as file or subdirectory creation, deletion, or modification, and triggers a callback action when a change is detected.
    /// </summary>
    /// <param name="directoryPath">The path of the directory to watch.</param>
    /// <param name="onChangeCallback">The callback action to trigger upon detecting a directory change.</param>
    void WatchDirectory(string directoryPath, Action<FileSystemEventArgs> onChangeCallback);

    /// <summary>
    /// Compresses the specified directory into a ZIP file, including all its files and subdirectories.
    /// </summary>
    /// <param name="directoryPath">The path of the directory to compress.</param>
    /// <param name="zipFilePath">The path where the resulting ZIP file should be saved.</param>
    void CompressDirectory(string directoryPath, string zipFilePath);

    /// <summary>
    /// Decompresses a ZIP file into a specified directory, extracting all its contents.
    /// </summary>
    /// <param name="zipFilePath">The path of the ZIP file to decompress.</param>
    /// <param name="directoryPath">The target directory path where the contents of the ZIP file will be extracted.</param>
    void DecompressToDirectory(string zipFilePath, string directoryPath);
}

// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Integrations;

/// <summary>
/// Provides functionality for directory-related operations.
/// </summary>
public class DirectoryService : IDirectoryService
{
    /// <inheritdoc />
    public string GetHomeDirectory()
    {
        return Environment.GetEnvironmentVariable("HOME")
               ?? Environment.GetEnvironmentVariable("USERPROFILE")
               ?? throw new Exception("Could not find home directory");
    }

    /// <inheritdoc />
    public string CreateNewDirectory(string baseDirectory, string newDirectoryName, bool overwrite = false)
    {
        var workingDirectory = Path.Combine(baseDirectory, newDirectoryName);
        if (!Directory.Exists(workingDirectory))
        {
            Directory.CreateDirectory(workingDirectory);
        }
        else if (overwrite)
        {
            ClearDirectory(workingDirectory);
        }

        return workingDirectory;
    }

    /// <inheritdoc />
    public void ClearDirectory(string directoryPath)
    {
        DirectoryInfo directoryInfo = new(directoryPath);
        foreach (var file in directoryInfo.GetFiles())
        {
            file.Delete();
        }

        foreach (var dir in directoryInfo.GetDirectories())
        {
            dir.Delete(true);
        }
    }
}

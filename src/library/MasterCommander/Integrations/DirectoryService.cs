// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.IO.Compression;

namespace MasterCommander.Integrations;

/// <summary>
/// Provides functionality for directory-related operations.
/// </summary>
public class DirectoryService : IDirectoryService
{
    private const string WorkingDirectoryName = "MasterCommander";
    private const string HomeEnvironmentVariable = "HOME";
    private const string UserProfileEnvironmentVariable = "USERPROFILE";

    /// <summary>
    /// Initializes a new instance of the <see cref="DirectoryService"/> class.
    /// </summary>
    public DirectoryService()
    {
        HomeDirectory =
            Environment.GetEnvironmentVariable(HomeEnvironmentVariable)
            ?? Environment.GetEnvironmentVariable(UserProfileEnvironmentVariable)
            ?? throw new InvalidOperationException("The home directory could not be determined.");

        WorkingDirectory = CreateNewDirectory(HomeDirectory, WorkingDirectoryName, true);
    }

    /// <inheritdoc />
    public string HomeDirectory { get; }

    /// <inheritdoc />
    public string WorkingDirectory { get; }

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

    /// <inheritdoc />
    public long CalculateDirectorySize(string directoryPath)
    {
        DirectoryInfo directoryInfo = new(directoryPath);
        return directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length);
    }

    /// <inheritdoc />
    public string CreateTemporaryDirectory()
    {
        var tempDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(tempDirectoryPath);
        return tempDirectoryPath;
    }

    /// <inheritdoc />
    public void WatchDirectory(string directoryPath, Action<FileSystemEventArgs> onChangeCallback)
    {
        var watcher = new FileSystemWatcher(directoryPath)
        {
            NotifyFilter = NotifyFilters.LastAccess
                           | NotifyFilters.LastWrite
                           | NotifyFilters.FileName
                           | NotifyFilters.DirectoryName,
            IncludeSubdirectories = true,
            EnableRaisingEvents = true
        };

        watcher.Changed += (sender, e) => onChangeCallback(e);
        watcher.Created += (sender, e) => onChangeCallback(e);
        watcher.Deleted += (sender, e) => onChangeCallback(e);
        watcher.Renamed += (sender, e) => onChangeCallback(e);
    }

    /// <inheritdoc />
    public void CompressDirectory(string directoryPath, string zipFilePath)
    {
        ZipFile.CreateFromDirectory(directoryPath, zipFilePath);
    }

    /// <inheritdoc />
    public void DecompressToDirectory(string zipFilePath, string directoryPath)
    {
        ZipFile.ExtractToDirectory(zipFilePath, directoryPath);
    }
}

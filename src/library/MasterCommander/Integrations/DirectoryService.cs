// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Diagnostics;
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

    private readonly IConsole _console;

    /// <summary>
    /// Initializes a new instance of the <see cref="DirectoryService"/> class.
    /// </summary>
    /// <param name="console">The console service.</param>
    public DirectoryService(IConsole console)
    {
        _console = console;

        HomeDirectory =
            Environment.GetEnvironmentVariable(HomeEnvironmentVariable)
            ?? Environment.GetEnvironmentVariable(UserProfileEnvironmentVariable)
            ?? throw new InvalidOperationException("The home directory could not be determined.");

        MasterCommanderDirectory = CreateNewDirectory(HomeDirectory, WorkingDirectoryName, true);
    }

    /// <inheritdoc />
    public string HomeDirectory { get; }

    /// <inheritdoc />
    public string MasterCommanderDirectory { get; }

    /// <inheritdoc />
    public string? WorkingDirectory { get; set; }

    /// <inheritdoc />
    public void SetWorkingDirectory(string relativePath, bool createIfNotExists = false)
    {
        WorkingDirectory = createIfNotExists
            ? CreateNewDirectory(MasterCommanderDirectory, relativePath, true)
            : Path.Combine(MasterCommanderDirectory, relativePath);
    }

    /// <inheritdoc />
    public string CreateNewDirectory(string baseDirectory, string newDirectoryName, bool overwrite = false)
    {
        var newDirectory = Path.Combine(baseDirectory, newDirectoryName);

        if (!Directory.Exists(newDirectory))
        {
            Directory.CreateDirectory(newDirectory);
        }
        else if (overwrite)
        {
            ClearDirectory(newDirectory);
        }

        return newDirectory;
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
        ExecuteDirectoryOperation(
            () => ZipFile.CreateFromDirectory(directoryPath, zipFilePath),
            $"Compressing directory {directoryPath} to {zipFilePath}...");
    }

    /// <inheritdoc />
    public void DecompressToDirectory(string zipFilePath, string directoryPath)
    {
        ExecuteDirectoryOperation(
            () => ZipFile.ExtractToDirectory(zipFilePath, directoryPath),
            $"Decompressing directory {zipFilePath} to {directoryPath}...");
    }

    private void ExecuteDirectoryOperation(Action operation, string actionMessage)
    {
        try
        {
            _console.WriteAction("Directory operation", actionMessage);
            var stopWatch = Stopwatch.StartNew();
            operation.Invoke();
            stopWatch.Stop();
            _console.WriteElapsedConsoleEvent(new ExecutionTimeConsoleEvent(stopWatch.Elapsed));
        }
        catch (Exception e)
        {
            _console.WriteStandardErrorConsoleEvent(new StandardErrorConsoleEvent(e.Message));
            throw; // Consider enriching the exception or handling specific cases.
        }
    }
}

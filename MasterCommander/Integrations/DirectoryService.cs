namespace MasterCommander.Integrations;

public class DirectoryService : IDirectoryService
{
    public string GetHomeDirectory()
    {
        return 
            Environment.GetEnvironmentVariable("HOME") 
            ?? Environment.GetEnvironmentVariable("USERPROFILE") 
            ?? throw new Exception("Could not find home directory");
    }

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

    public void ClearDirectory(string directoryPath)
    {
        DirectoryInfo directoryInfo = new(directoryPath);
        foreach (var file in directoryInfo.GetFiles()) file.Delete();
        foreach (var dir in directoryInfo.GetDirectories()) dir.Delete(true);
    }
}
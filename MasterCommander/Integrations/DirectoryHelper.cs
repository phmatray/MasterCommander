namespace MasterCommander.Integrations;

public static class DirectoryHelper
{
    // Method to get the home directory
    public static string GetHomeDirectory()
    {
        return 
            GetEnvironmentVariable("HOME") 
            ?? GetEnvironmentVariable("USERPROFILE") 
            ?? throw new Exception("Could not find home directory");
    }

    // Method to create a new directory
    public static string CreateNewDirectory(string baseDirectory, string newDirectoryName, bool overwrite = false)
    {
        var workingDirectory = Path.Combine(baseDirectory, newDirectoryName);
        Directory.CreateDirectory(workingDirectory);
        
        if (overwrite)
        {
            ClearDirectory(workingDirectory);
        }
        
        return workingDirectory;
    }

    // Method to clear the directory
    public static void ClearDirectory(string directoryPath)
    {
        DirectoryInfo directoryInfo = new(directoryPath);
        foreach (var file in directoryInfo.GetFiles()) file.Delete();
        foreach (var dir in directoryInfo.GetDirectories()) dir.Delete(true);
    }
}

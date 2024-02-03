namespace MasterCommander.Core.Services;

public interface IDirectoryService
{
    string GetHomeDirectory();
    string CreateNewDirectory(string baseDirectory, string newDirectoryName, bool overwrite = false);
    void ClearDirectory(string directoryPath);
}
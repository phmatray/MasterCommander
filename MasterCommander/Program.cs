WriteLine("MasterCommander");
WriteLine("--------------\n");

// get home directory
string homeDirectory = 
    GetEnvironmentVariable("HOME")
    ?? GetEnvironmentVariable("USERPROFILE")
    ?? throw new Exception("Could not find home directory");

// create a new directory
string workingDirectory = Path.Combine(homeDirectory, "MasterCommander");
Directory.CreateDirectory(workingDirectory);

// initialize a new Git repository
StandardConsole standardConsole = new();
GitCommandFactory gitCommandFactory = new(workingDirectory);
GitService git = new(gitCommandFactory, standardConsole);

await git.InitAsync();
await git.StatusAsync();

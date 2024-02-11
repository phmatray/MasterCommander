#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.md#MasterCommander.Commanders.Git 'MasterCommander.Commanders.Git').[IGitCommandFactory](IGitCommandFactory.md 'MasterCommander.Commanders.Git.IGitCommandFactory')

## IGitCommandFactory.CreateCommandCloneRepository(string, string) Method

Creates a command for cloning a remote repository into a local directory.

```csharp
CliWrap.Command CreateCommandCloneRepository(string repositoryUrl, string localPath);
```
#### Parameters

<a name='MasterCommander.Commanders.Git.IGitCommandFactory.CreateCommandCloneRepository(string,string).repositoryUrl'></a>

`repositoryUrl` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The URL of the remote repository to clone.

<a name='MasterCommander.Commanders.Git.IGitCommandFactory.CreateCommandCloneRepository(string,string).localPath'></a>

`localPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The local directory path where the repository should be cloned.

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to clone the repository.
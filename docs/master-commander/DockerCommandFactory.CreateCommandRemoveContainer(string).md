#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander\.Commanders\.Docker').[DockerCommandFactory](DockerCommandFactory.md 'MasterCommander\.Commanders\.Docker\.DockerCommandFactory')

## DockerCommandFactory\.CreateCommandRemoveContainer\(string\) Method

Creates a command to remove a Docker container\.

```csharp
public CliWrap.Command CreateCommandRemoveContainer(string containerName);
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.DockerCommandFactory.CreateCommandRemoveContainer(string).containerName'></a>

`containerName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the container to remove\.

Implements [CreateCommandRemoveContainer\(string\)](IDockerCommandFactory.CreateCommandRemoveContainer(string).md 'MasterCommander\.Commanders\.Docker\.IDockerCommandFactory\.CreateCommandRemoveContainer\(string\)')

#### Returns
[CliWrap\.Command](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.command 'CliWrap\.Command')  
A command to remove a Docker container\.
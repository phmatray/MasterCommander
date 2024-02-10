#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.Commanders.Docker.md 'MasterCommander.Commanders.Docker').[DockerCommandFactory](DockerCommandFactory.md 'MasterCommander.Commanders.Docker.DockerCommandFactory')

## DockerCommandFactory.CreateCommandRemoveContainer(string) Method

Creates a command to remove a Docker container.

```csharp
public CliWrap.Command CreateCommandRemoveContainer(string containerName);
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.DockerCommandFactory.CreateCommandRemoveContainer(string).containerName'></a>

`containerName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the container to remove.

Implements [CreateCommandRemoveContainer(string)](IDockerCommandFactory.CreateCommandRemoveContainer(string).md 'MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandRemoveContainer(string)')

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to remove a Docker container.
#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.Commanders.Docker.md 'MasterCommander.Commanders.Docker').[DockerCommandFactory](DockerCommandFactory.md 'MasterCommander.Commanders.Docker.DockerCommandFactory')

## DockerCommandFactory.CreateCommandStop(string) Method

Creates a command to stop a running Docker container.

```csharp
public CliWrap.Command CreateCommandStop(string containerName);
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.DockerCommandFactory.CreateCommandStop(string).containerName'></a>

`containerName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the container to stop.

Implements [CreateCommandStop(string)](IDockerCommandFactory.CreateCommandStop(string).md 'MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandStop(string)')

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to stop a Docker container.
#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.Commanders.Docker.md 'MasterCommander.Commanders.Docker').[DockerCommandFactory](DockerCommandFactory.md 'MasterCommander.Commanders.Docker.DockerCommandFactory')

## DockerCommandFactory.CreateCommandRun(string, string) Method

Creates a command to run a Docker container from an image.

```csharp
public CliWrap.Command CreateCommandRun(string image, string? containerName=null);
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.DockerCommandFactory.CreateCommandRun(string,string).image'></a>

`image` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The Docker image to run.

<a name='MasterCommander.Commanders.Docker.DockerCommandFactory.CreateCommandRun(string,string).containerName'></a>

`containerName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Optional name for the container.

Implements [CreateCommandRun(string, string)](IDockerCommandFactory.CreateCommandRun(string,string).md 'MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandRun(string, string)')

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to run a Docker container.
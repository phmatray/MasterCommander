#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.Commanders.Docker.md 'MasterCommander.Commanders.Docker').[IDockerCommandFactory](IDockerCommandFactory.md 'MasterCommander.Commanders.Docker.IDockerCommandFactory')

## IDockerCommandFactory.CreateCommandRun(string, string) Method

Creates a command to run a Docker container from an image.

```csharp
CliWrap.Command CreateCommandRun(string image, string? containerName=null);
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandRun(string,string).image'></a>

`image` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The Docker image to run.

<a name='MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandRun(string,string).containerName'></a>

`containerName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Optional name for the container.

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to run a Docker container.
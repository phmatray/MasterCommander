#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander.Commanders.Docker').[IDockerCommandFactory](IDockerCommandFactory.md 'MasterCommander.Commanders.Docker.IDockerCommandFactory')

## IDockerCommandFactory.CreateCommandBuild(string, string) Method

Creates a command to build a Docker image from a Dockerfile.

```csharp
CliWrap.Command CreateCommandBuild(string dockerfilePath, string tag);
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandBuild(string,string).dockerfilePath'></a>

`dockerfilePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path to the Dockerfile.

<a name='MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandBuild(string,string).tag'></a>

`tag` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The tag to assign to the built image.

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to build a Docker image.
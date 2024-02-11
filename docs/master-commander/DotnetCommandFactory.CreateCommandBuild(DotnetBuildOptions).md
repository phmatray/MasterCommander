#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.md#MasterCommander.Commanders.Dotnet 'MasterCommander.Commanders.Dotnet').[DotnetCommandFactory](DotnetCommandFactory.md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory')

## DotnetCommandFactory.CreateCommandBuild(DotnetBuildOptions) Method

Creates a new command to build a .NET project.

```csharp
public CliWrap.Command CreateCommandBuild(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions options);
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.DotnetCommandFactory.CreateCommandBuild(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions).options'></a>

`options` [DotnetBuildOptions](DotnetBuildOptions.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions')

The options for building the .NET project.

Implements [CreateCommandBuild(DotnetBuildOptions)](IDotnetCommandFactory.CreateCommandBuild(DotnetBuildOptions).md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandBuild(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions)')

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to build a .NET project.
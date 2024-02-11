#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet.CmdRun](MasterCommander.md#MasterCommander.Commanders.Dotnet.CmdRun 'MasterCommander.Commanders.Dotnet.CmdRun')

## DotnetRunOptions Class

Represents options for the 'dotnet run' command, which runs a .NET project in the context of the project's directory or using specified options.

```csharp
public class DotnetRunOptions : MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase,
System.IEquatable<MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CmdOptionsBase](CmdOptionsBase.md 'MasterCommander.Core.CmdOptionsBase') &#129106; [DotnetCommandOptionsBase](DotnetCommandOptionsBase.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase') &#129106; DotnetRunOptions

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[DotnetRunOptions](DotnetRunOptions.md 'MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [DotnetRunOptions()](DotnetRunOptions.DotnetRunOptions().md 'MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions.DotnetRunOptions()') | Represents options for the 'dotnet run' command, which runs a .NET project in the context of the project's directory or using specified options. |

| Properties | |
| :--- | :--- |
| [ApplicationArguments](DotnetRunOptions.ApplicationArguments.md 'MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions.ApplicationArguments') | Gets additional arguments to pass to the application being run. |
| [LaunchProfile](DotnetRunOptions.LaunchProfile.md 'MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions.LaunchProfile') | Gets the name of the launch profile to use from the launchSettings.json configuration file. |
| [NoBuild](DotnetRunOptions.NoBuild.md 'MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions.NoBuild') | Gets a value indicating whether to skip building the project before running. |
| [NoLaunchProfile](DotnetRunOptions.NoLaunchProfile.md 'MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions.NoLaunchProfile') | Gets a value indicating whether to run the project without using any launch profile. |
| [Project](DotnetRunOptions.Project.md 'MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions.Project') | Gets the path to the project file to run. If not specified, the command will search the current directory for a project file. |

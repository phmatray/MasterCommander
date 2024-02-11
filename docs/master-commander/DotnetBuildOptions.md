#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet.CmdBuild](MasterCommander.md#MasterCommander.Commanders.Dotnet.CmdBuild 'MasterCommander.Commanders.Dotnet.CmdBuild')

## DotnetBuildOptions Class

Represents the options available for the dotnet build command.

```csharp
public class DotnetBuildOptions : MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase,
System.IEquatable<MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CmdOptionsBase](CmdOptionsBase.md 'MasterCommander.Core.CmdOptionsBase') &#129106; [DotnetCommandOptionsBase](DotnetCommandOptionsBase.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase') &#129106; DotnetBuildOptions

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[DotnetBuildOptions](DotnetBuildOptions.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [DotnetBuildOptions()](DotnetBuildOptions.DotnetBuildOptions().md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions.DotnetBuildOptions()') | Represents the options available for the dotnet build command. |

| Properties | |
| :--- | :--- |
| [DisableBuildServers](DotnetBuildOptions.DisableBuildServers.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions.DisableBuildServers') | Gets a value indicating whether to disable the use of build servers. |
| [NoIncremental](DotnetBuildOptions.NoIncremental.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions.NoIncremental') | Gets a value indicating whether to disable incremental build. |
| [NoSelfContained](DotnetBuildOptions.NoSelfContained.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions.NoSelfContained') | Gets a value indicating whether to build the project without producing a self-contained application. |
| [OutputDirectory](DotnetBuildOptions.OutputDirectory.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions.OutputDirectory') | Gets or initializes the output directory for the build. |
| [Property](DotnetBuildOptions.Property.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions.Property') | Gets or initializes the additional properties for the build command. |
| [SelfContained](DotnetBuildOptions.SelfContained.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions.SelfContained') | Gets a value indicating whether to produce a self-contained application. |
| [Source](DotnetBuildOptions.Source.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions.Source') | Gets or initializes the source for the build. |
| [UseCurrentRuntime](DotnetBuildOptions.UseCurrentRuntime.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions.UseCurrentRuntime') | Gets a value indicating whether to use the current runtime for the build. |
| [VersionSuffix](DotnetBuildOptions.VersionSuffix.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions.VersionSuffix') | Gets or initializes the version suffix for the build output. |

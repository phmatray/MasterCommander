#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.md#MasterCommander.Commanders.Dotnet 'MasterCommander.Commanders.Dotnet')

## DotnetCommandOptionsBase Class

Base record for .NET command options, providing common options applicable to various .NET CLI commands.

```csharp
public abstract class DotnetCommandOptionsBase : MasterCommander.Core.CmdOptionsBase,
System.IEquatable<MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CmdOptionsBase](CmdOptionsBase.md 'MasterCommander.Core.CmdOptionsBase') &#129106; DotnetCommandOptionsBase

Derived  
&#8627; [DotnetBuildOptions](DotnetBuildOptions.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions')  
&#8627; [DotnetRunOptions](DotnetRunOptions.md 'MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[DotnetCommandOptionsBase](DotnetCommandOptionsBase.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [DotnetCommandOptionsBase(string)](DotnetCommandOptionsBase.DotnetCommandOptionsBase(string).md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.DotnetCommandOptionsBase(string)') | Base record for .NET command options, providing common options applicable to various .NET CLI commands. |

| Properties | |
| :--- | :--- |
| [Architecture](DotnetCommandOptionsBase.Architecture.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.Architecture') | Gets or initializes the architecture option for the command. |
| [Command](DotnetCommandOptionsBase.Command.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.Command') | The command to execute. |
| [Configuration](DotnetCommandOptionsBase.Configuration.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.Configuration') | Gets or initializes the configuration option for the command, such as Debug or Release. |
| [Force](DotnetCommandOptionsBase.Force.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.Force') | Gets a value indicating whether the command should force the execution without prompt. |
| [Framework](DotnetCommandOptionsBase.Framework.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.Framework') | Gets or initializes the target framework for the command. |
| [Interactive](DotnetCommandOptionsBase.Interactive.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.Interactive') | Gets a value indicating whether the command should run in interactive mode. |
| [NoDependencies](DotnetCommandOptionsBase.NoDependencies.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.NoDependencies') | Gets a value indicating whether the command should ignore project-to-project references. |
| [NoRestore](DotnetCommandOptionsBase.NoRestore.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.NoRestore') | Gets a value indicating whether the command should not restore dependencies. |
| [OS](DotnetCommandOptionsBase.OS.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.OS') | Gets or initializes the operating system option for the command. |
| [RuntimeIdentifier](DotnetCommandOptionsBase.RuntimeIdentifier.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.RuntimeIdentifier') | Gets or initializes the runtime identifier for the command, specifying the target runtime. |
| [TerminalLogger](DotnetCommandOptionsBase.TerminalLogger.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.TerminalLogger') | Gets or initializes the terminal logger option with values like auto, on, or off. |
| [VerbosityLevel](DotnetCommandOptionsBase.VerbosityLevel.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase.VerbosityLevel') | Gets or initializes the verbosity level of the command's output. |

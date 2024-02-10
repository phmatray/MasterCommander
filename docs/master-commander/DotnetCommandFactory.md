#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.Commanders.Dotnet.md 'MasterCommander.Commanders.Dotnet')

## DotnetCommandFactory Class

A factory for creating .NET command instances.

```csharp
public class DotnetCommandFactory : MasterCommander.Integrations.Processes.CommandBuilder,
MasterCommander.Commanders.Dotnet.IDotnetCommandFactory
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommandBuilder](CommandBuilder.md 'MasterCommander.Integrations.Processes.CommandBuilder') &#129106; DotnetCommandFactory

Implements [IDotnetCommandFactory](IDotnetCommandFactory.md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory')

| Constructors | |
| :--- | :--- |
| [DotnetCommandFactory(IDirectoryService)](DotnetCommandFactory.DotnetCommandFactory(IDirectoryService).md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory.DotnetCommandFactory(MasterCommander.Core.Services.IDirectoryService)') | A factory for creating .NET command instances. |

| Properties | |
| :--- | :--- |
| [ExecutablePath](DotnetCommandFactory.ExecutablePath.md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory.ExecutablePath') | Gets the path to the executable that the command will run. |

| Methods | |
| :--- | :--- |
| [CreateCommandBuild(DotnetBuildOptions)](DotnetCommandFactory.CreateCommandBuild(DotnetBuildOptions).md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory.CreateCommandBuild(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions)') | Creates a new command to build a .NET project. |
| [CreateCommandNew(DotnetNewOptions)](DotnetCommandFactory.CreateCommandNew(DotnetNewOptions).md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory.CreateCommandNew(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions)') | Creates a new command to create a new .NET project or file. |
| [CreateCommandRun(DotnetRunOptions)](DotnetCommandFactory.CreateCommandRun(DotnetRunOptions).md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory.CreateCommandRun(MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions)') | Creates a new command to run a .NET project. |
| [CreateCommandSlnAdd(string)](DotnetCommandFactory.CreateCommandSlnAdd(string).md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory.CreateCommandSlnAdd(string)') | Creates a new command to add a C# project file (.csproj) to a solution (.sln). |
| [CreateCommandTest()](DotnetCommandFactory.CreateCommandTest().md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory.CreateCommandTest()') | Creates a new command to run tests in a .NET project. |

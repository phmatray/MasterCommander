#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.Commanders.Dotnet.md 'MasterCommander.Commanders.Dotnet')

## IDotnetCommandFactory Interface

Defines the interface for creating .NET command instances.

```csharp
public interface IDotnetCommandFactory
```

Derived  
&#8627; [DotnetCommandFactory](DotnetCommandFactory.md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory')

| Methods | |
| :--- | :--- |
| [CreateCommandBuild(DotnetBuildOptions)](IDotnetCommandFactory.CreateCommandBuild(DotnetBuildOptions).md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandBuild(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions)') | Creates a new command to build a .NET project. |
| [CreateCommandNew(DotnetNewOptions)](IDotnetCommandFactory.CreateCommandNew(DotnetNewOptions).md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandNew(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions)') | Creates a new command to create a new .NET project or file. |
| [CreateCommandRun(DotnetRunOptions)](IDotnetCommandFactory.CreateCommandRun(DotnetRunOptions).md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandRun(MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions)') | Creates a new command to run a .NET project. |
| [CreateCommandSlnAdd(string)](IDotnetCommandFactory.CreateCommandSlnAdd(string).md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandSlnAdd(string)') | Creates a new command to add a C# project file (.csproj) to a solution (.sln). |
| [CreateCommandTest()](IDotnetCommandFactory.CreateCommandTest().md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandTest()') | Creates a new command to run tests in a .NET project. |

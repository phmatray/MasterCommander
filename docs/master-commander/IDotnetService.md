#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.Commanders.Dotnet.md 'MasterCommander.Commanders.Dotnet')

## IDotnetService Interface

Provides an interface for .NET related operations.

```csharp
public interface IDotnetService
```

Derived  
&#8627; [DotnetService](DotnetService.md 'MasterCommander.Commanders.Dotnet.DotnetService')

| Methods | |
| :--- | :--- |
| [BuildAsync(DotnetBuildOptions, CancellationToken)](IDotnetService.BuildAsync(DotnetBuildOptions,CancellationToken).md 'MasterCommander.Commanders.Dotnet.IDotnetService.BuildAsync(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions, System.Threading.CancellationToken)') | Builds the .NET project. |
| [NewAsync(DotnetNewOptions, CancellationToken)](IDotnetService.NewAsync(DotnetNewOptions,CancellationToken).md 'MasterCommander.Commanders.Dotnet.IDotnetService.NewAsync(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions, System.Threading.CancellationToken)') | Creates a new .NET project with the specified template and outputName. |
| [RunAsync(DotnetRunOptions, CancellationToken)](IDotnetService.RunAsync(DotnetRunOptions,CancellationToken).md 'MasterCommander.Commanders.Dotnet.IDotnetService.RunAsync(MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions, System.Threading.CancellationToken)') | Runs the .NET project. |
| [SlnAddAsync(string, CancellationToken)](IDotnetService.SlnAddAsync(string,CancellationToken).md 'MasterCommander.Commanders.Dotnet.IDotnetService.SlnAddAsync(string, System.Threading.CancellationToken)') | Adds the specified .NET project to the solution. |
| [TestAsync(CancellationToken)](IDotnetService.TestAsync(CancellationToken).md 'MasterCommander.Commanders.Dotnet.IDotnetService.TestAsync(System.Threading.CancellationToken)') | Runs the tests in the .NET project. |

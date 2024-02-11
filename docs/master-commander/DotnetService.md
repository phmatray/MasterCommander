#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.md#MasterCommander.Commanders.Dotnet 'MasterCommander.Commanders.Dotnet')

## DotnetService Class

Provides .NET related operations.

```csharp
public class DotnetService : MasterCommander.Integrations.Processes.CommandOutputHandler,
MasterCommander.Commanders.Dotnet.IDotnetService
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommandOutputHandler](CommandOutputHandler.md 'MasterCommander.Integrations.Processes.CommandOutputHandler') &#129106; DotnetService

Implements [IDotnetService](IDotnetService.md 'MasterCommander.Commanders.Dotnet.IDotnetService')

| Constructors | |
| :--- | :--- |
| [DotnetService(IDotnetCommandFactory, IConsole)](DotnetService.DotnetService(IDotnetCommandFactory,IConsole).md 'MasterCommander.Commanders.Dotnet.DotnetService.DotnetService(MasterCommander.Commanders.Dotnet.IDotnetCommandFactory, MasterCommander.Core.Display.IConsole)') | Provides .NET related operations. |

| Methods | |
| :--- | :--- |
| [BuildAsync(DotnetBuildOptions, CancellationToken)](DotnetService.BuildAsync(DotnetBuildOptions,CancellationToken).md 'MasterCommander.Commanders.Dotnet.DotnetService.BuildAsync(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions, System.Threading.CancellationToken)') | Builds the .NET project. |
| [NewAsync(DotnetNewOptions, CancellationToken)](DotnetService.NewAsync(DotnetNewOptions,CancellationToken).md 'MasterCommander.Commanders.Dotnet.DotnetService.NewAsync(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions, System.Threading.CancellationToken)') | Creates a new .NET project with the specified template and outputName. |
| [RunAsync(DotnetRunOptions, CancellationToken)](DotnetService.RunAsync(DotnetRunOptions,CancellationToken).md 'MasterCommander.Commanders.Dotnet.DotnetService.RunAsync(MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions, System.Threading.CancellationToken)') | Runs the .NET project. |
| [SlnAddAsync(string, CancellationToken)](DotnetService.SlnAddAsync(string,CancellationToken).md 'MasterCommander.Commanders.Dotnet.DotnetService.SlnAddAsync(string, System.Threading.CancellationToken)') | Adds the specified .NET project to the solution. |
| [TestAsync(CancellationToken)](DotnetService.TestAsync(CancellationToken).md 'MasterCommander.Commanders.Dotnet.DotnetService.TestAsync(System.Threading.CancellationToken)') | Runs the tests in the .NET project. |

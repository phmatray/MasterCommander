#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Npm](MasterCommander.Commanders.Npm.md 'MasterCommander.Commanders.Npm')

## NpmService Class

Provides npm related operations.

```csharp
public class NpmService : MasterCommander.Integrations.Processes.CommandOutputHandler,
MasterCommander.Commanders.Npm.INpmService
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommandOutputHandler](CommandOutputHandler.md 'MasterCommander.Integrations.Processes.CommandOutputHandler') &#129106; NpmService

Implements [INpmService](INpmService.md 'MasterCommander.Commanders.Npm.INpmService')

| Constructors | |
| :--- | :--- |
| [NpmService(INpmCommandFactory, IConsole)](NpmService.NpmService(INpmCommandFactory,IConsole).md 'MasterCommander.Commanders.Npm.NpmService.NpmService(MasterCommander.Commanders.Npm.INpmCommandFactory, MasterCommander.Core.Display.IConsole)') | Provides npm related operations. |

| Methods | |
| :--- | :--- |
| [InitAsync(CancellationToken)](NpmService.InitAsync(CancellationToken).md 'MasterCommander.Commanders.Npm.NpmService.InitAsync(System.Threading.CancellationToken)') | Initializes a new npm project asynchronously. |
| [InstallAsync(CancellationToken)](NpmService.InstallAsync(CancellationToken).md 'MasterCommander.Commanders.Npm.NpmService.InstallAsync(System.Threading.CancellationToken)') | Installs npm packages for the project asynchronously. |
| [RunScriptAsync(string, CancellationToken)](NpmService.RunScriptAsync(string,CancellationToken).md 'MasterCommander.Commanders.Npm.NpmService.RunScriptAsync(string, System.Threading.CancellationToken)') | Runs a specified script defined in the project's package.json file asynchronously. |
| [StartAsync(CancellationToken)](NpmService.StartAsync(CancellationToken).md 'MasterCommander.Commanders.Npm.NpmService.StartAsync(System.Threading.CancellationToken)') | Starts the npm project asynchronously. |
| [UpdateAsync(CancellationToken)](NpmService.UpdateAsync(CancellationToken).md 'MasterCommander.Commanders.Npm.NpmService.UpdateAsync(System.Threading.CancellationToken)') | Updates npm packages for the project asynchronously. |

#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Npm](MasterCommander.md#MasterCommander.Commanders.Npm 'MasterCommander.Commanders.Npm')

## INpmService Interface

Provides an interface for interacting with npm (Node Package Manager) operations asynchronously.

```csharp
public interface INpmService
```

Derived  
&#8627; [NpmService](NpmService.md 'MasterCommander.Commanders.Npm.NpmService')

| Methods | |
| :--- | :--- |
| [InitAsync(CancellationToken)](INpmService.InitAsync(CancellationToken).md 'MasterCommander.Commanders.Npm.INpmService.InitAsync(System.Threading.CancellationToken)') | Initializes a new npm project asynchronously. |
| [InstallAsync(CancellationToken)](INpmService.InstallAsync(CancellationToken).md 'MasterCommander.Commanders.Npm.INpmService.InstallAsync(System.Threading.CancellationToken)') | Installs npm packages for the project asynchronously. |
| [RunScriptAsync(string, CancellationToken)](INpmService.RunScriptAsync(string,CancellationToken).md 'MasterCommander.Commanders.Npm.INpmService.RunScriptAsync(string, System.Threading.CancellationToken)') | Runs a specified script defined in the project's package.json file asynchronously. |
| [StartAsync(CancellationToken)](INpmService.StartAsync(CancellationToken).md 'MasterCommander.Commanders.Npm.INpmService.StartAsync(System.Threading.CancellationToken)') | Starts the npm project asynchronously. |
| [UpdateAsync(CancellationToken)](INpmService.UpdateAsync(CancellationToken).md 'MasterCommander.Commanders.Npm.INpmService.UpdateAsync(System.Threading.CancellationToken)') | Updates npm packages for the project asynchronously. |

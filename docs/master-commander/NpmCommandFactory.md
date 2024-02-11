#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Npm](MasterCommander.md#MasterCommander.Commanders.Npm 'MasterCommander.Commanders.Npm')

## NpmCommandFactory Class

Provides npm related operations.

```csharp
public class NpmCommandFactory : MasterCommander.Integrations.Processes.CommandBuilder,
MasterCommander.Commanders.Npm.INpmCommandFactory
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommandBuilder](CommandBuilder.md 'MasterCommander.Integrations.Processes.CommandBuilder') &#129106; NpmCommandFactory

Implements [INpmCommandFactory](INpmCommandFactory.md 'MasterCommander.Commanders.Npm.INpmCommandFactory')

| Constructors | |
| :--- | :--- |
| [NpmCommandFactory(IDirectoryService)](NpmCommandFactory.NpmCommandFactory(IDirectoryService).md 'MasterCommander.Commanders.Npm.NpmCommandFactory.NpmCommandFactory(MasterCommander.Core.Services.IDirectoryService)') | Provides npm related operations. |

| Properties | |
| :--- | :--- |
| [ExecutablePath](NpmCommandFactory.ExecutablePath.md 'MasterCommander.Commanders.Npm.NpmCommandFactory.ExecutablePath') | Gets the path to the executable that the command will run. |

| Methods | |
| :--- | :--- |
| [CreateCommandInit()](NpmCommandFactory.CreateCommandInit().md 'MasterCommander.Commanders.Npm.NpmCommandFactory.CreateCommandInit()') | Creates a command for initializing a new npm project. |
| [CreateCommandInstall()](NpmCommandFactory.CreateCommandInstall().md 'MasterCommander.Commanders.Npm.NpmCommandFactory.CreateCommandInstall()') | Creates a command for installing npm packages in the project. |
| [CreateCommandRunScript(string)](NpmCommandFactory.CreateCommandRunScript(string).md 'MasterCommander.Commanders.Npm.NpmCommandFactory.CreateCommandRunScript(string)') | Creates a command to run a specific npm script defined in the project's package.json. |
| [CreateCommandStart()](NpmCommandFactory.CreateCommandStart().md 'MasterCommander.Commanders.Npm.NpmCommandFactory.CreateCommandStart()') | Creates a command to start the npm project. |
| [CreateCommandUpdate()](NpmCommandFactory.CreateCommandUpdate().md 'MasterCommander.Commanders.Npm.NpmCommandFactory.CreateCommandUpdate()') | Creates a command for updating npm packages in the project. |

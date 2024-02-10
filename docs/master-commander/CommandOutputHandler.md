#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Integrations.Processes](MasterCommander.Integrations.Processes.md 'MasterCommander.Integrations.Processes')

## CommandOutputHandler Class

Provides a base class for handling the output of executed commands, displaying results and events to a console interface.

```csharp
public abstract class CommandOutputHandler
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CommandOutputHandler

Derived  
&#8627; [DockerService](DockerService.md 'MasterCommander.Commanders.Docker.DockerService')  
&#8627; [DotnetService](DotnetService.md 'MasterCommander.Commanders.Dotnet.DotnetService')  
&#8627; [GitService](GitService.md 'MasterCommander.Commanders.Git.GitService')  
&#8627; [NpmService](NpmService.md 'MasterCommander.Commanders.Npm.NpmService')

| Constructors | |
| :--- | :--- |
| [CommandOutputHandler(IConsole)](CommandOutputHandler.CommandOutputHandler(IConsole).md 'MasterCommander.Integrations.Processes.CommandOutputHandler.CommandOutputHandler(MasterCommander.Core.Display.IConsole)') | Provides a base class for handling the output of executed commands, displaying results and events to a console interface. |

| Methods | |
| :--- | :--- |
| [ListenCommandAsync(Command, CancellationToken)](CommandOutputHandler.ListenCommandAsync(Command,CancellationToken).md 'MasterCommander.Integrations.Processes.CommandOutputHandler.ListenCommandAsync(CliWrap.Command, System.Threading.CancellationToken)') | Listens for and processes command execution events asynchronously, writing output and events to the console. |

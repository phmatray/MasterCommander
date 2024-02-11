#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Integrations.Processes](MasterCommander.md#MasterCommander.Integrations.Processes 'MasterCommander.Integrations.Processes')

## CommandBuilder Class

Provides a base for building commands to execute external processes, encapsulating common configuration aspects.

```csharp
public abstract class CommandBuilder
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CommandBuilder

Derived  
&#8627; [DockerCommandFactory](DockerCommandFactory.md 'MasterCommander.Commanders.Docker.DockerCommandFactory')  
&#8627; [DotnetCommandFactory](DotnetCommandFactory.md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory')  
&#8627; [GitCommandFactory](GitCommandFactory.md 'MasterCommander.Commanders.Git.GitCommandFactory')  
&#8627; [NpmCommandFactory](NpmCommandFactory.md 'MasterCommander.Commanders.Npm.NpmCommandFactory')

| Constructors | |
| :--- | :--- |
| [CommandBuilder(IDirectoryService)](CommandBuilder.CommandBuilder(IDirectoryService).md 'MasterCommander.Integrations.Processes.CommandBuilder.CommandBuilder(MasterCommander.Core.Services.IDirectoryService)') | Provides a base for building commands to execute external processes, encapsulating common configuration aspects. |

| Properties | |
| :--- | :--- |
| [ExecutablePath](CommandBuilder.ExecutablePath.md 'MasterCommander.Integrations.Processes.CommandBuilder.ExecutablePath') | Gets the path to the executable that the command will run. |

| Methods | |
| :--- | :--- |
| [ConfigureCommand(Command)](CommandBuilder.ConfigureCommand(Command).md 'MasterCommander.Integrations.Processes.CommandBuilder.ConfigureCommand(CliWrap.Command)') | Allows derived classes to further configure the command before execution.<br/>This method can be overridden to apply additional configurations like environment variables, timeout settings, etc. |
| [CreateCommand(IEnumerable&lt;string&gt;)](CommandBuilder.CreateCommand(IEnumerable_string_).md 'MasterCommander.Integrations.Processes.CommandBuilder.CreateCommand(System.Collections.Generic.IEnumerable<string>)') | Creates a command with the specified arguments, configuring the executable path and working directory. |
| [GetWorkingDirectory()](CommandBuilder.GetWorkingDirectory().md 'MasterCommander.Integrations.Processes.CommandBuilder.GetWorkingDirectory()') | Gets the working directory for the command execution. |

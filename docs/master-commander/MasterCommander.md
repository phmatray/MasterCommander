#### [MasterCommander](MasterCommander.md 'MasterCommander')

## MasterCommander Assembly
### Namespaces

<a name='MasterCommander'></a>

## MasterCommander Namespace

| Classes | |
| :--- | :--- |
| [MainExtensions](MainExtensions.md 'MasterCommander.MainExtensions') | Represents the main extensions for the application. |

<a name='MasterCommander.Commanders.Docker'></a>

## MasterCommander.Commanders.Docker Namespace

| Classes | |
| :--- | :--- |
| [DockerCommandFactory](DockerCommandFactory.md 'MasterCommander.Commanders.Docker.DockerCommandFactory') | Defines the interface for creating Docker command instances. |
| [DockerService](DockerService.md 'MasterCommander.Commanders.Docker.DockerService') | Provides Docker related operations. |

| Interfaces | |
| :--- | :--- |
| [IDockerCommandFactory](IDockerCommandFactory.md 'MasterCommander.Commanders.Docker.IDockerCommandFactory') | Defines the interface for creating Docker command instances. |
| [IDockerService](IDockerService.md 'MasterCommander.Commanders.Docker.IDockerService') | Provides an interface for managing Docker operations asynchronously. |

<a name='MasterCommander.Commanders.Dotnet'></a>

## MasterCommander.Commanders.Dotnet Namespace

| Classes | |
| :--- | :--- |
| [DotnetCommandFactory](DotnetCommandFactory.md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory') | A factory for creating .NET command instances. |
| [DotnetCommandOptionsBase](DotnetCommandOptionsBase.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase') | Base record for .NET command options, providing common options applicable to various .NET CLI commands. |
| [DotnetService](DotnetService.md 'MasterCommander.Commanders.Dotnet.DotnetService') | Provides .NET related operations. |

| Interfaces | |
| :--- | :--- |
| [IDotnetCommandFactory](IDotnetCommandFactory.md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory') | Defines the interface for creating .NET command instances. |
| [IDotnetService](IDotnetService.md 'MasterCommander.Commanders.Dotnet.IDotnetService') | Provides an interface for .NET related operations. |

<a name='MasterCommander.Commanders.Dotnet.CmdBuild'></a>

## MasterCommander.Commanders.Dotnet.CmdBuild Namespace

| Classes | |
| :--- | :--- |
| [DotnetBuildOptions](DotnetBuildOptions.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions') | Represents the options available for the dotnet build command. |

<a name='MasterCommander.Commanders.Dotnet.CmdNew.Abstractions'></a>

## MasterCommander.Commanders.Dotnet.CmdNew.Abstractions Namespace

| Interfaces | |
| :--- | :--- |
| [IHasFramework](IHasFramework.md 'MasterCommander.Commanders.Dotnet.CmdNew.Abstractions.IHasFramework') | Defines a contract for objects that specify a target framework. |
| [IHasLangVersion](IHasLangVersion.md 'MasterCommander.Commanders.Dotnet.CmdNew.Abstractions.IHasLangVersion') | Defines a contract for objects that specify a language version. |
| [IHasNoRestore](IHasNoRestore.md 'MasterCommander.Commanders.Dotnet.CmdNew.Abstractions.IHasNoRestore') | Defines a contract for objects that can specify whether to skip the restore process. |
| [IHasUseProgramMain](IHasUseProgramMain.md 'MasterCommander.Commanders.Dotnet.CmdNew.Abstractions.IHasUseProgramMain') | Defines a contract for objects that can specify whether to use a Program.Main entry point. |

<a name='MasterCommander.Commanders.Dotnet.CmdNew.Options'></a>

## MasterCommander.Commanders.Dotnet.CmdNew.Options Namespace

| Classes | |
| :--- | :--- |
| [DotnetNewClassLibraryOptions](DotnetNewClassLibraryOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewClassLibraryOptions') | Options for creating a new .NET class library project with specific configurations. |
| [DotnetNewConsoleOptions](DotnetNewConsoleOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewConsoleOptions') | Options for creating a new console application. |
| [DotnetNewEditorConfigOptions](DotnetNewEditorConfigOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewEditorConfigOptions') | Options for creating a new .editorconfig file. |
| [DotnetNewGitignoreOptions](DotnetNewGitignoreOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewGitignoreOptions') | Options for creating a new .gitignore file. |
| [DotnetNewGlobalJsonOptions](DotnetNewGlobalJsonOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewGlobalJsonOptions') | Options for creating a new global.json file. |
| [DotnetNewNuGetConfigOptions](DotnetNewNuGetConfigOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewNuGetConfigOptions') | Options for creating a new NuGet.config file. |
| [DotnetNewOptions](DotnetNewOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions') | Represents options for the 'dotnet new' command, which creates a .NET project or other artifacts based on a template.<br/>This record encapsulates common and template-specific options that can be passed to the command. |
| [DotnetNewSolutionOptions](DotnetNewSolutionOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewSolutionOptions') | Options for creating a new solution file. |
| [DotnetNewWebApiOptions](DotnetNewWebApiOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewWebApiOptions') | Options for creating a new web API project. |
| [DotnetNewWpfCustomControlLibOptions](DotnetNewWpfCustomControlLibOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewWpfCustomControlLibOptions') | Options for creating a new WPF custom control library. |
| [DotnetNewWpfLibOptions](DotnetNewWpfLibOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewWpfLibOptions') | Options for creating a new WPF library. |
| [DotnetNewWpfOptions](DotnetNewWpfOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewWpfOptions') | Options for creating a new WPF project. |
| [DotnetNewWpfUserControlLibOptions](DotnetNewWpfUserControlLibOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewWpfUserControlLibOptions') | Options for creating a new WPF user control library. |

<a name='MasterCommander.Commanders.Dotnet.CmdRun'></a>

## MasterCommander.Commanders.Dotnet.CmdRun Namespace

| Classes | |
| :--- | :--- |
| [DotnetRunOptions](DotnetRunOptions.md 'MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions') | Represents options for the 'dotnet run' command, which runs a .NET project in the context of the project's directory or using specified options. |

<a name='MasterCommander.Commanders.Git'></a>

## MasterCommander.Commanders.Git Namespace

| Classes | |
| :--- | :--- |
| [GitCommandFactory](GitCommandFactory.md 'MasterCommander.Commanders.Git.GitCommandFactory') | A factory for creating git command instances. |
| [GitService](GitService.md 'MasterCommander.Commanders.Git.GitService') | Provides an implementation for interacting with Git repositories asynchronously. |

| Interfaces | |
| :--- | :--- |
| [IGitCommandFactory](IGitCommandFactory.md 'MasterCommander.Commanders.Git.IGitCommandFactory') | Defines the interface for creating git command instances. |
| [IGitService](IGitService.md 'MasterCommander.Commanders.Git.IGitService') | Provides an interface for interacting with Git repositories asynchronously. |

<a name='MasterCommander.Commanders.Npm'></a>

## MasterCommander.Commanders.Npm Namespace

| Classes | |
| :--- | :--- |
| [NpmCommandFactory](NpmCommandFactory.md 'MasterCommander.Commanders.Npm.NpmCommandFactory') | Provides npm related operations. |
| [NpmService](NpmService.md 'MasterCommander.Commanders.Npm.NpmService') | Provides npm related operations. |

| Interfaces | |
| :--- | :--- |
| [INpmCommandFactory](INpmCommandFactory.md 'MasterCommander.Commanders.Npm.INpmCommandFactory') | Defines the interface for creating npm command instances. |
| [INpmService](INpmService.md 'MasterCommander.Commanders.Npm.INpmService') | Provides an interface for interacting with npm (Node Package Manager) operations asynchronously. |

<a name='MasterCommander.Core'></a>

## MasterCommander.Core Namespace

| Classes | |
| :--- | :--- |
| [CmdOptionAttribute](CmdOptionAttribute.md 'MasterCommander.Core.CmdOptionAttribute') | Specifies a command option attribute for properties to indicate their corresponding command line option. |
| [CmdOptionOrderAttribute](CmdOptionOrderAttribute.md 'MasterCommander.Core.CmdOptionOrderAttribute') | Specifies the order in which command option attributes should be processed. |
| [CmdOptionsBase](CmdOptionsBase.md 'MasterCommander.Core.CmdOptionsBase') | Serves as the base record for command options, providing mechanisms to convert properties into command line arguments. |
| [CmdOptionValuesAttribute](CmdOptionValuesAttribute.md 'MasterCommander.Core.CmdOptionValuesAttribute') | Specifies valid values for a command option attribute. |

<a name='MasterCommander.Core.ConsoleEvents'></a>

## MasterCommander.Core.ConsoleEvents Namespace

| Classes | |
| :--- | :--- |
| [ConsoleEvent](ConsoleEvent.md 'MasterCommander.Core.ConsoleEvents.ConsoleEvent') | Represents the base class for all console events. |
| [ExecutionTimeConsoleEvent](ExecutionTimeConsoleEvent.md 'MasterCommander.Core.ConsoleEvents.ExecutionTimeConsoleEvent') | Represents a console event that indicates the execution time of a process. |
| [ExitedConsoleEvent](ExitedConsoleEvent.md 'MasterCommander.Core.ConsoleEvents.ExitedConsoleEvent') | Represents a console event that indicates the exit code of a process. |
| [StandardErrorConsoleEvent](StandardErrorConsoleEvent.md 'MasterCommander.Core.ConsoleEvents.StandardErrorConsoleEvent') | Represents a console event that contains the standard error output of a process. |
| [StandardOutputConsoleEvent](StandardOutputConsoleEvent.md 'MasterCommander.Core.ConsoleEvents.StandardOutputConsoleEvent') | Represents a console event that contains the standard output of a process. |
| [StartedConsoleEvent](StartedConsoleEvent.md 'MasterCommander.Core.ConsoleEvents.StartedConsoleEvent') | Represents a console event that indicates the start of a process, including its process ID. |

<a name='MasterCommander.Core.Display'></a>

## MasterCommander.Core.Display Namespace

| Classes | |
| :--- | :--- |
| [ConsoleBase](ConsoleBase.md 'MasterCommander.Core.Display.ConsoleBase') | Serves as the base class for console output handling, providing a mechanism to write different types of console events. |
| [ConsoleEventFactory](ConsoleEventFactory.md 'MasterCommander.Core.Display.ConsoleEventFactory') | Provides factory methods for creating various types of console events. |

| Interfaces | |
| :--- | :--- |
| [IConsole](IConsole.md 'MasterCommander.Core.Display.IConsole') | Defines an interface for console operations, allowing for writing lines, commands, startup messages, and console events. |

<a name='MasterCommander.Core.Exceptions'></a>

## MasterCommander.Core.Exceptions Namespace

| Classes | |
| :--- | :--- |
| [CliCommandException](CliCommandException.md 'MasterCommander.Core.Exceptions.CliCommandException') | Represents an exception related to CLI command execution failures, including the associated exit code. |
| [CliOperationCanceledException](CliOperationCanceledException.md 'MasterCommander.Core.Exceptions.CliOperationCanceledException') | Represents an exception that occurs when a CLI operation is canceled. |
| [CliOperationException](CliOperationException.md 'MasterCommander.Core.Exceptions.CliOperationException') | Represents an exception for general CLI operation failures, including an inner exception that represents the cause of the current exception. |
| [HomeDirectoryNotFoundException](HomeDirectoryNotFoundException.md 'MasterCommander.Core.Exceptions.HomeDirectoryNotFoundException') | Represents an exception that occurs when the home directory cannot be determined. |

<a name='MasterCommander.Core.Services'></a>

## MasterCommander.Core.Services Namespace

| Interfaces | |
| :--- | :--- |
| [IDirectoryService](IDirectoryService.md 'MasterCommander.Core.Services.IDirectoryService') | Defines the interface for directory-related operations. |
| [IProjectInitializationService](IProjectInitializationService.md 'MasterCommander.Core.Services.IProjectInitializationService') | Defines the interface for initializing projects, specifically for creating new console projects. |

<a name='MasterCommander.Integrations'></a>

## MasterCommander.Integrations Namespace

| Classes | |
| :--- | :--- |
| [DirectoryService](DirectoryService.md 'MasterCommander.Integrations.DirectoryService') | Provides functionality for directory-related operations. |
| [ProjectInitializationService](ProjectInitializationService.md 'MasterCommander.Integrations.ProjectInitializationService') | Represents the project initialization service. |

<a name='MasterCommander.Integrations.Display'></a>

## MasterCommander.Integrations.Display Namespace

| Classes | |
| :--- | :--- |
| [SpectreConsole](SpectreConsole.md 'MasterCommander.Integrations.Display.SpectreConsole') | Provides Spectre console output. |
| [StandardConsole](StandardConsole.md 'MasterCommander.Integrations.Display.StandardConsole') | Provides standard console output. |

<a name='MasterCommander.Integrations.Processes'></a>

## MasterCommander.Integrations.Processes Namespace

| Classes | |
| :--- | :--- |
| [CommandBuilder](CommandBuilder.md 'MasterCommander.Integrations.Processes.CommandBuilder') | Provides a base for building commands to execute external processes, encapsulating common configuration aspects. |
| [CommandOutputHandler](CommandOutputHandler.md 'MasterCommander.Integrations.Processes.CommandOutputHandler') | Provides a base class for handling the output of executed commands, displaying results and events to a console interface. |

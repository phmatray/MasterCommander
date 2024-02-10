#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.Commanders.Git.md 'MasterCommander.Commanders.Git').[GitService](GitService.md 'MasterCommander.Commanders.Git.GitService')

## GitService(IGitCommandFactory, IConsole) Constructor

Provides an implementation for interacting with Git repositories asynchronously.

```csharp
public GitService(MasterCommander.Commanders.Git.IGitCommandFactory gitCommandFactory, MasterCommander.Core.Display.IConsole console);
```
#### Parameters

<a name='MasterCommander.Commanders.Git.GitService.GitService(MasterCommander.Commanders.Git.IGitCommandFactory,MasterCommander.Core.Display.IConsole).gitCommandFactory'></a>

`gitCommandFactory` [IGitCommandFactory](IGitCommandFactory.md 'MasterCommander.Commanders.Git.IGitCommandFactory')

The factory for creating git command instances.

<a name='MasterCommander.Commanders.Git.GitService.GitService(MasterCommander.Commanders.Git.IGitCommandFactory,MasterCommander.Core.Display.IConsole).console'></a>

`console` [IConsole](IConsole.md 'MasterCommander.Core.Display.IConsole')

The console to use for output.
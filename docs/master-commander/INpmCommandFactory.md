#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Npm](MasterCommander.md#MasterCommander.Commanders.Npm 'MasterCommander.Commanders.Npm')

## INpmCommandFactory Interface

Defines the interface for creating npm command instances.

```csharp
public interface INpmCommandFactory
```

Derived  
&#8627; [NpmCommandFactory](NpmCommandFactory.md 'MasterCommander.Commanders.Npm.NpmCommandFactory')

| Methods | |
| :--- | :--- |
| [CreateCommandInit()](INpmCommandFactory.CreateCommandInit().md 'MasterCommander.Commanders.Npm.INpmCommandFactory.CreateCommandInit()') | Creates a command for initializing a new npm project. |
| [CreateCommandInstall()](INpmCommandFactory.CreateCommandInstall().md 'MasterCommander.Commanders.Npm.INpmCommandFactory.CreateCommandInstall()') | Creates a command for installing npm packages in the project. |
| [CreateCommandRunScript(string)](INpmCommandFactory.CreateCommandRunScript(string).md 'MasterCommander.Commanders.Npm.INpmCommandFactory.CreateCommandRunScript(string)') | Creates a command to run a specific npm script defined in the project's package.json. |
| [CreateCommandStart()](INpmCommandFactory.CreateCommandStart().md 'MasterCommander.Commanders.Npm.INpmCommandFactory.CreateCommandStart()') | Creates a command to start the npm project. |
| [CreateCommandUpdate()](INpmCommandFactory.CreateCommandUpdate().md 'MasterCommander.Commanders.Npm.INpmCommandFactory.CreateCommandUpdate()') | Creates a command for updating npm packages in the project. |

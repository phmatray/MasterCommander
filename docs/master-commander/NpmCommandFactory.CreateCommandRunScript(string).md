#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Npm](MasterCommander.Commanders.Npm.md 'MasterCommander.Commanders.Npm').[NpmCommandFactory](NpmCommandFactory.md 'MasterCommander.Commanders.Npm.NpmCommandFactory')

## NpmCommandFactory.CreateCommandRunScript(string) Method

Creates a command to run a specific npm script defined in the project's package.json.

```csharp
public CliWrap.Command CreateCommandRunScript(string scriptName);
```
#### Parameters

<a name='MasterCommander.Commanders.Npm.NpmCommandFactory.CreateCommandRunScript(string).scriptName'></a>

`scriptName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the script to run.

Implements [CreateCommandRunScript(string)](INpmCommandFactory.CreateCommandRunScript(string).md 'MasterCommander.Commanders.Npm.INpmCommandFactory.CreateCommandRunScript(string)')

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to run the specified npm script.
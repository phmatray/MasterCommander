#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Npm](MasterCommander.md#MasterCommander.Commanders.Npm 'MasterCommander\.Commanders\.Npm').[INpmCommandFactory](INpmCommandFactory.md 'MasterCommander\.Commanders\.Npm\.INpmCommandFactory')

## INpmCommandFactory\.CreateCommandRunScript\(string\) Method

Creates a command to run a specific npm script defined in the project's package\.json\.

```csharp
CliWrap.Command CreateCommandRunScript(string scriptName);
```
#### Parameters

<a name='MasterCommander.Commanders.Npm.INpmCommandFactory.CreateCommandRunScript(string).scriptName'></a>

`scriptName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the script to run\.

#### Returns
[CliWrap\.Command](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.command 'CliWrap\.Command')  
A command to run the specified npm script\.
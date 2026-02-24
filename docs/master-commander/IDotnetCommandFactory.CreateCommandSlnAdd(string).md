#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Dotnet](MasterCommander.md#MasterCommander.Commanders.Dotnet 'MasterCommander\.Commanders\.Dotnet').[IDotnetCommandFactory](IDotnetCommandFactory.md 'MasterCommander\.Commanders\.Dotnet\.IDotnetCommandFactory')

## IDotnetCommandFactory\.CreateCommandSlnAdd\(string\) Method

Creates a new command to add a C\# project file \(\.csproj\) to a solution \(\.sln\)\.

```csharp
CliWrap.Command CreateCommandSlnAdd(string csproj);
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandSlnAdd(string).csproj'></a>

`csproj` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the C\# project file to add\.

#### Returns
[CliWrap\.Command](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.command 'CliWrap\.Command')  
A command to add a C\# project file to a solution\.
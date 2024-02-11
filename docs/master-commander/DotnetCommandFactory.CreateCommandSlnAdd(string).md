#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.md#MasterCommander.Commanders.Dotnet 'MasterCommander.Commanders.Dotnet').[DotnetCommandFactory](DotnetCommandFactory.md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory')

## DotnetCommandFactory.CreateCommandSlnAdd(string) Method

Creates a new command to add a C# project file (.csproj) to a solution (.sln).

```csharp
public CliWrap.Command CreateCommandSlnAdd(string csproj);
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.DotnetCommandFactory.CreateCommandSlnAdd(string).csproj'></a>

`csproj` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path to the C# project file to add.

Implements [CreateCommandSlnAdd(string)](IDotnetCommandFactory.CreateCommandSlnAdd(string).md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandSlnAdd(string)')

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to add a C# project file to a solution.
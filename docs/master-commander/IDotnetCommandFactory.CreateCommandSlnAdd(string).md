#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.Commanders.Dotnet.md 'MasterCommander.Commanders.Dotnet').[IDotnetCommandFactory](IDotnetCommandFactory.md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory')

## IDotnetCommandFactory.CreateCommandSlnAdd(string) Method

Creates a new command to add a C# project file (.csproj) to a solution (.sln).

```csharp
CliWrap.Command CreateCommandSlnAdd(string csproj);
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandSlnAdd(string).csproj'></a>

`csproj` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path to the C# project file to add.

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to add a C# project file to a solution.
#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet.CmdRun](MasterCommander.Commanders.Dotnet.CmdRun.md 'MasterCommander.Commanders.Dotnet.CmdRun').[DotnetRunOptions](DotnetRunOptions.md 'MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions')

## DotnetRunOptions.ApplicationArguments Property

Gets additional arguments to pass to the application being run.

```csharp
public string? ApplicationArguments { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks
These arguments are passed directly to the application and are not used by the `dotnet run` command itself.
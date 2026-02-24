#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Dotnet\.CmdRun](MasterCommander.md#MasterCommander.Commanders.Dotnet.CmdRun 'MasterCommander\.Commanders\.Dotnet\.CmdRun').[DotnetRunOptions](DotnetRunOptions.md 'MasterCommander\.Commanders\.Dotnet\.CmdRun\.DotnetRunOptions')

## DotnetRunOptions\.ApplicationArguments Property

Gets additional arguments to pass to the application being run\.

```csharp
public string? ApplicationArguments { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

### Remarks
These arguments are passed directly to the application and are not used by the \`dotnet run\` command itself\.
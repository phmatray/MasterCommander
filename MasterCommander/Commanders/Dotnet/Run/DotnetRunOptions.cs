namespace MasterCommander.Commanders.Dotnet.Run;

public record DotnetRunOptions()
    : DotnetCommandOptionsBase("run")
{
    [CmdOption("--launch-profile")]
    public string? LaunchProfile { get; init; }
    
    [CmdOption("--no-build")]
    public bool NoBuild { get; init; }
    
    [CmdOption("--no-launch-profile")]
    public bool NoLaunchProfile { get; init; }
    
    [CmdOption("--project")]
    public string? Project { get; init; }
    
    public string? ApplicationArguments { get; init; }
}
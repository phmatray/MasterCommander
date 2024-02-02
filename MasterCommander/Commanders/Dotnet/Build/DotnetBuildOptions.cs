namespace MasterCommander.Commanders.Dotnet.Build;

public record DotnetBuildOptions()
    : DotnetCommandOptionsBase("build")
{
    [CmdOption("--disable-build-servers")]
    [CmdOptionOrder(100)]
    public bool DisableBuildServers { get; init; }
    
    [CmdOption("--no-incremental")]
    [CmdOptionOrder(101)]
    public bool NoIncremental { get; init; }
    
    [CmdOption("--no-self-contained")]
    [CmdOptionOrder(103)]
    public bool NoSelfContained { get; init; }
    
    [CmdOption("-o|--output")]
    [CmdOptionOrder(104)]
    public string? OutputDirectory { get; init; }
    
    [CmdOption("-p|--property")]
    [CmdOptionOrder(105)]
    public string? Property { get; init; }
    
    [CmdOption("--self-contained")]
    [CmdOptionOrder(106)]
    public bool SelfContained { get; init; }
    
    [CmdOption("--source")]
    [CmdOptionOrder(107)]
    public string? Source { get; init; }
    
    [CmdOption("--use-current-runtime")]
    [CmdOptionOrder(108)]
    public bool UseCurrentRuntime { get; init; }
    
    [CmdOption("--version-suffix")]
    [CmdOptionOrder(109)]
    public string? VersionSuffix { get; init; }
}
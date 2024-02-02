namespace MasterCommander.Commanders.Dotnet.Build;

public record DotnetBuildOptions()
    : CmdOptionsBase("build")
{
    [CmdOption("-a|--arch")]
    [CmdOptionOrder(1)]
    public string? Architecture { get; init; }
    
    [CmdOption("-c|--configuration")]
    [CmdOptionOrder(2)]
    public string? Configuration { get; init; }
    
    [CmdOption("--disable-build-servers")]
    [CmdOptionOrder(3)]
    public bool DisableBuildServers { get; init; }
    
    [CmdOption("-f|--framework")]
    [CmdOptionOrder(4)]
    public string? Framework { get; init; }
    
    [CmdOption("--force")]
    [CmdOptionOrder(5)]
    public bool Force { get; init; }
    
    [CmdOption("--interactive")]
    [CmdOptionOrder(6)]
    public bool Interactive { get; init; }
    
    [CmdOption("--no-dependencies")]
    [CmdOptionOrder(7)]
    public bool NoDependencies { get; init; }
    
    [CmdOption("--no-incremental")]
    [CmdOptionOrder(8)]
    public bool NoIncremental { get; init; }
    
    [CmdOption("--no-restore")]
    [CmdOptionOrder(9)]
    public bool NoRestore { get; init; }
    
    [CmdOption("--nologo")]
    [CmdOptionOrder(10)]
    public bool NoLogo { get; init; }
    
    [CmdOption("--no-self-contained")]
    [CmdOptionOrder(11)]
    public bool NoSelfContained { get; init; }
    
    [CmdOption("-o|--output")]
    [CmdOptionOrder(12)]
    public string? OutputDirectory { get; init; }
    
    [CmdOption("--os")]
    [CmdOptionOrder(13)]
    public string? OS { get; init; }
    
    [CmdOption("-p|--property")]
    [CmdOptionOrder(14)]
    public string? Property { get; init; }
    
    [CmdOption("-r|--runtime")]
    [CmdOptionOrder(15)]
    public string? RuntimeIdentifier { get; init; }
    
    [CmdOption("--self-contained")]
    [CmdOptionOrder(16)]
    public bool SelfContained { get; init; }
    
    [CmdOption("--source")]
    [CmdOptionOrder(17)]
    public string? Source { get; init; }
    
    [CmdOption("--tl")]
    [CmdOptionOrder(18)]
    [CmdOptionValues(["auto", "on", "off"])]
    public string? TerminalLogger { get; init; }
    
    [CmdOption("-v|--verbosity")]
    [CmdOptionOrder(19)]
    [CmdOptionValues(["quiet", "minimal", "normal", "detailed", "diagnostic"])]
    public string? VerbosityLevel { get; init; }
    
    [CmdOption("--use-current-runtime")]
    [CmdOptionOrder(20)]
    public bool UseCurrentRuntime { get; init; }
    
    [CmdOption("--version-suffix")]
    [CmdOptionOrder(21)]
    public string? VersionSuffix { get; init; }
}
namespace MasterCommander.Commanders.Dotnet;

public abstract record DotnetCommandOptionsBase(string Command)
    : CmdOptionsBase(Command)
{
    [CmdOption("-a|--arch")]
    [CmdOptionOrder(1)]
    public string? Architecture { get; init; }
    
    [CmdOption("-c|--configuration")]
    [CmdOptionOrder(2)]
    public string? Configuration { get; init; }
    
    [CmdOption("-f|--framework")]
    [CmdOptionOrder(3)]
    public string? Framework { get; init; }
    
    [CmdOption("--force")]
    [CmdOptionOrder(4)]
    public bool Force { get; init; }
    
    [CmdOption("--interactive")]
    [CmdOptionOrder(5)]
    public bool Interactive { get; init; }
    
    [CmdOption("--no-dependencies")]
    [CmdOptionOrder(6)]
    public bool NoDependencies { get; init; }
    
    [CmdOption("--no-restore")]
    [CmdOptionOrder(7)]
    public bool NoRestore { get; init; }
    
    [CmdOption("--os")]
    [CmdOptionOrder(8)]
    public string? OS { get; init; }
    
    [CmdOption("-r|--runtime")]
    [CmdOptionOrder(9)]
    public string? RuntimeIdentifier { get; init; }
    
    [CmdOption("--tl")]
    [CmdOptionOrder(10)]
    [CmdOptionValues(["auto", "on", "off"])]
    public string? TerminalLogger { get; init; }
    
    [CmdOption("-v|--verbosity")]
    [CmdOptionOrder(11)]
    [CmdOptionValues(["quiet", "minimal", "normal", "detailed", "diagnostic"])]
    public string? VerbosityLevel { get; init; }
}
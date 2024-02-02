namespace MasterCommander.Commanders.Dotnet.New.Options;

public record DotnetNewClassLibraryOptions(string? Template = null)
    : DotnetNewOptions(Template ?? "classlib"),
        IHasFramework, IHasLangVersion, IHasNoRestore
{
    [CmdOption("-f|--framework")]
    [CmdOptionOrder(11)]
    public string? Framework { get; init; }
    
    [CmdOption("--lang-version")]
    [CmdOptionOrder(12)]
    public string? LangVersion { get; init; }
    
    [CmdOption("--no-restore")]
    [CmdOptionOrder(13)]
    public bool NoRestore { get; init; }
}
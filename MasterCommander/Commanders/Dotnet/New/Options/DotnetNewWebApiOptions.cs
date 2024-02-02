namespace MasterCommander.Commanders.Dotnet.New.Options;

public record DotnetNewWebApiOptions()
    : DotnetNewClassLibraryOptions("webapi"),
        IHasUseProgramMain
{
    [CmdOption("--use-program-main")]
    [CmdOptionOrder(14)]
    public bool UseProgramMain { get; init; }
}
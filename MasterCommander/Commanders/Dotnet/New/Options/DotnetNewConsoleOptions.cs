namespace MasterCommander.Commanders.Dotnet.New.Options;

public record DotnetNewConsoleOptions()
    : DotnetNewClassLibraryOptions("console"),
        IHasUseProgramMain
{
    [CmdOption("--use-program-main")]
    [CmdOptionOrder(14)]
    public bool UseProgramMain { get; init; }
}
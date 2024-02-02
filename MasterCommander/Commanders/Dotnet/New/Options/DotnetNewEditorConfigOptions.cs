namespace MasterCommander.Commanders.Dotnet.New.Options;

public record DotnetNewEditorConfigOptions()
    : DotnetNewOptions("editorconfig")
{
    [CmdOption("--empty")]
    [CmdOptionOrder(11)]
    public bool Empty { get; init; }
}
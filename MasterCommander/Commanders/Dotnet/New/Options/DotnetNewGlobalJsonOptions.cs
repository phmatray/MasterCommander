namespace MasterCommander.Commanders.Dotnet.New.Options;

public record DotnetNewGlobalJsonOptions()
    : DotnetNewOptions("globaljson")
{
    [CmdOption("--sdk-version")]
    [CmdOptionOrder(11)]
    public string? SdkVersion { get; init; }
}
namespace MasterCommander.Commanders.Dotnet.New.Options;

/// <summary>
/// The dotnet new command creates a .NET project or other artifacts based on a template.
/// The command calls the template engine to create the artifacts on disk based on the specified template and options.
/// </summary>
/// <param name="Template">The template to instantiate when the command is invoked. Each template might have specific options you can pass.</param>
public record DotnetNewOptions(string Template)
    : CmdOptionsBase("new", Template)
{
    /// <summary>
    /// Displays a summary of what would happen if the given command were run if it would result in a template creation. Available since .NET Core 2.2 SDK.
    /// </summary>
    [CmdOption("--dry-run")]
    [CmdOptionOrder(1)]
    public bool DryRun { get; init; }
    
    /// <summary>
    /// Forces content to be generated even if it would change existing files. This is required when the template chosen would override existing files in the output directory.
    /// </summary>
    [CmdOption("--force")]
    [CmdOptionOrder(2)]
    public bool Force { get; init; }
    
    /// <summary>
    /// The language of the template to create. The language accepted varies by the template. Not valid for some templates.
    /// </summary>
    [CmdOption("-lang|--language")]
    [CmdOptionOrder(3)]
    [CmdOptionValues(["C#", "F#", "VB"])]
    public string? Language { get; init; }
    
    [CmdOption("-n|--name")]
    [CmdOptionOrder(4)]
    public string? OutputName { get; init; }
    
    [CmdOption("--no-update-check")]
    [CmdOptionOrder(6)]
    public bool NoUpdateCheck { get; init; }
    
    [CmdOption("-o|--output")]
    [CmdOptionOrder(7)]
    public string? OutputDirectory { get; init; }
    
    [CmdOption("--project")]
    [CmdOptionOrder(8)]
    public string? ProjectPath { get; init; }
    
    [CmdOption("--diagnostics")]
    [CmdOptionOrder(9)]
    public bool Diagnostics { get; init; }
    
    [CmdOption("--verbosity")]
    [CmdOptionOrder(10)]
    [CmdOptionValues(["quiet", "minimal", "normal", "diagnostic"])]
    public string? Verbosity { get; init; }
}
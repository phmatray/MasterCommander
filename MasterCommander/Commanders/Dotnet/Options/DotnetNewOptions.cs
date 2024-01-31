namespace MasterCommander.Commanders.Dotnet.Options;

public sealed record DotnetNewOptions
{
    public string Template { get; init; }
    public string Name { get; init; }

    public DotnetNewOptions(string template, string name)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(template);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        Template = template;
        Name = name;
    }
    
    public string[] ToArguments()
    {
        return ["new", Template, "-n", Name];
    }
}
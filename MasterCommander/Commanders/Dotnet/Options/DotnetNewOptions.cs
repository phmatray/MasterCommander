namespace MasterCommander.Commanders.Dotnet.Options;

public sealed record DotnetNewOptions
{
    public string Template { get; init; }
    public string Name { get; init; }
    public bool Force { get; init; }

    public DotnetNewOptions(string template, string name, bool force)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(template);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        Template = template;
        Name = name;
        Force = force;
    }
    
    public string[] ToArguments()
    {
        var arguments = new List<string> {"new", Template, "-n", Name};

        if (Force)
        {
            arguments.Add("--force");
        }
        
        return arguments.ToArray();
    }
}
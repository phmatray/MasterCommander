namespace MasterCommander.Commanders.Dotnet;

public class DotnetCommandFactory(
    string workingDirectory = ".",
    string executablePath = "dotnet")
    : CommandBuilder(workingDirectory, executablePath), IDotnetCommandFactory
{
    public Command New(DotnetNewOptions options)
    {
        return CreateCommand(options.ToArguments());
    }

    public Command Build(DotnetBuildOptions options)
    {
        return CreateCommand(options.ToArguments());
    }

    public Command Run()
    {
        string[] arguments = ["run"];
        return CreateCommand(arguments);
    }

    public Command Test()
    {
        string[] arguments = ["test"];
        return CreateCommand(arguments);
    }

    public Command SlnAdd(string csproj)
    {
        string[] arguments = ["sln", "add", csproj];
        return CreateCommand(arguments);
    }
}
namespace MasterCommander.Commanders.Dotnet;

public interface IDotnetCommandFactory
{
    Command New(DotnetNewOptions options);
    Command Build(DotnetBuildOptions options);
    Command Run();
    Command Test();
    Command SlnAdd(string csproj);
}
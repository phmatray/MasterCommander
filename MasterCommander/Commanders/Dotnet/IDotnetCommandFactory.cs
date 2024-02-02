namespace MasterCommander.Commanders.Dotnet;

public interface IDotnetCommandFactory
{
    Command New(DotnetNewOptions options);
    Command Build();
    Command Run();
    Command Test();
    Command SlnAdd(string csproj);
}
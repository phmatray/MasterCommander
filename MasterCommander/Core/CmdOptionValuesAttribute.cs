namespace MasterCommander.Core;

[AttributeUsage(AttributeTargets.Property)]
public class CmdOptionValuesAttribute(string[] validOptions) : Attribute
{
    public string[] ValidOptions { get; } = validOptions;
}
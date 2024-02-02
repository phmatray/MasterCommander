namespace MasterCommander.Core;

[AttributeUsage(AttributeTargets.Property)]
public class CmdOptionOrderAttribute(int order) : Attribute
{
    public int Order { get; } = order;
}
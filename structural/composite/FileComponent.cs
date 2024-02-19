using System.Reflection.Metadata.Ecma335;

namespace composite;

public class FileComponent : Component
{
    public FileComponent(string name)
    {
        _name = name;
        _child = new List<Component>();
    }
    protected override void PrintTitle() => Console.WriteLine($"File: {_name}");
    protected override void PrintFooter() {}
}

namespace composite;

public class FolderComponent : Component
{
    public FolderComponent(string name)
    {
        _name = name;
        _child = new List<Component>();
    }
    protected override void PrintTitle() => Console.WriteLine($"BEGIN Folder: {_name}");
    protected override void PrintFooter() => Console.WriteLine($"END Folder: {_name}");
}

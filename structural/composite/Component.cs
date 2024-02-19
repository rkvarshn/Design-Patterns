namespace composite;

public abstract class Component
{
    protected string _name;
    protected List<Component> _child;

    protected abstract void PrintTitle();
    protected abstract void PrintFooter();
    public void Add(Component component)
    {
        _child.Add(component);
    }
    public void Remove(Component component)
    {
        _child.Remove(component);
    }
    public Component? GetChild(int n)
    {
        if(n < _child.Count)
            return _child[n];
        return null;
    }
    public void Print()
    {
        PrintTitle();        
        foreach(Component c in _child)
            c.Print();
        PrintFooter();
    }
}
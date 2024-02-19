namespace iterator;

public class PancakeHouseIteratorMenu : IIterator<MenuItem>
{
    List<MenuItem> _items;
    int _position;
    public PancakeHouseIteratorMenu(List<MenuItem> items)
    {
        _items = items;
        _position = 0;
    }
    public bool HasNext() => _position < _items.Count;
    public MenuItem Next() => _items[_position++];
    public void Reset() => _position = 0;
}

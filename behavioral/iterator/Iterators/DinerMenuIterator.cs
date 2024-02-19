namespace iterator;

public class DinerMenuIterator : IIterator<MenuItem>
{
    MenuItem[] _items;
    int _position;
    public DinerMenuIterator(MenuItem[] items)
    {
        _items = items;
        _position = 0;
    }
    public bool HasNext() => _position < _items.Count();
    public MenuItem Next() => _items[_position++];
    public void Reset() => _position = 0;
}

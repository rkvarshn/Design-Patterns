namespace iterator;

public class CafeMenuIterator : IIterator<MenuItem>
{
    LinkedList<MenuItem> _items;
    int _position;
    public CafeMenuIterator(LinkedList<MenuItem> items)
    {
        _items = items;
        _position = 0;
    }
    public bool HasNext() => _position < _items.Count();
    public MenuItem Next() => _items.ElementAt(_position++);
    public void Reset() => _position = 0;
}

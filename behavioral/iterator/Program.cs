using iterator;

List<IIterable<MenuItem>> menus = new List<IIterable<MenuItem>>() { new DinersMenu(4), new PancakeHouseMenu(), new CafeMenu() };
foreach(var menu in menus)
    PrintMenu(menu);

void PrintMenu(IIterable<MenuItem> iterableCollection)
{
    IIterator<MenuItem> iterator = iterableCollection.CreateIterator();
    while(iterator.HasNext())
        iterator.Next().Print();
}

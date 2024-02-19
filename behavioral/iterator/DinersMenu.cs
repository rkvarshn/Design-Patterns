namespace iterator;
public class DinersMenu : IIterable<MenuItem>
{
    private MenuItem[] menuItems;
    private int maxItems;
    private int numberOfItems = 0;
    public DinersMenu(int maxItems)
    {
        this.maxItems = maxItems;
        menuItems = new MenuItem[maxItems];

        // Adding sample menu items
        AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
        AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
        AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
        AddItem("Hotdog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05);
    }
    public void AddItem(string name, string description, bool vegetarian, double price)
    {
        if (numberOfItems >= maxItems)
        {
            Console.WriteLine("Sorry, menu is full! Can't add item: " + name);
            return;
        }

        MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
        menuItems[numberOfItems] = menuItem;
        numberOfItems++;
    }
    public IIterator<MenuItem> CreateIterator()
    {
        return new DinerMenuIterator(menuItems);
    }
    public MenuItem[] GetMenuItems()
    {
        return menuItems;
    }
}

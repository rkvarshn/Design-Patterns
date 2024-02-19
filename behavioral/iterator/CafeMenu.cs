﻿namespace iterator;

public class CafeMenu : IIterable<MenuItem>
{
    private LinkedList<MenuItem> menuItems;
    public CafeMenu()
    {
        menuItems = new LinkedList<MenuItem>();

        // Adding sample menu items
        AddItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99);
        AddItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69);
        AddItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29);
    }
    public void AddItem(string name, string description, bool vegetarian, double price)
    {
        MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
        menuItems.AddLast(menuItem);
    }
    public IIterator<MenuItem> CreateIterator()
    {
        return new CafeMenuIterator(menuItems);
    }
    public LinkedList<MenuItem> GetMenuItems()
    {
        return menuItems;
    }
}

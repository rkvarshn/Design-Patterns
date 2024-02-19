namespace iterator;
public class MenuItem
{
    public string Name { get; }
    public string Description { get; }
    public bool Vegetarian { get; }
    public double Price { get; }
    public MenuItem(string name, string description, bool vegetarian, double price)
    {
        Name = name;
        Description = description;
        Vegetarian = vegetarian;
        Price = price;
    }
    public void Print() => Console.WriteLine($"Name: {Name}\nDescription: {Description}\nVegetarian: {Vegetarian}\nPrice: {Price}\n");
}

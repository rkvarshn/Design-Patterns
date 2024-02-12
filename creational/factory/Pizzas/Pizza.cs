namespace Factory.Pizza;

public abstract class Pizza : IPizza
{
    protected string Name;
    protected string Dough;
    protected string Sauce;
    protected List<string> Toppings;
    public void Prepare()
    {
        Console.WriteLine($"Preparing {Name} pizza");
        Console.WriteLine($"Tossing {Dough} dough");
        Console.WriteLine($"Adding {Sauce} sauce");
        Console.WriteLine("Adding Toppings:");
        foreach(string topping in Toppings)
            Console.WriteLine($"\t- {topping}");
    }
    public void Bake()
    {
        Console.WriteLine($"Baking {Name} pizza");
    }
    public void Cut()
    {
        Console.WriteLine($"Cutting {Name} pizza");
    }
    public void Box()
    {
        Console.WriteLine($"Placing {Name} pizza in box");
    }
}

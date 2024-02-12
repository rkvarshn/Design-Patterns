using Factory.Pizza;
namespace Factory.PizzaStores;
public class NYPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch 
        {
            "cheese" => new NYCheesePizza(),
            "clam" => new NYClamPizza(),
            "pepperoni" => new NYPepperoniPizza(),
            "veggie" => new NYVeggiePizza(),
            _ => throw new InvalidDataException()
        };
    }
}

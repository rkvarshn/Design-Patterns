using Factory.Pizza;
namespace Factory.PizzaStores;
public class IndianPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch
        {
            "farmhouse" => new IndianFarmhousePizza(),
            "paneer" => new IndianPaneerPizza(),
            _ => throw new InvalidDataException()
        };
    }
}

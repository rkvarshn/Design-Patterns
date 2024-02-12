namespace Factory.Pizza;
public class IndianFarmhousePizza : Pizza
{
    public IndianFarmhousePizza()
    {
        Name = "Indian Farmhouse Pizza";
        Dough = "Cheese Filled";
        Sauce = "Pasta Sauce";
        Toppings = new (){ "Mozzarela and Cheddar Cheese", "Onion", "Capsicum", "Mushroom", "Baby Corn" };
    }
}

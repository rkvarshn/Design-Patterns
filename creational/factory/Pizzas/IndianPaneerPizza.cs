namespace Factory.Pizza;
public class IndianPaneerPizza : Pizza
{
    public IndianPaneerPizza()
    {
        Name = "Indian Paneer Pizza";
        Dough = "Regular Wheat";
        Sauce = "Tandoori Makhni";
        Toppings = new (){ "Mozzarela Cheese", "Paneer", "Paprika", "Onions" };
    }
}

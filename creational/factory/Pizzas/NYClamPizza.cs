namespace Factory.Pizza;
public class NYClamPizza : Pizza
{
    public NYClamPizza()
    {
        Name = "New York Style Clam";
        Dough = "Regular";
        Sauce = "Garlic";
        Toppings = new () { "Mozzarella Cheese", "Clams" };
    }
}
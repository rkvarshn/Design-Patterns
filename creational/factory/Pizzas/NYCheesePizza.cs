namespace Factory.Pizza;
public class NYCheesePizza : Pizza
{
    public NYCheesePizza()
    {
        Name = "New York Style Cheese";
        Dough = "Thin Crust";
        Sauce = "Marinara";
        Toppings = new () { "Reggiano Cheese" };
    }
}

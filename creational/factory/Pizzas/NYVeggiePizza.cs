namespace Factory.Pizza;
public class NYVeggiePizza : Pizza
{
    public NYVeggiePizza()
    {
        Name = "New York Style Veggie";
        Dough = "Stuffed Crust";
        Sauce = "Tomato and Basil";
        Toppings = new () { "Mozzarella Cheese", "Pepper", "Corn" };
    }
}
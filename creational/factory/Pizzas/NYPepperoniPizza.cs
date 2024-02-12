namespace Factory.Pizza;
public class NYPepperoniPizza : Pizza
{
    public NYPepperoniPizza()
    {
        Name = "New York Style Pepperoni";
        Dough = "Regular";
        Sauce = "Marinara";
        Toppings = new () { "Mozzarella Cheese", "Pepperoni" };
    }   
}
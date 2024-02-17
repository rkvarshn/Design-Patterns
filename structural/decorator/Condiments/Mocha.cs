namespace decorator;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage) => Beverage = beverage;
    public override string Description 
    {
        get => Beverage.Description + ", Mocha";
    }
    public override double Cost() => Beverage.Cost() + 0.20;
}

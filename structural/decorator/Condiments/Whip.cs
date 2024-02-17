namespace decorator;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage) => Beverage = beverage;
    public override string Description
    {
        get => Beverage.Description + ", Whip";
    }
    public override double Cost() => Beverage.Cost() + 0.10;
}
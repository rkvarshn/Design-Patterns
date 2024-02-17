namespace decorator;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage) => Beverage = beverage;
    public override string Description
    {
        get => this.Beverage.Description + ", Soy";
    }
    public override double Cost() => Beverage.Cost() + 0.15;
}

namespace decorator;

public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage) => Beverage = beverage;
        public override string Description
        {
            get => Beverage.Description + ", Steamed Milk";
        }
        public override double Cost() => Beverage.Cost() + 0.10;
    }


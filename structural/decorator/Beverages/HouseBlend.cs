namespace decorator;

public class HouseBlend : Beverage
{
    public HouseBlend() => Description = "House Blend";
    public override double Cost() => 0.89;
}
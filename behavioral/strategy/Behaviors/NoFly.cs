namespace strategy;

public class NoFly : IFlyBehavior
{
    public void Fly() => Console.WriteLine("Can't fly");
}

namespace strategy;

public class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        _name = "Reahead Duck";
        _flyBehavior = new FlyWithWings();
        _quackBehaviour = new RealQuack();
    }
}

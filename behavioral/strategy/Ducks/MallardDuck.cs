namespace strategy;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        _name = "Mallard Duck";
        _flyBehavior = new FlyWithWings();
        _quackBehaviour = new RealQuack();
    }
}

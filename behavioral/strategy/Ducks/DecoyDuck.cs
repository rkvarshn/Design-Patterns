namespace strategy;

public class DecoyDuck : Duck
{
    public DecoyDuck()
    {
        _name = "Decoy Duck";
        _flyBehavior = new NoFly();
        _quackBehaviour = new SilentQuack();
    }
}

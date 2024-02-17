namespace strategy;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        _name = "Rubber Duck";
        _flyBehavior = new NoFly();
        _quackBehaviour = new Squeak();
    }
}

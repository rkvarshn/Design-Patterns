namespace strategy;

public abstract class Duck : IDuck
{
    protected IFlyBehavior _flyBehavior;
    protected IQuackBehaviour _quackBehaviour;
    protected string _name;
    public void Display() => Console.WriteLine(_name);
    public void Swim() => Console.WriteLine("Swimming");
    public void Quack() => _quackBehaviour?.Quack();
    public void Fly() => _flyBehavior?.Fly();
}
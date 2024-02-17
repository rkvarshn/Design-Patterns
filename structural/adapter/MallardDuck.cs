namespace adapter;

public class MallardDuck : IDuck
{
    public void Fly() => Console.WriteLine("Flying");
    public void Quack() => Console.WriteLine("Quack Quack!");
}

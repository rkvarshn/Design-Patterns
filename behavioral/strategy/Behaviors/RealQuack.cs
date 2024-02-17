namespace strategy;

public class RealQuack : IQuackBehaviour
{
    public void Quack() => Console.WriteLine("Quack Quack!");
}

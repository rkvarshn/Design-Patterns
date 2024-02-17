namespace strategy;

public class SilentQuack : IQuackBehaviour
{
    public void Quack() => Console.WriteLine("Silent");
}

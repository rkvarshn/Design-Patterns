namespace adapter;

public class WildTurkey : ITurkey
{
    public void Fly() => Console.WriteLine("Flying short distance");
    public void Gobble() => Console.WriteLine("Gobble Gobble!");
}

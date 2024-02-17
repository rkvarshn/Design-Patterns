namespace facade;

public class Projector
{
    public void On() => Console.WriteLine("Projector ON");
    public void SetInput(Player player) => Console.WriteLine($"Set the projector to play from {player.Name}");
    public void Off() => Console.WriteLine("Projector OFF"); 
}

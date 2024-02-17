namespace facade;

public class Player
{
    public string Name { get; set; }
    public Player(string n) => Name = n;
    public void On() => Console.WriteLine("Player ON");
    public void Off() => Console.WriteLine("Player OFF"); 
    public void PlayMovie(string m) => Console.WriteLine($"Playing movie {m}");
    public void Stop() => Console.WriteLine("Stopping...");
}

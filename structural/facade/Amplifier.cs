namespace facade;

public class Amplifier
{
    public void On() => Console.WriteLine("Amplifier ON");
    public void Off() => Console.WriteLine("Amplifier OFF");
    public void SetStreaming(Player player) => Console.WriteLine($"Streaming from {player.Name}");
    public void SetVolume(int x) => Console.WriteLine($"Volume set to {x}"); 
}

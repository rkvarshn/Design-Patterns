using System.Runtime.Serialization;

namespace command;

public class Light
{
    public void LightOn() => Console.WriteLine("Light is ON");
    public void LightOff() => Console.WriteLine("Light is OFF");
}
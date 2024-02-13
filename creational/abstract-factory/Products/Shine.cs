namespace abstract_factory;

public class Shine : IBike
{
    public int GetGears() => 4;
    public string GetName() => "Shine";
    public string GetRideType() => "Economy";
}

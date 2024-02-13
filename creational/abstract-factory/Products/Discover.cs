namespace abstract_factory;

public class Discover : IBike
{
    public int GetGears() => 4;
    public string GetName() => "Discover";
    public string GetRideType() => "Economy";
}

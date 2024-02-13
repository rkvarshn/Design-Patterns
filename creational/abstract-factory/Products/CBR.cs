namespace abstract_factory;

public class CBR : IBike
{
    public int GetGears() => 5;
    public string GetName() => "CBR";
    public string GetRideType() => "Sports";
}

namespace abstract_factory;

public class Pulsar : IBike
{
    public int GetGears() => 5;
    public string GetName() => "Pulsar";
    public string GetRideType() => "Sports";
}

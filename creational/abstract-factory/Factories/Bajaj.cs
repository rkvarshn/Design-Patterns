namespace abstract_factory;

public class Bajaj : ITwoWheelerFactory
{
    public IBike GetBike(string name) => name switch 
    {
        "pulsar" => new Pulsar(),
        "discover" => new Discover(),
        _ => throw new InvalidDataException()
    };

    public IScooty GetScooty(string name) => name switch
    {
        "chetak" => new Chetak(),
        _ => throw new InvalidDataException()
    };
}

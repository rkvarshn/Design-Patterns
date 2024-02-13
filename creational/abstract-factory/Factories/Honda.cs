namespace abstract_factory;

public class Honda : ITwoWheelerFactory
{
    public IBike GetBike(string name) => name switch 
    {
        "shine" => new Shine(),
        "cbr" => new CBR(),
        _ => throw new InvalidDataException()
    };

    public IScooty GetScooty(string name) => name switch
    {
        "activa" => new Activa(),
        _ => throw new InvalidDataException()
    };
}

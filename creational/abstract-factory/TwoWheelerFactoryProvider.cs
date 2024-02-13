namespace abstract_factory;

public class TwoWheelerFactoryProvider : ITwoWheelerFactoryProvider
{
    public ITwoWheelerFactory GetFactory(string brand) => brand switch 
    {
        "honda" => new Honda(),
        "bajaj" => new Bajaj(),
        _ => throw new InvalidDataException()
    };
}

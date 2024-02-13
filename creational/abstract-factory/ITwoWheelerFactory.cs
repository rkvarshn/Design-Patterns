namespace abstract_factory;
public interface ITwoWheelerFactory
{
    IScooty GetScooty(string name);
    IBike GetBike(string name);
}

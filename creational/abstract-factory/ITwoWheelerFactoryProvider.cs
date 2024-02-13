namespace abstract_factory;

public interface ITwoWheelerFactoryProvider
{
    ITwoWheelerFactory GetFactory(string brand);
}

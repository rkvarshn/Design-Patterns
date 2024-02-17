namespace observer;

public class WeatherStationSubject : ISubject
{
    private List<IObserver> _observers;
    private float _temperature;
    private float _humidity;
    private float _pressure;
    public WeatherStationSubject() => _observers = new List<IObserver>();
    public void RegisterObserver(IObserver observer) => _observers.Add(observer);
    public void RemoveObserver(IObserver observer) => _observers.Remove(observer);
    public void NotifyObservers()
    {
        foreach(IObserver observer in _observers)
            observer.Update(_temperature, _humidity, _pressure);
    }
    public void SetMeasurements(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;
        _pressure = pressure;
        NotifyObservers();
    }
}

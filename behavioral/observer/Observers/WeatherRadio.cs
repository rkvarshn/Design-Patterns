namespace observer;

public class WeatherRadio : IObserver
{
    // each observer comsumes/displays info in its own manner
    void Announce(float temp, float humidity, float pressure) 
    {
        Console.WriteLine("\nWeather Radio Announcement");
        Console.WriteLine($"The current weather conditions have changed. Currently its {temp} degree celcius with humidity of {humidity} percentage and pressure of {pressure} hectopascal. Have a nice time!");
    }

    // implement update method for each observer
    public void Update(float temp, float humidity, float pressure)
    {
        Announce(temp, humidity, pressure);
    }
}

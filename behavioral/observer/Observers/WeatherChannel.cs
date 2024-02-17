namespace observer;

public class WeatherChannel : IObserver
{
    void Display(float temp, float humidity, float pressure)
    {
        Console.WriteLine("\nWeather Channel Display");
        Console.WriteLine("Weather Updates-");
        Console.WriteLine($"Tempreature: {temp} °C");
        Console.WriteLine($"Humidity: {humidity} %");
        Console.WriteLine($"Pressure: {pressure} hPa");
    }
    public void Update(float temp, float humidity, float pressure)
    {
        Display(temp, humidity, pressure);
    }
}

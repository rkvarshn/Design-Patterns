using observer;

WeatherStationSubject weatherStation = new();
IObserver weatherChannel = new WeatherChannel();
IObserver weatherRadio = new WeatherRadio();
weatherStation.RegisterObserver(weatherChannel);
weatherStation.RegisterObserver(weatherRadio);

weatherStation.SetMeasurements(19,22, 1012);

// radio channel switched to other weather station, so won't be receiving updates
weatherStation.RemoveObserver(weatherRadio);

weatherStation.SetMeasurements(20,25, 1000);
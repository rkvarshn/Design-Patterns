using abstract_factory;

ITwoWheelerFactory hondaFactory = new Honda();
ITwoWheelerFactory bajajFactory = new Bajaj();

IScooty activa = hondaFactory.GetScooty("activa");
print_scooty_details(activa);
IScooty chetak = bajajFactory.GetScooty("chetak");
print_scooty_details(chetak);

var shine = hondaFactory.GetBike("shine");
print_bike_details(shine);
var cbr = hondaFactory.GetBike("cbr");
print_bike_details(cbr);
var discover = bajajFactory.GetBike("discover");
print_bike_details(discover);
var pulsar = bajajFactory.GetBike("pulsar");
print_bike_details(pulsar);

void print_bike_details(IBike bike) => Console.WriteLine($"Bike {bike.GetName()} is {bike.GetRideType()} ride with {bike.GetGears()} gears");
void print_scooty_details(IScooty scooty) => Console.WriteLine($"Scooty {scooty.GetName()} is {scooty.GetFuelType()} vehicle");
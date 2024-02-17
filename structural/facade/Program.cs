using facade;

// setting up services, normally will be registered within dependency injection framework
Projector projector = new();
Lights lights = new();
Popper popper = new();
Amplifier amplifier = new();
Screen screen = new();
Player player = new("Blu-ray player");

// creating an instance of facade. this too may be registered with DI framework
HomeTheaterFacade homeTheaterFacade = new(amplifier, lights, player, popper, projector, screen);

// just two methods exposed by facade, that we have to call
homeTheaterFacade.WatchMovie("Batman");
homeTheaterFacade.EndMovie();

namespace facade;

public class HomeTheaterFacade
{
    Amplifier _amplifier;
    Lights _lights;
    Player _player;
    Popper _popper;
    Projector _projector;
    Screen _screen;
    public HomeTheaterFacade(Amplifier amplifier, Lights lights, Player player, Popper popper, Projector projector, Screen screen)
    {
        _amplifier = amplifier;
        _lights = lights;
        _player = player;
        _popper = popper;
        _projector = projector;
        _screen = screen;
    }
    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch movie...");
        
        _lights.On();
        
        _popper.On();

        _player.On();

        _screen.Down();

        _amplifier.On();
        _amplifier.SetVolume(7);
        _amplifier.SetStreaming(_player);

        _projector.On();
        _projector.SetInput(_player);

        _popper.GetPopcorn();
        _player.PlayMovie(movie);

        Console.WriteLine();
    }
    public void EndMovie()
    {
        Console.WriteLine("Shutting the theater down...");

        _player.Stop();
        _player.Off();

        _popper.Off();

        _projector.Off();

        _amplifier.Off();

        _screen.Up();

        _lights.Off();

        Console.WriteLine();
    }
}

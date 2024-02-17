namespace command;

public class FanOffCommand : ICommand
{
    Fan fan;
    public FanOffCommand(Fan f) => fan = f;
    public void Execute() => fan.FanOff();
    public void Undo() => fan.FanOn();
}
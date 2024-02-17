namespace command;

public class FanOnCommand : ICommand
{
    Fan fan;
    public FanOnCommand(Fan f) => fan = f;
    public void Execute() => fan.FanOn();
    public void Undo() => fan.FanOff();
}

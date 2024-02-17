namespace command;

public class LightOffCommand : ICommand
{
    Light light;
    public LightOffCommand(Light l) => light = l;
    public void Execute() => light.LightOff();
    public void Undo() => light.LightOn();
}

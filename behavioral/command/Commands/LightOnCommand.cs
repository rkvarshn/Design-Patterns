namespace command;

public class LightOnCommand: ICommand
{
    Light light;
    public LightOnCommand(Light l) => light = l;
    public void Execute() => light.LightOn();
    public void Undo() => light.LightOff();
}

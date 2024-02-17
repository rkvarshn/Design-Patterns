namespace command;

public class GarageDoorOpenCommand: ICommand
{
    GarageDoor garageDoor;
    public GarageDoorOpenCommand(GarageDoor g) => garageDoor = g;
    public void Execute() => garageDoor.PullUp();
    public void Undo() => garageDoor.PullDown();
}
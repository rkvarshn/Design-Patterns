namespace command;

public class GarageDoorCloseCommand : ICommand
{
    GarageDoor garageDoor;
    public GarageDoorCloseCommand(GarageDoor g) => garageDoor = g;
    public void Execute() => garageDoor.PullDown();
    public void Undo() => garageDoor.PullUp();
}

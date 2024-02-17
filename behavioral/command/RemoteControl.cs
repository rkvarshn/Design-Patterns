namespace command;

// this is the invoker
public class RemoteControl
{
    List<(ICommand, ICommand)> slots;
    ICommand lastCommand;
    public RemoteControl()
    {
        slots = new List<(ICommand, ICommand)>
        {
            (new NoCommand(), new NoCommand()),
            (new NoCommand(), new NoCommand()),
            (new NoCommand(), new NoCommand()),
            (new NoCommand(), new NoCommand()),
            (new NoCommand(), new NoCommand()),
        };
        lastCommand = new NoCommand();
    }
    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand) => 
        slots[slot] = (onCommand, offCommand);
    public void OnButtonPressed(int slot)
    {
        slots[slot].Item1.Execute();
        lastCommand = slots[slot].Item1;
    }
    public void OffButtonPressed(int slot)
    {
        slots[slot].Item2.Execute();
        lastCommand = slots[slot].Item1;
    }
    public void UndoButtonPressed() => lastCommand.Undo();
}
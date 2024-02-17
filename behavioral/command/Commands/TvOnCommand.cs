namespace command;

public class TvOnCommand : ICommand
{
    Television tv;
    public TvOnCommand(Television t) => tv = t;
    public void Execute() => tv.TelevisionOn();
    public void Undo() => tv.TelevisionOff();
}

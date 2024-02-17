namespace command;

public class TvOffCommand: ICommand
{
    Television tv;
    public TvOffCommand(Television t) => tv = t;
    public void Execute() => tv.TelevisionOff();
    public void Undo() => tv.TelevisionOn();
}
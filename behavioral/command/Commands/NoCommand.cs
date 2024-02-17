namespace command;

public class NoCommand : ICommand
{
    public void Execute() => Console.WriteLine();
    public void Undo() => Console.WriteLine();
}

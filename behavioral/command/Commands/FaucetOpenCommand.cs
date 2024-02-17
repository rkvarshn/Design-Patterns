namespace command;

public class FaucetOpenCommand : ICommand
{
    FaucetControl faucetControl;
    public FaucetOpenCommand(FaucetControl f) => faucetControl = f;
    public void Execute() => faucetControl.OpenValve();
    public void Undo() => faucetControl.ShutValve();
}

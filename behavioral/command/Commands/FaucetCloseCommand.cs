namespace command;

public class FaucetCloseCommand : ICommand
{
    FaucetControl faucetControl;
    public FaucetCloseCommand(FaucetControl f) => faucetControl = f;
    public void Execute() => faucetControl.ShutValve();
    public void Undo() => faucetControl.OpenValve();
}

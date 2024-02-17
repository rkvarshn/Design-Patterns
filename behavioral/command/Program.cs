// The Command Pattern decouples an object making a request from the one that knows how to perform it.
// Client -> which performs the action (Program)
// Invoker -> Remote Control has set command method to register command
// Command -> command has a receiver
// Receiver -> Appliances which actually perform action

using command;

Fan fan = new();
FaucetControl faucetControl = new();
GarageDoor garageDoor = new();
Light light = new();
Television television = new();

RemoteControl remoteControl = new RemoteControl();

remoteControl.SetCommand(0, new FanOnCommand(fan), new FanOffCommand(fan));
remoteControl.SetCommand(1, new FaucetOpenCommand(faucetControl), new FaucetCloseCommand(faucetControl));
remoteControl.SetCommand(2, new GarageDoorOpenCommand(garageDoor), new GarageDoorCloseCommand(garageDoor));
remoteControl.SetCommand(3, new LightOnCommand(light), new LightOffCommand(light));
remoteControl.SetCommand(4, new TvOnCommand(television), new TvOffCommand(television));

remoteControl.OnButtonPressed(0);
remoteControl.OnButtonPressed(3);
remoteControl.OnButtonPressed(4);
remoteControl.UndoButtonPressed();
remoteControl.OffButtonPressed(3);
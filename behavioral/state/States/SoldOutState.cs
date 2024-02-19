namespace state;

public class SoldOutState : IGumballMachineState
{
    GumballMachine _machine;   
    public SoldOutState(GumballMachine machine) => _machine = machine;
    public void Dispense() => Console.WriteLine("No gumball dispensed");
    public void EjectQuarter() => Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
    public void InsertQuarter() => Console.WriteLine("Sorry, gumballs are sold out");
    public void TurnCrank() => Console.WriteLine("You turned, but there are no gumballs");
}

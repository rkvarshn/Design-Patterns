namespace state;

public class HasQuarterState : IGumballMachineState
{
    GumballMachine _machine;
    public HasQuarterState(GumballMachine machine) => _machine = machine;
    public void InsertQuarter() => Console.WriteLine("You can't insert another quarter");
    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned");
        _machine.CurrentState = _machine.NoQuarterState;
    }
    public void TurnCrank()
    {
        Console.WriteLine("You turned...");
        _machine.CurrentState = _machine.SoldState;
    }
    public void Dispense() => Console.WriteLine("No gumball dispensed");
}
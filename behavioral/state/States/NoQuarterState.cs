namespace state;

public class NoQuarterState : IGumballMachineState
{
    GumballMachine _machine;   
    public NoQuarterState(GumballMachine machine) => _machine = machine;
    public void Dispense() => Console.WriteLine("You need to pay first");
    public void EjectQuarter() => Console.WriteLine("You haven't inserted a quarter");
    public void InsertQuarter()
    {
         Console.WriteLine("You inserted a quarter");
        _machine.CurrentState = _machine.HasQuarterState;
    }
    public void TurnCrank() => Console.WriteLine("You turned, but there's no quarter");
}

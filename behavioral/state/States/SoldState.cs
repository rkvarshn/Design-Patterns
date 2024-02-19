namespace state;

public class SoldState : IGumballMachineState
{
    GumballMachine _machine;   
    public SoldState(GumballMachine machine) => _machine = machine;
    public void Dispense()
    {
        _machine.ReleaseBall();
        if (_machine.Count > 0)
        {
            _machine.CurrentState = _machine.NoQuarterState;
            return;
        }
        Console.WriteLine("Oops, out of gumballs!");
        _machine.CurrentState = _machine.SoldOutState;
    }
    public void EjectQuarter() => Console.WriteLine("Sorry, you already turned the crank");
    public void InsertQuarter() => Console.WriteLine("Please wait, we're already giving you a gumball");
    public void TurnCrank() => Console.WriteLine("Turning twice doesn't get you another gumball!");
}
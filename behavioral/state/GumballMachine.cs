namespace state;
// Context class: GumballMachine
public class GumballMachine
{
    public IGumballMachineState SoldOutState { get; init; }
    public IGumballMachineState NoQuarterState { get; init; }
    public IGumballMachineState HasQuarterState { get; init; }
    public IGumballMachineState SoldState { get; init; }
    public IGumballMachineState CurrentState { get; set; }
    public int Count { get; set; }
    public GumballMachine(int numOfGumballs)
    {
        SoldOutState = new SoldOutState(this);
        NoQuarterState = new NoQuarterState(this);
        HasQuarterState = new HasQuarterState(this);
        SoldState = new SoldState(this);
        Count = numOfGumballs;
        CurrentState = numOfGumballs > 0 ? NoQuarterState : SoldOutState;
    }
    // actions that can be performed on gumball machine
    public void InsertQuarter() => CurrentState.InsertQuarter();
    public void EjectQuarter() => CurrentState.EjectQuarter();
    public void TurnCrank()
    {
        CurrentState.TurnCrank();
        CurrentState.Dispense();
    }
    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out the slot...");
        if (Count != 0)
            Count--;
    }
}

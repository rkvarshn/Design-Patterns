using state;

GumballMachine gumballMachine = new GumballMachine(5);

Console.WriteLine(gumballMachine.Count + " gumballs available");

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();

Console.WriteLine(gumballMachine.Count + " gumballs available");

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.InsertQuarter();
gumballMachine.EjectQuarter();
gumballMachine.TurnCrank();

Console.WriteLine(gumballMachine.Count + " gumballs available");

gumballMachine.InsertQuarter();
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();

Console.WriteLine(gumballMachine.Count + " gumballs available");

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();

Console.WriteLine(gumballMachine.Count + " gumballs available");
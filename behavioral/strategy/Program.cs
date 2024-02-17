using strategy;

IDuck[] ducks = 
{ 
    new MallardDuck(),
    new RedheadDuck(),
    new DecoyDuck(),
    new RubberDuck()
};

foreach(IDuck duck in ducks)
{
    duck.Display();
    duck.Quack();
    duck.Fly();
    Console.WriteLine();
}
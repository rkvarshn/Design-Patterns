using adapter;

IDuck mallardDuck = new MallardDuck();
ITurkey wildTurkey = new WildTurkey();
IDuck turkeyDuck = new TurkeyAdapter(wildTurkey); // convert turkey to a duck using adapter

TestDuck(mallardDuck);
TestDuck(turkeyDuck);

static void TestDuck(IDuck duck)
{
    duck.Quack();
    duck.Fly();
}
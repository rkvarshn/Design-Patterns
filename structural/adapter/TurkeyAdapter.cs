namespace adapter;

public class TurkeyAdapter : IDuck
{
    ITurkey turkey;
    public TurkeyAdapter(ITurkey t) => turkey = t;
    public void Fly()
    {
        for(int i = 0; i < 5; i++) 
            turkey.Fly();
    }
    public void Quack()
    {
        turkey.Gobble();
    }
}

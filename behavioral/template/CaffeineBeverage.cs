namespace template;

public abstract class CaffeineBeverage
{
    // template method
    public void PrepareRecepie()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }
    protected void BoilWater() => Console.WriteLine("Boiling Water");
    protected abstract void Brew();
    protected void PourInCup() => Console.WriteLine("Pouring into cup");
    protected abstract void AddCondiments();
}

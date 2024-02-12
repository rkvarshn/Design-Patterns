class MyClass
{
    private static readonly object _locker = new();
    private static MyClass? _instance = null;
    private MyClass()
    {
        Console.WriteLine("Constructor called");
    }
    public static MyClass GetInstance()
    {
        if(_instance == null)
        {
            lock(_locker) // lock is used to prevent other threads to create instance at the same time
            {
                if(_instance == null) // this prevents other instances waiting on lock to re-initialize, adding an extra layer of safety
                {
                    _instance = new MyClass();
                }
            }
        }
        return _instance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass.GetInstance(); // only first time constructor is called
        MyClass.GetInstance(); // constructor will nor be called as instance created by previous call will be returned
    }
}
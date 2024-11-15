using Usercounter;

class Program
{
    static void Main()
    {

        var userCounter = new UserCounterSingleton(10);

        userCounter.UserAdd();
        userCounter.UserAdd();
        userCounter.UserAdd();
        userCounter.UserAdd();
        userCounter.UserRemove();
        Console.WriteLine("user count=<{0}>",userCounter.UserGetCount());

    }
}
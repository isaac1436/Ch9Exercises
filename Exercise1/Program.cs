class Exercise1
{    
    static void Main()
    {
        Console.Write("Please enter your name: ");
        string tempName = Console.ReadLine();
        sayHello(tempName);
    }

    static void sayHello(string tempName)
    {
        Console.WriteLine("Hello, {0}!",tempName);
    }
}
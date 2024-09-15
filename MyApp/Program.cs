using System;
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!1111");
        GreetUser("User");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

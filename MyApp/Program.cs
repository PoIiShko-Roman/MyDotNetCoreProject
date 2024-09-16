using System;
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!Hello, World!");
        GreetUser("User");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

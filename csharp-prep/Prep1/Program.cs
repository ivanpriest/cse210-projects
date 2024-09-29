using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your firstname? ");
        string firstname = Console.ReadLine();

        Console.Write("what is your lastname? ");
        string lastname=Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
           string userName=Console.ReadLine();
           return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber=int.Parse(Console.ReadLine());
            return userNumber;
        }
        static int SquareNumber( int numberToBeSquared)
        {
            int squaredNumber=numberToBeSquared*numberToBeSquared;
            return squaredNumber;
        }
        static void DisplayResult(string userName,int squaredNumber)
        {
            Console.WriteLine($"{userName}, the sqaure of your number is {squaredNumber}");
        }
        
        DisplayWelcome();
        string name=PromptUserName();
        int number=PromptUserNumber();
        int square=SquareNumber(number);
        DisplayResult(name,square);

    }
}
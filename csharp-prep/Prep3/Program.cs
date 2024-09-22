using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 51);
        Console.WriteLine("Guess is the magic number?: ");
        string guessInput=Console.ReadLine();
        int guessedNumber=int.Parse(guessInput);
        int numberOfGuesses=1;
        
        while (guessedNumber != magicNumber)
        {
           if (guessedNumber > magicNumber)
           {
             Console.WriteLine("Lower");
           }
           else if (guessedNumber < magicNumber)
           {
             Console.WriteLine("Higher");
           }
           Console.WriteLine("Try again guess the magic number?: ");
           int loopGuessedNumber=int.Parse(Console.ReadLine());
           guessedNumber=loopGuessedNumber;
           numberOfGuesses=+1; 
        }
        if (guessedNumber == magicNumber)
        {
            Console.WriteLine("That is correct you guessed right");
            Console.WriteLine($"You made {numberOfGuesses} guess(es)"); 
        }

    }
}
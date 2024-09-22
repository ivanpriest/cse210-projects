using System;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers=new List <int> ();

        Console.WriteLine("Enter a number enter zero to stop: ");
        int number=int.Parse(Console.ReadLine());
        int sum=0;
        int max=0;
        int avg;

        while (number != 0)
        {
            
            numbers.Add(number);
            Console.WriteLine("Enter another Remember to enter 0 to stop: ");
            number=int.Parse(Console.ReadLine());
            
        }
        if (numbers.Count >=1);
        {
            foreach (int num in numbers)
            {
              sum=sum+num;
              if (num >max) 
              {
                max=num;
              } 
              Console.WriteLine(num); 
            }
        }
        avg=sum/numbers.Count;
        Console.WriteLine($"Sum= {sum}");
        Console.WriteLine($"Average= {avg}");
        Console.WriteLine($"Largest number in the list = {max}");
    }
}
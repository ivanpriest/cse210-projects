using System;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers=new List <int> ();

        Console.Write("Enter a number enter zero to stop: ");
        int number=int.Parse(Console.ReadLine());
        int sum=0;
        int max=0;
        double avg;

        while (number != 0)
        {
            
            numbers.Add(number);
            Console.Write("Enter another Remember to enter 0 to stop: ");
            number=int.Parse(Console.ReadLine());
            
        }
        if (numbers.Count >=1);
        {
            foreach (int num in numbers)
            {
              sum+=num;
              if (num >max) 
              {
                max=num;
              } 
               
            }
        }
        avg=sum/numbers.Count;
        Console.WriteLine($"Sum={sum}");
        Console.WriteLine($"Average={avg}");
        Console.WriteLine($"Largest number in the list ={max}");
    }
}
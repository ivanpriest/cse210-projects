using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions firstFrac= new Fractions();
        string fraction = firstFrac.GetFractionString();
        double value=firstFrac.GetDecimalValue();
        Console.WriteLine($"{fraction}");
        Console.WriteLine($"{value}");

        Fractions secondFrac= new Fractions(4);
        string fraction2 = secondFrac.GetFractionString();
        double value2=secondFrac.GetDecimalValue();
        Console.WriteLine($"{fraction2}");
        Console.WriteLine($"{value2}");

         Fractions thirdFrac= new Fractions(10,2);
        string fraction3 = thirdFrac.GetFractionString();
        double value3=thirdFrac.GetDecimalValue();
        Console.WriteLine($"{fraction3}");
        Console.WriteLine($"{value3}");
    }
}
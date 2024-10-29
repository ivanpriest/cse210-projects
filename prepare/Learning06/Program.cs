using System;

class Program
{
    static void Main(string[] args)
    {
        Circle cir=new Circle("white",2);
        Console.WriteLine($"{cir.GetArea()}");

        Rectangle rect=new Rectangle("white",4,2);
        Console.WriteLine($"{rect.GetArea()}");

        Square sqr=new Square("white",2);
        Console.WriteLine($"{sqr.GetArea()}");
    }
}
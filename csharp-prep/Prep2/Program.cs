using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your score percent: ");
        string userinput=Console.ReadLine();
        int scorePercent = int.Parse(userinput);
        string letter="";
        int quotient;
        int remainder;
        string plusOrMinus="";
        if(scorePercent>=90)
        {  
            letter="A";    
        }
        else if(scorePercent>=80 && scorePercent<90)
        {
            letter="B";
           
        }
        else if(scorePercent>=70 && scorePercent <80)
        {
             
            letter="C";
            
        }
        else if(scorePercent>=60 && scorePercent<70)
        {
             
            letter="D";

        }
        else if(scorePercent>=0 && scorePercent<60)
        {
        
            letter="F";
        }
        else
        {
            Console.WriteLine("Error please enter a valid score percent");
        }
        quotient=scorePercent/10 ;
        remainder=scorePercent-(quotient*10);
        if (remainder>=7)
        {
            plusOrMinus="+";
        }
        else if (remainder<3)
        {
            plusOrMinus="-";
        }
        Console.WriteLine($"___________{letter}{plusOrMinus}_________");
        if (scorePercent>=70 && scorePercent<=100)
        {
            Console.WriteLine("Congratulations you have passed the exams");
        }
        else if (scorePercent<=69 && scorePercent>=0)
        {
            Console.WriteLine("Sorry you have failed try again next time");
        }
    }
}
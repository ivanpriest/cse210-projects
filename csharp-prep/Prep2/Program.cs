using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your score percent: ");
        string userinput=Console.ReadLine();
        int scorePercent = int.Parse(userinput);
        string letter="";
        string message="";
        string plusOrMinus="";
        if(scorePercent>=90)
        {   
            message="Congratulations you have passed the exams";
            letter="A";
            if(scorePercent>=97)
            {
                plusOrMinus="+";

            }
            else if(scorePercent<=97)
            {
                plusOrMinus="-";

            }

        }
        else if(scorePercent>=80 && scorePercent<90)
        {
            message="Congratulations you have passed the exams";
            letter="B";
            if(scorePercent>=87)
            {
                plusOrMinus="+";

            }
            else if(scorePercent<=87)
            {
                plusOrMinus="-";

            }

        }
        else if(scorePercent>=70 && scorePercent <80)
        {
             message="Congratulations you have passed the exams";
            letter="C";
            if(scorePercent>=77)
            {
                plusOrMinus="+";

            }
            else if(scorePercent<=77)
            {
                plusOrMinus="-";

            }

        }
        else if(scorePercent>=60 && scorePercent<70)
        {
             message="Sorry you have failed try again next time";
            letter="D";
            if(scorePercent>=67)
            {
                plusOrMinus="+";

            }
            else if(scorePercent<=67)
            {
                plusOrMinus="-";

            }

        }
        else if(scorePercent>=0 && scorePercent<60)
        {
            message="Sorry you have failed try again next time";
            letter="F";
        }
        else
        {
            Console.WriteLine("Error please enter a valid score percent");
        }
      Console.WriteLine($"___________{letter}{plusOrMinus}_________");
      Console.WriteLine(message);
    }
}
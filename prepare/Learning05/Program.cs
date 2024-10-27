using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assgn =new Assignment("Ivan","math");
        string message= assgn.GetSummary();
        MathAssignment math1 = new MathAssignment("ivan","fraction","109","1.2");
        WritingAssignment write1= new WritingAssignment("Ivan","writing","ME");
        string message1=math1.GetSummary();
        string message2=math1.GetHomeworkList();
        string message3=write1.GetWritingInformation();
        Console.WriteLine($"{message} {message1} {message2} {message3}");
    }
}
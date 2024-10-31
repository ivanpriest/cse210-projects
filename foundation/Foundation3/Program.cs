using System;

class Program
{
    static void Main(string[] args)
    {
       RunningActivity newRunning=new RunningActivity(30,5);
       CyclingActivity newCycling=new CyclingActivity(30,10);
       SwimmingActivity newSwimming=new SwimmingActivity(30,2);
       string runningMassage=newRunning.GetSummary();
       string cyclingMassage=newCycling.GetSummary();
       string swimmingMassage=newSwimming.GetSummary();
       Console.WriteLine($"{runningMassage}\n{cyclingMassage}\n{swimmingMassage}");
    }
}
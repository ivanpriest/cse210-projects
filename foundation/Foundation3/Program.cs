using System;

class Program
{
    static void Main(string[] args)
    {
       List<Activity> activityList=new List<Activity>();
       RunningActivity newRunning=new RunningActivity(30,5);
       activityList.Add(newRunning);
       CyclingActivity newCycling=new CyclingActivity(30,10);
       activityList.Add(newCycling);
       SwimmingActivity newSwimming=new SwimmingActivity(30,50);
       activityList.Add(newSwimming);
       foreach(Activity activity in activityList)
       {
         Console.WriteLine($"{activity.GetSummary()}");
       }
       
    }
}
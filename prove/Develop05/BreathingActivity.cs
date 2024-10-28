public class BreathingActivity: Activity
{
public BreathingActivity(string name="Breathing Activity",string description="This exercise will help calm down and be mindful through breathing in and out"):base(name,description)
{

}

public void Run()
{
   Console.Write($"How long do you want to do this activity to last (in seconds): ");
   SetDuration(int.Parse(Console.ReadLine()));
   Console.Write($"Get ready ... ");
   ShowSpinner(2); 
   DateTime endTime=DateTime.Now.AddSeconds(GetDuration());
   while(DateTime.Now < endTime)
   {
      Console.Clear();
      Console.Write($"Breath in... ");
      ShowCountDown(5);
      Console.Clear();
      Console.Write($"Breath out... ");
      ShowCountDown(5);
      Console.Clear();

   }
   
}

}
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager1 =new GoalManager();
        manager1.DisplayPlayerInfo();
        manager1.Start();
        int userChoice1=int.Parse(Console.ReadLine());
        while (userChoice1!=6)
        {
            if (userChoice1==1)
            {
                manager1.CreateGoal();
                
            }
            else if (userChoice1==2)
            {
                Console.Clear();
                manager1.ListGoalDetails();
            }
            else if (userChoice1==3)
            {
                Console.Write($"Enter the name of the file: ");
                string filename=Console.ReadLine();
                manager1.SaveGoal(filename);
                Console.Write($"Saving...");
                Thread.Sleep(3000);
                Console.Clear();
                Console.Write($"Done");
            }
            else if (userChoice1==4)
            {
               Console.Write($"What file do want to load from: ");
               string filename=Console.ReadLine();
               Console.Clear();
               Console.WriteLine($"Loading...");
               Thread.Sleep(2000);
               manager1.LoadGoal(filename);
               Console.Write($"Done");
               Thread.Sleep(2000);
               Console.Clear();
            }
            else if (userChoice1==5)
            {
                manager1.RecordEvent(); 
            }
            Console.Write($"\nEnter 1 to go back to main menu: ");
            int noUse=int.Parse(Console.ReadLine());
            Console.Clear();
             manager1.DisplayPlayerInfo();
            manager1.Start();
            userChoice1=int.Parse(Console.ReadLine());
        }


        
    }
}
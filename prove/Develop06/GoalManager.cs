public class GoalManager
{
    private List<Goal> _goals=new List<Goal>();

    private int _score=0;

    public GoalManager()
    {

    }

    public void AddToList(Goal goal)
    {
        _goals.Add(goal);
    }
    public void SetScore(int score)
    {
        _score=score;
    }
    public void Start ()
    {
        Console.Write($"\nMenu Option\n1.Create New Goal\n2.List Goals\n3.Save Goals\n4.Load Goals\n5.Record Event\n6.Quit\nWhat do you wanna do: ");

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current score {_score}");
    }
    public void ListGoalNames()
    {
        Console.Write($"\n1.Simple Goal\n2.Eternal Goal\n3.Checklist Goal\nWhat Goal You want to create: ");
    }
    public void ListGoalDetails()
    {
        int index=0;
        foreach(Goal goal in _goals)
        {
            index+=1;
            string goalDetails =goal.GetDetailsString();
            Console.WriteLine($"{index}.{goal.GetDetailsString()}");

        }
    }
    public void CreateGoal()
    {
        ListGoalNames();
        int userChoice2 = int.Parse(Console.ReadLine());
        
        if(userChoice2==1)
        {
            Console.Write($"What is the name of your goal: ");
            string nameOfGoal=Console.ReadLine();
            Console.Write($"Give a short description of your goal: ");
            string descriptionOfGoal=Console.ReadLine();
            Console.Write($"What is the point associated for this goal: ");
            string pointForGoal=Console.ReadLine();
            SimpleGoal newSimpleGoal= new SimpleGoal(nameOfGoal,descriptionOfGoal,pointForGoal);
            _goals.Add(newSimpleGoal);
        }
        else if(userChoice2==2)
        {
        Console.Write($"What is the name of your goal: ");
        string nameOfGoal=Console.ReadLine();
        Console.Write($"Give a short description of your goal: ");
        string descriptionOfGoal=Console.ReadLine();
        Console.Write($"What is the point associated for this goal: ");
        string pointForGoal=Console.ReadLine();
        EternalGoal newEternalGoal = new EternalGoal(nameOfGoal,descriptionOfGoal,pointForGoal);
        _goals.Add(newEternalGoal);
        }
        else if(userChoice2==3)
        {
            Console.Write($"What is the name of your goal: ");
            string nameOfGoal=Console.ReadLine();
            Console.Write($"Give a short description of your goal: ");
            string descriptionOfGoal=Console.ReadLine();
            Console.Write($"What is the point associated for this goal: ");
            string pointForGoal=Console.ReadLine();
            Console.Write($"How many times would like to get this done: ");
            int targetOfGoal=int.Parse(Console.ReadLine());
            Console.Write($"What should be bonus for Achieving the target of your goal: ");
            int bonusForGoal=int.Parse(Console.ReadLine());
            CheckListGoal newCheckListGoal= new CheckListGoal(nameOfGoal,descriptionOfGoal,pointForGoal,targetOfGoal,bonusForGoal);
            _goals.Add(newCheckListGoal);
        }
    
        

    }
    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write($"Which goal did you accomplish? ");
        int userGoalAccomlished=int.Parse(Console.ReadLine());
        int realIndex=userGoalAccomlished-1;
        _goals[realIndex].RecordEvent();
        string point=_goals[realIndex].GetPoints();
        _score=_score+int.Parse(point);
    }
    public void SaveGoal(string filename)
    {
        using (StreamWriter outputFile =new StreamWriter(filename))
        {
            foreach(Goal goal in _goals)
           {
             outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            } 
        }

    }
    public void LoadGoal(string filename)
    {
        _goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
           string[] parts = line.Split(":");
           string[] goalAttributes = parts[1].Split("-");
           if (parts[0].ToLower()=="simple")
           {
              SimpleGoal newSimpleGoal= new SimpleGoal(goalAttributes[0],goalAttributes[1],goalAttributes[2],bool.Parse(goalAttributes[3]));
              _goals.Add(newSimpleGoal);
           }
           else if (parts[0].ToLower()=="eternal")
           {
              EternalGoal newEternalGoal= new EternalGoal(goalAttributes[0],goalAttributes[1],goalAttributes[2]);
              _goals.Add(newEternalGoal);
            }
           else if (parts[0].ToLower()=="checklist")
           {
              CheckListGoal newChecklistGoal= new CheckListGoal(goalAttributes[0],goalAttributes[1],goalAttributes[2],int.Parse(goalAttributes[3]),int.Parse(goalAttributes[4]));
              _goals.Add(newChecklistGoal);
            }
            foreach (Goal goal in _goals)
            {
               if (goal.IsComplete()==true)
               {
                   _score=_score+int.Parse(goal.GetPoints());
               }
            }
        }
      
       

    }
}
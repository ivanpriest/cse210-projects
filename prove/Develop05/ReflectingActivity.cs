public class ReflectingActivity : Activity
{
    private List<string> _prompts= new List<string>{$"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
    private List<string> _questions =new List<string>{$"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What is your favorite thing about this experience?"};


    public ReflectingActivity(string name="Reflecting Activity", string description="This exercise helps you be mindful by helping you reflect on significant events in your life"): base(name,description)
    {

    }
    
    public string GetRandomPrompt()
    {
        List<int> randomIndexes= new List<int>();
        Random random =new Random();
        int index;
        index= random.Next(_prompts.Count);
        while (randomIndexes.Contains(index))
        {
          index= random.Next(_prompts.Count);
        }
        randomIndexes.Add(index);
        return _prompts[index];

    }

    public string GetRandomQuestion()
    {
        
        Random random =new Random();
        int index;
        index= random.Next(_prompts.Count);
        return _questions[index];

    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"\n---{GetRandomPrompt()}---\n");
    }
    public void DisplayQuestion()
    {
        Console.WriteLine($"{GetRandomQuestion()}");
    
    }
    public void Run()
    {   
        Console.Write($"How long do you want to do this activity to last (in seconds): ");
        SetDuration(int.Parse(Console.ReadLine()));
        ShowSpinner(3);
        DisplayPrompt();
        Console.WriteLine($"Reflect on the following related questions\n");
        Thread.Sleep(3000);
        DateTime  endTime= DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(5);
        }
    }

}
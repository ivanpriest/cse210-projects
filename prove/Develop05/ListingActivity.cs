public class ListingActivity: Activity
{
   private int _count;
   private List<string> _prompts = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?"};


   public ListingActivity(string name="Listing Activity", string description="This activity helps be mindful by allowing you give a number of replies to a prompt.") : base (name,description)
   {
      
   }

   public void SetCount(int count)
   {
      _count=count;
   }
   public List<string> GetListFromUser()
   {
      List<string> userResponses=new List<string>();
      DateTime endTime=DateTime.Now.AddSeconds(GetDuration());
      while(DateTime.Now < endTime)
      {
        Console.Write($">");
        userResponses.Add(Console.ReadLine());
      }
      return userResponses;
    }

   public void GetRandomPrompt()
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
      Console.WriteLine(_prompts[index]); 
    }
   public void Run()
   {  
      Console.Write($"How long do you want to do this activity to last (in seconds): ");
      SetDuration(int.Parse(Console.ReadLine()));
      List<string> userResponses= new List<string>();
      Console.WriteLine($"\nList as many Responses to the prompt as the time would allow\n");
      GetRandomPrompt();
      ShowSpinner(5);
      Console.WriteLine($"\nYou may begin : ");
      userResponses=GetListFromUser();
      SetCount(userResponses.Count);
      Console.WriteLine($"You have listed {_count} items\n");
    }  
}
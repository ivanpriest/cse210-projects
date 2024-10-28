public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    // Constructor declaration takes the name and description of the activity and assgn them to the member variables
    public Activity(string name,string description)
    {
        _name=name;
        _description=description;
    }
    public Activity(string name,string description,int duration)
    {
        _name=name;
        _description=description;
        _duration=duration;
    }
    // variables setter and Getter methods declaration
    public void SetDuration(int seconds)
    {
        _duration=seconds;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    // method to display the name and description of the activity as starting message
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"This is a {_name}\n\n{_description}.\n");
       
    }
    // method diplay end message
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done !!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have compeleted {_duration} seconds of {_name}");
    }
    // spinner animation method  to diplay a spinning animation in a number of given seconds by displaying different characters and pausing in-between the display
    public void ShowSpinner(int seconds)
    {
        // list of characters used in the animation
        List<string> spinner= new List<string>{"|","/","-","\\","|","/","-","\\"};

        DateTime endTime=DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now<endTime)
        {
            foreach (string character in spinner)
            {
                Console.Write(character);
                Thread.Sleep(500);
                Console.Write($"\b \b");
            }
        }
    }
    // Count down animation method  to diplay a spinning animation in a number of given seconds by displaying nubmers in a descending order and pausing in-between the display
    public void ShowCountDown(int seconds)
    {
       
        DateTime endTime=DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now<endTime)
        {
            for(int i=seconds;i>0;i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write($"\b \b");
            }
        }
        
    }

}
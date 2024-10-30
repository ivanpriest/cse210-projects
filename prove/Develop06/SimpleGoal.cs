public class SimpleGoal : Goal
{
    private bool _isComplete;

     public SimpleGoal(string shortName,string description,string points) : base (shortName,description,points)
    {
           _isComplete=false;
    }

    public SimpleGoal(string shortName,string description,string points,bool complete) : base (shortName,description,points)
    {
           _isComplete=complete;
    }
    public override string GetStringRepresentation()
    {
        return $"Simple:{_shortName}-{_description}-{_points}-{_isComplete}";
    }
    public override void RecordEvent()
    {
        _isComplete=true;
        Console.WriteLine($"Congratulations you have won {_points} points !!!");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
        
}
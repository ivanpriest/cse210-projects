public class EternalGoal : Goal
{
    public EternalGoal(string shortName,string description,string points) : base (shortName,description,points)
    {

    }

    public override void RecordEvent()
    {
       Console.WriteLine($"Congratulations you have won {_points} points !!!");
    }
    public override string GetStringRepresentation()
    {
        return $"Eternal:{_shortName}-{_description}-{_points}";
    }
    public override bool IsComplete()
    {
        return false;
    }
}
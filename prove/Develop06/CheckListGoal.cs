public class CheckListGoal: Goal
{
    private int _amountCompleted=0;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName,string description,string points,int target,int bonus) :base(shortName,description,points)
    {
        _target=target;
        _bonus=bonus;
    }
    public override void RecordEvent()
    {
       
        if(_target==_amountCompleted && _target!<_amountCompleted && _target!>_amountCompleted)
        {
            Console.WriteLine($"Congratulations you have won {_points} and a bonus of {_bonus} points for accomplishing the goal !!!");
        }
        else if (_target >_amountCompleted)
        {
            _amountCompleted+=1;
            Console.WriteLine($"Congratulations you have won {_points}  points !!!");
        }
        else
        {
            Console.WriteLine($"This Goal has already been exhausted");
        }

    }
    public override bool IsComplete()
    {
        bool complete;
        if (_target==_amountCompleted)
        {
            complete= true;
        }
        else 
        {
            complete= false;
        }
        return complete;
    }
    public override string GetDetailsString()
    {
    
        return $"[ ]{_shortName}({_description}) --Currently Completed{_amountCompleted}/{_target}";
        
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist:{_shortName}-{_description}-{_points}-{_amountCompleted}-{_target}-{_bonus}";
    }

}
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string shortName,string description,string points)
    {
        _shortName=shortName;
        _description=description;
        _points=points;
    }

    public void SetShortName(string shortName)
    {
        _shortName=shortName;
    }
     public void SetDescription(string description)
    {
        _description =description;
    }
     public void SetPoints(string points )
    {
        _points=points;
    }
    public string GetShortName()
    {
       return _shortName;
    }
     public string GetDescription()
    {
       return _description;
    }
     public string GetPoints()
    {
       return _points; 
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string detail;
        if (IsComplete()==true)
        {
            detail=$"[x]{_shortName} ({_description})";
        }
        else 
        {
            detail=$"[ ]{_shortName} ({_description})";
        }
        return detail;
    }
    public abstract string GetStringRepresentation();
}
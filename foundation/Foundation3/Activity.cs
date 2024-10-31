public class Activity
{
    protected string _date;
    protected int _lengthInMinute;

    public Activity(int length)
    {
        _date= DateTime.Now.ToString("dddd, dd MMMM yyyy");
        _lengthInMinute=length;
    }
    public virtual double GetDistance()
    {
        return 00000;
    }
    public virtual double GetSpeed()
    {
        return 00000;
    }
    public virtual double GetPace()
    {
        return 00000;
    }
    public virtual string GetSummary()
    {
        return "It is empty";
    }
}   
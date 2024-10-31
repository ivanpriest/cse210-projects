public class SwimmingActivity : Activity
{
    private int _numberOfLaps;

    public SwimmingActivity(int length,int numberOfLaps) : base(length)
    {
        _numberOfLaps=numberOfLaps;
    }

    public override double GetDistance()
    {
       return _numberOfLaps*50/1000;
    }
    public override double GetSpeed()
    {
       return (GetDistance()/_lengthInMinute)*60;
    }
    public override double GetPace()
    {
       return _lengthInMinute/GetDistance();
    }
    public override string GetSummary()
    {
       return $"{_date} Swimming ({_lengthInMinute}):Distance {GetDistance()} km, Speed:{GetSpeed()} kph, Pace:{GetPace()}min per km ";
    }
}
public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(int length,double distance) :base (length)
    {
        _distance=distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance/_lengthInMinute)*60;
    }
    public override double GetPace()
    {
        return 60/GetSpeed();
    }
     public override string GetSummary()
    {
       return $"{_date} Running ({_lengthInMinute}):Distance {GetDistance()} km, Speed:{GetSpeed()} kph, Pace:{GetPace()}min per km ";
    }
}
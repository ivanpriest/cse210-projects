public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(int length,double speed) : base(length)
    {
        _speed=speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
      public override double GetDistance()
    {
       return _speed*_lengthInMinute/60;
    }
    public override double GetPace()
    {
        return 60/GetSpeed();
    }
     public override string GetSummary()
    {
       return $"{_date} Cycling ({_lengthInMinute}):Distance {GetDistance()} km, Speed:{GetSpeed()} kph, Pace:{GetPace()}min per km ";
    }
}
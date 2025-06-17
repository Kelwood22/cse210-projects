
public class Swimming : Activity
{
    private double _laps;
    private double _distance;
    private double _speed;
    private double _pace;

    public Swimming(double laps, double distance, double speed, double pace, double duration)
        : base(distance, speed, pace, duration)
    {
        _laps = laps;
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }

    public override double GetDistance()
    {
        _distance = _laps * 50 / 1000 * 0.62;
        return _distance;
    }

    public override double GetSpeed()
    {
        _speed = (GetDistance() / _duration) * 60;
        return _speed;
    }

    public override double GetPace()
    {
        _pace =  _duration / GetDistance();
        return _pace;
    }
    
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_duration} min) - Laps {_laps}, Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}

public class Running : Activity
{
    private double _distance;
    private double _speed;
    private double _pace;

    public Running(double distance, double speed, double pace, double duration)
        : base(distance, speed, pace, duration)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        _speed = (GetDistance() / _duration) * 60;
        return _speed;
    }

    public override double GetPace()
    {
        _pace = _duration / GetDistance();
        return _pace;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_duration} min)- Distance {_distance} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}
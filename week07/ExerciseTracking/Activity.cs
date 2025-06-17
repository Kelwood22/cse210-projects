
public abstract class Activity
{
    protected string _date;
    protected double _duration;

    public Activity(double distance, double speed, double pace, double duration)
    {
        _date = System.DateTime.Now.ToString("dd-MMM-yyyy");
        _duration = duration;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract string GetSummary();
}
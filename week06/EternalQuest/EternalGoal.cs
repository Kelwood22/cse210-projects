
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description}) - {_points} points";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name}|{_description}|{_points}|0";
    }
}
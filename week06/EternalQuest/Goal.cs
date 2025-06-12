
public abstract class Goal
{
    public string _name;
    public string _description;
    public int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();


    public abstract string GetStringRepresentation();
    
}
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Available Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._name}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(string type, string name, string description, int points, int target = 0, int bonus = 0)
    {
        Goal goal;
        switch (type.ToLower())
        {
            case "simple":
                goal = new SimpleGoal(name, description, points);
                break;
            case "eternal":
                goal = new EternalGoal(name, description, points);
                break;
            case "checklist":
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Unknown goal type.");
                return;
        }
        _goals.Add(goal);
        Console.WriteLine($"Goal '{name}' created successfully.");
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        var goal = _goals[goalIndex];
        goal.RecordEvent();
        if (goal.IsComplete())
        {
            _score += goal._points;
            Console.WriteLine($"Goal '{goal._name}' completed! You earned {goal._points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{goal._name}' updated. Current progress: {goal.GetDetailsString()}");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
            writer.WriteLine($"Score:{_score}");
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Score:"))
                {
                    _score = int.Parse(line.Split(':')[1]);
                    continue;
                }

                string[] data = line.Split('|');
                string type = line.Split(':')[0];

                Goal goal;
                switch (type)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                        if (data[3] == "1") ((SimpleGoal)goal).RecordEvent();
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[5]));
                        ((ChecklistGoal)goal).AmountCompleted = int.Parse(data[3]);
                        break;
                    default:
                        Console.WriteLine($"Unknown goal type: {type}");
                        continue;
                }
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }

}
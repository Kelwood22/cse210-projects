using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager(); // Create an instance
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"\nCurrent Score: {goalManager.GetScore()}");

            Console.WriteLine("\nWelcome to Eternal Quest!");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List all goals");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. Save goals to file");
            Console.WriteLine("5. Load goals from file");
            Console.WriteLine("6. Exit");
            Console.Write("Please enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateNewGoal(goalManager);
                        break;
                    case 2:
                        goalManager.ListGoalDetails();
                        break;
                    case 3:
                        RecordGoalEvent(goalManager);
                        break;
                    case 4:
                        Console.Write("Enter filename to save: ");
                        goalManager.SaveGoals(Console.ReadLine());
                        break;
                    case 5:
                        Console.Write("Enter filename to load: ");
                        goalManager.LoadGoals(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number between 1 and 6.");
            }
        }
    }

    static void CreateNewGoal(GoalManager manager)
    {
        Console.WriteLine("The goal types available are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");

        if (int.TryParse(Console.ReadLine(), out int points))
        {
            switch (type)
            {
                case "1":
                    manager.CreateGoal("simple", name, description, points);
                    break;
                case "2":
                    manager.CreateGoal("eternal", name, description, points);
                    break;
                case "3":
                    Console.Write("Enter the number of times this goal must be completed: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter the bonus points for completing this goal: ");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.CreateGoal("checklist", name, description, points, target, bonus);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please choose 1, 2, or 3.");
                    break;
            }
        }
            else
            {
                Console.WriteLine("Invalid points value.");
            }
    }

    static void RecordGoalEvent(GoalManager manager)
    {
        manager.ListGoalNames();
        Console.Write("Enter the number of the goal to record an event: ");

        if (int.TryParse(Console.ReadLine(), out int goalIndex))
        {
            manager.RecordEvent(goalIndex - 1);
            Console.WriteLine($"Updated score: {manager.GetScore()}");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Swimming(20, 0, 0, 0, 30),
            new Cycling(15, 0, 0, 45),
            new Running(3, 0, 0, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
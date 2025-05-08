using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letterGrade = string.Empty;
        string plusOrMinus = string.Empty;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (grade % 10 >= 7)
        {
            plusOrMinus = "+";
        }
        else if (grade % 10 <= 3)
        {
            plusOrMinus = "-";
        }
        else
        {
            plusOrMinus = string.Empty;
        }

        if (grade >= 97 || grade <= 60)
        {
            plusOrMinus = string.Empty; // No plus or minus for A+
        }
        
        Console.WriteLine($"Your letter grade is: {letterGrade}{plusOrMinus}");
       

        if (grade >= 70)
        {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("You didn't pass the class. Try again!");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        Console.WriteLine("Enter numbers (0 to stop):");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            userNumber = int.Parse(input);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum number is: {max}");

        int minPositive = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The minimum positive number is: {minPositive}");

        numbers.Sort();
        Console.WriteLine("The numbers in ascending order are:");  
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        } 

    }
}
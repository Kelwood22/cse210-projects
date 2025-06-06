using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter the number of your choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        BreathingActivity breathingActivity = new BreathingActivity(0); // Default duration of 30 seconds
                        breathingActivity.Run();
                        break;
                    case 2:
                        ReflectingActivity reflectingActivity = new ReflectingActivity(0);
                        reflectingActivity.Run();
                        break;
                    case 3:
                        ListingActivity listingActivity = new ListingActivity(0);
                        listingActivity.Run();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            }
            Console.WriteLine();
        }

    }
}
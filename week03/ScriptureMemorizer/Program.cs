using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him shall not perish but have eternal life.");

        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to hide some words, or type 'exit' to quit.");
            string input = Console.ReadLine();

            if (input == "exit")
            {
                Console.WriteLine("Exiting the Scripture Memorizer. Goodbye!");
                return;
            }

            Console.Clear();

            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());
        }
        Console.WriteLine("Congratulations! You have memorized the scripture.");
    }
}



        
      



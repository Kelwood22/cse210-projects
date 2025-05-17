// Added a mood entry to the journal program for creativity and exceeding expectations. Thank you! :)


using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save Entries to File");
            Console.WriteLine("4. Load Entries from File");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string entryText = Console.ReadLine();

                    Console.WriteLine("How are you feeling today?");
                    Console.WriteLine("1. Happy\n2. Reflective\n3. Stressed\n4. Excited\n5. Sad");
                    string moodChoice = Console.ReadLine();
                    string mood = moodChoice switch
                    {
                        "1" => "Happy",
                        "2" => "Reflective",
                        "3" => "Stressed",
                        "4" => "Excited",
                        "5" => "Sad",
                        _ => "Unknown"
                    };


                    Entry newEntry = new Entry
                    {
                        _date = DateTime.Now.ToString("yyyy-MM-dd"),
                        _prompt = prompt,
                        _mood = mood,
                        _entryText = entryText
                    };
                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save entries(e.g. journal.txt): ");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    break;
                case "4":
                    Console.Write("Enter filename to load entries(e.g. journal.txt): ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
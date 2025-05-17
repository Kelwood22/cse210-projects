using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        try
        {
            string filePath = Path.Combine(@"C:\Users\kelse\OneDrive\Documents\cse210-projects\week02\Journal", file);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._entryText}");
                }
            }

            Console.WriteLine($"Entries saved to {file}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        string filePath = Path.Combine(@"C:\Users\kelse\OneDrive\Documents\cse210-projects\week02\Journal", file);

        if (File.Exists(filePath))
        {
            _entries = new List<Entry>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _prompt = parts[1],
                        _entryText = parts[2]
                    };
                    _entries.Add(entry);
                }
            }
            Console.WriteLine($"Entries loaded from {filePath}: ");
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine($"File {filePath} not found.");
        }
    }
}
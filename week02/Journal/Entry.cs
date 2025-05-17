public class Entry
{
    public string _date;
    public string _prompt;
    public string _entryText;

    public string _mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}

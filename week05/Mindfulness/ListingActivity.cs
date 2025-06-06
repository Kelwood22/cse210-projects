
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int duration)
        : base("Listing", "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area. Clear your mind and focus on the positive aspects.", duration)
    {
        _count = 0;
        _prompts = new List<string>
        {
            "List things you are grateful for.",
            "Who are people that you appreciate?",
            "List your personal strengths.",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are some of your blessings?",
        };
    }

    public void Run()
    {
        int duration = DisplayStartingMessage();
        if (duration <= 0)
        {
            return;
        }

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random random = new Random();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\n---{prompt}---");
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                _count++;
            }
        }

        Console.WriteLine($"You listed {_count} items for the prompt: {prompt}");
        

        DisplayEndingMessage();
        Thread.Sleep(2000);
    }
}
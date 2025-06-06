
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(int duration)
        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. Clear your mind and focus on the prompts and questions.", duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you overcame a challenge.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you felt proud of yourself.",
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations in your life?",
            "What did you learn about yourself from this experience?",
            "How can you keep this experience in mind when you face challenges in the future?",
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

        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n---{prompt}---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);


        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine($"\n>{question}");
            ShowSpinner(10);
        }

        DisplayEndingMessage();
        Thread.Sleep(2000);
       
    }
}
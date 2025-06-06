
public class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
        : base("Breathing", "This activity will help you relax by guiding you through slow, deep breaths. Clear your mind and focus on your breathing.", duration)
    {

    }

    public void Run()
    {
        int duration = DisplayStartingMessage();
        if (duration <= 0)
        {
            return;
        }

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(4);
            Console.WriteLine("Breathe out...");
            ShowSpinner(4);
            Console.WriteLine();
        }

        DisplayEndingMessage();
        Thread.Sleep(2000);
    }
}
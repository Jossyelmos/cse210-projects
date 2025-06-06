public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Exercise", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        DisplayStatrtingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("\nBreath in...");
            ShowCountDown(4);
            Console.Write("Breath out...");
            ShowCountDown(4);
        }

        DisplayEndingMessage();
    }
}
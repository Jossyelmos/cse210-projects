public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStatrtingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}...");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nEnter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowCountDown(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job...");
        ShowSpinner(3);
        Console.WriteLine($"\nYou completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int duration)
    {
        List<string> _animationString = new List<string> { "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(duration);

        int i = 0;
        while (DateTime.Now < endtime)
        {
            string animation = _animationString[i];
            Console.Write(animation);
            Thread.Sleep(200);
            Console.Write("\b \b");

            i++;

            if (i >= _animationString.Count)
            {
                i = 0;
            }
        }
    }

    protected void ShowCountDown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"{i}...\r");
            Thread.Sleep(1000);
        }

        Console.WriteLine("     ");
    }
}
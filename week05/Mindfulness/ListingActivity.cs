public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _counts = 0;
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        Console.WriteLine($"\n -- {_prompts[rand.Next(_prompts.Count)]} --");
    }

    public void GetListFromUser()
    {
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            _counts++;
        }
        Console.WriteLine($"\nYou listed {_counts} items!");
    }

    public void Run()
    {
        DisplayStatrtingMessage();
        GetRandomPrompt();
        Console.WriteLine("You may begin listing in:");
        ShowCountDown(5);
        GetListFromUser();

        DisplayEndingMessage();
    }
}
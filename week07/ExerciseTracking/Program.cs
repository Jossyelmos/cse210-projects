using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime workoutDate = new DateTime(2022, 11, 3);

        List<Activity> _activities = new List<Activity>
        {
            new Running(workoutDate, 30, 5.0f),
            new Cycling(workoutDate, 30, 20.0f),
            new Swimming(workoutDate, 30, 40)
        };

        Console.WriteLine("\n");
        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager() { }

    public void Start()
    {
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Events");
            Console.WriteLine("  4. Save");
            Console.WriteLine("  5. Load");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": quit = true; break;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:\n1. Simple\n2. Eternal\n3. Checklist");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();
        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it: ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal: ");
        int points = int.Parse(Console.ReadLine());


        if (type == "1") _goals.Add(new SimpleGoal(name, desc, points));
        else if (type == "2") _goals.Add(new EternalGoal(name, desc, points));
        else if (type == "3")
        {
            Console.Write("Target completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you complete? ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        int index = int.Parse(Console.ReadLine()) - 1;
        int earned = _goals[index].RecordEvent();
        _score += earned;
        Console.WriteLine($"You earned {earned} points!");
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("✅ Goals saved successfully!");
    }
    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("Error: File is empty.");
            return;
        }

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Trim().Split("|");

            if (parts.Length < 4)
            {
                Console.WriteLine($"Error: Malformed data on line {i + 1}");
                continue;
            }

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(name, description, points));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "ChecklistGoal")
            {
                if (parts.Length < 6)
                {
                    Console.WriteLine($"Error: Invalid checklist goal format in file (line {i + 1}).");
                    continue;
                }

                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
            }
            else
            {
                Console.WriteLine($"Error: Invalid goal type in file (line {i + 1}).");
            }
        }

        Console.WriteLine("📂 Goals loaded successfully!");
    }

}
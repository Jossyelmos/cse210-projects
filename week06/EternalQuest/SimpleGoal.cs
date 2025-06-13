public class SimpleGoal : Goal
{
    protected bool _isComplete = false;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points) { }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        Console.WriteLine("The goals are: ");
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}";
    }
}
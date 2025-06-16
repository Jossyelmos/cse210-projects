public abstract class Activity
{
    DateTime _dateTime;
    protected int _minutes;

    public Activity(DateTime dateTime, int minutes)
    {
        _dateTime = dateTime;
        _minutes = minutes;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

    public virtual string GetSummary()
    {
        DateTime date = DateTime.Now;
        string currentDate = date.ToString("dd MMM yyyy");

        return $"{currentDate} {GetType().Name} ({_minutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0}kph, Pace: {GetPace():0.0} min per km";
    }
}
public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime dateTime, int minutes, int laps) : base(dateTime, minutes)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000f;
    }

    public override float GetSpeed()
    {
        return (GetDistance() * _minutes) / 60f;
    }

    public override float GetPace()
    {
        return _minutes / GetDistance();
    }
}
public class Running : Activity
{
    private float _distance;
    public Running(DateTime dateTime, int minutes, float distance) : base(dateTime, minutes)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override float GetPace()
    {
        return _minutes / _distance;
    }
}

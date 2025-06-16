public class Cycling : Activity
{
    private float _speed;

    public Cycling(DateTime dateTime, int minutes, float speed) : base(dateTime, minutes)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return (_speed * _minutes) / 60f;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return 60f / GetSpeed();
    }
}
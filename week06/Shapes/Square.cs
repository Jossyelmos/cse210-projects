public class Square : Shape
{
    private int _side = 0;

    public Square(int side, string color) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}
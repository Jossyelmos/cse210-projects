using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(12, "blue");

        Circle circle = new Circle(7, "green");

        Rectangle rec = new Rectangle(12, 6, "brown");

        List<Shape> _shapes = new List<Shape>();
        _shapes.Add(square);
        _shapes.Add(rec);
        _shapes.Add(circle);

        foreach (Shape shape in _shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"\nColor: {color}");
            Console.WriteLine($"Shape Area: {area}");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction();
        Fraction fraction3 = new Fraction();

        fraction.SetTop(1);
        fraction1.SetTop(5);
        fraction2.SetTop(3);
        fraction3.SetTop(1);

        fraction.SetBottom(1);
        fraction1.SetBottom(1);
        fraction2.SetBottom(4);
        fraction3.SetBottom(3);

        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}
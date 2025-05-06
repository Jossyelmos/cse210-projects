using System;

class Program
{
    static void Main(string[] args)
    {
        string signs = "";

        Console.Write("What is your grade percentage? ");

        string valueFromUser = Console.ReadLine();
        int result = int.Parse(valueFromUser);

        string letter = "";

        if (result >= 90)
        {
            letter = "A";
        }
        else if (result >= 80)
        {
            letter = "B";
        }
        else if (result >= 70)
        {
            letter = "C";
        }
        else if (result >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = result % 10;
        if (lastDigit >= 7)
        {
            signs = "+";
        }
        else if (lastDigit <= 3)
        {
            signs = "-";
        }
        else
        {
            signs = "";
        }


        if (result > 97)
        {
            signs = "";
        }
        if (result < 60)
        {
            signs = "";
        }


        Console.WriteLine($"Your grade is {letter}{signs}");

        if (result >= 70)
        {
            Console.WriteLine("Congratulation you passed....");
        }
        else
        {
            Console.WriteLine("Sorry you didn't make. Better luck next term.");
        }

    }
}
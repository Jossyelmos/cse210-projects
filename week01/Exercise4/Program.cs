using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        int totalNumber = 0;
        float averageNumber = 0;

        while (number != 0)
        {
            Console.Write("Type a number (0 to stop): ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        if (numbers.Count > 0)
        {
            foreach (int numb in numbers)
            {
                totalNumber += numb;
            }

        }
        int maximum = numbers[0];

        foreach (int numb in numbers)
        {
            if (numb > maximum)
            {
                maximum = numb;
            }

        }

        int minimum = maximum;
        foreach (int numb in numbers)
        {
            if (numb > 0 && numb < minimum)
            {
                minimum = numb;
            }
        }


        averageNumber = (float)totalNumber / numbers.Count;
        Console.WriteLine($"\nThe sum is {totalNumber}");
        Console.WriteLine($"The average is {averageNumber}");
        Console.WriteLine($"The maximum number is {maximum}");
        Console.WriteLine($"The minimum positive number is {minimum}");

        Console.WriteLine("The sorted lists is: ");
        numbers.Sort();
        foreach (int sort in numbers)
        {
            Console.WriteLine(sort);
        }
    }
}
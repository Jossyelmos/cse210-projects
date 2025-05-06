using System;

class Program
{
    static void Main(string[] args)
    {
        string playMore = "yes";
        int playMoreCount = 0;

        while (playMore == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int magicNumber = number;

            int guessCount = 0;
            int guess = -1;
            while (magicNumber != guess)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount += 1;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} number of guesses!");
                }

            }

            Console.Write("Want to play again: ");
            playMore = Console.ReadLine();
            playMoreCount += 1;

        }
        Console.WriteLine($"You played {playMoreCount} times.");
        Console.WriteLine("Thank you. Come back again.");
    }
}
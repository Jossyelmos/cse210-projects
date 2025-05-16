using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        Console.WriteLine("\nWelcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            List<string> menuLists = new List<string> { "Write", "Display", "Load", "Save", "Quit" };


            for (int i = 0; i < menuLists.Count; i++)
            {
                int humanCount = i + 1;
                Console.WriteLine($"{humanCount}. {menuLists[i]}");
            }
            Console.Write("What would you like to do? ");
            if (!int.TryParse(Console.ReadLine(), out int optionCase))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            if (optionCase == 1)
            {
                string randomPrompt = generator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write("Enter your entry: ");
                string entryText = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string currentDate = theCurrentTime.ToShortDateString();
                Entry newEntry = new Entry(currentDate, randomPrompt, entryText);
                theJournal.AddEntry(newEntry);
                Console.WriteLine("Entry Saved...\n");

            }

            else if (optionCase == 2)
            {
                theJournal.DisplayAll();
            }

            else if (optionCase == 3)
            {
                Console.WriteLine("Enter the filename to load: ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }

            else if (optionCase == 4)
            {
                Console.WriteLine("Enter a filename to save: ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }

            else if (optionCase == 5)
            {
                Console.WriteLine("Thank you, Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose a number between 1 and 5.");
            }
        }
    }
}
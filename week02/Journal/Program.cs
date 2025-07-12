using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.IO.Enumeration;
using System.Xml.Serialization;

// I have added a search feature to the program.
// It lets the user enter a keyword to the search
// the entries for. It then displays all the entries
// containing the keyword.

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        Journal journal = new Journal();

        while (running)
        {
            Console.WriteLine("Welcome to the Journal program.");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1: Add a journal entry.");
            Console.WriteLine("2: Display all journal entries.");
            Console.WriteLine("3: Save journal to file.");
            Console.WriteLine("4: Load journal from file.");
            Console.WriteLine("5: Search entries by keyword");
            Console.WriteLine("6: Exit.");
            Console.WriteLine();
            Console.WriteLine("Please type a number 1-6.");

            string input = Console.ReadLine();
            int choice = int.Parse(input);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Adding a journal entry.");
                    Console.WriteLine();
                    journal.AddEntry();
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Displaying all entries");
                    Console.WriteLine();
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Saving journal to file.");
                    Console.WriteLine();
                    Console.WriteLine("Please type the filename you would like to save to. Example: 'Journal.txt'");
                    string filename = Console.ReadLine().Trim();
                    journal.SaveToFile(filename);
                    break;
                case 4:
                    Console.WriteLine("Loading journal from file.");
                    journal.LoadFromFile();
                    break;
                case 5:
                    Console.WriteLine("Please enter a keyword to search your journal entries for.");
                    string keyword = Console.ReadLine().Trim();
                    journal.SearchEntries(keyword);
                    break;
                case 6:
                    Console.WriteLine("Exiting program. Goodbye.");
                    running = false;
                    break;
            }

        }
    }
}
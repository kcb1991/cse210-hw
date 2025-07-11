using System;
using System.ComponentModel.DataAnnotations;
using System.IO.Enumeration;
using System.Xml.Serialization;

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
            Console.WriteLine("5: Exit.");
            Console.WriteLine("Please type a number 1-5.");

            string input = Console.ReadLine();
            int choice = int.Parse(input);



            switch (choice)
            {
                case 1:
                    Console.WriteLine("Adding a journal entry.");
                    journal.AddEntry();
                    break;
                case 2:
                    Console.WriteLine("Displaying all entries");
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Saving journal to file.");
                    Console.WriteLine("Please type the filename you would like to save to. Example: 'Journal.txt'");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    break;
                case 4:
                    Console.WriteLine("Loading journal from file.");
                    journal.LoadFromFile();
                    break;
                case 5:
                    Console.WriteLine("Exiting program. Goodbye.");
                    running = false;
                    break;
            }

        }
    }
}
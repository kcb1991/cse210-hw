using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose which book you'd like to study:");
            Console.WriteLine("1. Book of Mormon");
            Console.WriteLine("2. Doctrine and Covenants");
            Console.WriteLine("3. New Testament");
            Console.WriteLine("4. Old Testament");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice (1–5): ");

            string choice = Console.ReadLine();
            string fileName = "";

            switch (choice)
            {
                case "1": fileName = "BookOfMormon_Mastery.txt"; break;
                case "2": fileName = "Doctrine&Covenants_Mastery.txt"; break;
                case "3": fileName = "NewTestament_Mastery.txt"; break;
                case "4": fileName = "OldTestament_Mastery.txt"; break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    continue;
            }

            
            ScriptureLibrary library = new ScriptureLibrary();
            library.LoadFromTextFile(fileName);

            Scripture scripture = library.GetRandomScripture();
            if (scripture == null)
            {
                Console.WriteLine("No scriptures available. Press Enter to return to menu.");
                Console.ReadLine();
                continue;
            }

            
            while (true)
            {
                Console.Clear();
                scripture.GetDisplayText();

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words are hidden. Study complete!");
                    Console.ReadLine();
                    break;
                }

                Console.Write("Press Enter to continue or type 'quit' to return to menu: ");
                string input = Console.ReadLine()?.ToLower();
                if (input == "quit") break;

                scripture.HideRandomWords(3);
            }
        }
    }
}
































































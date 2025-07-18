using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.LoadMasteryScriptures();

        Scripture scripture = library.GetRandomScripture();
        if (scripture == null)
        {
            Console.WriteLine("No scriptures available.");
            return;
        }
    
        while (true)
        {
            Console.Clear();
            scripture.GetDisplayText();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Program ending.");
                break;
            }

            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine()?.ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Thanks for using the program, goodbye!");
                break;
            }

            scripture.HideRandomWords(3);
        }


    }
}
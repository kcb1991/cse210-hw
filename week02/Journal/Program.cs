using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        for (int i = 0; i < 3; i++)
        {
            string prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine($"Prompt: {i + 1}: {prompt} ");
        }

        Entry entry1 = new Entry();
        entry1._date = "07 / 07 / 2025";
        entry1._promptText = promptGenerator.GetRandomPrompt();
        entry1._entryText = "Hello there.";

        entry1.Display();


    }
}
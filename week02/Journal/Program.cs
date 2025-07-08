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
    }
}
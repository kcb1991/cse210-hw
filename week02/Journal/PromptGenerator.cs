public class PromptGenerator
{
    public static List<string> _prompts = new List<string>
    {
        "What made me smile today?",
        "How did I overcome a challenge today?",
        "What did I learn about myself?",
        "What surprised me today?",
        "What would I like to do differently tomorrow?",
        "How did I see the hand of the Lord in my life today?",
        "Who was the most interesting person I interacted with today?",
        "What was the strongest emotion I felt today?"
    };

    private static Random _random = new Random();

    public static string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}


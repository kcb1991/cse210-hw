public class ReflectingActivity : Activity
{
    private static readonly string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base(
        "Reflection",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
        "This will help you recognize the power you have and how you can use it in other aspects of your life."
    )
    { }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        Console.WriteLine();
        Console.WriteLine("Prompt:");
        Console.WriteLine(_prompts[rand.Next(_prompts.Length)]);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Length)];
            Console.WriteLine($"Reflect: {question}");
            LoadingSpinner(5);
            Console.WriteLine();
        }
    }

    private void LoadingSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        int totalTicks = seconds * 10;
        for (int i = 0; i < totalTicks; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(100);
            Console.Write("\b");
        }
    }
}
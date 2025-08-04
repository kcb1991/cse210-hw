public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Run()
    {
        LoadingAnimation(2);
        DisplayStartMessage();
        PerformActivity();
        DisplayEndMessage();
        Console.WriteLine("Please press enter to return to the main menu");
        Console.ReadLine();
        
    }

    protected abstract void PerformActivity();



    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        while (true)
        {
            Console.Write("Enter duration of your session in seconds: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out _duration) && _duration > 0)
            {
                break;
            }

            Console.WriteLine("Invalid input. Please enter a positive number like 30 or 60.");
            Console.WriteLine();
        }
        Thread.Sleep(2000);
        Console.WriteLine("Get Ready,");
        Thread.Sleep(2000);
        Console.WriteLine("Get Set,");
        Thread.Sleep(2000);
        Console.WriteLine("GO!");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Good work, you completed {_duration} more seconds of the {_name}.");
        Console.WriteLine();
    }

    protected void CountdownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
    }

    protected void LoadingAnimation(int seconds)
    {
        string loadingText = "LOADING";
        int totalCycles = 3;

        for (int cycle = 0; cycle < totalCycles; cycle++)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            for (int i = 0; i < loadingText.Length; i++)
            {
                Console.Write(loadingText[i]);
                Thread.Sleep(200);
            }
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', loadingText.Length));
        }
    }
}
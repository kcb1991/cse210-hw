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
        DisplayStartMessage();
        PerformActivity();
        DisplayEndMessage();
        LoadingAnimation(3);
    }

    protected abstract void PerformActivity();



    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("Enter duration of your session in seconds:");
        _duration = int.Parse(Console.ReadLine());
        Thread.Sleep(1000);
        Console.WriteLine("Get Ready,");
        Thread.Sleep(2000);
        Console.WriteLine("Get Set,");
        Thread.Sleep(3000);
        Console.WriteLine("GO!");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Good work, you completed {_duration} more seconds of the {_name} Activity.");
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
        int totalCycles = seconds * 1000 / 500;

        for (int cycle = 0; cycle < totalCycles; cycle++)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            for (int i = 0; i < loadingText.Length; i++)
            {
                Console.Write(loadingText[i]);
                Thread.Sleep(100);
            }
            Console.Write(" ");
            Thread.Sleep(200);
            Console.WriteLine();
        }
    }
}
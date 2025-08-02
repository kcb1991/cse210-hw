class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    protected override void PerformActivity()
    {
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);
            Console.WriteLine("Breathe out...");
            Countdown(3);
            elapsed += 6;
        }
    }
}

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    protected override void PerformActivity()
    {
        int _elapsed = 0;
        while (_elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            CountdownTimer(3);
            Console.WriteLine("Breathe out...");
            CountdownTimer(3);
            _elapsed += 6;
        }
    }
}

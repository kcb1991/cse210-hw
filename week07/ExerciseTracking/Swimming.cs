using System.Security.Cryptography.X509Certificates;

public class Swimming : Activity
{
    private int _laps = 0;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetSpeed() => GetDistance() / GetMinutes() * 60;
    public override double GetDistance() => _laps * 50 / 1000.0 * 0.62;
    public override double GetPace() => GetMinutes() / GetDistance();

    public override string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes}) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}
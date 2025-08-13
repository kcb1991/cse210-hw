using System.Security.Cryptography.X509Certificates;

public class Swimming : Activity
{
    private int _laps = 0;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public override double GetSpeed() => (_laps * 50) / 1000.0;
    public override double GetDistance() => (GetDistance() / GetMinutes()) * 60;
    public override double GetPace() => GetMinutes() / GetDistance();
}
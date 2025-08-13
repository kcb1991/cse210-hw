public class Cycling : Activity
{
    private double _speed = 0;

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed() => _speed;
    public override double GetDistance() => (_speed * GetMinutes());
    public override double GetPace() => 60 / _speed;
}
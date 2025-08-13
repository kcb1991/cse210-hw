public abstract class Activity
{
    private string _date = "";
    private int _minutes = 0;

    public Activity(string date, int minutes)
    {
        _date => date;
        _minutes => minutes;
    }

    public string GetDate() => _date;
    public int GetMinutes() => _minutes;


    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();


    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_minutes}) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}
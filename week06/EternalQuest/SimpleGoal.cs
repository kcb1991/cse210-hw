public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[✅]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    public static SimpleGoal FromString(string data)
    {
        var parts = data.Split('|');
        var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
        goal._isComplete = bool.Parse(parts[4]);
        return goal;
    }
}
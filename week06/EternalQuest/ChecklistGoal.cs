public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[✅]" : "[ ]";
        return $"{status} {_shortName} ({_description}) — Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_amountCompleted}|{_bonus}";
    }
    public static ChecklistGoal FromString(string data)
    {
        var parts = data.Split('|');
        var goal = new ChecklistGoal(
            parts[1],                     // name
            parts[2],                     // description
            int.Parse(parts[3]),          // points
            int.Parse(parts[4]),          // target
            int.Parse(parts[6])           // bonus
        );
        goal._amountCompleted = int.Parse(parts[5]); // progress
        return goal;
    }
}
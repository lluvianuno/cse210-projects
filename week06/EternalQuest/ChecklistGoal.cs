class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
         if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"You now earned bonus points: {_bonus}!");
            }
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}
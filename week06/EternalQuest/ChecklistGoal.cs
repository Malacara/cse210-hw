using System;

public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _target;
    private int _current;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int current = 0) : base(name, description, points)
    {
        _bonusPoints = bonus;
        _target = target;
        _current = current;
    }

    public override int RecordEvent()
    {
        _current++;
        if (_current < _target)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
        if (_current == _target)
        {
            IsComplete();
            Console.WriteLine($"Congratulations! You have earned {_bonusPoints} bonus points!");
            return _bonusPoints;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        if (_current >= _target)
        {
            return true;
        }
        return false;
    }

    public override string GetStringRepresentation()
    {
        if (IsComplete())
        {
            return $"[X] {_goalName} ({_goalDescription}) -- Currently completed: {GetDetailsString()}";
        }
        else
        {
            return $"[ ] {_goalName} ({_goalDescription}) -- Currently completed: {GetDetailsString()}";
        }
    }

    public override string GetDetailsString()
    {
        return $"{_current}/{_target}";
    }

    public override string GenFileFormat()
    {
        return $"ChecklistGoal|{_goalName}|{_goalDescription}|{_points}|{_target}|{_bonusPoints}|{_current}";
    }

}
using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {_points}!");
            return _points;
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }


    public override string GetStringRepresentation()
    {
        if (_isComplete)
        {
            return $"[X] {GetDetailsString()}";
        }
        else
        {
            return $"[ ] {GetDetailsString()}";
        }
    }

    public override string GenFileFormat()
    {
        return $"SimpleGoal|{_goalName}|{_goalDescription}|{_points}|{_isComplete}";
    }

}
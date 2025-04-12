using System;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points}!");
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {GetDetailsString()}";
    }

    public override string GenFileFormat()
    {
        return $"EternalGoal|{_goalName}|{_goalDescription}|{_points}";
    }

}
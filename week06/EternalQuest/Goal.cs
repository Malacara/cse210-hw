using System;

public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
        _points = points;
    }

    public virtual string GetDetailsString()
    {
        return $"{_goalName} ({_goalDescription})";
    }

    public string GetGoalName()
    {
        return $"{_goalName}";
    }

    public abstract string GetStringRepresentation();
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GenFileFormat();

}
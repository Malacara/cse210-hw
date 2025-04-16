using System;

public abstract class Activity
{
    private DateTime _date = DateTime.Now;
    private double _minutes;

    public Activity(double minutes)
    {
        _minutes = minutes;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date.Month} {_date.Day} {_date.Year} {GetActivity()} ({_minutes} min)- Distance {Distance(_minutes)} miles, Speed {Speed(_minutes)} mph, Pace: {Pace(_minutes)} min per mile");
    }

    public abstract double Distance(double minutes);
    public abstract double Speed(double minutes);
    public abstract double Pace(double minutes);
    public abstract string GetActivity();

}
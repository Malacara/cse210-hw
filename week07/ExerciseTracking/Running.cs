using System;

public class Running : Activity
{
    private double _distance;

    public Running(double minutes, double distance) : base(minutes)
    {
        _distance = distance;
    }
    public override double Distance(double minutes)
    {
        return _distance;
    }

    public override double Pace(double minutes)
    {
        return minutes / _distance;
    }

    public override double Speed(double minutes)
    {
        return Distance(minutes) / minutes * 60;
    }

    public override string GetActivity()
    {
        return "Running";
    }
}
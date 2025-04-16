using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(double minutes, double laps) : base(minutes)
    {
        _laps = laps;
    }

    public override double Distance(double minutes)
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double Pace(double minutes)
    {
        return minutes / Distance(minutes);
    }

    public override double Speed(double minutes)
    {
        return (Distance(minutes) / minutes) * 60;
    }

    public override string GetActivity()
    {
        return "Swimming";
    }
}
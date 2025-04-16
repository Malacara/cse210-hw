using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(double minutes, double speed) : base(minutes)
    {
        _speed = speed;
    }

    public override double Distance(double minutes)
    {
        return (minutes / 60) * _speed;
    }

    public override double Pace(double minutes)
    {
        return minutes / Distance(minutes);
    }

    public override double Speed(double minutes)
    {
        return _speed;
    }

    public override string GetActivity()
    {
        return "Cycling";
    }
}
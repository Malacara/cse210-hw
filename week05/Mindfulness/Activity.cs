using System;

public class Activity
{

    private string _name;
    private string _description;
    protected int _duration;

    private DateTime futureTime;


    public void RunActivity()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
    }

    public void StartTimer()
    {
        DateTime _startTime = DateTime.Now;
        futureTime = _startTime.AddSeconds(_duration);
    }

    public bool CheckTimer()
    {
        DateTime _currentTime = DateTime.Now;
        if (_currentTime > futureTime)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner();
        Console.Clear();
    }

    public void ShowSpinner()
    {
            Console.Write("|");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(400);
            Console.Write("\b \b");
    }

    public void ShowCountDown(int seconds)
    {
        int timer = seconds;

        do
        {
            Console.Write(timer);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            timer = timer - 1;
        } while (timer != 0);
    }

    public void setName(string name)
    {
        _name = name;
    }

    public void setDescription(string description)
    {
        _description = description;
    }

}
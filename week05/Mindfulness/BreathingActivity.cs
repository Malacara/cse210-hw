using System;

public class BreathingActivity : Activity
{
    private bool timerCheck;
    public BreathingActivity()
    {
        Console.Clear();
        setName("Breathing Activity");
        setDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        DisplayStartingMessage();

        Run();
    }

    public void Run()
    {
        RunActivity();
        ShowSpinner();
        Console.WriteLine();
        StartTimer();
        do
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            ShowCountDown(6);
            timerCheck = CheckTimer();
            Console.WriteLine();
            Console.WriteLine();

        } while (timerCheck == false);

        DisplayEndingMessage();

    }

}
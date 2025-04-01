using System;

public class ListingActivity : Activity
{

    private int _count = 0;
    private List<string> _prompts = new List<string>();
    private Random rnd = new Random();
    private bool timerCheck;

    public ListingActivity()
    {
        Console.Clear();
        setName("Listing Activity");
        setDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        DisplayStartingMessage();

        Run();
    }

    public void Run()
    {
        RunActivity();
        ShowSpinner();
        Console.WriteLine();
        StartTimer();
        GetRandomPrompt();
        int inputTotal = GetListFromUser();
        Console.WriteLine($"You listed {inputTotal} items!");
        Console.WriteLine();
        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        int random = rnd.Next(0, _prompts.Count);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[random]} ---");
    }

    public int GetListFromUser()
    {
        Console.Write("You may begin in:");
        ShowCountDown(4);
        Console.WriteLine("");

        do
        {
            Console.Write("> ");
            Console.ReadLine();
            timerCheck = CheckTimer();
            _count = _count + 1;

        } while (timerCheck == false);

        return _count;
    }


}
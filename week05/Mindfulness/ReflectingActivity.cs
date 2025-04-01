using System;

public class ReflectingActivity : Activity
{

    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private Random rnd = new Random();
    private bool timerCheck;

    public ReflectingActivity()
    {
        Console.Clear();
        setName("Reflection Activity");
        setDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        DisplayStartingMessage();

        Run();
    }

    public void Run()
    {
        RunActivity();
        ShowSpinner();
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        DisplayQuestion();
        Console.WriteLine();
        DisplayEndingMessage();
    }
    
    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        int random = rnd.Next(0, _prompts.Count);

        return _prompts[random];
    }

    public string GetRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        int random = rnd.Next(0, _questions.Count);

        return _questions[random];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: \n");
        string GetPrompt = GetRandomPrompt();
        Console.WriteLine($" --- {GetPrompt} --- \n");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:");
        ShowCountDown(4);
        StartTimer();
        Console.WriteLine("");
        Console.Clear();

        do
        {
            Console.Write("> ");
            Console.Write(GetRandomQuestion() + " ");
            ShowSpinner();
            ShowSpinner();
            ShowSpinner();
            Console.WriteLine("");
            timerCheck = CheckTimer();

        } while (timerCheck == false);
    }

}
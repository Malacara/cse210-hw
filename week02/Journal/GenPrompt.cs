using System;

public class GenPrompt
{
    public List<string> _prompts = new List<string>();
    public string _promptText = "";
    public GenPrompt()
    {
        _prompts.Add("How am I feeling today?");
        _prompts.Add("What are three things I’m grateful for today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("What challenge did I face today, and how did I handle it?");
        _prompts.Add("What is one thing I learned today?");
        _prompts.Add("What is one thing I could have done better today?");
        _prompts.Add("What is something positive I told myself or someone else today?");
        _prompts.Add("What is my main goal for tomorrow?");
        _prompts.Add("Did I take care of myself today? How?");
        _prompts.Add("What inspired me today?");
    }

    int _randomNumber;
    Random number = new Random();
    public string GetRandomPrompt()
    {   
        _randomNumber = number.Next(1, 10);
        _promptText = _prompts[_randomNumber];
        return $"{_promptText}";
    }

}
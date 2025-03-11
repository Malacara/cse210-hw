using System;

public class NewEntry
{

    GenPrompt prompt = new GenPrompt();
    DateTime theCurrentTime = DateTime.Now;
    public string _prompt = "";
    public string _entryText = "";
    public string _date = "";

    public NewEntry()
    {
        _prompt = prompt.GetRandomPrompt();
        _date = theCurrentTime.ToShortDateString();
    }

    public string Display()
    {
        Console.WriteLine();
        Console.WriteLine($"{_date} {_prompt}");
        _entryText = Console.ReadLine();
        Console.WriteLine();
        return $"{_date} ~ {_prompt} ~ {_entryText}";
    }


}
using System;

public class Comment
{
    private string _userName;
    private string _text;

    public Comment(string text, string user)
    {
        _text = text;
        _userName = user;
    }

    public void DisplayComment()
    {
        Console.Write($"{_userName}: ");
        Console.WriteLine(_text);
    }

}
using System;

public class Video
{

    private string _title;
    private string _author;
    private int _lenght;
    private List<Comment> comments = new List<Comment>();
    
    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }

    public void AddComment(string text, string user)
    {
        comments.Add(new Comment($"{text}", $"{user}"));
    }

    public int TotalComments()
    {
        return comments.Count();
    }

    public void DisplayComments()
    {
        foreach (Comment comment in comments)
        {
            comment.DisplayComment();
        }
    }

    private int _videoLenght;
    public void DisplayVideo()
    {
        _videoLenght = _lenght / 60; 

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"{_title} ({_videoLenght} minutes) - by {_author}");
        Console.WriteLine();
        Console.WriteLine($"{TotalComments()} Comments:");
        DisplayComments();
        Console.WriteLine();
        Console.WriteLine();
    }

}
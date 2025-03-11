using System;

public class Journal
{
    public List<string> _journal = new List<string>();

    public Journal()
    {
    }

    public void AddEntry(string entry)
    {
        _journal.Add(entry);
        Console.WriteLine();
    }
    public void DisplayAll()
    {
        Console.WriteLine();
        foreach (string e in _journal)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine();
    }

    public void SaveFile(string _fileName)
    {
        Console.WriteLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (string e in _journal)
            {
                outputFile.WriteLine($"{e}");
            }
        }
    }


    public void LoadFile(string _fileName)
    {
        Console.WriteLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            _journal.Add(line);
        }
    }
}
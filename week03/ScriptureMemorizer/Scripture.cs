using System;

public class Scripture
{

    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random rnd = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            _words.Add(new Word(words[i]));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int random = rnd.Next(0, _words.Count);
            
            _words.ElementAt(random).Hide();

        }
    }

    public string GetDisplayText()
    {
        string localText = "";

        foreach (Word word in _words)
        {
            localText = localText + " " + word.GetDisplayText();
        }

        return localText;
    }

    public bool IsCompletelyHidden()
    {
        string localText = "";

        foreach (Word word in _words)
        {
            localText = localText + " " + word.GetDisplayText();
        }

        bool isHidden = localText.All(c => c == '_' || c == ' ');

        return isHidden;
    }


}
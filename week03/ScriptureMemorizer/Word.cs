using System;

public class Word
{

    private string _text;
    private string _hiddenText;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
        _hiddenText = new string('_', _text.Length);
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            return _hiddenText;
        }
        else
        {
            return _text;
        }
    }

}
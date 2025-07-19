public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // the default visibility is that the text/word is shown
    }

    public void Hide()
    {
        _isHidden= true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {        
        return _isHidden;
    }

    public string GetDisplayText()
    {
        
        int size = _text.Length;
        string underscore = "";

        if (size == 1)
        {
            underscore = "_";
        }
        
        else if (size == 2)
        {
            underscore = "_ _";
        }
        
        else if (size == 3)
        {
            underscore = "_ _ _";
        }

        else if (size == 4)
        {
            underscore = "_ _ _ _";
        }

        else if (size == 5)
        {
            underscore = "_ _ _ _";
        }
        else if (size == 6)
        {
            underscore = "_ _ _ _ _ _";
        }
        else if (size == 7)
        {
            underscore = "_ _ _ _ _ _ _";
        }
        else if (size == 8)
        {
            underscore = "_ _ _ _ _ _ _ _";
        }
        else if (size == 9)
        {
            underscore = "_ _ _ _ _ _ _ _ _";
        }
        else if (size == 10)
        {
            underscore = "_ _ _ _ _ _ _ _ _ _ ";
        }

        if (_isHidden == true)
        {
            return $"{_text.Replace(_text, underscore)} ";

        }
        else
        {
            return _text;
        }
            
    }
}
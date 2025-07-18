using System.Collections.Concurrent;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText(string book, int chapter, int verse)
    {
        return _book + " " + _chapter + ":" + _verse;
    }

    public string GetDisplayText(string book, int chapter, int verse, int endVerse)
    {
        return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
    }

    
}
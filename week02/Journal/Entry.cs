public class Entry
{
    public string _promptText;
    public string _entryText;
    public string _date;

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }

}
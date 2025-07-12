using System.IO;
using System.IO.Enumeration;
using Microsoft.VisualBasic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry newEntry in _entries)
        {
            newEntry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry newEntry in _entries)
            {
                outputFile.WriteLine($"{newEntry._date} - Prompt: {newEntry._promptText}");
                outputFile.WriteLine($"{newEntry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
    }
}
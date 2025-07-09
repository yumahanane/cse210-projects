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

    }

    public void LoadFromFile(string file)
    {

    }
}
public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }
    
    public abstract string GetName();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public void GetSummary()
    {
       
        Console.WriteLine($"{_date} {GetName()} ({_minutes} min): Distance {Math.Round(GetDistance(), 2)} km, Speed: {Math.Round(GetSpeed(), 2)} kph, Pace: {Math.Round(GetPace(), 2)} min per km");
    }

    
}
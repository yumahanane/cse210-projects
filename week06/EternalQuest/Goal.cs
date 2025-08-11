public abstract class Goal
{
    private string _shortName;
    private string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }
    public virtual string GetPoints() 
    {
        return _points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
               
        if (IsComplete() == false)
        {
            return $"[ ] {_shortName} ({_description})";
        }
        else 
        {
            return $"[X] {_shortName} ({_description})";
        }
        
    }

    public abstract string GetStringRepresentation();
}
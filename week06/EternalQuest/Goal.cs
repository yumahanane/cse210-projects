public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

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

    public string Getpoints()
    {
        return _points;
    }


    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        bool isComplete = IsComplete();
        
        if ( isComplete == false)
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
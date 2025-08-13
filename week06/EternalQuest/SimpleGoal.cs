public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
       _isComplete = false;
    }

    public override void RecordEvent()
    {
        GetPoints();
       _isComplete = true; //why is this not working????

    }

    public override bool IsComplete()
    {
    
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }

}
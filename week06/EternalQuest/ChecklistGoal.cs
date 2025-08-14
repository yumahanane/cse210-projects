public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override string GetPoints()
    {
        if (IsComplete() == true)
        {
            int points = int.Parse(_points); // convert to int since _points is a string
            int totalPoints = points + _bonus;
            string total = totalPoints.ToString(); // convert to string since this method returns a string
            return total;
        }

        else
        {
            return _points;
        }
    }

    public override void RecordEvent()
    {
        GetPoints();
        _amountCompleted++; // increment _amountCompleted

    }


    public override bool IsComplete()
    {
        if (_target == _amountCompleted)
        {
            return true; 
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {        
        if (IsComplete() == false)
        {
            return $"[ ] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[X] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }


    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }

}
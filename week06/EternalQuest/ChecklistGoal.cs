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
        bool completed = IsComplete();
        if (completed == true)
        {
            return _points + _bonus;
        }

        else
        {
            return _points;
        }

    }

    public override void RecordEvent()
    {
        GetPoints();
        _amountCompleted++;

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
        bool isComplete = IsComplete();

        if (isComplete == false)
        {
            return $"[ ] {GetShortName()} ({GetDescription()}) -- Curently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[X] {GetShortName()} ({GetDescription()}) -- Curently completed: {_amountCompleted}/{_target}";
        }
    }


    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }

}
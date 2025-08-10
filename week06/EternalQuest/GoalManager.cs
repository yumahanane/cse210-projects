using System.Formats.Asn1;
using System.Security.Cryptography;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
    }


    public void Start()
    {
        Console.WriteLine();
        DisplayPlayerInfo();
        Console.WriteLine();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");

        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{i}. ");
            Console.WriteLine(goal.GetDetailsString());
            i++;
        }

    }

    public void CreateGoal()
    {
        ListGoalNames();
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        string name = "";
        string description = "";
        string points = "";
        int target = 0;
        int bonus = 0;


        if (choice == 1)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points = Console.ReadLine();

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);

        }
        else if (choice == 2)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points = Console.ReadLine();

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }

        else if (choice == 3)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);

        }
    }
    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

        Console.Write("What is the filename for the goal files? Please type MyGoals.txt ");
        string filename = Console.ReadLine();


        string[] paths = { @"C:\Users", "yumas", "OneDrive", "Documents", "cse210", "cse210-projects", "week06", "EternalQuest", filename };
        string filePath = Path.Combine(paths);

        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            outputFile.WriteLine();
            
        }

    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal files? Please type MyGoals.txt ");
        string filename = Console.ReadLine();


        string[] paths = { @"C:\Users", "yumas", "OneDrive", "Documents", "cse210", "cse210-projects", "week06", "EternalQuest", filename };
        string filePath = Path.Combine(paths);

        string[] lines = System.IO.File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine(parts);
        }

        Console.ReadLine();


    }


}

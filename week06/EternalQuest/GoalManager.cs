using System.Formats.Asn1;
using System.Security.Cryptography;
using System.IO;
using System.Threading.Channels;

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
        DisplayPlayerInfo(); // To display the score
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
        Console.WriteLine("The goals are: ");

        int i = 1;
        foreach (Goal goal in _goals)
        {
            string line = goal.GetDetailsString(); // To get the name of the goal
            string[] parts = line.Split(" ");

            string goalName = parts[2];

            Console.Write($"{i}. "); // Display the list of goals  
            Console.WriteLine(goalName);
            i++;
        }

        Console.Write("Which goal did you accomplish? ");
        int answer = int.Parse(Console.ReadLine());
        int index = answer - 1; // To account for index 0

        Goal theGoal = _goals[index]; // Grab the goal correspondent to the index chosen by user
        theGoal.RecordEvent(); // Call the RecordEvent() of that type of goal

        int points = int.Parse(theGoal.GetPoints()); // Get the points of that specific goal

        _score += points; // Add the points to the total score

        Console.WriteLine($"Congratulations! You have earned {points} points!");
        DisplayWinningMessage();
        Console.WriteLine($"You now have {_score} points!");
    }


    public void DisplayWinningMessage() // Display a over the top celebration with animations
    {
        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");

        foreach (string a in animations)
        {
            Console.Write(a);
            Thread.Sleep(700);
            Console.Write("\b \b");
        }

        int n = 5;
        for (int i = 0; i < n; ++i)
        {
            Stars(i + 1);
            Spaces(n - i - 1);
            Stars(n - i + 1);
            Spaces(2 * i);
            Stars(n - i);
            Spaces(n - i - 1);
            Stars(i + 1);

            Console.WriteLine();
        }
    }

    private static void Stars(int count)
    {
        for (int i = 0; i < count; ++i)
            Console.Write("*");
    }

    private static void Spaces(int count)
    {
        for (int i = 0; i < count; ++i)
            Console.Write(" ");
    }

    public void SaveGoals()
    {
        // Get filename from user
        Console.Write("What is the filename for the goal files? ");
        string filename = Console.ReadLine();

        string[] paths = { @"C:\Users", "yumas", "OneDrive", "Documents", "cse210", "cse210-projects", "week06", "EternalQuest", filename };
        string filePath = Path.Combine(paths);

        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            outputFile.WriteLine(_score);

            List<string> goalStringList = new List<string>();

            foreach (Goal goal in _goals)
            {
                goalStringList.Add(goal.GetStringRepresentation());
            }

            foreach (String s in goalStringList)
            {
                outputFile.WriteLine(s);
            }
        }
    }

    public void LoadGoals()
    {
        //Get filename from user
        Console.Write("What is the filename for the goal files? ");
        string filename = Console.ReadLine();

        string[] paths = { @"C:\Users", "yumas", "OneDrive", "Documents", "cse210", "cse210-projects", "week06", "EternalQuest", filename };
        string filePath = Path.Combine(paths);

        string[] lines = System.IO.File.ReadAllLines(filePath);

        string[] sLines = lines.Skip(1).ToArray(); // skip the first line (that is the score)

        char[] separators = { ':', ',' };

        string goalType = "";
        string name = "";
        string description = "";
        string points = "";
        int target = 0;
        int bonus = 0;

        foreach (string line in sLines)
        {
            string[] parts = line.Split(separators);

            goalType = parts[0];
            name = parts[1];
            description = parts[2];
            points = parts[3];
            

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
            }

            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }

            else if (goalType == "ChecklistGoal")
            {
                target = int.Parse(parts[5]);
                bonus = int.Parse(parts[4]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(goal);
            }
        }       
    }
}





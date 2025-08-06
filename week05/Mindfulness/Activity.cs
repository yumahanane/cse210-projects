using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {

    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_description}.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine()); // setting a value for _duration

        Console.Clear();
        Console.WriteLine("Get ready... ");
        //spinner
        ShowSpinner(5);
        Console.WriteLine();

    }

    public int GetDuration()
    {
        return _duration; //called by other classes methods
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        //spinner
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        //spinner
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
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

        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < future) 
        {
            string a = animations[i];
            Console.Write(a);
            Thread.Sleep(700); //so that it will not take much time for each string to show
            Console.Write("\b \b");

            i++;

            if (i >= animations.Count) 
            {
                i = 0;
            }
            
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
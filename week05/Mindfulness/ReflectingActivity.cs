using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity() : base()
    {

    }

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    public void AddQuestion(string question)
    {
        _questions.Add(question);
    }

    public void Run()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();

        Console.Write("Now ponder on each of the following questions as they are related to this experience.\nYou may begin in: ");
        //countdown 4s
        ShowCountDown(4);
        Console.Clear();

        DisplayQuestion();

    }

    public string GetRandomPrompt()
    {
        var randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        var randomQuestion = new Random();
        int index = randomQuestion.Next(_questions.Count);
        string question = _questions[index];
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();
    }

    public void DisplayQuestion()
    {
        // display questions one by one until the _duration is up
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(GetDuration());

        while (DateTime.Now < future)
        {
            Console.Write($"> {GetRandomQuestion()}");
            // spinner
            ShowSpinner();
            Console.WriteLine();
        }
    }
}
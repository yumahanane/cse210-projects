using System.Runtime.InteropServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() : base()
    {

    }

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine();

        Console.Write("You may begin in: ");
        //countdown 5s
        ShowCountDown(5);
        Console.WriteLine();

        // Calls the method so that the user can write a list of responses
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");

    }

    public void GetRandomPrompt()
    {
        var randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($" --- {prompt} ---");

    }

    public List<string> GetListFromUser()
    {
        //Prompt the user if they would like to write their responses into a file 
        Console.WriteLine("If you would like to save your answers to a file, press 1. If not, press 2.");
        int choice = int.Parse(Console.ReadLine());

        // must be called right after Run()
        List<string> userList = new List<string>();

        _count = 0;
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(GetDuration());

        while (DateTime.Now < future)
        {
            if (choice == 1)
            {
                // for each response, add to the list
                Console.Write("> ");
                userList.Add(Console.ReadLine());

                string filePath = @"C:\Users\yumas\OneDrive\Documents\cse210\cse210-projects\week05\Mindfulness\MyJournal.txt";

                File.WriteAllLines(filePath, userList);
            }

            else //If the user chooses 2 or presses any other number, their answers will only be showing in the console 
            {
                // for each response, add to the list
                Console.Write("> ");
                userList.Add(Console.ReadLine());
            }
            _count++;
        }
        return userList;

    }
}
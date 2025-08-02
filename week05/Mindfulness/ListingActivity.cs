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
        GetLIstFromUser();
        Console.WriteLine($"You listed {_count} items!");

    }

    public void GetRandomPrompt()
    {
        var randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($" --- {prompt} ---");

    }

    public List<string> GetLIstFromUser()
    {
        // must be called right after Run()
        List<string> userList = new List<string>();

        _count = 0;
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(GetDuration());

        while (DateTime.Now < future)
        {
            // for each response, add to the list
            Console.Write("> ");
            userList.Add(Console.ReadLine());
            _count++;
        }
        return userList;

    }
}
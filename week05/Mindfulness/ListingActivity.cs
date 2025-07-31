using System.Runtime.InteropServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration, List<string> prompts) : base(name, description, duration)
    {
        _count = 0;
        _prompts = prompts;

    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }

    public List<string> GetLIstFromUser()
    {
        List<string> userList = new List<string>();
        return userList;
    }
}
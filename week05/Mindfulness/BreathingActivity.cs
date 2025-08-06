public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {

    }

    public void Run()
    {
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(GetDuration());

        while (DateTime.Now < future)
        {
            Console.Write("Breath in...");
            //countdown 4s
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Hold in...");
            //countdown 7s
            ShowCountDown(7);
            Console.WriteLine();
            Console.Write("Now breath out...");
            //countdown 8s
            ShowCountDown(8);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
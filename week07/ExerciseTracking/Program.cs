using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        Running running = new Running("12 Aug 2025", 40, 4.8);
        activities.Add(running);

        Cycling cycling = new Cycling("13 Aug 2025", 20, 9.5);
        activities.Add(cycling);

        Swimming swimming = new Swimming("14 Aug 2025", 15, 9);
        activities.Add(swimming);

        Console.WriteLine();
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
        Console.WriteLine();

    }

         
            
    
}
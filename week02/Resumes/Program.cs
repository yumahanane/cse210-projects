using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create new instance of class Job
        Job job1 = new Job();

        // Assign values to the member variables
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create new instance of class Job
        Job job2 = new Job();

        // Assign values to the member variables
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create new instance of class Resume
        Resume myResume = new Resume();

        // Add every instance of Job to the new isntance of Resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume._name = "Allison Rose";

        myResume.Display();

    }
}
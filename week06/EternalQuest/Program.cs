using System;

// Show Creactivity: Display a over the top celebration with animations

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager goalManager = new GoalManager();

        int choice = 0;

        while (choice != 6)
        {
            goalManager.Start();

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());


            if (choice == 1) // Create New Goal
            {
                goalManager.CreateGoal();
            }

            else if (choice == 2) // List Goals
            {
                goalManager.ListGoalDetails();
            }

            else if (choice == 3) // Save Goals
            {
                goalManager.SaveGoals();
            }

            else if (choice == 4) // Load Goals
            {
                goalManager.LoadGoals();
            }

            else if (choice == 5) // Record Event
            {
                goalManager.RecordEvent();
            }
        }
    }
}
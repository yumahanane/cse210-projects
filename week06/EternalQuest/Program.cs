using System;

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

            if (choice == 1)
            {
                goalManager.CreateGoal();

            }

            if (choice == 2)
            {
                goalManager.ListGoalDetails();

            }

            if (choice == 3)
            {
                goalManager.SaveGoals();

            }

            if (choice == 4)
            {

                goalManager.LoadGoals();
            }

            if (choice == 5)
            {
                goalManager.RecordEvent();
            }

        }
        


    }
}
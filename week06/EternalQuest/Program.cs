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
            goalManager.ListGoalDetails();
            goalManager.SaveGoals();
            goalManager.LoadGoals();

        }
        


    }
}
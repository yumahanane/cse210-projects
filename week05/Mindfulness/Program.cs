using System;
using System.Collections.Generic;

// Showing Creativity: 
// In the ListingActivity class, the user is prompted if they would like to 
// write/save their responses into a file. 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int choice = 0;

        while (choice != 4)
        {
            Console.Clear(); //Ensures that everytime  the menu shows, it shows in a cleared console
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breathAct = new BreathingActivity();
                breathAct.SetName("Breathing Activity");
                breathAct.SetDescription("relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing");

                breathAct.DisplayStartingMessage();
                breathAct.Run();
                breathAct.DisplayEndingMessage();
            }

            else if (choice == 2)
            {
                ReflectingActivity reflectAct = new ReflectingActivity();
                reflectAct.SetName("Reflecting Activity");
                reflectAct.SetDescription("reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life");

                //Populating the prompt list
                reflectAct.AddPrompt("Think of a time when you stood up for someone else.");
                reflectAct.AddPrompt("Think of a time when you did something really difficult.");
                reflectAct.AddPrompt("Think of a time when you helped someone in need.");
                reflectAct.AddPrompt("Think of a time when you did something truly selfless.");

                //Populating the question list
                reflectAct.AddQuestion("Why was this experience meaningful to you?");
                reflectAct.AddQuestion("Have you ever done anything like this before?");
                reflectAct.AddQuestion("How did you get started?");
                reflectAct.AddQuestion("How did you feel when it was complete?");
                reflectAct.AddQuestion("What made this time different than other times when you were not as successful?");
                reflectAct.AddQuestion("What is your favorite thing about this experience?");
                reflectAct.AddQuestion("What could you learn from this experience that applies to other situations?");
                reflectAct.AddQuestion("What did you learn about yourself through this experience?");
                reflectAct.AddQuestion("How can you keep this experience in mind in the future?");

                reflectAct.DisplayStartingMessage();
                reflectAct.Run();
                reflectAct.DisplayEndingMessage();

            }

            else if (choice == 3)
            {
                ListingActivity listAct = new ListingActivity();
                listAct.SetName("Listing Activity");
                listAct.SetDescription("reflect on good things in your life by having you list as many\nthings as you can in a certain area");

                //Populating the propmt list
                listAct.AddPrompt("Who are people that you appreciate?");
                listAct.AddPrompt("What are personal strengths of yours?");
                listAct.AddPrompt("Who are people that you have helped this week?");
                listAct.AddPrompt("When have you felt the Holy Ghost this month?");
                listAct.AddPrompt("Who are some of your personal heroes?");

                listAct.DisplayStartingMessage();
                listAct.Run();
                listAct.DisplayEndingMessage();
            }
        }
    }
}
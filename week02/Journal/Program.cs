using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        // Create an instance of Journal
        Journal theJournal = new Journal();

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");

            // Create the menu
            List<string> menu = new List<string>();
            menu.Add("1. Write");
            menu.Add("2. Display");
            menu.Add("3. Load");
            menu.Add("4. Save");
            menu.Add("5. Quit");

            // Display the menu
            menu.ForEach(Console.WriteLine);

            // Get response from user
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // Create an instance of Entry and populate it
                Entry anEntry = new Entry();
                string dateText = "";
                string thePrompt = "";
                string response = "";

                // Generate the date
                DateTime theCurrentTime = DateTime.Now;
                dateText = theCurrentTime.ToShortDateString();

                anEntry._date = dateText;

                // Create an instance of PromptGenerator and populate it 
                PromptGenerator promptsList = new PromptGenerator();
                promptsList._prompts.Add("Who was the most interesting person I interacted with today?");
                promptsList._prompts.Add("What was the best part of my day?");
                promptsList._prompts.Add("How did I see the hand of the Lord in my life today?");
                promptsList._prompts.Add("What was the strongest emotion I felt today?");
                promptsList._prompts.Add("If I had one thing I could do over today, what would it be?");

                // Generate a random prompt
                // This assigns a value to the variable. That value is generated randomly
                // using the GetRandomPrompt method. Then, it prints out in the console 
                // that value, that is the chosen string.
                thePrompt = promptsList.GetRandomPrompt();
                anEntry._promptText = thePrompt;
                Console.WriteLine(thePrompt);

                // Get answer from user
                response = Console.ReadLine();
                anEntry._entryText = response;

                // Append the entry to the journal
                theJournal.AddEntry(anEntry);         
            }

            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (choice == 4) //save
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                theJournal.SaveToFile(filename);
            }

            else if (choice == 3) //load
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                theJournal.LoadFromFile(filename);
            }
        }

    }
}
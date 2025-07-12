using System;
using System.Runtime;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        // Ask the user name and capitalize it
        Console.Write("What is your name? ");
        string writerName = Console.ReadLine();
        string capitalizedName = char.ToUpper(writerName[0]) + writerName.Substring(1);

        // Create an instance of Journal
        Journal theJournal = new Journal();

        int choice = 0;
        while (choice != 7)
        {
            Console.WriteLine("Please select one of the following choices:");

            // Create the menu
            // It contains 2 additional items for "Showing Creativity and Exceeding Requirements"
            List<string> menu = new List<string>();
            menu.Add("1. Write");
            menu.Add("2. Display");
            menu.Add("3. Load");
            menu.Add("4. Save");
            menu.Add("5. Suggest Prompt");
            menu.Add("6. Feedback");
            menu.Add("7. Quit");

            // Display the menu
            menu.ForEach(Console.WriteLine);

            // Get response from user
            Console.Write($"What would you like to do, {capitalizedName}? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // Create an instance of Entry and populate it
                Entry anEntry = new Entry();

                // Generate the date
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

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
                string thePrompt = promptsList.GetRandomPrompt();
                anEntry._promptText = thePrompt;
                Console.WriteLine(thePrompt);

                // Get answer from user
                string response = Console.ReadLine();
                anEntry._entryText = response;

                // Append the entry to the journal
                theJournal.AddEntry(anEntry);
            }

            else if (choice == 2) // display journal
            {
                theJournal.DisplayAll();
            }

            else if (choice == 4) // save
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                theJournal.SaveToFile(filename);
            }

            else if (choice == 3) // load
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                theJournal.LoadFromFile(filename);
            }

            // The following 2 options are for "Showing Creativity and Exceeding Requirements"
            // For both, the user is given a prompt. Then, their name and inputs are saved in a file.

            else if (choice == 5) // suggest prompt
            {
                Console.WriteLine("Please give us your suggestion: ");
                string suggestion = Console.ReadLine();

                string filename = "suggestions.txt";
                using (StreamWriter outputFile = new StreamWriter(filename))
                    outputFile.WriteLine($"{capitalizedName}'s prompt suggestion - {suggestion}");

                Console.WriteLine($"Thank you for your suggestion, {capitalizedName}.");

            }

            else if (choice == 6) // feedback
            {
                Console.Write("On a scale of 0 to 10, how enjoyable was your experience journaling today? ");
                int feedback = int.Parse(Console.ReadLine());

                string filename = "feedback.txt";
                using (StreamWriter outputFile = new StreamWriter(filename))
                    outputFile.WriteLine($"{capitalizedName}'s feedback - {feedback}");

                Console.WriteLine($"Thank you for your feedback, {capitalizedName}.");
            }
        }
    }
}
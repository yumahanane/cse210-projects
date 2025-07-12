using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal theJournal = new Journal();

        Entry anEntry = new Entry();

        PromptGenerator promptList = new PromptGenerator();
        promptList._prompts.Add("Who was the most interesting person I interacted with today?");
        promptList._prompts.Add("What was the best part of my day?");
        promptList._prompts.Add("How did I see the hand of the Lord in my life today?");
        promptList._prompts.Add("What was the strongest emotion I felt today?");
        promptList._prompts.Add("If I had one thing I could do over today, what would it be?");
        promptList._prompts.Add("How did you show compassion to others? How can you extend that same compassion to yourself?");

        string chosenPrompt = promptList.GetRandomPrompt();

        anEntry._promptText = chosenPrompt;

        Console.WriteLine(chosenPrompt);
        anEntry._entryText = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        anEntry._date = dateText;

        theJournal.AddEntry(anEntry);

        theJournal.DisplayAll();


        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        theJournal.SaveToFile(filename);
    }
}
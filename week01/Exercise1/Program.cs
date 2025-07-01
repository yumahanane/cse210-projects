using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        // Prompt the user for their first name
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        // Prompt the user for their last name
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        // Display the user's name
        Console.WriteLine();
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}
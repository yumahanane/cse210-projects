using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("James", 1, 5, 6);

        string scriptureText = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.";

        Scripture aScripture = new Scripture(reference, scriptureText);

       
       bool programRunning = aScripture.IsCompletelyHidden();

        do
        {
            Console.WriteLine(aScripture.GetDisplayText());
            Console.WriteLine("Please enter to continue or type 'quit' to finish: ");

            aScripture.HideRandomWords(3);

            Console.Clear();

            Console.WriteLine(aScripture.GetDisplayText());
        } while (programRunning != true);
        
        
        
        
    }
}
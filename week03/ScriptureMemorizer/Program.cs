using System;
using System.Collections.Concurrent;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine();


        Reference reference = new Reference("James", 1, 5, 6);

        //string scriptureText = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.";
        string scriptureText = "If any of you lack wisdom, let him ask of God.";


        Scripture aScripture = new Scripture(reference, scriptureText);


        string response = "";

        while (response != "quit")
        {

            bool programRunning = aScripture.IsCompletelyHidden();

            if (programRunning != true)
            {

                Console.WriteLine(aScripture.GetDisplayText());
                Console.WriteLine();

                Console.Write("Please enter to continue or type 'quit' to finish: ");
                response = Console.ReadLine();

                aScripture.HideRandomWords(4);

                Console.Clear();
            }
            else
            {
                response = "quit";
            }

        }


    }
}
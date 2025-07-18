using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("James", 1, 5, 6);


        Console.WriteLine(reference.GetDisplayText("James", 1, 5));
        Console.WriteLine(reference.GetDisplayText("James", 1, 5, 6));
        
    }
}
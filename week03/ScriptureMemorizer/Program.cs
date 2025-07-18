using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("James", 1, 5, 6);

        // bad encapsulation. Need to fix this.
        Console.WriteLine(reference.GetDisplayText());
        
        
    }
}
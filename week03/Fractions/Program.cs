using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        

        Fraction fraction3 = new Fraction();
        fraction3.SetTop(6);
        fraction3.SetBottom(7);
        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetBottom());

       

    }
}
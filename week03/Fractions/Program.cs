using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        fraction1.Display();

        Fraction fraction2 = new Fraction(6);
        fraction2.Display();

        Fraction fraction3 = new Fraction(6, 7);
        fraction3.Display();

    }
}
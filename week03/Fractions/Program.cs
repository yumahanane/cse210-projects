using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");


        // I do not think this is wrong. But it is lengthy. 
        // And it can cause problems if I do not pay attention 
        // to what I have set the top and bottom to be previously. 
        /*
        Fraction fraction = new Fraction();
        fraction.SetTop(1);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction.SetTop(5);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction.SetTop(3);
        fraction.SetBottom(4);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction.SetTop(1); // I must set top as well, even though 1 is default. 
        // That is because if the last block of code, I had set top to 3.
        fraction.SetBottom(3);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        */

        // or a better way is to create different instances of the object
        // At the same time, use the constructors

        Fraction fraction1 = new Fraction(1);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());







        

       

    }
}
using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = ""; 

        /*
        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations. You passed the class.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the class. You will do better next time.");
        }

        */

        /*

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        */

        // Stretch Challenge

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign
        if ((grade % 10) >= 7)
        {
            sign = "+";
        }
        else if ((grade % 10) < 3)
        {
            sign = "-";
        }
        else
        {
            sign = " ";
        }

        // Recognize that there is no A+ grade, only A and A-
        // Recognize that 100 is A.
        if (letter == "A" && (grade % 10) >= 7 || grade == 100)
        {
            sign = " ";
        }
        
        // Recognize that there is no F+ or F- grades
        if (letter == "F")
        {
            sign = " ";
        }
        
        // Print out the letter grade
        Console.WriteLine($"{letter}{sign}");

        // Assess whether the student passed or not and display result
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations. You passed the class.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the class. You will do better next time.");
        }


    }


}
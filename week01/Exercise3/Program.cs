using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        /*

         // Core Requirement 1 

        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }

        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

        */

        /*

        // Core Requirement 2

        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        int guess = 0;

        while (magicNumber != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

         */


        /*
        // Core Requirement 3

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;

        while (magicNumber != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
        */

        // Stretch Challenge

        string response = "yes";

        while (response == "yes")
        {
            // Randomly generate a magic number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = 0;
            int count = 0;

            while (magicNumber != guess)
            {
                // Get user guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                // Keep track of the guess count
                count++;

                // Check if the user guessed it right 
                // If not, give a hint
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }

                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Display the number of guesses it took
            if (guess == 1)
            {
                Console.WriteLine($"You have made {count} guess.");
            }
            else
            {
                Console.WriteLine($"You have made {count} guesses.");
            }

            // Ask user if they want to keep playing
            Console.Write("Would you like to play again? ");
            response = Console.ReadLine();
        }
    }
}
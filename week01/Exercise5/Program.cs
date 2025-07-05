using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        // Since the function serves only to display,
        // it is not stored in a variable.
        // Besides, the function was defined as having 
        // a void return. Then, it cannot be converted 
        // to another datatype.
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        // Note that the parameter should be the functions 
        // themselves because it does not accept local variables. 
        int squaredNumber = SquareNumber(userNumber); 
        DisplayResult(userName, squaredNumber);


        // Display a message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        
        // Ask for and return the user's name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        
        // Ask for and return the user's favorite number
        static int PromptUserNumber() 
        {
            Console.Write("Please enter your favorite number: ");
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;

        }
        
        // Square the user's favorite number and return it
        static int SquareNumber(int favNumber)
        {
            int squared = favNumber * favNumber;
            return squared;
        }
        
        // Display the user's name and the squared number
        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}");
        }
    }
}
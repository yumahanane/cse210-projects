using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        //Ask the user for a series of numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number = -1;

         // Create a list to store the numbers 
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            

            // Append the numbers to the list
            // If the number is not 0
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Calculate and print the sum of the numbers in the list
        int sum = numbers.Sum();
        /* 
        Another way of calculating the sum:
        int sum = 0;
        foreach (int i in mumbers)
        {
            sum += number;
        }
        */
        Console.WriteLine($"The sum is: {sum}");

        // Calculate and print the average of the numbers in the list
        // Note that without making the sum float -> ((float)sum),
        // the average will be an integer since we are adding
        // integers. But since the exercise wanted the average 
        // to be in float, we are making the sum float.
        double average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Determine and print the largest number in the list
        int largest = 0;
        foreach (int i in numbers)
        {
            if (i > largest)
            {    
                largest = i;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

        // Determine and print the smallest positive number in the list
        int smallestPositive = 0;
        foreach (int i in numbers)
        {
            if (i < largest && i > 0)
            {    
                smallestPositive = i;
            }
        }
        Console.WriteLine($"The largest number is: {smallestPositive}");

        //Sort the numbers in the list and print the new list
        numbers.Sort();
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}
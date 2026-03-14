using System;
using System.Collections.Generic;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a list of integers
            List<int> numbers = new List<int> { 10, 25, 50, 100, 500 };

            // 5. Wrap the logic in a try/catch block
            try
            {
                // Ask the user for a number to divide by
                Console.WriteLine("Enter a number to divide our list by:");
                int divider = Convert.ToInt32(Console.ReadLine());

                // Loop through the list and divide
                foreach (int num in numbers)
                {
                    int result = num / divider;
                    Console.WriteLine(num + " divided by " + divider + " equals " + result);
                }
            }
            // Catch block for when the user enters a string instead of a number
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter a whole number, not a string.");
                Console.WriteLine("System Message: " + ex.Message);
            }
            // Catch block for when the user enters zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: You cannot divide by zero.");
                Console.WriteLine("System Message: " + ex.Message);
            }
            // Catch block for any other unexpected errors
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            // This code is outside the try/catch block
            Console.WriteLine("\nThe program has emerged from the try/catch block and continued execution.");

            // Keep console open
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
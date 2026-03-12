using System;

namespace ConsoleApplicationChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Multiply by 50
            Console.WriteLine("Enter a number to multiply by 50:");
            string input1 = Console.ReadLine();
            double num1 = Convert.ToDouble(input1);
            double result1 = num1 * 50;
            Console.WriteLine("Result: " + result1);

            // 2. Add 25
            Console.WriteLine("\nEnter a number to add 25 to:");
            string input2 = Console.ReadLine();
            double num2 = Convert.ToDouble(input2);
            double result2 = num2 + 25;
            Console.WriteLine("Result: " + result2);

            // 3. Divide by 12.5
            Console.WriteLine("\nEnter a number to divide by 12.5:");
            string input3 = Console.ReadLine();
            double num3 = Convert.ToDouble(input3);
            double result3 = num3 / 12.5;
            Console.WriteLine("Result: " + result3);

            // 4. Check if greater than 50
            Console.WriteLine("\nEnter a number to check if it is greater than 50:");
            string input4 = Console.ReadLine();
            double num4 = Convert.ToDouble(input4);
            bool isGreater = num4 > 50;
            Console.WriteLine("Result: " + isGreater);

            // 5. Remainder after dividing by 7
            Console.WriteLine("\nEnter a number to find the remainder after dividing by 7:");
            string input5 = Console.ReadLine();
            double num5 = Convert.ToDouble(input5);
            double remainder = num5 % 7;
            Console.WriteLine("Remainder: " + remainder);

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
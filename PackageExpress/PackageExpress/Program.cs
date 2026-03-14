using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Display the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // 2. Prompt for package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // 3. Check if weight is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // 4. Prompt for dimensions
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                // 7. Check if dimensions total is too big
                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    // 8 & 9. Calculate the quote
                    // Formula: (Width * Height * Length * Weight) / 100
                    decimal product = width * height * length * weight;
                    decimal quote = product / 100;

                    // 10. Display the result as a dollar amount
                    // The :C format specifier automatically adds the $ sign and 2 decimal places
                    Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C"));
                    Console.WriteLine("Thank you!");
                }
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
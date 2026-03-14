using System;

namespace IterationAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- PART 3: Comparison using the "<" operator ---
            Console.WriteLine("Loop using the '<' operator:");
            // This loop will run 5 times (0, 1, 2, 3, 4)
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }
            Console.WriteLine("Notice that it stopped BEFORE 5.");
            Console.WriteLine();


            // --- PART 4: Comparison using the "<=" operator ---
            Console.WriteLine("Loop using the '<=' operator:");
            // This loop will run 6 times (0, 1, 2, 3, 4, 5)
            for (int j = 0; j <= 5; j++)
            {
                Console.WriteLine("Iteration: " + j);
            }
            Console.WriteLine("Notice that it included 5 because of the '=' sign.");

            Console.ReadLine();
        }
    }
}
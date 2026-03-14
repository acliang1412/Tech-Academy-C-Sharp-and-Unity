using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Part 2: Fixed Loop ---
            // Now the loop will execute properly and stop after 5 iterations.
            int i = 5;
            while (i > 0)
            {
                Console.WriteLine("The loop value is: " + i);
                i--; // Decrementing i ensures the loop eventually ends.
            }

            Console.WriteLine("Loop has finished successfully.");
            Console.ReadLine();
        }
    }
}
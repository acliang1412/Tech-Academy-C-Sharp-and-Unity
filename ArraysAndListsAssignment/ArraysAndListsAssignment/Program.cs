using System;
using System.Collections.Generic;

namespace ArraysAndListsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- 1. ONE-DIMENSIONAL ARRAY OF STRINGS ---
            string[] colorArray = { "Red", "Blue", "Green", "Yellow", "Purple" };

            Console.WriteLine("Select an index (0-4) to see a color:");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Check if index exists
            if (stringIndex >= 0 && stringIndex < colorArray.Length)
            {
                Console.WriteLine("The color at index " + stringIndex + " is: " + colorArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("Error: That index does not exist in the string array.");
            }
            Console.WriteLine(); // Blank line


            // --- 2. ONE-DIMENSIONAL ARRAY OF INTEGERS ---
            int[] intArray = { 100, 250, 500, 750, 1000 };

            Console.WriteLine("Select an index (0-4) to see an integer:");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if index exists
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine("The number at index " + intIndex + " is: " + intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("Error: That index does not exist in the integer array.");
            }
            Console.WriteLine();


            // --- 3. LIST OF STRINGS ---
            List<string> occupationList = new List<string>();
            occupationList.Add("Developer");
            occupationList.Add("Data Scientist");
            occupationList.Add("UX Designer");
            occupationList.Add("Project Manager");

            Console.WriteLine("Select an index (0-3) to see an occupation:");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Check if index exists in the List
            if (listIndex >= 0 && listIndex < occupationList.Count)
            {
                Console.WriteLine("The occupation at index " + listIndex + " is: " + occupationList[listIndex]);
            }
            else
            {
                Console.WriteLine("Error: That index does not exist in the list.");
            }

            // Keep console open
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
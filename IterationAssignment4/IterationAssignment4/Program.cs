using System;
using System.Collections.Generic;

namespace IterationAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. A list of strings where each item in the list is unique.
            List<string> teams = new List<string> { "Lakers", "Celtics", "Bulls", "Warriors", "Heat" };

            // 2. Ask the user to input text to search for in the list.
            Console.WriteLine("Enter a team name to find its index (Lakers, Celtics, Bulls, Warriors, or Heat):");
            string searchText = Console.ReadLine();

            // Create a boolean to track if a match was found
            bool matchFound = false;

            // 3. A loop that iterates through the list
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i] == searchText)
                {
                    // Displays the index of the list that contains matching text
                    Console.WriteLine("Match found at index: " + i);
                    matchFound = true;

                    // 5. Stops the loop from executing once a match has been found.
                    break;
                }
            }

            // 4. Tells a user if they put in text that isn’t in the list.
            if (!matchFound)
            {
                Console.WriteLine("The text you entered is not in the list.");
            }

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            // ##########################################################
            // PART 1: STRING ARRAY & USER INPUT
            // ##########################################################
            string[] responses = { "The user said: ", "I like the word: ", "Your input was: " };
            Console.WriteLine("--- PART 1 ---");
            Console.WriteLine("Please enter some text to add to the array:");
            string userInput = Console.ReadLine();

            for (int i = 0; i < responses.Length; i++)
            {
                responses[i] = responses[i] + userInput;
            }

            foreach (string s in responses)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();


            // ##########################################################
            // PART 2 & 3: LOOPS AND COMPARISONS (< and <=)
            // ##########################################################
            Console.WriteLine("--- PART 2 & 3 ---");
            // Example of a fixed loop (previously infinite)
            int loopVal = 0;
            while (loopVal < 3)
            {
                Console.WriteLine("Loop comparison '<' value: " + loopVal);
                loopVal++;
            }

            for (int j = 0; j <= 2; j++)
            {
                Console.WriteLine("Loop comparison '<=' value: " + j);
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();


            // ##########################################################
            // PART 4: UNIQUE LIST SEARCH
            // ##########################################################
            Console.WriteLine("--- PART 4 ---");
            List<string> teams = new List<string> { "Lakers", "Celtics", "Bulls", "Warriors" };
            Console.WriteLine("Enter a team name to find its index (Lakers, Celtics, Bulls, Warriors):");
            string teamSearch = Console.ReadLine();
            bool foundTeam = false;

            for (int k = 0; k < teams.Count; k++)
            {
                if (teams[k] == teamSearch)
                {
                    Console.WriteLine("Match found at index: " + k);
                    foundTeam = true;
                    break; // Stop loop once match is found
                }
            }
            if (!foundTeam) Console.WriteLine("Team not found.");
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();


            // ##########################################################
            // PART 5: LIST SEARCH WITH DUPLICATES
            // ##########################################################
            // Based on your current step: [Console App Assignment Part Five](https://www.learncodinganywhere.com/96)
            Console.WriteLine("--- PART 5 ---");
            List<string> names = new List<string> { "Andy", "John", "Andy", "Sarah", "John" };
            Console.WriteLine("Enter a name to search for (Note: some names appear twice):");
            string nameSearch = Console.ReadLine();
            bool nameExists = false;

            for (int m = 0; m < names.Count; m++)
            {
                if (names[m] == nameSearch)
                {
                    Console.WriteLine("Match found at index: " + m);
                    nameExists = true;
                }
            }

            if (!nameExists)
            {
                Console.WriteLine("That name is not in the list.");
            }

            // ##########################################################
            // END OF PROGRAM
            // ##########################################################
            Console.WriteLine("\nAll assignments complete. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
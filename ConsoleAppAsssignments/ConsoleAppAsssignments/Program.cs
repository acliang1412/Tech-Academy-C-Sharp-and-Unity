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
            // PART 2: INFINITE LOOP & THE FIX
            // ##########################################################
            Console.WriteLine("--- PART 2 ---");

            // This was an infinite loop because the condition was always true (1 is always 1)
            // while (true) 
            // { 
            //    Console.WriteLine("Infinite loop!"); 
            // }

            // FIXED LOOP:
            int countdown = 3;
            while (countdown > 0)
            {
                Console.WriteLine("This loop is no longer infinite. Countdown: " + countdown);
                countdown--; // This line "fixes" the loop by making the condition eventually false
            }
            Console.WriteLine("Loop fixed!");
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

            // ##########################################################
            // PART 3: COMPARISONS USING < AND <=
            // ##########################################################
            Console.WriteLine("--- PART 3 ---");

            // 1. Loop using the "<" operator
            Console.WriteLine("Loop using '<' (will stop before 3):");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Value is: " + i);
            }

            // 2. Loop using the "<=" operator
            Console.WriteLine("\nLoop using '<=' (will include 3):");
            for (int j = 0; j <= 3; j++)
            {
                Console.WriteLine("Value is: " + j);
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
            // PART 6: LIST ITERATION WITH DUPLICATE CHECK
            // ##########################################################
            Console.WriteLine("--- PART 6 ---");

            // 1. Create a list of strings that has at least two identical strings.
            List<string> animals = new List<string> { "Dog", "Cat", "Bird", "Dog", "Hamster", "Cat" };

            // Create a new empty list to store strings as we "see" them
            List<string> seenAnimals = new List<string>();

            Console.WriteLine("Animal Evaluation:");

            // 2. Create a foreach loop that evaluates each item
            foreach (string animal in animals)
            {
                // Check if the current animal is already in our 'seenAnimals' list
                if (seenAnimals.Contains(animal))
                {
                    Console.WriteLine(animal + " - this item has already appeared in the list.");
                }
                else
                {
                    Console.WriteLine(animal + " - this item is unique (has not appeared yet).");
                    // Add the animal to the 'seen' list so it's recognized the next time
                    seenAnimals.Add(animal);
                }
            }

            // Keep the console open
            Console.WriteLine("\nAssignment Complete. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
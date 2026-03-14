using System;

namespace LoopsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- PART 1: WHILE STATEMENT ---
            Console.WriteLine("Part 1: Guess the secret number (While Loop)");
            Console.WriteLine("Guess a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            // The code inside only runs if the comparison is true
            while (!isGuessed)
            {
                Console.WriteLine("Wrong! Guess again:");
                number = Convert.ToInt32(Console.ReadLine());
                isGuessed = number == 12;
            }
            Console.WriteLine("You got it! 12 was correct.\n");


            // --- PART 2: DO WHILE STATEMENT ---
            Console.WriteLine("Part 2: Guess the color (Do While Loop)");
            string color;
            bool isCorrectColor = false;

            // This code will run AT LEAST once regardless of the comparison
            do
            {
                Console.WriteLine("What is the best color? (Hint: Blue)");
                color = Console.ReadLine().ToLower();

                if (color == "blue")
                {
                    Console.WriteLine("That's right! Blue is the best.");
                    isCorrectColor = true;
                }
                else
                {
                    Console.WriteLine("Incorrect. Try again.");
                }
            }
            while (!isCorrectColor);

            Console.WriteLine("Program finished. Press any key to exit.");
            Console.Read();
        }
    }
}
using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Header
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine(); // Blank line for readability

            // PART 2: Questions & Data Collection

            // What is your name? (String)
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            // What course are you on? (String)
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            // What page number? (Integer)
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Do you need help? (Boolean)
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // Positive experiences? (String)
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            // Other feedback? (String)
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            // Study hours? (Double/Decimal)
            Console.WriteLine("How many hours did you study today?");
            double studyHours = Convert.ToDouble(Console.ReadLine());

            // PART 3: Footer
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            // Keeps the console window open until you press a key
            Console.ReadLine();
        }
    }
}
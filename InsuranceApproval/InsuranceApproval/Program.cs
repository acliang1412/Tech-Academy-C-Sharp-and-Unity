using System;

namespace InsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ask the applicant questions
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine("Have you ever had a DUI? (Please enter 'true' or 'false')");
            string duiInput = Console.ReadLine();
            bool hasDui = Convert.ToBoolean(duiInput);

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsInput = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketsInput);

            // 2. Determine qualification using a boolean expression
            // Rules: Over 15 AND no DUIs AND no more than 3 tickets
            bool isQualified = (age > 15) && (hasDui == false) && (tickets <= 3);

            // 3. Print the result
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}

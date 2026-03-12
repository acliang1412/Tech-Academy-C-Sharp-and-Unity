using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Start by printing the program title
            Console.WriteLine("Anonymous Income Comparison Program");

            // 2. Get details for Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string p1RateInput = Console.ReadLine();
            decimal p1Rate = Convert.ToDecimal(p1RateInput);

            Console.WriteLine("Hours worked per week?");
            string p1HoursInput = Console.ReadLine();
            decimal p1Hours = Convert.ToDecimal(p1HoursInput);

            // 3. Get details for Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string p2RateInput = Console.ReadLine();
            decimal p2Rate = Convert.ToDecimal(p2RateInput);

            Console.WriteLine("Hours worked per week?");
            string p2HoursInput = Console.ReadLine();
            decimal p2Hours = Convert.ToDecimal(p2HoursInput);

            // 4. Calculate and display Annual Salary for Person 1
            // Formula: Rate * Hours * 52 weeks
            decimal p1Annual = p1Rate * p1Hours * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(p1Annual);

            // 5. Calculate and display Annual Salary for Person 2
            decimal p2Annual = p2Rate * p2Hours * 52;
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(p2Annual);

            // 6. Comparison: Does Person 1 make more than Person 2?
            bool isMore = p1Annual > p2Annual;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(isMore);

            // Keep console open
            Console.ReadLine();
        }
    }
}
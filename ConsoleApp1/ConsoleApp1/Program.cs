using System;

namespace SwitchChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (1-3) to select a day:");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("That number isn't between 1 and 3!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
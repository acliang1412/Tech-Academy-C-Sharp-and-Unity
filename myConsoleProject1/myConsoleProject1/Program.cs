using System;
using System.Runtime.CompilerServices;

namespace myConsoleProject
{
    class Program
    {
        static void Main()
        {
            // This is a simple program 
            //Console.WriteLine("What is your name?");
            // string yourName = Console.ReadLine();
            // Console.WriteLine("Hello " + yourName + ", welcome to C# programming!");
            // Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNum = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNum);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';
            
            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.30202092;

            float secondsLeft = 2.62f;

            short temperatureOnMars = -341;

            String myName = "Drew";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);


            Console.WriteLine(rainingStatus);
            Console.WriteLine(moneyInBank);
        }
    }
}
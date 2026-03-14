using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenating three strings
            string name = "Jesse";
            string quote = "The man said, \"Hello\", Jesse. \n Hello on a new line. \t Hello on a tab.";
            string fileName = @"C:\Users\Jesse"; // The @ symbol allows for backslashes without escape characters

            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.EndsWith("e");

            int length = name.Length;

            name = name.ToUpper(); // Converts to JESSE
            name = name.ToLower(); // Converts to jesse

            // StringBuilder is more efficient for modifying strings frequently
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse.");
            sb.Append(" I am a student.");
            sb.Append("\nI am learning C#.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
using System;
using System.Text; // Required for StringBuilder

namespace StringsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Concatenates three strings
            string part1 = "Learning to code ";
            string part2 = "is an exciting ";
            string part3 = "journey!";
            string fullSentence = part1 + part2 + part3;

            Console.WriteLine("Concatenated String:");
            Console.WriteLine(fullSentence);
            Console.WriteLine(); // Blank line for readability


            // 2) Converts a string to uppercase
            string originalText = "this was lowercase.";
            string upperText = originalText.ToUpper();

            Console.WriteLine("Uppercase Conversion:");
            Console.WriteLine(upperText);
            Console.WriteLine();


            // 3) Creates a Stringbuilder and builds a paragraph, one sentence at a time
            StringBuilder sb = new StringBuilder();

            sb.Append("This is the first sentence of my paragraph.");
            sb.Append(" By using StringBuilder, I can efficiently add more text.");
            sb.Append(" Each sentence is added one at a time to build the full block of text.");
            sb.Append(" This is much better for performance than standard string concatenation.");

            Console.WriteLine("StringBuilder Paragraph:");
            Console.WriteLine(sb.ToString());

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
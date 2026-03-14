using System;
using System.Collections.Generic;

namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "John", "Jane", "Jack", "Jill" };
            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(85);
            //testScores.Add(70);
            //testScores.Add(82);
            //testScores.Add(34);
            //testScores.Add(91);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}

            //List<string> names = new List<string>() { "John", "Jane", "Jack", "Jill" };

            //foreach (string name in names)
            //{

            //    Console.WriteLine(name);


            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 53, 43, 93 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main()
        {

            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);

            Console.WriteLine(intList[0]);
            Console.ReadLine();

            //int[] numArray = new int[5];
            //numArray[0] = 1;
            //numArray[1] = 2;
            //numArray[2] = 3; 
            //numArray[3] = 4;
            //numArray[4] = 5;


            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //Console.WriteLine(numArray1[3]);
            //Console.ReadLine();

        }
    }
}

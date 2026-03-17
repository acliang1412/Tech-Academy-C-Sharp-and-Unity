using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects
            Employee emp1 = new Employee() { firstName = "Sample", lastName = "Student", Id = 101 };
            Employee emp2 = new Employee() { firstName = "Jane", lastName = "Doe", Id = 102 };

            // Compare them using the overloaded operator
            if (emp1 == emp2)
            {
                Console.WriteLine("These employees have the same ID.");
            }
            else
            {
                Console.WriteLine("These employees have different IDs.");
            }

            // Test with identical IDs
            emp2.Id = 101;
            Console.WriteLine("\nAfter changing emp2's ID to match emp1:");
            Console.WriteLine(emp1 == emp2 ? "Matches!" : "No match.");

            Console.ReadLine();
        }
    }
}
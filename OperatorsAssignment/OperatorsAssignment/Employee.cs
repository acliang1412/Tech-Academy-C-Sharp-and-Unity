using System;

namespace OperatorsAssignment
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        // Overload the "==" operator
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both IDs are the same
            return emp1.Id == emp2.Id;
        }

        // You MUST overload "!=" if you overload "=="
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite of the "==" comparison
            return emp1.Id != emp2.Id;
        }
    }
}
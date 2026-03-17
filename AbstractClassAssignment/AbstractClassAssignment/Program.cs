using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use polymorphism to create an object of type IQuittable
            // An Employee 'is-an' IQuittable, so this is valid:
            IQuittable quiter = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };

            // Call the Quit() method on the IQuittable object
            quiter.Quit();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable
    {
        // 4. Implement the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        // Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has quit.");
        }
    }
 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person
    {
        // Two properties: string firstName and string lastName
        public string firstName { get; set; }
        public string lastName { get; set; }

        // 2. Give it the method SayName()
        // Note: We make this abstract so it MUST be implemented by any derived class
        public abstract void SayName();
    }
}

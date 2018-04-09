using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    class Student : Person
    {
        public Student (string name, int age) : base(name, age)
        {

        }

        public void ShowAge()
        {
            
            Console.WriteLine("My age is: {0} years old", age);
        }
        public override void AboutSelf()
        {
            Console.WriteLine("Hi. My name is {0} I'm a student in the school. I am {1} years old", name, age);
        }
    }
}






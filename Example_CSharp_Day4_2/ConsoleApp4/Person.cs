using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    class Person
    {
        protected int age;

        protected string name;

        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }
        public virtual void AboutSelf()
        {
            Console.WriteLine("I'm {0}, just a person you've met. I am {1} years old", name, age);
        }
    }
}

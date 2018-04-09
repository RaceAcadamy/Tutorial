using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    class Teacher : Person
    {
        private string subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this.subject = subject;
        }

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }

        public override void AboutSelf()
        {
            Console.Write("I'm a teacher teaching the subject {0}. My name is {1}", subject, name);
        }
    }
}

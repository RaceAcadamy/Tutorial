using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Student : Human
    {
        public string Grade { get; private set; }

        public Student(string firstName, string lastName, string grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return base.ToString("Grade: " + this.Grade);
        }
    }
}

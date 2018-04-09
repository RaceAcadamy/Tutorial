using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
//using System;
//namespace December_19th
//{
//    class Teacher : Person
//    {
//        private string subject;
//        public void Explain()
//        {
//            Console.WriteLine("Explanation begins");
//        }
//    }
//}
  
//using System;
//namespace December_19th
//{
//    class StudentAndTeacherTest
//    {
//        static void Main()
//        {
//            bool debug = false;

//            //Create a Person and make it say hello
//            Person myPerson = new Person();
//            myPerson.Greet();

//            /*Create a student, set his age to 21, 
//              tell him to Greet and display his age*/
//            Student myStudent = new Student();
//            myStudent.SetAge(21);
//            myStudent.Greet();
//            myStudent.ShowAge();

//            /*Create a teacher, 30 years old, 
//             *ask him to say hello and then explain*/
//            Teacher myTeacher = new Teacher();
//            myTeacher.SetAge(30);
//            myTeacher.Greet();
//            myTeacher.Explain();

//            if (debug)
//                Console.ReadLine();
//        }
//    }
//}
  
//using System;
//namespace December_19th
//{
//    class Student : Person
//    {
//        public void ShowAge()
//        {
//            Console.WriteLine("My age is: {0} years old", age);
//        }
//    }
//}
  
//using System;
//namespace December_19th
//{
//    class Person
//    {
//        protected int age;
//        public void Greet()
//        {
//            Console.WriteLine("Hello");
//        }
//        public void SetAge(int n)
//        {
//            age = n;
//        }
//    }
//}
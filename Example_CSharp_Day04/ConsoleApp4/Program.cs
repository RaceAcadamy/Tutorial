using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Person> people = new List<Person>();

            Person bob = new Person("bob", 32);
            Student jane = new Student("jane", 12);
            Student jill = new Student("jill", 11);
            Teacher Fred = new Teacher("Fred", 45, "History");

            people.Add(bob);
            people.Add(jane);
            people.Add(jill);
            people.Add(Fred);

            Console.WriteLine("Tell me more about yourselves.");
            foreach(Person person in people)
            {
                person.AboutSelf();
            }
            
            ////Create a Person and make it say hello
            //Person myPerson = new Person();
            //myPerson.Greet();

            ///*Create a student, set his age to 21, 
            //  tell him to Greet and display his age*/
            //Student myStudent = new Student();
            //myStudent.SetAge(21);
            //myStudent.Greet();
            //myStudent.ShowAge();

            ///*Create a teacher, 30 years old, 
            // *ask him to say hello and then explain*/
            //Teacher myTeacher = new Teacher();
            //myTeacher.SetAge(30);
            //myTeacher.Greet();
            //myTeacher.Explain();
            
         //   if (debug)
                Console.ReadLine();

        }
    }
}

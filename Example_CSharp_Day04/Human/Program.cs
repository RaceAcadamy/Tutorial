using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
        {
            new Student("Weller", "Aung Myo ", "08 А"),
            new Student("Lwin", "Jacob ", "08 А"),
            new Student("Fatimah", "Bte Ahmed ", "10 А"),
            new Student("Ali", "Bin Mohd", "10 А"),
            new Student("Yeo", "Zhi", "10 Б"),
            new Student("David", "Wei", "08 Б"),
            new Student("Tan", "Leng", "10 Б"),
            new Student("Jessie", "Tan", "12 А"),
            new Student("Janine Mei ", "Yi Tan", "12 А"),
            new Student("Xiao Long.", "Lee", "12 Б"),
            new Student("Leng", "Yeo", "12 Б")
        };

            List<Worker> workers = new List<Worker>()
        {
            new Worker("SMITH", "ROGERS", 22, 26),
            new Worker("JONES", "HARRISON", 73, 26),
            new Worker("BROWN", "LEE", 233, 25),
            new Worker("WILLIAMS", "COLLINS", 97, 45),
            new Worker("TAYLOR", "FOSTER", 261, 44),
            new Worker("DAVIS", "RUSSELL", 173, 52),
            new Worker("DAVIS", "PALMER", 172, 36),
            new Worker("THOMAS", "CLARKE", 172, 35),
            new Worker("MOORE", "ELLIS", 57, 43),
            new Worker("ANDERSON", "HOBSON", 108, 51),
            new Worker("WRIGHT", "JOHNSTON", 107, 35)
        };

            {
                students.OrderBy(
                   student => student.Grade
                ).Print();

                workers.OrderByDescending(
                    worker => worker.GetMoneyPerHour()
                ).Print();
            }


            {
                //List<Human> humans = new List<Human>();

                //humans.AddRange(students);
                //humans.AddRange(workers);

                //humans.OrderBy(
                //    human => human.FirstName
                //).ThenBy(
                //    human => human.LastName
                //).Print();
            }
            Console.ReadKey();
        }
    }
}
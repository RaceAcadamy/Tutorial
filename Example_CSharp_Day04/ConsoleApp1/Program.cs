using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animalObj = new Animal();
            animalObj.MakeSound();

            Dog dogObj = new Dog();
            dogObj.MakeSound();
            dogObj.DoTricks();

            Animal dog = new Dog();
            dog.MakeSound();
            //Dog wholeDog = (Cat)dog;
            //wholeDog.PatTheCat();

            Cat catObj = new Cat();
            catObj.MakeSound();

            Animal cat = new Cat();
            cat.MakeSound();

            Console.ReadKey();

        }
    }


    class Animal
    {
        //static double val = 3.147;
        const double PI = 3.147;
        public Animal()
        {

        }
        public virtual void MakeSound()
        {
            Console.WriteLine("generic animal sound");
            
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("woof");
        }

        public void DoTricks()
        {
            Console.WriteLine("Do a trick for master");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("meow");
        }

        public void PatTheCat()
        {
            Console.WriteLine("Purrrr");
        }
    }
}

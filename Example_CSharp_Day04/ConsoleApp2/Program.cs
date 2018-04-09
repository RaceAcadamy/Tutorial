using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ferrari = new Car("Ferrari");
            Ferrari.EngineV1();
            Ferrari.Tyre();
            Ferrari.SoundSystem();
            Ferrari.Colour("SkyBlue");

            Console.WriteLine("\n\n*********************\n");
            Car BMW = new Car("BMW");
            BMW.EngineV2();
            BMW.Tyre();
            BMW.SoundSystem();
            BMW.Colour("Red");

            Console.WriteLine("\n\n*********************\n");
            Car Ford = new Car("Ford");
            Ford.EngineV3();
            Ford.Tyre();
            Ford.SoundSystem();
            Ford.Colour("Coffee");

            Console.ReadKey();
        }
    }

    class Car : CarBase, CarColour
    {
        public Car(String CarName) : base(CarName)
        {
        }
        public void Colour(String color)
        {
            Console.WriteLine("Car Colour is : " + color);
        }
    }

    class CarBase
    {
        public CarBase(String CarName)
        {
            Console.WriteLine("This is " + CarName);
        }

        public void EngineV1()
        {
            Console.WriteLine("Engine Type is V.1 4500CC Engine");
        }

        public void EngineV2()
        {
            Console.WriteLine("Engine Type is V.2 5500CC Engine");
        }

        public void EngineV3()
        {
            Console.WriteLine("Engine Type is V.2 6500CC Engine");
        }

        public void Tyre()
        {
            Console.WriteLine("Tyre Type is MRF TubeLess Tyre");
        }
        public void SoundSystem()
        {
            Console.WriteLine("Sound System Type is Sony Dolby Digital Extra Bass System");
        }
    }
    interface CarColour
    {
        void Colour(String color);
    }
}
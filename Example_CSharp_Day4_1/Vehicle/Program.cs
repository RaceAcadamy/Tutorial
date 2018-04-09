using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {

            Scooter sc = new Scooter();
            sc.ScooterType();

            Car c = new Car();
            c.CarType();

            Console.ReadKey();
        }
    }
    //Creating Base Class
    class Tyre
    {
        protected void TyreType()
        {
            Console.WriteLine("This is Tubeless Tyre");
        }
    }
    //Creating Child Class
    class Scooter : Tyre
    {
        public void ScooterType()
        {
            Console.WriteLine("Scooter Color is Red");
            TyreType();
        }
    }
    //Creating Child Class
    class Car : Tyre
    {
        public void CarType()
        {
            Console.WriteLine("Car Type : Ferrari");
            TyreType();
        }
    }
}


////using System;
////namespace Vehicles
////{
////    class Car : Vehicle
////    {

////    }
////}
 
////using System;
////namespace Vehicles
////{
////    class ExcursionVan : Van
////    {
////    }
////}
  
////using System;
////namespace Vehicles
////{
////    class Minivan : Van
////    {
////        protected bool cargo_Net;
////        protected bool dual_Sliding_Doors;

////        public Minivan()
////        {
////        }
////        public Minivan(bool cargo_Net, bool dual_Sliding_Doors)
////        {
////            this.cargo_Net = cargo_Net;
////            this.dual_Sliding_Doors = dual_Sliding_Doors;
////        }

////        public void SetCargoNet(bool cargo_Net)
////        {
////            this.cargo_Net = cargo_Net;
////        }
////        public void SetDualSlidingDoors(bool dual_Sliding_Doors)
////        {
////            this.dual_Sliding_Doors = dual_Sliding_Doors;
////        }

////        public bool HasCargoNet()
////        {
////            return cargo_Net;
////        }
////        public bool HasDualSlidingDoors()
////        {
////            return dual_Sliding_Doors;
////        }
////    }
////}
  
//using System;
//namespace Vehicles
//{
//    class Sportscar : Car
//    {

//    }
//}
  
//using System;
//namespace Vehicles
//{
//    class TestVehicles
//    {
//        static void Main()
//        {
//            Car myCar = new Car();
//            myCar.Drive();

//            Sportscar mySportsCar = new Sportscar();
//            mySportsCar.Drive();

//            Van myVan = new Van();
//            myVan.Drive();

//            Minivan myMiniVan = new Minivan();
//            myMiniVan.Drive();

//            ExcursionVan myExcursionVan = new ExcursionVan();
//            myExcursionVan.Drive();
//        }
//    }
//}
  
//using System;
//namespace Vehicles
//{
//    class Van : Vehicle
//    {

//    }
//}
  
//using System;
//namespace Vehicles
//{
//    class Vehicle
//    {
//        protected string make;
//        protected string model;
//        protected string year;

//        public Vehicle()
//        {
//        }
//        public Vehicle(string make, string model, string year)
//        {
//            this.make = make;
//            this.model = model;
//            this.year = year;
//        }

//        public string Make
//        {
//            set { make = value; }
//            get { return make; }
//        }
//        public string Model
//        {
//            set { model = value; }
//            get { return model; }
//        }
//        public string Year
//        {
//            set { year = value; }
//            get { return year; }
//        }

//        public void Accelerate()
//        {
//        }
//        public void Decelerate()
//        {
//        }
//        public void Drive()
//        {
//        }
//        public void Start()
//        {
//        }
//        public void Stop()
//        {
//        }
//    }
//}
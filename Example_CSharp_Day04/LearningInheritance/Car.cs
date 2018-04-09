using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritance
{
    class Car
    {
        public int noOfPassengers, noOfWheels;
        public float torque, topSpeed, power;
        protected int k=3, l=4, m = 1;

        public Car(int noOfPassengers, float torque, float topSpeed, float power, int noOfWheels = 4)
        {
            this.noOfPassengers = noOfPassengers;
            this.noOfWheels = noOfWheels;
            this.torque = torque;
            this.topSpeed = topSpeed;
            this.power = power;
        }

         double DoWeirdCalculations()
        {
            return 4.0;
        }

        public double GetPrice()
        {
            return k * l * m* DoWeirdCalculations();
        }
    }
}

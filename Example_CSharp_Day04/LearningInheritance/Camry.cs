using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritance
{
    class Camry : Car
    {
        string variant;
        public Camry(int noOfPassengers, int noOfWheels, float torque, float topSpeed, float power, string variant) : base(noOfPassengers, torque, topSpeed, power)
        {
            this.variant = variant;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritance
{
    class Prius : Car
    {
        string hybridEngineModel;
        public Prius(int noOfPassengers, int noOfWheels, float torque, float topSpeed, float power, string hybridEngineModel) : 		base(noOfPassengers, torque, topSpeed, power)
        {
            
            this.hybridEngineModel = hybridEngineModel;
        }
        public int SomeFunction()
        {
            return k + l + m + 2;
        }

    }
}

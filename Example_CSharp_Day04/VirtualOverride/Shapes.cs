using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    class Shapes
    {
        protected const double PI = 3.147;
        protected double x, y;
        public Shapes(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual double FindArea()
        {
            return x * y;
        }
    }

    class Triangle : Shapes
    {
        public Triangle (double x, double y) : base(x,y)
        {
        }

        public override double FindArea()
        {
            return PI * x * x;
        }
    }
}

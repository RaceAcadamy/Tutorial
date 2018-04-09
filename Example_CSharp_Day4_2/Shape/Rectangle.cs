using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return base.CalculateSurface(1);
        }

        public override string ToString()
        {
            return base.ToString("Rectangle");
        }
    }
}

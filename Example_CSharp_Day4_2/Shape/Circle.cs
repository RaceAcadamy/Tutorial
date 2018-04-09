using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Circle : Ellipsis
    {
        public Circle(double width)  : base(width, width)
        {
        }

        public override string ToString()
        {
            return base.ToString("Circle");
        }
    }
}

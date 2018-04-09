﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return base.CalculateSurface(.5);
        }

        public override string ToString()
        {
            return base.ToString("Triangle");
        }
    }
}

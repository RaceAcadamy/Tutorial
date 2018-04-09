using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
        {
            new Triangle(3, 4),
            new Rectangle(3, 4),
            new Ellipsis(3, 4),
            new Circle(3)
        };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
            Console.ReadKey();
        }
    }
}

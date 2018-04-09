using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_05_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
                Console.WriteLine("{0} % {1} = {2}", x, y, x % y);

            Console.ReadLine();

        }
    }
}

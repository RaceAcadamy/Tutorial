using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_CSharp_Day3
{

    class Program
    {
        public static void Main()
        {
            Program instance = new Program();
            double a, b;
            Console.WriteLine("Enter number 1:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add is : {0}", instance.add(a, b));
            Console.WriteLine("sub is : {0}", instance.sub(a, b));
            Console.WriteLine("mul is : {0}", instance.mul(a, b));
            Console.WriteLine("division is : {0}", instance.div(a, b));
            Console.ReadKey();
        }


        public  double add(double a, double b)
        {
            return a + b;

        }
        public  double sub(double a, double b)
        {
            return a - b;

        }
        public  double mul(double a, double b)
        {
            return a * b;

        }
        public  double div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("cannot divide by zero");
                return -1;
            }
            return a / b;
        }



    }



}

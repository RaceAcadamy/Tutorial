using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci of {0} is {1}", number,
            Fibonacci(number));
            Console.ReadKey();
        }

        public static int Fibonacci(int number)
        {
            if ((number == 1) || (number == 2))
                return 1;
            else
                return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

    }
}

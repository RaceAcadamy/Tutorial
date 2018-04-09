using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public static int Factorial(int num)
        {
            if (num == 0)
                return 1;
            else
                return num * Factorial(num - 1);
        }

        public static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(number));
            Console.WriteLine(Factorial(6));
            Console.ReadLine();
        }
    }
}

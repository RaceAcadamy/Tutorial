using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Factorial(6));
            Console.ReadKey();
        }

        public static float Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
               // result *= i;
            }
            return result;
        }

    }
}

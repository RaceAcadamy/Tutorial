using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_Function_ReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 13;
            int y = 25;
            Console.WriteLine(Sum(x, y));
        }

        public static int Sum(int a, int b)
        {
            int result;
            result = a + b;
            return result;
        }
      

    }
}

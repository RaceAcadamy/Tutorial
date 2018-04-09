using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n Recursion : Print the first n natural number :\n");
            Console.Write("---------------------------------------------------\n");
            Console.Write(" How many numbers to print : ");
            int ctr = Convert.ToInt32(Console.ReadLine());
            // Call recursive method with two parameters.	
            printNatural(1, ctr);
            Console.Write("\n\n");
        }

        static int printNatural(int stval, int ctr)
        {
            if (ctr < 1)
            {
                return stval;
            }
            ctr--;
            Console.Write(" {0} ", stval);
            return printNatural(stval + 1, ctr);
        }
    }
}

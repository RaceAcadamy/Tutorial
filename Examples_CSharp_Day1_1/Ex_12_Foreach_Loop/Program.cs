using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_17_Foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //program to print 1 to 10 using foreach loop
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            
        }
    }
}

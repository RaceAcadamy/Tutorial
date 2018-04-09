using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_17_Infinite_Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {               
                // body of while loop
                Console.WriteLine("Hello " + i++);
            }
            while (true);
        }
    }
}

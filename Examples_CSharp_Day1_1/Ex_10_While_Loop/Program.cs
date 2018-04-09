using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_15_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Continue in while-loop until index is equal to 10.
            int i = 1;
            while (i <= 10)
            {
                Console.Write("While statement ");
                // Write the index to the screen.
                Console.WriteLine(i);
                // Increment the variable.
                i++;
            }
            Console.ReadLine();
        }
    }
}

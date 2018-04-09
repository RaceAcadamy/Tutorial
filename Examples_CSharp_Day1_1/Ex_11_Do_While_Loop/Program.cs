using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_16_Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Continue in while-loop until index is equal to 10.
            int i = 1;
            do
            {
                Console.Write("Do While statement ");
                // Write the index to the screen.
                Console.WriteLine(i);
                // Increment the variable.
                i++;
            }
            while (i <= 10);

            Console.ReadLine();
        }
    }
}
/*do {
   statement(s);
} while(condition );
*/
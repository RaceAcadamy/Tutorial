using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_11_IF_Else_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Enter input variable");
            result = Convert.ToInt32(Console.ReadLine()) % 2;
            if (result == 0)  //condition
            {
                //if result is even
                Console.WriteLine("input is even");
            }
            else
            {
                //if result isodd
                Console.WriteLine("input is odd");
            }
            Console.ReadKey();
        }
    }
}

/*
 
if(boolean expression)
{
     // statements executed if boolean-expression is true
}
else
{
    // statements executed if boolean-expression is false
}

*/

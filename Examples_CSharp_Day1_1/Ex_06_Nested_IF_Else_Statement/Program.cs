using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_12_Nested_IF_Else_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 7;
            int second = -23;
            int third = 13;

            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("{0} is the largest", first);
                }
                else
                {
                    Console.WriteLine("{0} is the largest", third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("{0} is the largest", second);
                }
                else
                {
                    Console.WriteLine("{0} is the largest", third);
                }
            }
            Console.ReadLine();
        }
    }
}

/*
if (boolean-expression)
{
	if (nested-expression-1)
	{
		// code to be executed
	}
	else
	{
	// code to be executed
	}
}
else
{
	if (nested-expression-2)
	{
		// code to be executed
	}
	else
	{
		// code to be executed
	}
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_02_DataType_and_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int intVar = 100;
            double doubleVar = 120.35D;
            float floatVar = 10.2F;
            char charVar = 'A';
            bool boolVar = true;            
            decimal decimalVar = 5.3M;
            string stringVar = "C# Programming";

            Console.WriteLine(intVar);
            Console.WriteLine(doubleVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(charVar);
            Console.WriteLine(boolVar);
            Console.WriteLine(decimalVar);
            Console.WriteLine(stringVar);
            Console.ReadLine();

        }
    }
}
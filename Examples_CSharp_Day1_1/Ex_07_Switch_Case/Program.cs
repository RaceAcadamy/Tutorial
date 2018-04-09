using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_07_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            Console.ReadLine();
        }
    }
}


/*
 switch(expression)
{
    case <value1>
        // code block
    break;
    case <value2>
        // code block
    break;
    case <valueN>
        // code block
    break;
    default 
        // code block
    break;
}
 */

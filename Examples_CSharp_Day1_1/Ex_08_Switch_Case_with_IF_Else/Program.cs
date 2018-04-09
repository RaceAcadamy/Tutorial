using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_13_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 5;
            switch (val)
            {
                case 1:
                    Console.WriteLine("The day is - Sunday");
                    break;
                case 2:
                    Console.WriteLine("The day is - Monday");
                    break;
                case 3:
                    Console.WriteLine("The day is - Tuesday");
                    break;
                case 4:
                    Console.WriteLine("The day is - wednesday");
                    break;
                case 5:
                    Console.WriteLine("The day is - Thursday");
                    break;
                case 6:
                    Console.WriteLine("The day is - Friday");
                    break;
                case 7:
                    Console.WriteLine("The day is - Saturday");
                    break;
                default:
                    Console.WriteLine("Out of range !!");
                    break;
            }
            Console.ReadLine();
        }
    }
}

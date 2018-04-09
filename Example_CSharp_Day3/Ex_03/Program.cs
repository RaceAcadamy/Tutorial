using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int l = 0;

            Console.Write("\n\nSeparate the individual characters from a string :\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("The characters of the string are  :  ");
            while (l <= str.Length - 1)
            {
                Console.Write("{0} ", str[l]);
                l++;
            }
            Console.Write("\n\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.Write("\n\nAccept a string from keyboard :\n");
            Console.Write("-----------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("The string you entered is : {0}\n", str);

            int length = str.Length;
            Console.Write("Using Library Length of the string is : {0}\n\n", length);


            int l = 0;

            Console.Write("\n\nFind the length of a string :\n");
            Console.Write("---------------------------------\n");

            foreach (char chr in str)
            {
                l += 1;

            }

            Console.Write("Without using library Length of the string is : {0}\n\n", l);



        }




    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_13_Infinite_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Hey! I am Trapped");
            }
        }
    }
}

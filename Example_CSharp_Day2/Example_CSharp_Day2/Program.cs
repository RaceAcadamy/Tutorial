using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_CSharp_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayGoodbye();
            Console.ReadKey();
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public static void SayGoodbye()
        {
            Console.WriteLine("Good Bye!");
        }

        
    }
}

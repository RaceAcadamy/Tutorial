using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02_Function_with_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("Jonh");
            SayGoodBye();
            Console.ReadKey();
        }

        public static void SayHello(string name)
        {
            Console.WriteLine("Hello" + name);
        }
        public static void SayGoodBye()
        {
            Console.WriteLine("Good Bye!");
        }
    }
}

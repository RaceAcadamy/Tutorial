using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("radar"));
            Console.WriteLine(IsPalindrome("pato"));
            Console.ReadKey();
        }

        public static bool IsPalindrome(string text)
        {
            text = text.ToUpper();

            int begin = 0;
            int end = text.Length - 1;

            for (begin = 0; begin < end; begin++)
            {
                if (text[begin] != text[end])
                    return false;
                end--;
            }

            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
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

        public static void Main()
        {
            Console.WriteLine(IsPalindrome("radar"));
            Console.WriteLine(IsPalindrome("ratas"));
            Console.ReadLine();
        }
    }
}

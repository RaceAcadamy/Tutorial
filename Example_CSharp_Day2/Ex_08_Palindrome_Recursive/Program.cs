using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08_Palindrome_Recursive
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
            if (text.Length <= 1)
            {
                return true;
            }
            else
            {
                if (text[0] != text[text.Length - 1])
                {
                    return false;
                }
                else
                {
                    return IsPalindrome(text.Substring(1, text.Length - 2));
                }
            }
        }

    }
}

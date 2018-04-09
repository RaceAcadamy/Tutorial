using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int dividers = 0;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    dividers++;

            if (dividers == 2)
                Console.WriteLine("The number is prime");
            else
                Console.WriteLine("The number is not prime");
        }
    }
}

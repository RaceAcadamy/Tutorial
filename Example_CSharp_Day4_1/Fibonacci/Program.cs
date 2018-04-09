using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            //  Console.WriteLine("Fibonacci of {0} is {1}", number, Fibonacci(number));


            int lastNumber = 1;
            int lastTwoNumber = 1;
            int newNumber = 0;
            string fibSeries = "1, 1, ";
            for (int i = 0; i < number; i++)
            {
                newNumber = lastNumber + lastTwoNumber;
                fibSeries = fibSeries + newNumber.ToString() + ", ";

                lastTwoNumber = lastNumber;
                lastNumber = newNumber; 
            }
            Console.WriteLine("Fibonacci series is " + fibSeries);
            Console.ReadLine();

        }


    }
}

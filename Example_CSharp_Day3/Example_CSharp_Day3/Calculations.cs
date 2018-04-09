using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_CSharp_Day3
{
    class Calculations
    { 
    static double a, b;
    public static double add(double a, double b)
    {
        return a + b;

    }
    public static double sub(double a, double b)
    {
        return a - b;

    }
    public static double mul(double a, double b)
    {
        return a * b;

    }
    public static double div(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("cannot divide by zero");
            return -1;
        }
        return a / b;
    }

}
 

    //class program
    //{
    //    public static void Main()
    //    {
    //        double a, b;
    //        Console.WriteLine("Enter number 1:");
    //        a = Convert.ToDouble(Console.ReadLine());
    //        b = Convert.ToDouble(Console.ReadLine());
    //        Console.WriteLine("sum is : {0}", Calculation.add(a, b));
    //        Console.WriteLine("sub is : {0}", Calculation.sub(a, b));
    //        Console.WriteLine("mul is : {0}", Calculation.mul(a, b));
    //        Console.WriteLine("division is : {0}", Calculation.div(a, b));
    //        Console.ReadKey();
    //    }
    //}



}

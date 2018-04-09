using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Object of SuperClass and calling getModel Method
            MobilePhone mobileObj = new MobilePhone("Nokia", "Win8", "Lumia", 500);
            mobileObj.getModel();
            Console.WriteLine(mobileObj.getModel());

            //Creating Object of Sublcass and calling getModel Method
            IPhone iphoneObj = new IPhone("Apple", "iOS", "X" ,2200);
            iphoneObj.getModel();
            Console.WriteLine(iphoneObj.getModel());            

            Samsung samsungObj = new Samsung("Samsung", "Android", "S8", 1500);
            samsungObj.getModel();
            Console.WriteLine(samsungObj.GetWIFIConnection());
            Console.WriteLine(samsungObj.getModel());            

            WindowsPhone windowsphoneObj = new WindowsPhone("Microsoft", "Windows", "L7", 1000);
            windowsphoneObj.getModel();
            Console.WriteLine(windowsphoneObj.getModel());
            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone 
{
    public class WindowsPhone : MobilePhone
    {

        public WindowsPhone(String _manufacturer, String _operating_system, String _model, int _cost) 
            : base(_manufacturer, _operating_system, _model, _cost)
        {

        }
        public String getModel()
        {
            return "This is Windows Phone - " + model;
        }

        public void GetBlueToothConnection()
        {
            Console.WriteLine("Bluetooth connected");
        }

        //New implementation for this method which was available in Mobile Class  
        //This is runtime polymorphism  
        public override void SendMessage()
        {
            Console.WriteLine("Message Sent to a group");
        }
    }
   // public getModel()

}

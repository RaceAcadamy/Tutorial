using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    public class MobilePhone
    {
        private string manufacturer;
        private string operating_system;
        public string model;
        private int cost;
        //Encaptulation
        private string IEMICode { get; set; }
        public string SIMCard { get; set; }
        public string Processor { get; }
        public int InternalMemory { get; }
        public bool IsSingleSIM { get; set; }

       

        //Constructor to set properties/characteristics of object
        public MobilePhone(String _manufacturer, String _operating_system, String _model, int _cost)
        {
            this.manufacturer = _manufacturer;
            this.operating_system = _operating_system;
            this.model = _model;
            this.cost = _cost;
        }
        //Method to get access Model property of Object
        public String getModel()
        {
            return this.model;
        }

        public void GetIEMICode()
        {
            Console.WriteLine("IEMI Code - IEDF34343435235");
        }
        public void Dial()
        {
            Console.WriteLine("Dial a number");
        }
        public void Receive()
        {
            Console.WriteLine("Receive a call");
        }
        public virtual void SendMessage()
        {
            Console.WriteLine("Message Sent");
        }


        // We can add other method to get access to other properties
    }
}

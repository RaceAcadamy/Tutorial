using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    public class Samsung : MobilePhone
    {
        public Samsung(String _manufacturer, String _operating_system, String _model, int _cost) 
            : base(_manufacturer, _operating_system, _model, _cost)
        {

        }
        public String getModel()
        {
            return "This is Samsung - " + model;
        }

        public String GetWIFIConnection()
        {
            // Console.WriteLine("WIFI connected");
            return "WIFI connected";
        }

        //This is one mwthod which shows camera functionality  
        public void CameraClick()
        {
            Console.WriteLine("Camera clicked");
        }

        //This is one overloaded method which shows camera functionality as well but with its camera's different mode(panaroma)  
        public void CameraClick(string CameraMode)
        {
            Console.WriteLine("Camera clicked in " + CameraMode + " Mode");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    public class IPhone : MobilePhone
    {
        public IPhone(String _manufacturer, String _operating_system, String _model, int _cost) 
            : base(_manufacturer, _operating_system, _model, _cost)
        {

        }
        public String getModel()
        {
            return "This is iPhone - " + model;
        }
    }
}

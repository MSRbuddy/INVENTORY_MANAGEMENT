using System;
using System.Collections.Generic;
using System.Text;

namespace JsonInventoryManagement
{
    public class InventoryModel
    {
          public List<Rice> RiceList { get; set; }
          public List<Wheat> WheatList { get; set; }
          public List<Pulses> PulsesList { get; set; }

          //public String Brand { get; set; }
          //public double Weight { get; set; }
          //public double PricePerKg { get; set; }
    }
}

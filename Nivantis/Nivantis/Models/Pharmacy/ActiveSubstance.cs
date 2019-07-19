using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Models.Pharmacy
{
    public class ActiveSubstance
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

        public ActiveSubstance(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }
}

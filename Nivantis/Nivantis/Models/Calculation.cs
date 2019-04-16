using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Models
{
    public class Calculation
    {
        public decimal Discount { get; set; }
        public decimal NetPurchasePrice { get; set; }
        public decimal NetSellingPrice { get; set; }
        public decimal GrossPurchasePrice { get; set; }
        public decimal Multiplier { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Models.Pharmacy
{
    public class Sale
    {
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public Sale(double amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}

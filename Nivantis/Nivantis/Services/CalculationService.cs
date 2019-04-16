using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Services
{
    public static class CalculationService
    {
        public static decimal Discount(decimal netPurchasePrice, decimal grossPurchasePrice)
        {
            return (1 - netPurchasePrice / grossPurchasePrice ) * 100;
        }

        public static decimal NetPurchasePrice(decimal grossPurchasePrice, decimal discount)
        {
            return grossPurchasePrice * (1 - discount);
        }

        public static decimal NetSellingPrice(decimal netPurchasePrice, decimal multiplier)
        {
            return netPurchasePrice * multiplier;
        }

        public static decimal Multiplier(decimal netSellingPrice, decimal netPurchasePrice)
        {
            return netSellingPrice / netPurchasePrice;
        }
    }
}

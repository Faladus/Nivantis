using Nivantis.Services;
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

        public void CalculateDiscount()
        {
            Discount = CalculationService.Discount(NetPurchasePrice, GrossPurchasePrice);
        }
        public void CalculateNetPurchasePrice()
        {
            NetPurchasePrice = CalculationService.NetPurchasePrice(GrossPurchasePrice, Discount);
        }
        public void CalculateNetSellingPrice()
        {
            NetSellingPrice = CalculationService.NetSellingPrice(NetPurchasePrice, Multiplier);
        }
        public void CalculateMultiplier()
        {
            Multiplier = CalculationService.Multiplier(NetSellingPrice, NetPurchasePrice);
        }
    }
}

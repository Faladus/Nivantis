using Nivantis.Models;
using Nivantis.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.ViewModels
{
    public class CalculationViewModel : BaseViewModel
    {
        public Calculation Calculation { get; set; }

        public CalculationViewModel(Calculation calculation)
        {
            Title = "Résultat";
            Calculation = calculation;

            Calculate();
        }   
        
        private void Calculate()
        {
            Calculation.Discount = CalculationService.Discount(Calculation.NetPurchasePrice, Calculation.GrossPurchasePrice);
            Calculation.NetSellingPrice = CalculationService.NetSellingPrice(Calculation.NetPurchasePrice, Calculation.Multiplier);
        }       
    }
}

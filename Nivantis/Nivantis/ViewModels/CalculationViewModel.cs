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
            Calculation.CalculateNetPurchasePrice();
            Calculation.CalculateNetSellingPrice();
        }       
    }
}

using Nivantis.Models.Pharmacy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.ViewModels
{
    public class PharmacyDetailViewModel : BasePharmacyViewModel
    {
        public Pharmacy Pharmacy { get; set; }
        public PharmacyDetailViewModel(Pharmacy pharmacy = null)
        {
            Title = pharmacy?.Name;
            Pharmacy = pharmacy;            
        }
    }
}

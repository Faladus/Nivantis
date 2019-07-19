using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Models.Pharmacy
{
    public class Medicament
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public List<ActiveSubstance> ActiveSubstances { get; set; }
        public string Purpose { get; set; }
        public string [] Patologies { get; set; }

        public Medicament(string name, double price, int quantity, List<ActiveSubstance> activeSubstances, string purpose, string[] patologies)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            ActiveSubstances = activeSubstances;
            Purpose = purpose;
            Patologies = patologies;
        }
    }
}

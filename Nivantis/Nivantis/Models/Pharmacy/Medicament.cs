using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Models.Pharmacy
{
    public class Medicament
    {
        [JsonProperty("id_medic")]
        public int Id { get; set; }
        [JsonProperty("libelle_medic")]
        public string Name { get; set; }
        [JsonProperty("prix_achat_brut_medic")]
        public double Price { get; set; }
        [JsonProperty("date_update")]
        public DateTime UpdateDate { get; set; }
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

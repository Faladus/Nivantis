using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Models.Pharmacy
{
    public class Pharmacy
    {
        [JsonProperty("id_pharmacie")]
        public string Id { get; set; }
        [JsonProperty("libelle_pharmacie")]
        public string Name { get; set; }
        [JsonProperty("ville_pharmacie")]
        public string City { get; set; }
        [JsonProperty("cp_pharmacie")]
        public string PostalCode { get; set; }
        [JsonProperty("adresse_pharmacie")]
        public string Address { get; set; }
        [JsonProperty("date_update")]
        public DateTime UpdateDate { get; set; }
       
        public string Phone { get; set; }
        public string WebSite { get; set; }

        
        [JsonProperty("medicaments")]
        public List<Medicament> PurchasedMedicaments { get; set; }

        public List<Sale> Sales { get; set; }

        [JsonProperty("formations")]
        public List<TrainingCourse> TrainingCourses { get; set; }
    }
}

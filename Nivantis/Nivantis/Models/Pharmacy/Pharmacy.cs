using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Models.Pharmacy
{
    public class Pharmacy
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public List<Medicament> PurchasedMedicaments { get; set; }
        public List<Sale> Sales { get; set; }
        public List<TrainingCourse> AskedTrainingCourses { get; set; }
    }
}

using Nivantis.Models.Pharmacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivantis.Services
{
    public class MockPharmacy : IDataStore<Pharmacy>
    {
        readonly List<Pharmacy> pharmacies;

        public MockPharmacy()
        {
            pharmacies = new List<Pharmacy>();
            var mockParmacies= new List<Pharmacy>
            {
                new Pharmacy { Id = Guid.NewGuid().ToString(), Name = "Pharmacie Vitton-Zola", City = "Lyon", PostalCode = "69006", Address = "91 Cours Vitton",
                    Phone = "04 78 89 43 57",
                    PurchasedMedicaments = new List<Medicament>() {
                        new Medicament("Doliprane", 20.20, 25, 
                        new List<ActiveSubstance>() {
                            new ActiveSubstance("Paracétamol", 500, "mg")
                        },
                        "Traitement symptomatique des douleurs d'intensité légère à modérée et/ou des états fébriles.",
                        new string[] { "Douleur légère à modérée", "Etat fébrile" }),
                        new Medicament("Spedifen", 30.20, 20, new List<ActiveSubstance>() {
                            new ActiveSubstance("Ibuprofène", 200, "mg")
                        },
                        "Ce médicament contient un anti-inflammatoire non stéroïdien : l'ibuprofène.",
                        new string[] { "Fièvre", "Douleur" }),
                        new Medicament("Derinox", 60.20, 15,
                        new List<ActiveSubstance> () {
                            new ActiveSubstance("Prednisolone", 20, "mg"),
                            new ActiveSubstance("Naphazoline", 25, "mg")
                        },
                        "Traitement symptomatique local de courte durée des états congestifs et inflammatoires au cours des rhinites aiguës de l'adulte et des adolescents de plus de 15 ans.",
                        new string[] { "Rhinite aiguë" })
                    }, Sales = new List<Sale>()
                    {
                        new Sale(69.50, new DateTime(2019, 01, 02)),
                        new Sale(13.20, new DateTime(2019, 01, 12)),
                        new Sale(50.89, new DateTime(2019, 01, 13)),
                        new Sale(90.63, new DateTime(2019, 01, 19)),
                        new Sale(36.21, new DateTime(2019, 01, 22)),
                        new Sale(710.65, new DateTime(2019, 01, 29)),
                    }, TrainingCourses = new List<TrainingCourse>()
                    {
                        new TrainingCourse("Gestion des stocks", "21h", "Delores", "Christian", 32, new DateTime(2019, 07, 26))
                    }},
                new Pharmacy { Id = Guid.NewGuid().ToString(), Name = "Pharmacie du Gros Caillou", City = "Lyon", PostalCode = "69004", Address = "163 Boulevard de la Croix-Rousse",
                    Phone = "04 78 28 46 82", WebSite = "pharm-lyon.com",
                    PurchasedMedicaments = new List<Medicament>() {
                        new Medicament("Magne B6", 30.90, 20, 
                        new List<ActiveSubstance> () {
                            new ActiveSubstance("Magnésium", 100, "mg"),
                            new ActiveSubstance("Pyridoxine", 10, "mg")
                        },
                        "Nervosité, irritabilité, anxiété légère, fatigue passagère, troubles mineurs du sommeil.",
                        new string[] { "Douleur légère à modérée", "Etat fébrile" }),
                        new Medicament("Daflon", 250, 120, new List<ActiveSubstance>() {
                            new ActiveSubstance("Diosmine", 450, "mg"),
                            new ActiveSubstance("Flavonoïdes exprimés en hespéridine", 50, "mg")
                        },
                        "Traitement des symptômes en rapport avec l'insuffisance veinolymphatique (jambes lourdes, douleurs, impatiences du primo-décubitus).",
                        new string[] { "Insuffisance veinolymphatique", "Crise hémorroïdaire" })
                    }, Sales = new List<Sale>()
                    {
                        new Sale(35.20, new DateTime(2019, 01, 05)),                       
                        new Sale(12.63, new DateTime(2019, 01, 17)),                        
                        new Sale(41.20, new DateTime(2019, 01, 27)),
                        new Sale(45.12, new DateTime(2019, 01, 30)),
                    }, TrainingCourses = new List<TrainingCourse>()
                    {
                        new TrainingCourse("Apprentissage du logiciel de gestion", "14h", "Gracio", "Arthue", 24, new DateTime(2019, 08, 29))
                    }},
                new Pharmacy { Id = Guid.NewGuid().ToString(), Name = "Pharmacie du Cap Vaise", City = "Lyon", PostalCode = "69009", Address = "49Bis Rue du Sergent Michel Berthet",
                    Phone = "04 37 64 68 50", WebSite = "pharmacie-capvaise.fr",
                    PurchasedMedicaments = new List<Medicament>() {
                        new Medicament("Derinox", 60.20, 15,
                        new List<ActiveSubstance> () {
                            new ActiveSubstance("Prednisolone", 20, "mg"),
                            new ActiveSubstance("Naphazoline", 25, "mg")
                        },
                        "Traitement symptomatique local de courte durée des états congestifs et inflammatoires au cours des rhinites aiguës de l'adulte et des adolescents de plus de 15 ans.",
                        new string[] { "Rhinite aiguë" }),
                        new Medicament("Daflon", 140, 70, new List<ActiveSubstance>() {
                            new ActiveSubstance("Chlorure de potassium (E508)", 600, "mg")
                        },
                        "Traitement des hypokaliémies, en particulier médicamenteuses (salidiurétiques, corticoïdes, laxatifs).",
                        new string[] { "Hypokaliémie médicamenteuse" }),
                        new Medicament("Magne B6", 70, 40,
                        new List<ActiveSubstance> () {
                            new ActiveSubstance("Magnésium", 100, "mg"),
                            new ActiveSubstance("Pyridoxine", 10, "mg")
                        },
                        "Nervosité, irritabilité, anxiété légère, fatigue passagère, troubles mineurs du sommeil.",
                        new string[] { "Douleur légère à modérée", "Etat fébrile" }),
                    }, Sales = new List<Sale>()
                    {
                        new Sale(54.63, new DateTime(2019, 01, 08)),
                        new Sale(98.20, new DateTime(2019, 01, 11)),
                        new Sale(11.55, new DateTime(2019, 01, 15)),
                        new Sale(14.25, new DateTime(2019, 01, 20)),
                        new Sale(29.85, new DateTime(2019, 01, 23)),
                        new Sale(44.25, new DateTime(2019, 01, 25)),
                        new Sale(92.00, new DateTime(2019, 01, 27)),
                        new Sale(48.44, new DateTime(2019, 01, 29)),
                    }}              
            };

            foreach (var pharmacy in mockParmacies)
            {
                pharmacies.Add(pharmacy);
            }
        }

        public async Task<bool> AddItemAsync(Pharmacy item)
        {
            pharmacies.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Pharmacy pharmacy)
        {
            var oldPharmacy = pharmacies.Where((Pharmacy arg) => arg.Id == pharmacy.Id).FirstOrDefault();
            pharmacies.Remove(oldPharmacy);
            pharmacies.Add(pharmacy);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = pharmacies.Where((Pharmacy arg) => arg.Id == id).FirstOrDefault();
            pharmacies.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Pharmacy> GetItemAsync(string id)
        {
            return await Task.FromResult(pharmacies.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Pharmacy>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(pharmacies);
        }
    }
}

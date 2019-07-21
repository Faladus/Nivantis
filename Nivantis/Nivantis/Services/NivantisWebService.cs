using Newtonsoft.Json;
using Nivantis.Internal;
using Nivantis.Models;
using Nivantis.Models.Pharmacy;
using Nivantis.Models.Form;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nivantis.Services
{
    public class NivantisWebService
    {
        private static HttpClient _httpClient;

        public NivantisWebService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://mspr-nivantis.alwaysdata.net/")
            };
        }

        public async Task<User> Connect(string login, string password)
        {
            var response = await _httpClient.GetStringAsync($"connexion.php?login={login}&password={password}");

            if (!string.IsNullOrEmpty(response))
            {
                var user = JsonConvert.DeserializeObject<User>(response);
                return user;
            }
            return null;                
        }

        public async Task<List<Pharmacy>> GetPharmaciesByCity(string key, string city)
        {
            var response = await _httpClient.GetStringAsync($"pharmacie.php?key={key}&ville={city}");

            if (!string.IsNullOrEmpty(response))
            {
                var pharmacies = JsonConvert.DeserializeObject<List<Pharmacy>>(response);
                return pharmacies;
            }
            return null;
        }

        public async Task<List<Formulaire>> GetForms(string key)
        {
            var response = await _httpClient.GetStringAsync($"getFormat.php?key={key}");

            if (!string.IsNullOrEmpty(response))
            {
                var forms = JsonConvert.DeserializeObject<List<Formulaire>>(response);
                return forms;
            }
            return null;            
        }
    }
}

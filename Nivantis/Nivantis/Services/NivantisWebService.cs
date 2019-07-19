using Newtonsoft.Json;
using Nivantis.Internal;
using Nivantis.Models;
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
    }
}

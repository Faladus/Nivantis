using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Nivantis.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "id_user")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "nom_user")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "date_naiss_user")]
        public DateTime BirthDate { get; set; }
        [JsonProperty(PropertyName = "key_user")]
        public string Key { get; set; }
    }
}

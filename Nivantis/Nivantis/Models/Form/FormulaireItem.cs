using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Models.Form
{
    public class FormulaireItem
    {        
        [JsonProperty("input")]
        public string[] Inputs { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("title")]
        public string Question { get; set; }
    }
}

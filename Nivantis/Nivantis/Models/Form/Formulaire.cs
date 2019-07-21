﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Models.Form
{
    public class Formulaire
    {
        [JsonProperty("id_format")]
        public int Id { get; set; }
        [JsonProperty("json_format")]
        public List<FormulaireItem> FormItems { get; set; }
        [JsonProperty("date_update")]
        public DateTime UpdateDate { get; set; }
    }
}

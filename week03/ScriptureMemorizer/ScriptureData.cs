using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ScriptureMemorizer
{
    public class ScriptureData
    {
        [JsonPropertyName("reference")]
        public string _reference { get; set; }

        [JsonPropertyName("verses")]
         public List<string> _verses { get; set; }
    }
}
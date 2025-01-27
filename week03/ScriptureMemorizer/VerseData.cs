using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;

namespace ScriptureMemorizer
{
    public class VerseData
    {
        [JsonPropertyName("verses")]
        private List<string> _verses;
        public List<string> GetVerses()
        {
            return _verses;
        }
        public void SetVerses(List<string> verses)
        {
            _verses = verses;
        }
    }
}
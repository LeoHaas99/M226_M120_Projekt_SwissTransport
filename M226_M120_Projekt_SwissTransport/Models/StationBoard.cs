using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace M226_M120_Projekt_SwissTransport.Models
{
    public class StationBoard : ModelBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("stop")]
        public Stop Stop { get; set; }
    }

}

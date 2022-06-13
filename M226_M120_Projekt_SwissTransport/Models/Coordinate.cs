using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226_M120_Projekt_SwissTransport.Models
{
    public class Coordinate
    {
    
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("x")]
        public double? XCoordinate { get; set; }

        [JsonProperty("y")]
        public double? YCoordinate { get; set; }
    
}
    }


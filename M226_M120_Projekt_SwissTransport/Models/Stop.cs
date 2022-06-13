using System;
using Newtonsoft.Json;

namespace M226_M120_Projekt_SwissTransport.Models
{
    public class Stop
    {
        [JsonProperty("departure")]
        public DateTime? Departure { get; set; }

        [JsonProperty("platform")]
        public string? Platform { get; set; }
    }
}

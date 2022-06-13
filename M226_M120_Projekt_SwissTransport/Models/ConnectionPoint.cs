using Newtonsoft.Json;
using System;


namespace M226_M120_Projekt_SwissTransport.Models
{
    public class ConnectionPoint
    {
        [JsonProperty("station")]
        public Station? Station { get; set; }

        [JsonProperty("arrival")]
        public DateTime? Arrival { get; set; }

        [JsonProperty("departure")]
        public DateTime? Departure { get; set; }

        [JsonProperty("platform")]
        public string? Platform { get; set; }
    }
}

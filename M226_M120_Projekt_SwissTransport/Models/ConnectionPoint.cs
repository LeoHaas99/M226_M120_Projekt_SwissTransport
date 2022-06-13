using Newtonsoft.Json;
using System;


namespace M226_M120_Projekt_SwissTransport.Models
{
    public class ConnectionPoint
    {
        [JsonProperty("station")]
        public Station? Station { get; set; }

        public DateTime? Arrival { get; set; }

        public DateTime? Departure { get; set; }

        public string? Platform { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;


namespace M226_M120_Projekt_SwissTransport.Models
{
    public class StationBoard
    {
        [JsonProperty("Station")]
        public Station? Station { get; set; }

        [JsonProperty("stationboard")]
        public List<StationBoardEntry>? Entries { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226_M120_Projekt_SwissTransport.Models
{
    public class StationBoard : ModelBase
    {
        [JsonProperty("Station")]
        public Station Station { get; set; }

        [JsonProperty("stationboard")]
        public List<StationBoardEntry> Entries { get; set; }
    }
}

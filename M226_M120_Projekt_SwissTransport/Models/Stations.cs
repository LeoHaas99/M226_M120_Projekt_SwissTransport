using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226_M120_Projekt_SwissTransport.Models
{
    public class Stations
    {
        [JsonProperty("stations", NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<Station> StationList { get; set; }
    }
}

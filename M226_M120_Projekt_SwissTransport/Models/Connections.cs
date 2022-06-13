using Newtonsoft.Json;
using System.Collections.ObjectModel;


namespace M226_M120_Projekt_SwissTransport.Models
{
    public class Connections
    {
        [JsonProperty("connections")]
        public ObservableCollection<Connection>? ConnectionList { get; set; }
    }
}

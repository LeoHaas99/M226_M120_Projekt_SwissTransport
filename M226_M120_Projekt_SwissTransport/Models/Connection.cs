using Newtonsoft.Json;



namespace M226_M120_Projekt_SwissTransport.Models
{
    public class Connection
    {
        [JsonProperty("from")]
        public ConnectionPoint? From { get; set; }

        [JsonProperty("to")]
        public ConnectionPoint? To { get; set; }
    }
}

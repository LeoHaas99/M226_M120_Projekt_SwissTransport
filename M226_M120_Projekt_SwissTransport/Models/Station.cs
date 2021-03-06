using Newtonsoft.Json;


namespace M226_M120_Projekt_SwissTransport.Models
{
    public class Station
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("score")]
        public int? Score { get; set; }

        [JsonProperty("coordinate")]
        public Coordinate? Coordinate { get; set; }

        [JsonProperty("distance")]
        public double? Distance { get; set; }
    }
}

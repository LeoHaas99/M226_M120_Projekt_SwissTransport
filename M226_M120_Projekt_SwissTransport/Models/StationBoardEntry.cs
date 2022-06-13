using Newtonsoft.Json;

namespace M226_M120_Projekt_SwissTransport.Models
{
    public class StationBoardEntry
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("category")]
        public string? Category { get; set; }

        [JsonProperty("Number")]
        public string? Number { get; set; }

        public string Line { get { return Category + Number; } }

        [JsonProperty("to")]
        public string? To { get; set; }

        [JsonProperty("stop")]
        public Stop? Stop { get; set; }
    }
}

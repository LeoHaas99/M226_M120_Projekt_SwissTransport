using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226_M120_Projekt_SwissTransport.Model
{
    public class Station: ModelBase
    {
        private string id;
        private string name;
        private int? score;
        private Coordinate coordinate;
        private double? distance;
        [JsonProperty("id")]
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        [JsonProperty("score")]
        public int? Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                OnPropertyChanged(nameof(Score));
            }
        }

        [JsonProperty("coordinate")]
        public Coordinate Coordinate
        {
            get
            {
                return coordinate;
            }
            set
            {
                coordinate = value;
                OnPropertyChanged(nameof(Coordinate));
            }
        }

        [JsonProperty("distance")]
        public double? Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
                OnPropertyChanged(nameof(Distance));
            }
        }
    }
}

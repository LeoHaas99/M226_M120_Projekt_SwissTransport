using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace M226_M120_Projekt_SwissTransport.Model
{
    public class Connection: ModelBase
    {
        private ConnectionPoint from;
        private ConnectionPoint to;
        private string duration;

        [JsonProperty("from")]
        public ConnectionPoint From
        { 
            get
            {
                return from;
            }
            set
            {
                from = value;
                OnPropertyChanged(nameof(From));
            }
        }

        [JsonProperty("to")]
        public ConnectionPoint To
        {
            get
            {
                return to;
            }
            set
            {
                to = value;
                OnPropertyChanged(nameof(To));
            }
        }

        [JsonProperty("duration")]
        public string Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }
    }
}

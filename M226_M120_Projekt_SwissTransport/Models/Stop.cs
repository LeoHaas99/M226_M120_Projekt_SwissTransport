using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace M226_M120_Projekt_SwissTransport.Models
{
    public class Stop : ModelBase
    {
        [JsonProperty("departure")]
        public DateTime Departure { get; set; }
    }
}

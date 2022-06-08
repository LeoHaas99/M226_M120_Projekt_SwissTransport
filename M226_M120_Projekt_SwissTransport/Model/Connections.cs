using M226_M120_Projekt_SwissTransport.OnPropChange;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226_M120_Projekt_SwissTransport.Model
{
    public class Connections: OnPropertyChange
    {
        private List<Connection> connectionList;
        [JsonProperty("connections")]
        public List<Connection> ConnectionList
        {
            get
            {
                return connectionList;
            }
            set
            {
                connectionList = value;
                OnPropertyChanged(nameof(ConnectionList));
            }
        }
    }
}

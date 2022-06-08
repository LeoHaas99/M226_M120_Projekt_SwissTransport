using M226_M120_Projekt_SwissTransport.OnPropChange;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226_M120_Projekt_SwissTransport.Model
{
    public class ConnectionPoint: OnPropertyChange
    {
        private Station station;
        private DateTime? arrival;
        private string arrivalTimstamp;
        private DateTime? departure;
        private string departureTimstamp;
        private int? delay;
        private string platform;
        private string realtimeAvailability;
        [JsonProperty("station")]
        public Station Station
        {
            get
            {
                return station;
            }
            set
            {
                station = value;
                OnPropertyChanged(nameof(Station));
            }
        }

        public DateTime? Arrival
        {
            get
            {
                return arrival;
            }
            set
            {
                arrival = value;
                OnPropertyChanged(nameof(Arrival));
            }
        }

        public string ArrivalTimestamp
        {
            get
            {
                return arrivalTimstamp;
            }
            set
            {
                arrivalTimstamp = value;
                OnPropertyChanged(nameof(ArrivalTimestamp));
            }
        }

        public DateTime? Departure
        {
            get
            {
                return departure;
            }
            set
            {
                departure = value;
                OnPropertyChanged(nameof(Departure));
            }
        }

        public string DepartureTimestamp
        {
            get
            {
                return departureTimstamp;
            }
            set
            {
                departureTimstamp = value;
                OnPropertyChanged(nameof(DepartureTimestamp));
            }
        }

        public int? Delay
        {
            get
            {
                return delay;
            }
            set
            {
                delay = value;
                OnPropertyChanged(nameof(Delay));
            }
        }

        public string Platform
        {
            get
            {
                return platform;
            }
            set
            {
                platform = value;
                OnPropertyChanged(nameof(Platform));
            }
        }

        public string RealtimeAvailability
        {
            get
            {
                return realtimeAvailability;
            }
            set
            {
                realtimeAvailability = value;
                OnPropertyChanged(nameof(RealtimeAvailability));
            }
        }
    }
}

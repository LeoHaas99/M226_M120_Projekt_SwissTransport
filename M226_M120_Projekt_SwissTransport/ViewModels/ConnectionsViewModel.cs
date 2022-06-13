using M226_M120_Projekt_SwissTransport.Commands;
using M226_M120_Projekt_SwissTransport.Models;
using System;
using System.Windows.Input;

namespace M226_M120_Projekt_SwissTransport.ViewModels
{
    //ViewModel for ConnectionsView
    public class ConnectionsViewModel: ViewModelBase
    {
        //Fields
        private string fromStation;
        private string toStation;
        private string time;
        private DateTime date;
        private Connections connections;
        private Stations fromStations;
        private Stations toStations;

        //Constructor
        public ConnectionsViewModel()
        {
            FromStation = String.Empty;
            ToStation = String.Empty;
            Date = DateTime.Now;
            Time = DateTime.Now.ToString("HH:mm");
            ConnectionsCommand = new GetConnectionsCommand(this);
            Connections = new Connections();
            FromStations = new Stations();
            ToStations = new Stations();
        }

        //Properties
        public string FromStation 
        { 
            get
            { 
                return fromStation;
            } 
            set 
            { 
                if(fromStation != value)
                {
                    fromStation = value;
                    OnPropertyChanged(nameof(FromStation));
                    if(fromStation.Length > 2)
                    {
                        FromStations = this.GetStations(fromStation);
                    }
                }
            } 
        }
        public string ToStation
        {
            get
            {
                return toStation;
            }
            set
            {
                if (toStation != value)
                {
                    toStation = value;
                    OnPropertyChanged(nameof(ToStation));
                    if (toStation.Length > 2)
                    {
                        ToStations = this.GetStations(toStation);
                    }
                }
            }
        }
        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                if (time != value)
                {
                    time = value;
                    OnPropertyChanged(nameof(Time));
                }
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged(nameof(Date));
                }
            }
        }
        public Connections Connections
        {
            get
            {
                return connections;
            }
            set 
            {
                connections = value;
                OnPropertyChanged(nameof(Connections));
            }
        }
        public Stations FromStations
        {
            get
            {
                return fromStations;
            }
            set
            {
                fromStations = value;
                OnPropertyChanged(nameof(FromStations));
            }
        }
        public Stations ToStations
        {
            get
            {
                return toStations;
            }
            set
            {
                toStations = value;
                OnPropertyChanged(nameof(ToStations));
            }
        }
        public ICommand ConnectionsCommand { get; }

        
    }
}

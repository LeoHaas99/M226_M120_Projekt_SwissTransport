using M226_M120_Projekt_SwissTransport.Commands;
using M226_M120_Projekt_SwissTransport.Model;
using M226_M120_Projekt_SwissTransport.OnPropChange;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace M226_M120_Projekt_SwissTransport.ViewModel
{
    public class ConnectionsViewModel: OnPropertyChange
    {
        private string fromStation = String.Empty;
        private string toStation = String.Empty;
        private string time = String.Empty;
        private DateTime date = DateTime.Now;
        Connections connections = new Connections();
        
        public ConnectionsViewModel()
        {
            FromStation = String.Empty;
            ToStation = String.Empty;
            Date = DateTime.Now;
            Time = DateTime.Now.ToString("HH:mm");
            ConnectionsCommand = new GetConnectionsCommand(this);
            Connections = new Connections();
        }

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
        public ICommand ConnectionsCommand { get; }

    }
}

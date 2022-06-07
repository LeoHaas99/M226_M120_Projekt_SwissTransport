using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226_M120_Projekt_SwissTransport.ViewModel
{
    public class ConnectionsViewModel: ViewModelBase
    {
        public string from = String.Empty;
        public string to = String.Empty;
        public string time = String.Empty;
        public string date = String.Empty;
        public ConnectionsViewModel()
        {
            From = String.Empty;
            To = String.Empty;
            Date = DateTime.Now.ToString("d");
            Time = DateTime.Now.ToString("HH:mm");
        }
        
        public string From 
        { 
            get
            { 
                return from;
            } 
            set 
            { 
                if(from != value)
                {
                    from = value;
                    OnPropertyChanged(nameof(From));
                }
            } 
        }
        public string To
        {
            get
            {
                return to;
            }
            set
            {
                if (to != value)
                {
                    to = value;
                    OnPropertyChanged(nameof(To));
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
        public string Date
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

    }
}

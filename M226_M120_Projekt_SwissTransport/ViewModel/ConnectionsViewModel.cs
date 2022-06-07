using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226_M120_Projekt_SwissTransport.ViewModel
{
    public class ConnectionsViewModel
    {
        public string from;
        public string to;
        public string time;
        public DateTime date;
        public string From { get; set; }
        public string To { get; set; }
        public string Time { get; set; }
        
        public DateTime Date{ get; set; }
        public void OnStartUp()
        {
            Date = DateTime.Now;
            Time = DateTime.Now.ToString("HH:mm");
        }
    }
}

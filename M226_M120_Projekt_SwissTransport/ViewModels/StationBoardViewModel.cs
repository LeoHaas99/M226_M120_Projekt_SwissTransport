using M226_M120_Projekt_SwissTransport.Commands;
using M226_M120_Projekt_SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace M226_M120_Projekt_SwissTransport.ViewModels
{
    public class StationBoardViewModel : ViewModelBase
    {
        private string station;
        private StationBoard stationBoard;

        public StationBoardViewModel()
        {
            Station = String.Empty;
            StationBoard = new StationBoard();
            StationBoardCommand = new GetStationBoardCommand(this);
        }

        public string Station { 
            get => station;
            set 
            {
                station = value;
                OnPropertyChanged(nameof(Station));
            }
        }

        public StationBoard StationBoard {
            get => stationBoard; 
            set
            {
                stationBoard = value;
                OnPropertyChanged(nameof(StationBoard));
            }
        }

        public ICommand StationBoardCommand { get; }
    }
}

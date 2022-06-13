using M226_M120_Projekt_SwissTransport.Commands;
using M226_M120_Projekt_SwissTransport.Models;
using System;
using System.Windows.Input;

namespace M226_M120_Projekt_SwissTransport.ViewModels
{
    //ViewModel for StationboardView
    public class StationBoardViewModel : ViewModelBase
    {
        //Fields
        private string station;
        private StationBoard stationBoard;

        //Constructor
        public StationBoardViewModel()
        {
            Station = String.Empty;
            StationBoard = new StationBoard();
            StationBoardCommand = new GetStationBoardCommand(this);
        }

        //Properties
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

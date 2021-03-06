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
        private Stations stations;

        //Constructor
        public StationBoardViewModel()
        {
            Station = String.Empty;
            StationBoard = new StationBoard();
            StationBoardCommand = new GetStationBoardCommand(this);
            Stations = new Stations();
        }

        //Properties
        public string Station { 
            get => station;
            set 
            {
                station = value;
                OnPropertyChanged(nameof(Station));
                if (Station.Length > 2)
                {
                    Stations = this.GetStations(Station);
                }
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

        public Stations Stations
        {
            get
            {
                return stations;
            }
            set
            {
                stations = value;
                OnPropertyChanged(nameof(stations));
            }
        }
        public ICommand StationBoardCommand { get; }
    }
}

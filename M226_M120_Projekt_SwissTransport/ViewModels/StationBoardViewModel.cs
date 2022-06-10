﻿using M226_M120_Projekt_SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226_M120_Projekt_SwissTransport.ViewModels
{
    public class StationBoardViewModel : ViewModelBase
    {
        private string station;
        private StationBoardRoot stationBoardRoot;

        public StationBoardViewModel()
        {
            Station = String.Empty;
        }

        public string Station { 
            get => station;
            set 
            {
                station = value;
                OnPropertyChanged(nameof(Station));
            }
        }

        public StationBoardRoot StationBoardRoot {
            get => stationBoardRoot; 
            set
            {
                stationBoardRoot = value;
                OnPropertyChanged(nameof(StationBoardRoot));
            }
        }

    }
}
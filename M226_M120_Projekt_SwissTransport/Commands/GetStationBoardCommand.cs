using M226_M120_Projekt_SwissTransport.Models;
using M226_M120_Projekt_SwissTransport.ViewModels;
using System;
using System.Windows;

namespace M226_M120_Projekt_SwissTransport.Commands
{
    //Gets the Stationboard of a Station
   public class GetStationBoardCommand : CommandBase
    {
        //Properties
        private readonly StationBoardViewModel viewModel;
        //Constructor
        public GetStationBoardCommand(StationBoardViewModel stationBoardViewModel)
        {
           viewModel = stationBoardViewModel;
        }
        //Methods
        public override void Execute(object? parameter)
        {
            try
            {
                //Checks if strings are empty
                if (string.IsNullOrEmpty(viewModel.Station))
                {
                    throw new ArgumentNullException(nameof(viewModel.Station));
                }
                //Api Call saved to viewModel Property
                var uri = new Uri($"{WebApiHost}stationboard?station={viewModel.Station}");
                viewModel.StationBoard = this.GetObject<StationBoard>(uri);
                //Checks if ObservableCollection is empty
                if (viewModel.StationBoard.Entries.Count == 0)
                {
                    MessageBox.Show("Für diese Station wurde keine Verbindungen gefunden.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Es ist ein Fehler aufgetreten. Bitte überprüfen Sie Ihre Eingaben.\n" + ex.Message);
            }
            
        }
    }
}

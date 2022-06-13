using M226_M120_Projekt_SwissTransport.Models;
using M226_M120_Projekt_SwissTransport.ViewModels;
using System;
using System.Windows;

namespace M226_M120_Projekt_SwissTransport.Commands
{
   public class GetStationBoardCommand : CommandBase
    {
        private readonly StationBoardViewModel viewModel;
        public GetStationBoardCommand(StationBoardViewModel stationBoardViewModel)
        {
           viewModel = stationBoardViewModel;
        }

        public override void Execute(object? parameter)
        {
            try
            {
                if (string.IsNullOrEmpty(viewModel.Station))
                {
                    throw new ArgumentNullException(nameof(viewModel.Station));
                }

                var uri = new Uri($"{WebApiHost}stationboard?station={viewModel.Station}");
                viewModel.StationBoard = this.GetObject<StationBoard>(uri);

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

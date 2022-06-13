using M226_M120_Projekt_SwissTransport.Models;
using M226_M120_Projekt_SwissTransport.ViewModels;
using System;
using System.Windows;

namespace M226_M120_Projekt_SwissTransport.Commands
{
    //Gets Connections between two Stations with date and time
    public class GetConnectionsCommand : CommandBase
    {
        //Properties
        private readonly ConnectionsViewModel viewModel;

        //Constructor
        public GetConnectionsCommand(ConnectionsViewModel connectionsViewModel)
        {
            viewModel = connectionsViewModel;
        }
        //Methods
        public override void Execute(object? parameter)
        {
            try
            {
                //checks if Strings are empty
                if (string.IsNullOrEmpty(viewModel.FromStation))
                {
                    throw new ArgumentNullException(nameof(viewModel.FromStation));
                }
                if (string.IsNullOrEmpty(viewModel.ToStation))
                {
                    throw new ArgumentNullException(nameof(viewModel.ToStation));
                }
                //Api Call saved to viewModel Property
                var uri = new Uri($"{WebApiHost}connections?from={viewModel.FromStation}&to={viewModel.ToStation}&date={viewModel.Date.ToString("yyyy-MM-dd")}&time={viewModel.Time}&limit=10");
                viewModel.Connections = this.GetObject<Connections>(uri);
                //Check if empty
                if(viewModel.Connections.ConnectionList.Count == 0){
                    MessageBox.Show("Es wurden keine Verbindungen gefunden");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten. Bitte überprüfen Sie ihre Eingaben\n" + ex.Message);
            }
            
        }
    }
}

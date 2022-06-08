﻿using M226_M120_Projekt_SwissTransport.Model;
using M226_M120_Projekt_SwissTransport.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace M226_M120_Projekt_SwissTransport.Commands
{
    public class GetConnectionsCommand : CommandBase
    {
        private readonly ConnectionsViewModel viewModel;

        
        public GetConnectionsCommand(ConnectionsViewModel connectionsViewModel)
        {
            viewModel = connectionsViewModel;
        }
        public override void Execute(object? parameter)
        {
            if (string.IsNullOrEmpty(viewModel.FromStation))
            {
                throw new ArgumentNullException(nameof(viewModel.FromStation));
            }
            if (string.IsNullOrEmpty(viewModel.ToStation))
            {
                throw new ArgumentNullException(nameof(viewModel.ToStation));
            }
            var uri = new Uri($"{WebApiHost}connections?from={viewModel.FromStation}&to={viewModel.ToStation}&date={viewModel.Date.ToString("yyyy-MM-dd")}&time={viewModel.Time}&limit=10");
            viewModel.Connections = this.GetObject<Connections>(uri);
        }
    }
}
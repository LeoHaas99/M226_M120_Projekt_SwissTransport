using M226_M120_Projekt_SwissTransport.Models;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Net.Http;
using System.Windows;

namespace M226_M120_Projekt_SwissTransport.ViewModels
{
    //Base for all ViewModels, implements INotifyPropertyChanged and stores Properties and Methods for API Calls
    public class ViewModelBase : INotifyPropertyChanged
    {
        //Properties

        // URL for WebApiHost TransportAPI
        protected const string WebApiHost = "https://transport.opendata.ch/v1/";
        //HttpClient Object for Http API calls
        protected readonly HttpClient httpClient = new HttpClient();
        // EventHandler Property for DataBinding
        public event PropertyChangedEventHandler? PropertyChanged;

        //Methods

        //informs View if Property Changed
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //turns HttpResponse async into JSON string and async into usable Object
        protected T GetObject<T>(Uri uri)
        {
            HttpResponseMessage response = this.httpClient
                .GetAsync(uri)
                .GetAwaiter()
                .GetResult();
            string content = response.Content
                .ReadAsStringAsync()
                .GetAwaiter()
                .GetResult();

            return JsonConvert.DeserializeObject<T>(content);
        }

        // Gets Stations from the autocomplete Listbox
        protected Stations GetStations(string name)
        {
            try
            {
            if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException(nameof(name));
                }

            var uri = new Uri($"{WebApiHost}locations?query={name}");
            return this.GetObject<Stations>(uri);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten. Überprüfen Sie Ihre Internetverbindung\n" + ex.Message);
                return new Stations();
            }
            
        }
    }
}

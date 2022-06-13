using M226_M120_Projekt_SwissTransport.Models;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Net.Http;


namespace M226_M120_Projekt_SwissTransport.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        protected const string WebApiHost = "https://transport.opendata.ch/v1/";
        protected readonly HttpClient httpClient = new HttpClient();
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
        public Stations GetStations(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            var uri = new Uri($"{WebApiHost}locations?query={name}");
            return this.GetObject<Stations>(uri);
        }
    }
}

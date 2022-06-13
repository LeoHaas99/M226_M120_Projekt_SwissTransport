using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Input;


namespace M226_M120_Projekt_SwissTransport.Commands
{
    //implements ICommand as Base for all Commands and stores Properties and Methods for API calls in Commands 
    public abstract class CommandBase : ICommand
    {
        //Properties

        //Stores if command can be executed, usually true
        public event EventHandler? CanExecuteChanged;

        // URL for WebApiHost TransportAPI
        protected const string WebApiHost = "https://transport.opendata.ch/v1/";

        //HttpClient Object for Http API calls
        protected readonly HttpClient httpClient = new HttpClient();
        //Methods

        //checking if command can be executed, can be overwritten
        public virtual bool CanExecute(object? parameter)
        {
            return true;
        }

        // has to be implemented on command, all functionality goes here
        public abstract void Execute(object? parameter);

        //changes CanExecuteChanged Property
        protected void OnCanExecutedChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
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

    }
}

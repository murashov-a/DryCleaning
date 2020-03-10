using System;
using System.Collections.Generic;
using System.Net.Http;
using DryCleaningAPI.API.Requests;
using DryCleaningAPI.Http;
using DryCleaningClient.API.Responses;
using Newtonsoft.Json;

namespace DryCleaningAPI
{
    internal class Session
    {
        private HttpClient _client = new HttpClient();
        internal Requestor Requestor { get; private set; }
        private readonly AccessToken _token;

        /// <exception cref="DryCleaningAPI.Exceptions.DryCleaningException">Authorization error</exception>
        public Session(string ApiUrl, int passport, string password)
        {
            _client.BaseAddress = new Uri(ApiUrl);
            Requestor = new Requestor(new HttpClient() { BaseAddress = new Uri(ApiUrl) }, JsonSerializer.CreateDefault());
            _token = Requestor.Post<AccessToken>($"/authorization?passportid={passport}&password={password}");
            Requestor.AddHeader("token", _token.Token);

            var currentUser = Requestor.Get<User>("/user");
        }
        public Session(string ApiUrl, string token)
        {
            _client.BaseAddress = new Uri(ApiUrl);
            Requestor = new Requestor(new HttpClient() { BaseAddress = new Uri(ApiUrl) }, JsonSerializer.CreateDefault());
            _token = new AccessToken(token);
            Requestor.AddHeader("token", _token.Token);

            var currentUser = Requestor.Get<User>("/user");
        }
    }
}

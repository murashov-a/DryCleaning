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
        private readonly Requestor _requestor;
        private readonly AccessToken _token;
        /// <exception cref="DryCleaningAPI.Exceptions.DryCleaningException">Authorization error</exception>
        public Session(string ApiUrl, int passport, string password)
        {
            _requestor = new Requestor(new HttpClient() { BaseAddress = new Uri(ApiUrl) }, JsonSerializer.CreateDefault());
            _token = _requestor.Post<AccessToken>($"/authorization?passportid={passport}&password={password}");
        }
        public Session(string ApiUrl, string token)
        {
            _requestor = new Requestor(new HttpClient() { BaseAddress = new Uri(ApiUrl) }, JsonSerializer.CreateDefault());
            _token = new AccessToken(token);
        }

        public User GetCurrentUser()
        {
            return _requestor.Get<User>("/user");
        }
    }
}

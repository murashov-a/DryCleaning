using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DryCleaningAPI.API.Requests
{
    class AccessToken
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        public AccessToken(string token) => Token = token;
    }
}

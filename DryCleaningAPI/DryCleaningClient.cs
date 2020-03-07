using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningAPI
{
    public class DryCleaningClient
    {
        private Session _session;
        public DryCleaningClient(string ApiUrl, int passport, string password)
        {
            _session = new Session(ApiUrl, passport, password);
        }
        public DryCleaningClient(string ApiUrl, string token)
        {
            _session = new Session(ApiUrl, token);
        }
    }
}

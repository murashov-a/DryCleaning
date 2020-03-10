using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DryCleaningClient.API.Responses;

namespace DryCleaningAPI
{
    public class DryCleaningClient
    {
        private Session Session { get; set; }

        public UsersClient Users { get; private set; }
        public RolesClient Roles { get; private set; }

        public DryCleaningClient(string ApiUrl, int passport, string password)
        {
            Session = new Session(ApiUrl, passport, password);
            InitClients();
        }
        public DryCleaningClient(string ApiUrl, string token)
        {
            Session = new Session(ApiUrl, token);
            InitClients();
        }

        private void InitClients()
        {
            Users = new UsersClient(Session);
            Roles = new RolesClient(Session);
        }
    }
}
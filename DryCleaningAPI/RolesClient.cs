using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DryCleaningClient.API.Responses;

namespace DryCleaningAPI
{
    public class RolesClient
    {
        private readonly Session _session;
        internal RolesClient(Session session)
        {
            _session = session;
        }

        public Role[] GetRoles() => _session.Requestor.Get<Role[]>("/roles");

        public void AddRole(string name, int salary) =>
            _session.Requestor.Post($"/roles?name={name}&salary={salary}");
    }
}

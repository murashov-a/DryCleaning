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

        public void Add(string name, int? salary) =>
            _session.Requestor.Post($"/roles?name={name}&salary={salary}");

        public void Add(Role role) => 
            Add(role.Name, role.Salary);

        public void Edit(string name, string newName, int? salary) =>
            _session.Requestor.Put($"/roles/{name}?newName={newName}&newSalary={salary}");

        public void Edit(string name, Role role) => 
            Edit(name, role.Name, role.Salary);

        public void Delete(string name) =>
            _session.Requestor.Delete($"/roles/{name}");

        public void Delete(Role role) =>
            Delete(role.Name);

    }
}

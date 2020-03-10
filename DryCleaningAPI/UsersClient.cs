using DryCleaningClient.API.Responses;

namespace DryCleaningAPI
{
    public class UsersClient
    {
        private readonly Session _session;
        internal UsersClient(Session session)
        {
            _session = session;
        }

        public User GetCurrentUser() =>  _session.Requestor.Get<User>("/user");

        public User[] GetUsers() =>  _session.Requestor.Get<User[]>("/users");

        public User[] GetUser(int id) => _session.Requestor.Get<User[]>($"/users/{id}");

        public User EditCurrentUser(int? newPassportID = null, string newName = null, string newPassword = null) =>
            _session.Requestor.Put<User>($"/user?newPassportID={newPassportID}&newName={newName}&newPassword={newPassword}");

        public void AddUser(int newPassportID, string name, string role, string newPassword, bool isAdmin = false) =>
            _session.Requestor.Post($"/users?newPassportID={newPassportID}&name={name}&role={role}&newPassword={newPassword}&isAdmin={isAdmin}");
    }
}

using DryCleaningClient.API.Responses;

namespace DryCleaningAPI
{
    public class UsersClient : BaseClient
    {
        internal UsersClient(Session session) : base(session) { }

        public User GetCurrentUser() =>  _session.Requestor.Get<User>("/user");

        public User[] GetUsers() =>  _session.Requestor.Get<User[]>("/users");

        public User GetUser(int id) => _session.Requestor.Get<User>($"/users/{id}");

        public User EditCurrentUser(int? newPassportID = null, string newName = null, string newPassword = null) =>
            _session.Requestor.Put<User>($"/user?newPassportID={newPassportID}&newName={newName}&newPassword={newPassword}");

        public User EditCurrentUser(User user) =>
            _session.Requestor.Put<User>($"/user?newPassportID={user.PassportID}&newName={user.Name}&newPassword={user.Password}");

        public User Edit(int passportId, User user) =>
            _session.Requestor.Put<User>($"/users/{passportId}?newPassportID={user.PassportID}&newName={user.Name}&newPassword={user.Password}&newRole={user.Role}&newIsAdmin={user.IsAdmin}");

        public void Delete(int passportId) =>
            _session.Requestor.Delete($"/users/{passportId}");

        public void Add(int newPassportID, string name, string roleName, string newPassword, bool isAdmin = false) =>
            _session.Requestor.Post($"/users?newPassportID={newPassportID}&name={name}&role={roleName}&newPassword={newPassword}&isAdmin={isAdmin}");

        public void Add(User user) =>
            Add(user.PassportID, user.Name, user.Role, user.Password, user.IsAdmin);
    }
}

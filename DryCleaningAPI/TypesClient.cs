using DryCleaningClient.API.Responses;

namespace DryCleaningAPI
{
    public class TypesClient
    {
        private readonly Session _session;
        internal TypesClient(Session session)
        {
            _session = session;
        }

        public Type[] GetTypes() => _session.Requestor.Get<Type[]>("/types");

        public void Add(string name, int compensation, int cleaningprice) =>
            _session.Requestor.Post($"/types?name={name}&compensation={compensation}&cleaningprice={cleaningprice}");

        public void Add(Type type) =>
            Add(type.Name, type.Compensation, type.CleaningPrice);

        public void Edit(string oldName, string name, int compensation, int cleaningprice) =>
            _session.Requestor.Put($"/types/{oldName}?name={name}&compensation={compensation}&cleaningprice={cleaningprice}");

        public void Edit(string oldName, Type type) =>
            Edit(oldName, type.Name, type.Compensation, type.CleaningPrice);

        public void Delete(string name) =>
            _session.Requestor.Delete($"/types/{name}");

        public void Delete(Type type) =>
            Delete(type.Name);

    }
}

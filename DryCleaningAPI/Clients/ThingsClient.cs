using DryCleaningAPI.API.Responses;
using DryCleaningClient.API.Responses;

namespace DryCleaningAPI
{
    public class ThingsClient : BaseClient
    {
        internal ThingsClient(Session session) : base(session) { }

        public Thing[] GetThings() => _session.Requestor.Get<Thing[]>("/things");

        public Thing Add(string name, string material, string type, int cleaningorder) => 
            _session.Requestor.Post<Thing>($"/things?name={name}&material={material}&type={type}&cleaningorder={cleaningorder}");

        public Thing Edit(int id, string name, string material, string type, int cleaningorder) =>
            _session.Requestor.Put<Thing>($"/things/{id}?name={name}&material={material}&type={type}&cleaningorder={cleaningorder}");

        public Thing Edit(int id, Thing thing) =>
            Edit(id, thing.Name, thing.Material, thing.Type, thing.CleaningOrder);


        public void Delete(int id) =>
            _session.Requestor.Delete($"/things/{id}");

        public void Delete(Thing thing) =>
            Delete(thing.ID);

    }
}

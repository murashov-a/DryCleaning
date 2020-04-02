using System.Collections.Generic;
using DryCleaningAPI.API.Responses;

namespace DryCleaningAPI
{
    public class ThingsClient : BaseClient
    {
        internal ThingsClient(Session session) : base(session) { }

        public Thing[] GetThings() => _session.Requestor.Get<Thing[]>("/things");

        static Dictionary<int, Thing> cacheThings = new Dictionary<int, Thing>();
        public Thing Get(int id, bool useCache = false)
        {
            if (!useCache || !cacheThings.ContainsKey(id))
            {
                cacheThings[id] = _session.Requestor.Get<Thing>($"/things/{id}");
            }
            return cacheThings[id];
        }
        public static void ResetCache()
        {
            cacheThings.Clear();
        }

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

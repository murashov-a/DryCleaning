using System.Collections.Generic;
using System.Linq;
using DryCleaningAPI.API.Responses;

namespace DryCleaningAPI
{
    public class CleaningsThingsClient : BaseClient
    {
        internal CleaningsThingsClient(Session session) : base(session) { }

        public CleaningThing[] GetCleanings() => _session.Requestor.Get<CleaningThing[]>("/cleaningsthings");

        static Dictionary<int, Thing[]> cacheThings = new Dictionary<int, Thing[]>();
        public Thing[] GetThings(int cleaningID, bool useCache = false)
        {
            if (!useCache || !cacheThings.ContainsKey(cleaningID))
            {
                cacheThings[cleaningID] = _session.Requestor.Get<Thing[]>($"/cleaningsthings/{cleaningID}");
            }
            return cacheThings[cleaningID];
        }

        public static void ResetCache()
        {
            cacheThings.Clear();
        }

        public void Add(int cleaningID, int thingID) =>
            _session.Requestor.Post<CleaningThing>($"/cleaningsthings?cleaningid={cleaningID}&thingid={thingID}");

        public void Add(CleaningThing cleaningThing) =>
            Add(cleaningThing.CleaningID, cleaningThing.ThingID);

        /// <summary>
        /// Add things and ignote error of exists
        /// </summary>
        /// <param name="cleaningThing"></param>
        public void Add(IEnumerable<CleaningThing> cleaningsThings)
        {
            var allcleaningsThings = GetCleanings();
            foreach (var cleaningsThing in cleaningsThings)
            {
                if (!allcleaningsThings.Any(x =>
                    x.ThingID == cleaningsThing.ThingID && x.CleaningID == cleaningsThing.CleaningID))
                {
                    Add(cleaningsThing);
                }
            }
        }

        public void Edit(int oldCleaningID, int oldThingID, int newCleaningID, int newThingID) =>
            _session.Requestor.Put($"/cleaningsthings/{oldCleaningID}/{oldThingID}?newcleaningid={newCleaningID}&newthingid={newThingID}");

        public void Edit(CleaningThing oldCleaningThing, CleaningThing newCleaningThing) =>
            Edit(oldCleaningThing.CleaningID, oldCleaningThing.ThingID, newCleaningThing.CleaningID,
                newCleaningThing.ThingID);

        public void Delete(int cleaningID, int thingID) => _session.Requestor.Delete($"/cleaningsthings/{cleaningID}/{thingID}");

        public void Delete(CleaningThing cleaningThing) => Delete(cleaningThing.CleaningID, cleaningThing.ThingID);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DryCleaningAPI.API.Responses
{
    public class CleaningThing
    {
        public int CleaningID { get; set; }
        public int ThingID { get; set; }


        public override int GetHashCode()
        {
            return CleaningID ^ ThingID;
        }

        public override bool Equals(object obj)
        {
            bool equaled = false;
            if (obj is CleaningThing cleaningThing)
            {
                equaled = cleaningThing.GetHashCode().Equals(this.GetHashCode());
            }

            return equaled;
        }

        public CleaningThing Clone()
        {
            return new CleaningThing()
            {
                CleaningID = CleaningID,
                ThingID = ThingID
            };
        }
    }
}

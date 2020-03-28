using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningClient.API.Responses
{
    public class Type
    {
        public string Name { get; set; }

        public int Compensation { get; set; }

        public int CleaningPrice { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool equaled = false;
            if (obj is Type type)
            {
                equaled = type.GetHashCode().Equals(this.GetHashCode());
            }

            return equaled;
        }

        public Type Clone()
        {
            return new Type() { Name = Name, CleaningPrice = CleaningPrice, Compensation = Compensation};
        }

        public static readonly Type Default = new Type()
        {
            Name = ""
        };

        public override string ToString()
        {
            return Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningClient.API.Responses
{
    public class Material
    {
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool equaled = false;
            if (obj is Material material)
            {
                equaled = material.GetHashCode().Equals(this.GetHashCode());
            }

            return equaled;
        }

        public Material Clone()
        {
            return new Material() { Name = Name };
        }

        public static readonly Material Default = new Material()
        {
            Name = ""
        };

        public override string ToString()
        {
            return Name;
        }
    }
}

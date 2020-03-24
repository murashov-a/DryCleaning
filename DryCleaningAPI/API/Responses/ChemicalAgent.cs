using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningClient.API.Responses
{
    public class ChemicalAgent
    {
        [DisplayName("Химическое средство")]
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool equaled = false;
            if (obj is ChemicalAgent chemicalAgent)
            {
                equaled = chemicalAgent.GetHashCode().Equals(this.GetHashCode());
            }

            return equaled;
        }

        public ChemicalAgent Clone()
        {
            return new ChemicalAgent() { Name = Name };
        }

        public static readonly ChemicalAgent Default = new ChemicalAgent()
        {
            Name = ""
        };
    }
}

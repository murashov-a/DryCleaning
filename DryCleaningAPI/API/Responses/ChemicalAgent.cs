using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningClient.API.Responses
{
    class ChemicalAgent
    {
        [DisplayName("Химическое средство")]
        public string Name { get; set; }
    }
}

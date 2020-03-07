using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningClient.API.Responses
{
    class Material
    {
        [DisplayName("Название материала")]
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningClient.API.Responses
{
    class Role
    {
        [DisplayName("Должность")]
        public string Name { get; set; }

        [DisplayName("Зарплата")]
        public int? Salary { get; set; }
    }
}

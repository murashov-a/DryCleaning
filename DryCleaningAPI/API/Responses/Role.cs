using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningClient.API.Responses
{
    public class Role
    {
        [DisplayName("Должность")]
        public string Name { get; set; }

        [DisplayName("Зарплата")]
        public int? Salary { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool equaled = false;
            if (obj is Role role)
            {
                equaled = role.GetHashCode().Equals(this.GetHashCode());
            }

            return equaled;
        }
    }
}

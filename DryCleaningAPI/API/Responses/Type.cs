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
        [DisplayName("Тип")]
        public string Name { get; set; }

        [DisplayName("Компенсация")]
        public int Compensation { get; set; }

        [DisplayName("Цена чистки")]
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
    }
}

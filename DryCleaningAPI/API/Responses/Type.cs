using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningClient.API.Responses
{
    class Type
    {
        [DisplayName("Тип")]
        public string Name { get; set; }

        [DisplayName("Компенсация")]
        public int Compensation { get; set; }

        [DisplayName("Цена чистки")]
        public int CleaningPrice { get; set; }
    }
}

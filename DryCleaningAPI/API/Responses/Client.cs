using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningClient.API.Responses
{
    class Client
    {
        [DisplayName("Номер")]
        public int ID { get; set; }

        [DisplayName("ФИО")]
        public string Name { get; set; }

        [DisplayName("Номер телефона")]
        public string Telephone { get; set; }
    }
}
